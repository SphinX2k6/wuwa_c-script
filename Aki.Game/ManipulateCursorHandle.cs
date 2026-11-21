using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.Render;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x020013F6 RID: 5110
[NullableContext(2)]
[Nullable(0)]
public class ManipulateCursorHandle : HudUnitHandleBase
{
	// Token: 0x0600CA83 RID: 51843 RVA: 0x003C37F4 File Offset: 0x003C19F4
	protected override void OnInitialize()
	{
		base.InitCursorAxis();
		this.CurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		EntityHandle currentEntity = this.CurrentEntity;
		if (currentEntity == null || !currentEntity.Valid)
		{
			return;
		}
		this.CurrentTagComponent = this.CurrentEntity.Entity.GetComponent<BaseTagComponent>();
		this.CurrentEntityActorComponent = this.CurrentEntity.Entity.GetComponent<BaseActorComponent>();
		this.CurrentEntityManipulateComponent = this.CurrentEntity.Entity.GetComponent<CharacterManipulateComponent>();
		this.FightCameraLogicComponent = (CameraController.Instance.MainModel.FightCamera.GetComponent(typeof(FightCameraLogicComponent)) as FightCameraLogicComponent);
		string stringConfig = ConfigCommonParamById.GetStringConfig("ManipulateAimVisibleTags");
		if (string.IsNullOrEmpty(stringConfig))
		{
			return;
		}
		string[] array = stringConfig.Split(',', StringSplitOptions.None);
		for (int i = 0; i < array.Length; i++)
		{
			int tagIdByName = GameplayTagUtils.GetTagIdByName(array[i]);
			if (tagIdByName > 0)
			{
				this.DisableTagIds.Add(tagIdByName);
			}
		}
	}

	// Token: 0x0600CA84 RID: 51844 RVA: 0x003C38DF File Offset: 0x003C1ADF
	protected override void OnDestroyed()
	{
		this.Deactivate();
		this.ClearDisableTagTasks();
		this.CurrentEntity = null;
		this.CurrentEntityActorComponent = null;
		this.CurrentEntityManipulateComponent = null;
		this.CurrentTagComponent = null;
		this.DisableTagIds.Clear();
	}

