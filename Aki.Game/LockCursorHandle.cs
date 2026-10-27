using System;
using System.Runtime.CompilerServices;
using Aki.Protocol.Summon;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F2E RID: 7982
[NullableContext(2)]
[Nullable(0)]
public class LockCursorHandle : HudUnitHandleBase
{
	// Token: 0x0600F60F RID: 62991 RVA: 0x003B66F8 File Offset: 0x003B48F8
	protected override void OnAddEvents()
	{
		InputDistributeController.Instance.BindAction("锁定目标", new TInputHandle<InputDistributeDefine.EActionType>(this.OnLockInput));
		EventSystem.Instance.Add<bool, EBehaviorType>(EEventName.OnPressOrReleaseBehaviorButton, new Action<bool, EBehaviorType>(this.OnPressOrReleaseBehaviorButton));
		EventSystem.Instance.Add<bool, int>(EEventName.BreakWeaknessPanelLogicVisibleChange, new Action<bool, int>(this.OnBreakWeaknessPanelLogicVisibleChange));
	}

	// Token: 0x0600F610 RID: 62992 RVA: 0x003B6758 File Offset: 0x003B4958
	protected override void OnRemoveEvents()
	{
		InputDistributeController.Instance.UnBindAction("锁定目标", new TInputHandle<InputDistributeDefine.EActionType>(this.OnLockInput));
		EventSystem.Instance.Remove<bool, EBehaviorType>(EEventName.OnPressOrReleaseBehaviorButton, new Action<bool, EBehaviorType>(this.OnPressOrReleaseBehaviorButton));
		EventSystem.Instance.Remove<bool, int>(EEventName.BreakWeaknessPanelLogicVisibleChange, new Action<bool, int>(this.OnBreakWeaknessPanelLogicVisibleChange));
	}

	// Token: 0x0600F611 RID: 62993 RVA: 0x003B67B8 File Offset: 0x003B49B8
	[NullableContext(1)]
	private void OnLockInput(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification identification)
	{
		if (Info.Instance.IsInGamepad())
		{
			if (actionType == InputDistributeDefine.EActionType.Press)
			{
				this.HasLockCursorUnitBeforeGamepadLock = (this.LockCursorUnit != null);
			}
			else
			{
				this.ReleaseGamepadLock = true;
			}
		}
		if (this.LockCursorUnit == null)
		{
			return;
		}
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		object obj;
		if (getCurrentEntity == null)
		{
			obj = null;
		}
		else
		{
			WorldEntity entity = getCurrentEntity.Entity;
			obj = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 != null && obj2.HasTag(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止锁定目标"]))
		{
			return;
		}
		if (actionType == InputDistributeDefine.EActionType.Press)
		{
			this.ActivateUnlockTimeDown();
			return;
		}
		this.DeactivateUnlockTimeDown();
	}

	// Token: 0x0600F612 RID: 62994 RVA: 0x003B6845 File Offset: 0x003B4A45
	private void OnPressOrReleaseBehaviorButton(bool bPress, EBehaviorType behaviorType)
	{
		if (behaviorType != EBehaviorType.LockTarget)
		{
			return;
		}
		if (bPress)
		{
			this.ActivateUnlockTimeDown();
			return;
		}
		this.DeactivateUnlockTimeDown();
	}

	// Token: 0x0600F613 RID: 62995 RVA: 0x003B685D File Offset: 0x003B4A5D
	private void OnBreakWeaknessPanelLogicVisibleChange(bool logicVisible, int monsterEntityId)
	{
		if (logicVisible)
		{
			this.LockExecutionEntityId = monsterEntityId;
			return;
		}
		this.LockExecutionEntityId = 0;
	}

	// Token: 0x0600F614 RID: 62996 RVA: 0x003B6871 File Offset: 0x003B4A71
	protected override void OnDestroyed()
	{
		this.ClearTargetInfo();
		this.LockCursorUnit = null;
	}

	// Token: 0x0600F615 RID: 62997 RVA: 0x003B6880 File Offset: 0x003B4A80
	private void ActivateUnlockTimeDown()
	{
		LockCursorUnit lockCursorUnit = this.LockCursorUnit;
		if (lockCursorUnit == null || !lockCursorUnit.IsForceLockState())
		{
			return;
		}
		float time = SceneTeamModel.Instance.GetCurrentEntity.Entity.GetComponent<CharacterInputComponent>().GetBpInputComp().UnlockLongPressTime * (float)TimeUtil.Instance.InverseMillisecond;
		this.LockCursorUnit.ActivateUnlockTimeDown(time);
	}

	// Token: 0x0600F616 RID: 62998 RVA: 0x003B68DC File Offset: 0x003B4ADC
	private void DeactivateUnlockTimeDown()
	{
		LockCursorUnit lockCursorUnit = this.LockCursorUnit;
		if (lockCursorUnit == null)
		{
			return;
		}
		lockCursorUnit.DeactivateUnlockTimeDown();
	}

	// Token: 0x0600F617 RID: 62999 RVA: 0x003B68F0 File Offset: 0x003B4AF0
	protected override void OnTick(float delta)
	{
		base.OnTick(delta);
		if (this.IsLoading)
		{
			return;
		}
		this.RefreshTargetInfo();
		if (this.ReleaseGamepadLock)
		{
			this.ReleaseGamepadLock = false;
			if (!this.HasLockCursorUnitBeforeGamepadLock && this.TmpTargetEntity == null && !this.IsAim())
			{
				BattleUiControl.Instance.ResetFocus();
			}
		}
		if (this.TmpTargetEntity == null || this.TmpTargetEntity.Id == this.LockExecutionEntityId)
		{
			this.Deactivate();
			return;
		}
		FVectorDouble? worldLocation = this.GetWorldLocation(this.TmpTargetEntity, this.TmpTargetSocketName);
		if (worldLocation == null)
		{
			this.Deactivate();
			return;
		}
		if (!HudUnitUtils.PositionUtil.ProjectWorldToScreen(worldLocation.Value, this.ScreenPos))
		{
			this.Deactivate();
			return;
		}
		this.Activate();
		if (this.LockCursorUnit != null)
		{
			this.LockCursorUnit.Refresh(this.TmpTargetEntity, this.TmpSelfEntity, this.TmpIsPlayerLock);
			this.LockCursorUnit.GetRootItem().SetAnchorOffset(this.ScreenPos.ToUeVector2D(false));
		}
		this.ClearTargetInfo();
	}

	// Token: 0x0600F618 RID: 63000 RVA: 0x003B69F8 File Offset: 0x003B4BF8
	private bool IsAim()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null || !getCurrentEntity.Valid)
		{
			return false;
		}
		CharacterUnifiedStateComponent component = getCurrentEntity.Entity.GetComponent<CharacterUnifiedStateComponent>();
		return ((component != null) ? new ECharDirectionState?(component.DirectionState) : null).GetValueOrDefault() == ECharDirectionState.AimDirection;
	}

