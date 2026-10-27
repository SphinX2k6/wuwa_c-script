using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001F30 RID: 7984
[NullableContext(2)]
[Nullable(0)]
public class LockPredictedHandle : HudUnitHandleBase
{
	// Token: 0x0600F635 RID: 63029 RVA: 0x003B7151 File Offset: 0x003B5351
	protected override void OnInitialize()
	{
		base.OnInitialize();
		this.ListenEntityTag();
	}

	// Token: 0x0600F636 RID: 63030 RVA: 0x003B715F File Offset: 0x003B535F
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChangedNextTick, new Action<int, int>(this.OnChangeRoleNextTick));
	}

	// Token: 0x0600F637 RID: 63031 RVA: 0x003B717D File Offset: 0x003B537D
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, int>(EEventName.BattleUiCurRoleDataChangedNextTick, new Action<int, int>(this.OnChangeRoleNextTick));
	}

	// Token: 0x0600F638 RID: 63032 RVA: 0x003B719B File Offset: 0x003B539B
	private void OnChangeRoleNextTick(int newEntityId, int oldEntityId)
	{
		this.ListenEntityTag();
	}

	// Token: 0x0600F639 RID: 63033 RVA: 0x003B71A4 File Offset: 0x003B53A4
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

	// Token: 0x0600F63A RID: 63034 RVA: 0x003B723F File Offset: 0x003B543F
	private void OnTagChange(int tagId, bool bTagExists)
	{
		this.HasTag = bTagExists;
		if (!this.HasTag)
		{
			this.Deactivate();
		}
	}

	// Token: 0x0600F63B RID: 63035 RVA: 0x003B7256 File Offset: 0x003B5456
	protected override void OnDestroyed()
	{
		this.LockPredictedUnit = null;
		this.EndTagTask();
	}

	// Token: 0x0600F63C RID: 63036 RVA: 0x003B7265 File Offset: 0x003B5465
	private void EndTagTask()
	{
		this.HasTag = false;
		if (this.TagTask != null)
		{
			this.TagTask.EndTask();
			this.TagTask = null;
		}
	}

	// Token: 0x0600F63D RID: 63037 RVA: 0x003B7288 File Offset: 0x003B5488
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

	// Token: 0x0600F63E RID: 63038 RVA: 0x003B7338 File Offset: 0x003B5538
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

	// Token: 0x0600F63F RID: 63039 RVA: 0x003B7392 File Offset: 0x003B5592
	public void Deactivate()
	{
		if (this.LockPredictedUnit == null)
		{
			return;
		}
		this.LockPredictedUnit.Deactivate();
	}

	// Token: 0x0600F640 RID: 63040 RVA: 0x003B73A8 File Offset: 0x003B55A8
	public LockOnInfo GetTargetInfo()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null || !getCurrentEntity.Valid)
		{
			return null;
		}
		return getCurrentEntity.Entity.CheckGetComponent<CharacterLockOnComponent>().GetPredictedLockOnTarget();
	}

	// Token: 0x0600F641 RID: 63041 RVA: 0x003B73E4 File Offset: 0x003B55E4
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

	// Token: 0x040071F3 RID: 29171
	private static readonly FName _hitCaseSocket = new FName("HitCase");

	// Token: 0x040071F4 RID: 29172
	[Nullable(1)]
	private readonly Vector2D ScreenPos = new Vector2D();

	// Token: 0x040071F5 RID: 29173
	private LockPredictedUnit LockPredictedUnit;

	// Token: 0x040071F6 RID: 29174
	private bool IsLoading;

	// Token: 0x040071F7 RID: 29175
	private bool HasTag;

	// Token: 0x040071F8 RID: 29176
	private ITagTask TagTask;
}