	// Token: 0x0600CA85 RID: 51845 RVA: 0x003C3914 File Offset: 0x003C1B14
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRoleCompleted));
		EventSystem.Instance.Add<bool, Entity, bool>(EEventName.OnManipulateSwitchToNewTarget, new Action<bool, Entity, bool>(this.OnSwitchToNewTarget));
		EventSystem.Instance.Add<float, string>(EEventName.OnManipulateStartChanting, new Action<float, string>(this.OnManipulateStart));
		EventSystem.Instance.Add(EEventName.OnManipulateCancelChanting, new Action(this.OnManipulateCancel));
		EventSystem.Instance.Add(EEventName.OnManipulateCompleteChanting, new Action(this.OnManipulateComplete));
		EventSystem.Instance.Add<Entity, CharacterPart>(EEventName.ManipulateStartLockCastTarget, new Action<Entity, CharacterPart>(this.OnManipulateStartLockCastTarget));
		EventSystem.Instance.Add(EEventName.ManipulateEndLockCastTarget, new Action(this.OnManipulateEndLockCastTarget));
		EventSystem.Instance.Add(EEventName.HiddenManipulateUI, new Action(this.OnManipulateEnded));
	}

	// Token: 0x0600CA86 RID: 51846 RVA: 0x003C3A04 File Offset: 0x003C1C04
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRoleCompleted));
		EventSystem.Instance.Remove<bool, Entity, bool>(EEventName.OnManipulateSwitchToNewTarget, new Action<bool, Entity, bool>(this.OnSwitchToNewTarget));
		EventSystem.Instance.Remove<float, string>(EEventName.OnManipulateStartChanting, new Action<float, string>(this.OnManipulateStart));
		EventSystem.Instance.Remove(EEventName.OnManipulateCancelChanting, new Action(this.OnManipulateCancel));
		EventSystem.Instance.Remove(EEventName.OnManipulateCompleteChanting, new Action(this.OnManipulateComplete));
		EventSystem.Instance.Remove<Entity, CharacterPart>(EEventName.ManipulateStartLockCastTarget, new Action<Entity, CharacterPart>(this.OnManipulateStartLockCastTarget));
		EventSystem.Instance.Remove(EEventName.ManipulateEndLockCastTarget, new Action(this.OnManipulateEndLockCastTarget));
		EventSystem.Instance.Remove(EEventName.HiddenManipulateUI, new Action(this.OnManipulateEnded));
	}

	// Token: 0x0600CA87 RID: 51847 RVA: 0x003C3AF4 File Offset: 0x003C1CF4
	[NullableContext(1)]
	private void OnChangeRoleCompleted(EntityHandle newEntityHandle, [Nullable(2)] EntityHandle oldEntityHandle)
	{
		this.CurrentEntity = newEntityHandle;
		this.CurrentEntityActorComponent = this.CurrentEntity.Entity.GetComponent<BaseActorComponent>();
		this.CurrentEntityManipulateComponent = this.CurrentEntity.Entity.GetComponent<CharacterManipulateComponent>();
		this.CurrentTagComponent = newEntityHandle.Entity.GetComponent<BaseTagComponent>();
		this.ClearDisableTagTasks();
		foreach (int value in this.DisableTagIds)
		{
			ITagTask tagTask = this.CurrentTagComponent.ListenForTagAddOrRemove(new int?(value), new BaseTagComponent.TTagSwitchedCallback(this.OnDisableTagChanged), ManipulateCursorHandle.ListenTagStat);
			if (tagTask != null)
			{
				this.DisableTagTasks.Add(tagTask);
			}
		}
	}

	// Token: 0x0600CA88 RID: 51848 RVA: 0x003C3BBC File Offset: 0x003C1DBC
	[NullableContext(1)]
	private void OnManipulateStart(float time, string resId)
	{
		this.LockEntityAimVisible = string.IsNullOrEmpty(resId);
		this.ChangeState(EManipulateCursorState.Chanting);
		ManipulateCursorUnit manipulateCursorUnit = this.ManipulateCursorUnit;
		if (manipulateCursorUnit == null)
		{
			return;
		}
		manipulateCursorUnit.StartProcess(time);
	}

	// Token: 0x0600CA89 RID: 51849 RVA: 0x003C3BE2 File Offset: 0x003C1DE2
	private void OnManipulateCancel()
	{
		this.ChangeState(EManipulateCursorState.NoTarget);
	}

	// Token: 0x0600CA8A RID: 51850 RVA: 0x003C3BEB File Offset: 0x003C1DEB
	private void OnManipulateComplete()
	{
		this.ChangeState(EManipulateCursorState.Holding);
	}

	// Token: 0x0600CA8B RID: 51851 RVA: 0x003C3BF4 File Offset: 0x003C1DF4
	[NullableContext(1)]
	private void OnManipulateStartLockCastTarget(Entity lockEntity, CharacterPart lockPart)
	{
		if (!lockEntity.Valid)
		{
			this.IsCastTarget = false;
			this.ChangeState(EManipulateCursorState.NoTarget);
			return;
		}
		this.IsCastTarget = true;
		if (!this.LockEntityAimVisible)
		{
			this.ChangeState(EManipulateCursorState.Holding);
			return;
		}
		this.Activate(lockEntity);
	}

	// Token: 0x0600CA8C RID: 51852 RVA: 0x003C3C2B File Offset: 0x003C1E2B
	private void OnManipulateEndLockCastTarget()
	{
		this.IsCastTarget = false;
		this.ChangeState(EManipulateCursorState.NoTarget);
	}

	// Token: 0x0600CA8D RID: 51853 RVA: 0x003C3C3B File Offset: 0x003C1E3B
	private void OnManipulateEnded()
	{
		this.ChangeState(EManipulateCursorState.NoTarget);
	}

	// Token: 0x0600CA8E RID: 51854 RVA: 0x003C3C44 File Offset: 0x003C1E44
	public new void OnInputControllerChanged(EInputControllerType last, EInputControllerType now)
	{
		if (this.ManipulateCursorUnit == null)
		{
			return;
		}
		if (last != now && (last == EInputControllerType.Touch || now == EInputControllerType.Touch))
		{
			base.DestroyHudUnit(this.ManipulateCursorUnit);
			this.ManipulateCursorUnit = null;
			this.NewManipulateCursorUnit();
		}
	}

	// Token: 0x0600CA8F RID: 51855 RVA: 0x003C3C74 File Offset: 0x003C1E74
	private void OnSwitchToNewTarget(bool isActive, Entity entity, bool isCastTarget)
	{
		this.IsCastTarget = isCastTarget;
		if (!isActive)
		{
			this.ChangeState(EManipulateCursorState.NoTarget);
			return;
		}
		if (entity == null || !entity.Valid)
		{
			if (isCastTarget)
			{
				this.ChangeState(EManipulateCursorState.Holding);
				return;
			}
			this.ChangeState(EManipulateCursorState.NoTarget);
			return;
		}
		else
		{
			if (this.IsCastTarget && !this.LockEntityAimVisible)
			{
				this.ChangeState(EManipulateCursorState.Holding);
				return;
			}
			this.Activate(entity);
			return;
		}
	}

	// Token: 0x0600CA90 RID: 51856 RVA: 0x003C3CD6 File Offset: 0x003C1ED6
	protected override void OnAfterTick(float delta)
	{
		this.Refresh();
	}

	// Token: 0x0600CA91 RID: 51857 RVA: 0x003C3CDE File Offset: 0x003C1EDE
	private void OnDisableTagChanged(int tagId, bool tagExists)
	{
		if (!tagExists)
		{
			this.RefreshVisible();
			return;
		}
		ManipulateCursorUnit manipulateCursorUnit = this.ManipulateCursorUnit;
		if (manipulateCursorUnit == null)
		{
			return;
		}
		manipulateCursorUnit.SetActive(false);
	}

	// Token: 0x0600CA92 RID: 51858 RVA: 0x003C3CFC File Offset: 0x003C1EFC
	private bool RefreshVisible()
	{
		if (this.ManipulateCursorUnit == null)
		{
			return false;
		}
		if (this.ManipulateCursorUnit.InAsyncLoading())
		{
			return false;
		}
		bool flag = !this.HasDisableTag();
		if (this.ManipulateCursorUnit.GetActive() != flag)
		{
			this.ManipulateCursorUnit.SetActive(flag);
		}
		return flag;
	}

	// Token: 0x0600CA93 RID: 51859 RVA: 0x003C3D48 File Offset: 0x003C1F48
	private bool HasDisableTag()
	{
		if (this.DisableTagIds.Count == 0)
		{
			return false;
		}
		foreach (int tagId in this.DisableTagIds)
		{
			if (this.CurrentTagComponent.HasTag(tagId))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600CA94 RID: 51860 RVA: 0x003C3DB8 File Offset: 0x003C1FB8
	private void PlayActivateEffect()
	{
		ManipulateCursorUnit manipulateCursorUnit = this.ManipulateCursorUnit;
		if (manipulateCursorUnit == null)
		{
			return;
		}
		manipulateCursorUnit.PlayActivateEffect();
	}

	// Token: 0x0600CA95 RID: 51861 RVA: 0x003C3DCC File Offset: 0x003C1FCC
	[NullableContext(1)]
	private void Activate(Entity entity)
	{
		this.SelectEntity = entity;
		this.SelectActorComponent = entity.GetComponent<BaseActorComponent>();
		SceneItemActorComponent sceneItemActorComponent = this.SelectActorComponent as SceneItemActorComponent;
		if (sceneItemActorComponent != null)
		{
			this.SelectActor = SceneInteractionManager.Get().GetMainCollisionActor(sceneItemActorComponent.GetSceneInteractionLevelHandleId());
			AActor selectActor = this.SelectActor;
			if (selectActor == null || !selectActor.IsValid())
			{
				this.SelectActor = this.SelectActorComponent.Owner;
			}
		}
		else
		{
			this.SelectActor = this.SelectActorComponent.Owner;
		}
		this.ChangeState(EManipulateCursorState.Target);
		if (this.ManipulateCursorUnit != null)
		{
			if (!this.ManipulateCursorUnit.InAsyncLoading())
			{
				this.Refresh();
				this.RefreshVisible();
				this.PlayActivateEffect();
				this.RefreshIconPath();
			}
			return;
		}
		this.NewManipulateCursorUnit();
	}

	// Token: 0x0600CA96 RID: 51862 RVA: 0x003C3E88 File Offset: 0x003C2088
	private void RefreshIconPath()
	{
		if (!Info.Instance.IsInTouch())
		{
			return;
		}
		Entity selectEntity = this.SelectEntity;
		SceneItemExploreInteractComponent sceneItemExploreInteractComponent = (selectEntity != null) ? selectEntity.GetComponent<SceneItemExploreInteractComponent>() : null;
		string iconPath = (sceneItemExploreInteractComponent != null) ? sceneItemExploreInteractComponent.ExploreSkillUiResource : null;
		ManipulateCursorUnit manipulateCursorUnit = this.ManipulateCursorUnit;
		if (manipulateCursorUnit == null)
		{
			return;
		}
		manipulateCursorUnit.SetIconPath(iconPath);
	}

	// Token: 0x0600CA97 RID: 51863 RVA: 0x003C3ED2 File Offset: 0x003C20D2
	private void Deactivate()
	{
		if (this.ManipulateCursorUnit == null)
		{
			return;
		}
		base.DestroyHudUnit(this.ManipulateCursorUnit);
		this.ManipulateCursorUnit = null;
		this.SelectEntity = null;
		this.SelectActorComponent = null;
		this.SelectActor = null;
	}

	// Token: 0x0600CA98 RID: 51864 RVA: 0x003C3F08 File Offset: 0x003C2108
	private void ClearDisableTagTasks()
	{
		foreach (ITagTask tagTask in this.DisableTagTasks)
		{
			tagTask.EndTask();
		}
		this.DisableTagTasks.Clear();
	}

	// Token: 0x0600CA99 RID: 51865 RVA: 0x003C3F64 File Offset: 0x003C2164
	private void Refresh()
	{
		if (this.ManipulateCursorUnit == null)
		{
			return;
		}
		if (this.ManipulateCursorUnit.InAsyncLoading())
		{
			return;
		}
		if (!this.ManipulateCursorUnit.GetActive())
		{
			return;
		}
		global::Vector selectActorLocation = this.GetSelectActorLocation();
		if (selectActorLocation == null)
		{
			return;
		}
		global::Vector playerLocation = this.GetPlayerLocation();
		ValueTuple<FVector2D, FVector2D?> inEllipsePosition = base.GetInEllipsePosition(playerLocation, selectActorLocation.ToUeVector(false));
		Vector2D vector2D = new Vector2D();
		vector2D.FromUeVector2D(inEllipsePosition.Item1);
		FVector2D? item = inEllipsePosition.Item2;
		bool isInScreen = false;
		if (item != null)
		{
			isInScreen = this.FightCameraLogicComponent.GetScreenPositionIsInRange(item.Value, this.FightCameraLogicComponent.CameraAdjustController.CheckInScreenMinX, this.FightCameraLogicComponent.CameraAdjustController.CheckInScreenMaxX, this.FightCameraLogicComponent.CameraAdjustController.CheckInScreenMinY, this.FightCameraLogicComponent.CameraAdjustController.CheckInScreenMaxY);
		}
		this.ManipulateCursorUnit.Refresh(isInScreen, vector2D, this.IsCastTarget);
	}

	// Token: 0x0600CA9A RID: 51866 RVA: 0x003C404A File Offset: 0x003C224A
	private global::Vector GetPlayerLocation()
	{
		return this.CurrentEntityActorComponent.ActorLocationProxy;
	}

	// Token: 0x0600CA9B RID: 51867 RVA: 0x003C4058 File Offset: 0x003C2258
	private global::Vector GetSelectActorLocation()
	{
		Entity selectEntity = this.SelectEntity;
		if (selectEntity == null || !selectEntity.Valid)
		{
			return null;
		}
		AActor selectActor = this.SelectActor;
		if (selectActor == null || !selectActor.IsValid())
		{
			return null;
		}
		global::Vector vector = global::Vector.Create(this.SelectActor.D_K2_GetActorLocation());
		SceneItemManipulatableComponent component = this.SelectEntity.GetComponent<SceneItemManipulatableComponent>();
		if (component != null && component.GetPassThroughPortalType() != CharacterManipulateComponent.EPassThroughPortalType.None)
		{
			PortalUtils.Instance.GetMappingPosToOtherPortal(vector, component.GetPassThroughPortalId(), component.GetPassThroughPortalType() == CharacterManipulateComponent.EPassThroughPortalType.AToB, vector, false);
		}
		global::Vector targetPartLocation = ManipulaterModel.Instance.GetTargetPartLocation();
		if (targetPartLocation != global::Vector.ZeroVectorProxy)
		{
			vector = targetPartLocation;
		}
		SceneItemDamageComponent component2 = this.SelectEntity.GetComponent<SceneItemDamageComponent>();
		if (component2 != null && this.IsCastTarget)
		{
			vector = component2.GetHitPoint();
		}
		SceneItemOutletComponent component3 = this.SelectEntity.GetComponent<SceneItemOutletComponent>();
		if (component3 != null && this.IsCastTarget)
		{
			vector = component3.GetSocketLocation(this.CurrentEntityManipulateComponent.GetHoldingEntity());
		}
		GamePlayHitGearComponent component4 = this.SelectEntity.GetComponent<GamePlayHitGearComponent>();
		if (component4 != null && this.IsCastTarget)
		{
			vector = component4.GetHitPoint();
		}
		SceneItemExploreInteractComponent component5 = this.SelectEntity.GetComponent<SceneItemExploreInteractComponent>();
		if (component5 != null)
		{
			vector = component5.Location;
		}
		return vector;
	}

	// Token: 0x0600CA9C RID: 51868 RVA: 0x003C417B File Offset: 0x003C237B
	private void NewManipulateCursorUnit()
	{
		base.NewHudUnitWithReturn<ManipulateCursorUnit>(typeof(ManipulateCursorUnit), "UiItem_ObjControl", out this.ManipulateCursorUnit, true, delegate(ManipulateCursorUnit _)
		{
			if (this.State == EManipulateCursorState.NoTarget)
			{
				this.Deactivate();
				return;
			}
			ManipulateCursorUnit manipulateCursorUnit = this.ManipulateCursorUnit;
			if (manipulateCursorUnit != null)
			{
				manipulateCursorUnit.SetCloseAnimCallback(new Action(this.Deactivate));
			}
			this.Refresh();
			this.RefreshVisible();
			this.PlayActivateEffect();
			this.RefreshIconPath();
		}, false);
	}

	// Token: 0x0600CA9D RID: 51869 RVA: 0x003C41A8 File Offset: 0x003C23A8
	private void ChangeState(EManipulateCursorState state)
	{
		if (this.State == state)
		{
			return;
		}
		EManipulateCursorState state2 = this.State;
		this.State = state;
		if (this.ManipulateCursorUnit == null)
		{
			return;
		}
		switch (this.State)
		{
		case EManipulateCursorState.NoTarget:
			if (state2 == EManipulateCursorState.Target)
			{
				this.ManipulateCursorUnit.EndProcess(true);
				this.ManipulateCursorUnit.PlayCloseAnim(0f);
				return;
			}
			if (state2 == EManipulateCursorState.Chanting)
			{
				this.ManipulateCursorUnit.EndProcess(true);
				this.ManipulateCursorUnit.PlayInterruptedAnim();
				this.ManipulateCursorUnit.PlayCloseAnim(200f);
				return;
			}
			break;
		case EManipulateCursorState.Target:
			this.ManipulateCursorUnit.StopCloseAnim();
			this.ManipulateCursorUnit.EndProcess(true);
			this.ManipulateCursorUnit.Appear();
			return;
		case EManipulateCursorState.Chanting:
			this.ManipulateCursorUnit.PlayStartAnim();
			this.ManipulateCursorUnit.PlayProcessAnim();
			return;
		case EManipulateCursorState.Holding:
			if (state2 == EManipulateCursorState.Chanting)
			{
				this.ManipulateCursorUnit.EndProcess(false);
				this.ManipulateCursorUnit.PlayCompleteAnim();
				this.ManipulateCursorUnit.PlayCloseAnim(500f);
				return;
			}
			this.ManipulateCursorUnit.PlayCloseAnim(0f);
			break;
		default:
			return;
		}
	}

	// Token: 0x040072EF RID: 29423
	private const int COMPLETE_ANIM_TIME = 500;

	// Token: 0x040072F0 RID: 29424
	private const int INTERRUPT_ANIM_TIME = 200;

	// Token: 0x040072F1 RID: 29425
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat ListenTagStat = Stat.Create("[ManipulateCursorHandle]ListenTag", "", "");

	// Token: 0x040072F2 RID: 29426
	private EManipulateCursorState State;

	// Token: 0x040072F3 RID: 29427
	private ManipulateCursorUnit ManipulateCursorUnit;

	// Token: 0x040072F4 RID: 29428
	private Entity SelectEntity;

	// Token: 0x040072F5 RID: 29429
	private BaseActorComponent SelectActorComponent;

	// Token: 0x040072F6 RID: 29430
	private AActor SelectActor;

	// Token: 0x040072F7 RID: 29431
	private FVector ActorOrigin = new FVector();

	// Token: 0x040072F8 RID: 29432
	private bool IsCastTarget;

	// Token: 0x040072F9 RID: 29433
	private EntityHandle CurrentEntity;

	// Token: 0x040072FA RID: 29434
	private BaseActorComponent CurrentEntityActorComponent;

	// Token: 0x040072FB RID: 29435
	private CharacterManipulateComponent CurrentEntityManipulateComponent;

	// Token: 0x040072FC RID: 29436
	private FightCameraLogicComponent FightCameraLogicComponent;

	// Token: 0x040072FD RID: 29437
	private BaseTagComponent CurrentTagComponent;

	// Token: 0x040072FE RID: 29438
	[Nullable(1)]
	private readonly List<int> DisableTagIds = new List<int>();

	// Token: 0x040072FF RID: 29439
	[Nullable(1)]
	private readonly List<ITagTask> DisableTagTasks = new List<ITagTask>();

	// Token: 0x04007300 RID: 29440
	private bool LockEntityAimVisible = true;
}