	// Token: 0x0600F619 RID: 63001 RVA: 0x003B6A52 File Offset: 0x003B4C52
	public void Activate()
	{
		if (this.LockCursorUnit != null)
		{
			this.LockCursorUnit.Activate();
			return;
		}
		if (this.IsLoading)
		{
			return;
		}
		this.IsLoading = true;
		this.LoadLockCursorUnit().Forget();
	}

	// Token: 0x0600F61A RID: 63002 RVA: 0x003B6A84 File Offset: 0x003B4C84
	private UniTask LoadLockCursorUnit()
	{
		LockCursorHandle.<LoadLockCursorUnit>d__22 <LoadLockCursorUnit>d__;
		<LoadLockCursorUnit>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadLockCursorUnit>d__.<>4__this = this;
		<LoadLockCursorUnit>d__.<>1__state = -1;
		<LoadLockCursorUnit>d__.<>t__builder.Start<LockCursorHandle.<LoadLockCursorUnit>d__22>(ref <LoadLockCursorUnit>d__);
		return <LoadLockCursorUnit>d__.<>t__builder.Task;
	}

	// Token: 0x0600F61B RID: 63003 RVA: 0x003B6AC7 File Offset: 0x003B4CC7
	public void Deactivate()
	{
		this.ClearTargetInfo();
		if (this.LockCursorUnit == null)
		{
			return;
		}
		this.LockCursorUnit.Deactivate();
	}

