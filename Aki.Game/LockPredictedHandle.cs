using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020013F2 RID: 5106
[NullableContext(2)]
[Nullable(0)]
public class LockPredictedHandle : HudUnitHandleBase
{
	// Token: 0x0600CA54 RID: 51796 RVA: 0x003C2C3D File Offset: 0x003C0E3D
	protected override void OnInitialize()
	{
		base.OnInitialize();
		this.ListenEntityTag();
	}

	// Token: 0x0600CA55 RID: 51797 RVA: 0x003C2C4B File Offset: 0x003C0E4B
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChangedNextTick, new Action<int, int>(this.OnChangeRoleNextTick));
	}

	// Token: 0x0600CA56 RID: 51798 RVA: 0x003C2C69 File Offset: 0x003C0E69
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, int>(EEventName.BattleUiCurRoleDataChangedNextTick, new Action<int, int>(this.OnChangeRoleNextTick));
	}

	// Token: 0x0600CA57 RID: 51799 RVA: 0x003C2C87 File Offset: 0x003C0E87
	private void OnChangeRoleNextTick(int newEntityId, int oldEntityId)
	{
		this.ListenEntityTag();
	}

	// Token: 0x0600CA58 RID: 51800 RVA: 0x003C2C90 File Offset: 0x003C0E90
	private void ListenEntityTag()
	{
		this.EndTagTask();
		BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
		if (curRoleData == null)
		{
			return;
		}
		EntityHandle entityHandle = curRoleData.EntityHandle;
		if (entityHandle == null || !entityHandle.Valid)
		{
			return;
		}
		BaseTagComponent gameplayTagComponent = curRoleData.GameplayTagComponent;
		if (gameplayTagComponent == null)
		{
			return;
		}
		this.HasTag = gameplayTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.预测锁定"]);
		this.TagTask = gameplayTagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.预测锁定"]), new BaseTagComponent.TTagSwitchedCallback(this.OnTagChange), null);
		if (!this.HasTag)
		{
			this.Deactivate();
		}
	}

	// Token: 0x0600CA59 RID: 51801 RVA: 0x003C2D2B File Offset: 0x003C0F2B
	private void OnTagChange(int tagId, bool bTagExists)
	{
		this.HasTag = bTagExists;
		if (!this.HasTag)
		{
			this.Deactivate();
		}
	}

	// Token: 0x0600CA5A RID: 51802 RVA: 0x003C2D42 File Offset: 0x003C0F42
	protected override void OnDestroyed()
	{
		this.LockPredictedUnit = null;
		this.EndTagTask();
	}

	// Token: 0x0600CA5B RID: 51803 RVA: 0x003C2D51 File Offset: 0x003C0F51
	private void EndTagTask()
	{
		this.HasTag = false;
		if (this.TagTask != null)
		{
			this.TagTask.EndTask();
			this.TagTask = null;
		}
	}

	// Token: 0x0600CA5C RID: 51804 RVA: 0x003C2D74 File Offset: 0x003C0F74
	protected override void OnTick(float delta)
	{
		if (this.IsLoading || !this.HasTag)
		{
			return;
		}
		LockOnInfo targetInfo = this.GetTargetInfo();
		if (targetInfo != null)
		{
			EntityHandle entityHandle = targetInfo.EntityHandle;
			if (entityHandle != null && entityHandle.Valid)
			{
				FVectorDouble? worldLocation = this.GetWorldLocation(targetInfo);
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
				if (this.LockPredictedUnit == null)
				{
					return;
				}
				UUIItem rootItem = this.LockPredictedUnit.GetRootItem();
				if (rootItem == null)
				{
					return;
				}
				rootItem.SetAnchorOffset(this.ScreenPos.ToUeVector2D(false));
				return;
			}
		}
		this.Deactivate();
	}

	// Token: 0x0600CA5D RID: 51805 RVA: 0x003C2E24 File Offset: 0x003C1024
	public void Activate()
	{
		if (this.LockPredictedUnit != null)
		{
			this.LockPredictedUnit.Activate();
			return;
		}
		if (this.IsLoading)
		{
			return;
		}
		this.IsLoading = true;
		base.NewHudUnit<LockPredictedUnit>(typeof(LockPredictedUnit), "UiItem_SuoDingArrow", true, false).ContinueWith(delegate(LockPredictedUnit lockPredictedUnit)
		{
			if (lockPredictedUnit == null)
			{
				return;
			}
			this.IsLoading = false;
			this.LockPredictedUnit = lockPredictedUnit;
		});
	}

	// Token: 0x0600CA5E RID: 51806 RVA: 0x003C2E7E File Offset: 0x003C107E
	public void Deactivate()
	{
		if (this.LockPredictedUnit == null)
		{
			return;
		}
		this.LockPredictedUnit.Deactivate();
	}

	// Token: 0x0600CA5F RID: 51807 RVA: 0x003C2E94 File Offset: 0x003C1094
	public LockOnInfo GetTargetInfo()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null || !getCurrentEntity.Valid)
		{
			return null;
		}
		return getCurrentEntity.Entity.CheckGetComponent<CharacterLockOnComponent>().GetPredictedLockOnTarget();
	}

	// Token: 0x0600CA60 RID: 51808 RVA: 0x003C2ED0 File Offset: 0x003C10D0
	[NullableContext(1)]
	protected FVectorDouble? GetWorldLocation(LockOnInfo targetInfo)
	{
		EntityHandle entityHandle = targetInfo.EntityHandle;
		if (entityHandle == null || !entityHandle.Valid)
		{
			return null;
		}
		AActor owner = entityHandle.Entity.GetComponent<BaseActorComponent>().Owner;
		if (!(owner is TsBaseCharacter))
		{
			return null;
		}
		USkeletalMeshComponent mesh = (owner as TsBaseCharacter).Mesh;
		FName? dynamicFName = FNameUtil.GetDynamicFName(targetInfo.SocketName);
		if (dynamicFName == null || !mesh.DoesSocketExist(dynamicFName.Value))
		{
			dynamicFName = new FName?(LockPredictedHandle._hitCaseSocket);
		}
		return new FVectorDouble?(mesh.D_GetSocketLocation(dynamicFName.Value));
	}

	// Token: 0x040072D4 RID: 29396
	private static readonly FName _hitCaseSocket = new FName("HitCase");

	// Token: 0x040072D5 RID: 29397
	[Nullable(1)]
	private readonly Vector2D ScreenPos = new Vector2D();

	// Token: 0x040072D6 RID: 29398
	private LockPredictedUnit LockPredictedUnit;

	// Token: 0x040072D7 RID: 29399
	private bool IsLoading;

	// Token: 0x040072D8 RID: 29400
	private bool HasTag;

	// Token: 0x040072D9 RID: 29401
	private ITagTask TagTask;
}
