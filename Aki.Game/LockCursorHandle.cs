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

// Token: 0x020013F0 RID: 5104
[NullableContext(2)]
[Nullable(0)]
public class LockCursorHandle : HudUnitHandleBase
{
	// Token: 0x0600CA2E RID: 51758 RVA: 0x003C21E4 File Offset: 0x003C03E4
	protected override void OnAddEvents()
	{
		InputDistributeController.Instance.BindAction("锁定目标", new TInputHandle<InputDistributeDefine.EActionType>(this.OnLockInput));
		EventSystem.Instance.Add<bool, EBehaviorType>(EEventName.OnPressOrReleaseBehaviorButton, new Action<bool, EBehaviorType>(this.OnPressOrReleaseBehaviorButton));
		EventSystem.Instance.Add<bool, int>(EEventName.BreakWeaknessPanelLogicVisibleChange, new Action<bool, int>(this.OnBreakWeaknessPanelLogicVisibleChange));
	}

	// Token: 0x0600CA2F RID: 51759 RVA: 0x003C2244 File Offset: 0x003C0444
	protected override void OnRemoveEvents()
	{
		InputDistributeController.Instance.UnBindAction("锁定目标", new TInputHandle<InputDistributeDefine.EActionType>(this.OnLockInput));
		EventSystem.Instance.Remove<bool, EBehaviorType>(EEventName.OnPressOrReleaseBehaviorButton, new Action<bool, EBehaviorType>(this.OnPressOrReleaseBehaviorButton));
		EventSystem.Instance.Remove<bool, int>(EEventName.BreakWeaknessPanelLogicVisibleChange, new Action<bool, int>(this.OnBreakWeaknessPanelLogicVisibleChange));
	}

	// Token: 0x0600CA30 RID: 51760 RVA: 0x003C22A4 File Offset: 0x003C04A4
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

	// Token: 0x0600CA31 RID: 51761 RVA: 0x003C2331 File Offset: 0x003C0531
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

	// Token: 0x0600CA32 RID: 51762 RVA: 0x003C2349 File Offset: 0x003C0549
	private void OnBreakWeaknessPanelLogicVisibleChange(bool logicVisible, int monsterEntityId)
	{
		if (logicVisible)
		{
			this.LockExecutionEntityId = monsterEntityId;
			return;
		}
		this.LockExecutionEntityId = 0;
	}

	// Token: 0x0600CA33 RID: 51763 RVA: 0x003C235D File Offset: 0x003C055D
	protected override void OnDestroyed()
	{
		this.ClearTargetInfo();
		this.LockCursorUnit = null;
	}

	// Token: 0x0600CA34 RID: 51764 RVA: 0x003C236C File Offset: 0x003C056C
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

	// Token: 0x0600CA35 RID: 51765 RVA: 0x003C23C8 File Offset: 0x003C05C8
	private void DeactivateUnlockTimeDown()
	{
		LockCursorUnit lockCursorUnit = this.LockCursorUnit;
		if (lockCursorUnit == null)
		{
			return;
		}
		lockCursorUnit.DeactivateUnlockTimeDown();
	}

	// Token: 0x0600CA36 RID: 51766 RVA: 0x003C23DC File Offset: 0x003C05DC
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

	// Token: 0x0600CA37 RID: 51767 RVA: 0x003C24E4 File Offset: 0x003C06E4
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

	// Token: 0x0600CA38 RID: 51768 RVA: 0x003C253E File Offset: 0x003C073E
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

	// Token: 0x0600CA39 RID: 51769 RVA: 0x003C2570 File Offset: 0x003C0770
	private UniTask LoadLockCursorUnit()
	{
		LockCursorHandle.<LoadLockCursorUnit>d__22 <LoadLockCursorUnit>d__;
		<LoadLockCursorUnit>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadLockCursorUnit>d__.<>4__this = this;
		<LoadLockCursorUnit>d__.<>1__state = -1;
		<LoadLockCursorUnit>d__.<>t__builder.Start<LockCursorHandle.<LoadLockCursorUnit>d__22>(ref <LoadLockCursorUnit>d__);
		return <LoadLockCursorUnit>d__.<>t__builder.Task;
	}

	// Token: 0x0600CA3A RID: 51770 RVA: 0x003C25B3 File Offset: 0x003C07B3
	public void Deactivate()
	{
		this.ClearTargetInfo();
		if (this.LockCursorUnit == null)
		{
			return;
		}
		this.LockCursorUnit.Deactivate();
	}

	// Token: 0x0600CA3B RID: 51771 RVA: 0x003C25D0 File Offset: 0x003C07D0
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

	// Token: 0x0600CA3C RID: 51772 RVA: 0x003C273D File Offset: 0x003C093D
	private void ClearTargetInfo()
	{
		this.TmpTargetEntity = null;
		this.TmpTargetSocketName = null;
		this.TmpSelfEntity = null;
		this.TmpIsPlayerLock = false;
	}

	// Token: 0x0600CA3D RID: 51773 RVA: 0x003C275C File Offset: 0x003C095C
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

	// Token: 0x040072C2 RID: 29378
	private static readonly FName HIT_CASE_SOCKET = new FName("HitCase");

	// Token: 0x040072C3 RID: 29379
	[Nullable(1)]
	private readonly Vector2D ScreenPos = new Vector2D();

	// Token: 0x040072C4 RID: 29380
	private LockCursorUnit LockCursorUnit;

	// Token: 0x040072C5 RID: 29381
	private bool IsLoading;

	// Token: 0x040072C6 RID: 29382
	private bool ReleaseGamepadLock;

	// Token: 0x040072C7 RID: 29383
	private bool HasLockCursorUnitBeforeGamepadLock;

	// Token: 0x040072C8 RID: 29384
	private int LockExecutionEntityId;

	// Token: 0x040072C9 RID: 29385
	private EntityHandle TmpTargetEntity;

	// Token: 0x040072CA RID: 29386
	private string TmpTargetSocketName;

	// Token: 0x040072CB RID: 29387
	private EntityHandle TmpSelfEntity;

	// Token: 0x040072CC RID: 29388
	private bool TmpIsPlayerLock;
}