	// Token: 0x0600F61C RID: 63004 RVA: 0x003B6AE4 File Offset: 0x003B4CE4
	private void RefreshTargetInfo()
	{
		this.ClearTargetInfo();
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null || !getCurrentEntity.Valid)
		{
			return;
		}
		ShowTargetInfo targetInfo = getCurrentEntity.Entity.CheckGetComponent<CharacterLockOnComponent>().GetTargetInfo();
		EntityHandle showTarget = targetInfo.ShowTarget;
		if (showTarget != null && showTarget.Valid)
		{
			this.TmpTargetEntity = targetInfo.ShowTarget;
			this.TmpTargetSocketName = targetInfo.SocketName;
			this.TmpSelfEntity = getCurrentEntity;
			this.TmpIsPlayerLock = true;
			return;
		}
		RoleDriveVehicleComponent component = getCurrentEntity.Entity.GetComponent<RoleDriveVehicleComponent>();
		BaseLockOnComponent baseLockOnComponent;
		if (component == null)
		{
			baseLockOnComponent = null;
		}
		else
		{
			Entity vehicleEntity = component.VehicleEntity;
			baseLockOnComponent = ((vehicleEntity != null) ? vehicleEntity.GetComponent<BaseLockOnComponent>() : null);
		}
		BaseLockOnComponent baseLockOnComponent2 = baseLockOnComponent;
		if (baseLockOnComponent2 != null)
		{
			ShowTargetInfo targetInfo2 = baseLockOnComponent2.GetTargetInfo();
			EntityHandle showTarget2 = targetInfo2.ShowTarget;
			if (showTarget2 != null && showTarget2.Valid)
			{
				this.TmpTargetEntity = targetInfo2.ShowTarget;
				this.TmpTargetSocketName = targetInfo2.SocketName;
				return;
			}
		}
		BaseTagComponent component2 = getCurrentEntity.Entity.GetComponent<BaseTagComponent>();
		if (component2 != null && component2.HasTag(GameplayTagDefine.EGameplayTagId["角色.BaseRole.技能通用标识.幻象变身中"]))
		{
			EntityHandle summonedEntity = PhantomUtil.GetSummonedEntity(getCurrentEntity.Entity, ESummonType.ConcomitantVision, 1);
			if (summonedEntity != null && summonedEntity.Valid)
			{
				CharacterLockOnComponent characterLockOnComponent = summonedEntity.Entity.CheckGetComponent<CharacterLockOnComponent>();
				if (characterLockOnComponent != null)
				{
					ShowTargetInfo targetInfo3 = characterLockOnComponent.GetTargetInfo();
					EntityHandle showTarget3 = targetInfo3.ShowTarget;
					if (showTarget3 != null && showTarget3.Valid)
					{
						this.TmpTargetEntity = targetInfo3.ShowTarget;
						this.TmpTargetSocketName = targetInfo3.SocketName;
						this.TmpSelfEntity = summonedEntity;
					}
				}
			}
		}
	}

	// Token: 0x0600F61D RID: 63005 RVA: 0x003B6C51 File Offset: 0x003B4E51
	private void ClearTargetInfo()
	{
		this.TmpTargetEntity = null;
		this.TmpTargetSocketName = null;
		this.TmpSelfEntity = null;
		this.TmpIsPlayerLock = false;
	}

	// Token: 0x0600F61E RID: 63006 RVA: 0x003B6C70 File Offset: 0x003B4E70
	private FVectorDouble? GetWorldLocation(EntityHandle targetEntity, string targetSocketName)
	{
		if (targetEntity == null || !targetEntity.Valid)
		{
			return null;
		}
		TsBaseCharacter tsBaseCharacter = targetEntity.Entity.GetComponent<BaseActorComponent>().Owner as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return null;
		}
		USkeletalMeshComponent mesh = tsBaseCharacter.Mesh;
		FName inSocketName = LockCursorHandle.HIT_CASE_SOCKET;
		if (!string.IsNullOrEmpty(targetSocketName))
		{
			FName? dynamicFName = FNameUtil.GetDynamicFName(targetSocketName);
			if (dynamicFName != null)
			{
				FName value = dynamicFName.Value;
				if (mesh.DoesSocketExist(value))
				{
					inSocketName = value;
				}
			}
		}
		else if (!mesh.DoesSocketExist(inSocketName))
		{
			inSocketName = LockCursorHandle.HIT_CASE_SOCKET;
		}
		return new FVectorDouble?(mesh.D_GetSocketLocation(inSocketName));
	}

	// Token: 0x040071E1 RID: 29153
	private static readonly FName HIT_CASE_SOCKET = new FName("HitCase");

	// Token: 0x040071E2 RID: 29154
	[Nullable(1)]
	private readonly Vector2D ScreenPos = new Vector2D();

	// Token: 0x040071E3 RID: 29155
	private LockCursorUnit LockCursorUnit;

	// Token: 0x040071E4 RID: 29156
	private bool IsLoading;

	// Token: 0x040071E5 RID: 29157
	private bool ReleaseGamepadLock;

	// Token: 0x040071E6 RID: 29158
	private bool HasLockCursorUnitBeforeGamepadLock;

	// Token: 0x040071E7 RID: 29159
	private int LockExecutionEntityId;

	// Token: 0x040071E8 RID: 29160
	private EntityHandle TmpTargetEntity;

	// Token: 0x040071E9 RID: 29161
	private string TmpTargetSocketName;

	// Token: 0x040071EA RID: 29162
	private EntityHandle TmpSelfEntity;

	// Token: 0x040071EB RID: 29163
	private bool TmpIsPlayerLock;
}
