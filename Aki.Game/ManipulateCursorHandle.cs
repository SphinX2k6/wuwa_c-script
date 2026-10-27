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

// Token: 0x02001F34 RID: 7988
[NullableContext(2)]
[Nullable(0)]
public class ManipulateCursorHandle : HudUnitHandleBase
{
	// Token: 0x0600F664 RID: 63076 RVA: 0x003B7D08 File Offset: 0x003B5F08
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

	// Token: 0x0600F665 RID: 63077 RVA: 0x003B7DF3 File Offset: 0x003B5FF3
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

	// Token: 0x0600F666 RID: 63078 RVA: 0x003B7E28 File Offset: 0x003B6028
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

	// Token: 0x0600F667 RID: 63079 RVA: 0x003B7F18 File Offset: 0x003B6118
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

	// Token: 0x0600F668 RID: 63080 RVA: 0x003B8008 File Offset: 0x003B6208
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

	// Token: 0x0600F669 RID: 63081 RVA: 0x003B80D0 File Offset: 0x003B62D0
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

	// Token: 0x0600F66A RID: 63082 RVA: 0x003B80F6 File Offset: 0x003B62F6
	private void OnManipulateCancel()
	{
		this.ChangeState(EManipulateCursorState.NoTarget);
	}

	// Token: 0x0600F66B RID: 63083 RVA: 0x003B80FF File Offset: 0x003B62FF
	private void OnManipulateComplete()
	{
		this.ChangeState(EManipulateCursorState.Holding);
	}

	// Token: 0x0600F66C RID: 63084 RVA: 0x003B8108 File Offset: 0x003B6308
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

	// Token: 0x0600F66D RID: 63085 RVA: 0x003B813F File Offset: 0x003B633F
	private void OnManipulateEndLockCastTarget()
	{
		this.IsCastTarget = false;
		this.ChangeState(EManipulateCursorState.NoTarget);
	}

	// Token: 0x0600F66E RID: 63086 RVA: 0x003B814F File Offset: 0x003B634F
	private void OnManipulateEnded()
	{
		this.ChangeState(EManipulateCursorState.NoTarget);
	}

	// Token: 0x0600F66F RID: 63087 RVA: 0x003B8158 File Offset: 0x003B6358
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

	// Token: 0x0600F670 RID: 63088 RVA: 0x003B8188 File Offset: 0x003B6388
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

	// Token: 0x0600F671 RID: 63089 RVA: 0x003B81EA File Offset: 0x003B63EA
	protected override void OnAfterTick(float delta)
	{
		this.Refresh();
	}

	// Token: 0x0600F672 RID: 63090 RVA: 0x003B81F2 File Offset: 0x003B63F2
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

	// Token: 0x0600F673 RID: 63091 RVA: 0x003B8210 File Offset: 0x003B6410
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

	// Token: 0x0600F674 RID: 63092 RVA: 0x003B825C File Offset: 0x003B645C
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

	// Token: 0x0600F675 RID: 63093 RVA: 0x003B82CC File Offset: 0x003B64CC
	private void PlayActivateEffect()
	{
		ManipulateCursorUnit manipulateCursorUnit = this.ManipulateCursorUnit;
		if (manipulateCursorUnit == null)
		{
			return;
		}
		manipulateCursorUnit.PlayActivateEffect();
	}

	// Token: 0x0600F676 RID: 63094 RVA: 0x003B82E0 File Offset: 0x003B64E0
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

	// Token: 0x0600F677 RID: 63095 RVA: 0x003B839C File Offset: 0x003B659C
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

	// Token: 0x0600F678 RID: 63096 RVA: 0x003B83E6 File Offset: 0x003B65E6
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

	// Token: 0x0600F679 RID: 63097 RVA: 0x003B841C File Offset: 0x003B661C
	private void ClearDisableTagTasks()
	{
		foreach (ITagTask tagTask in this.DisableTagTasks)
		{
			tagTask.EndTask();
		}
		this.DisableTagTasks.Clear();
	}

	// Token: 0x0600F67A RID: 63098 RVA: 0x003B8478 File Offset: 0x003B6678
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

	// Token: 0x0600F67B RID: 63099 RVA: 0x003B855E File Offset: 0x003B675E
	private global::Vector GetPlayerLocation()
	{
		return this.CurrentEntityActorComponent.ActorLocationProxy;
	}

	// Token: 0x0600F67C RID: 63100 RVA: 0x003B856C File Offset: 0x003B676C
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

	// Token: 0x0600F67D RID: 63101 RVA: 0x003B868F File Offset: 0x003B688F
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

	// Token: 0x0600F67E RID: 63102 RVA: 0x003B86BC File Offset: 0x003B68BC
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

	// Token: 0x0400720E RID: 29198
	private const int COMPLETE_ANIM_TIME = 500;

	// Token: 0x0400720F RID: 29199
	private const int INTERRUPT_ANIM_TIME = 200;

	// Token: 0x04007210 RID: 29200
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat ListenTagStat = Stat.Create("[ManipulateCursorHandle]ListenTag", "", "");

	// Token: 0x04007211 RID: 29201
	private EManipulateCursorState State;

	// Token: 0x04007212 RID: 29202
	private ManipulateCursorUnit ManipulateCursorUnit;

	// Token: 0x04007213 RID: 29203
	private Entity SelectEntity;

	// Token: 0x04007214 RID: 29204
	private BaseActorComponent SelectActorComponent;

	// Token: 0x04007215 RID: 29205
	private AActor SelectActor;

	// Token: 0x04007216 RID: 29206
	private FVector ActorOrigin = new FVector();

	// Token: 0x04007217 RID: 29207
	private bool IsCastTarget;

	// Token: 0x04007218 RID: 29208
	private EntityHandle CurrentEntity;

	// Token: 0x04007219 RID: 29209
	private BaseActorComponent CurrentEntityActorComponent;

	// Token: 0x0400721A RID: 29210
	private CharacterManipulateComponent CurrentEntityManipulateComponent;

	// Token: 0x0400721B RID: 29211
	private FightCameraLogicComponent FightCameraLogicComponent;

	// Token: 0x0400721C RID: 29212
	private BaseTagComponent CurrentTagComponent;

	// Token: 0x0400721D RID: 29213
	[Nullable(1)]
	private readonly List<int> DisableTagIds = new List<int>();

	// Token: 0x0400721E RID: 29214
	[Nullable(1)]
	private readonly List<ITagTask> DisableTagTasks = new List<ITagTask>();

	// Token: 0x0400721F RID: 29215
	private bool LockEntityAimVisible = true;
}
