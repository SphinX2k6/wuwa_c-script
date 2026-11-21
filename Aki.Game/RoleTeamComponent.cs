using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Role.Common;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using CSharpScript.Game.NewWorld.Character.Role.Component;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x020027C5 RID: 10181
[NullableContext(2)]
[Nullable(0)]
public class RoleTeamComponent : EntityComponent
{
	// Token: 0x0601988E RID: 104590 RVA: 0x007D5328 File Offset: 0x007D3528
	protected override bool OnInit()
	{
		this.BuffComponent = base.Entity.GetComponent<CharacterBuffComponent>();
		this.TagComponent = base.Entity.GetComponent<BaseTagComponent>();
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		this.StateComp = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
		this.FloatingComp = base.Entity.GetComponent<CharacterFloatingComponent>();
		this.InheritComp = base.Entity.GetComponent<RoleInheritComponent>();
		this.SkillComp = base.Entity.GetComponent<CharacterSkillComponent>();
		this.QteComp = base.Entity.GetComponent<RoleQteComponent>();
		this.MoveComp = base.Entity.GetComponent<CharacterMoveComponent>();
		this.InputComp = base.Entity.GetComponent<CharacterInputComponent>();
		this.LockOnComp = base.Entity.GetComponent<CharacterLockOnComponent>();
		this.ManipulateComp = base.Entity.GetComponent<CharacterManipulateComponent>();
		this.ManipulateInteractComp = base.Entity.GetComponent<CharacterManipulateInteractComponent>();
		this.CharacterExploreComp = base.Entity.GetComponent<CharacterExploreComponent>();
		this.RoleSceneInteractComp = base.Entity.GetComponent<RoleSceneInteractComponent>();
		this.DriveVehicleComp = base.Entity.GetComponent<CharacterDriveVehicleComponent>();
		this.MovementSyncComp = base.Entity.GetComponent<CharacterMovementSyncComponent>();
		return true;
	}

	// Token: 0x0601988F RID: 104591 RVA: 0x007D5458 File Offset: 0x007D3658
	protected override bool OnStart()
	{
		string effectPath = EffectUtil.GetEffectPath("GoBattleMaterial");
		ResourceSystem.Instance.LoadAsync<PD_CharacterControllerDataGroup_C>(effectPath, delegate([Nullable(2)] PD_CharacterControllerDataGroup_C effect, string _)
		{
			if (effect == null)
			{
				return;
			}
			this.GoBattleMaterial = effect;
		}, 100, "js_undefined");
		string effectPath2 = EffectUtil.GetEffectPath("GoDownMaterial");
		ResourceSystem.Instance.LoadAsync<PD_CharacterControllerData_C>(effectPath2, delegate([Nullable(2)] PD_CharacterControllerData_C effect, string _)
		{
			if (effect == null)
			{
				return;
			}
			this.GoDownMaterial = effect;
		}, 100, "js_undefined");
		return true;
	}

	// Token: 0x06019890 RID: 104592 RVA: 0x007D54BA File Offset: 0x007D36BA
	protected override void OnPostActivate()
	{
		this.RefreshTeamTag();
		if (this.DelayOutOfControl)
		{
			this.DelayOutOfControl = false;
			this.ExecuteOutOfControl();
		}
	}

	// Token: 0x06019891 RID: 104593 RVA: 0x007D54D7 File Offset: 0x007D36D7
	protected override bool OnEnd()
	{
		this.ClearWaiters();
		return true;
	}

	// Token: 0x06019892 RID: 104594 RVA: 0x007D54E0 File Offset: 0x007D36E0
	private void ClearWaiters()
	{
		ITagTask notHideTagTask = this.NotHideTagTask;
		if (notHideTagTask != null)
		{
			notHideTagTask.EndTask();
		}
		this.NotHideTagTask = null;
		ITagTask isStiffTagTask = this.IsStiffTagTask;
		if (isStiffTagTask != null)
		{
			isStiffTagTask.EndTask();
		}
		this.IsStiffTagTask = null;
		if (this.WaitQuitEffectTimer != null)
		{
			TimerSystem.Instance.Remove(this.WaitQuitEffectTimer);
			this.WaitQuitEffectTimer = null;
		}
	}

	// Token: 0x06019893 RID: 104595 RVA: 0x007D553D File Offset: 0x007D373D
	public bool NeedSyncTransform()
	{
		return !this.InheritedTransform;
	}

	// Token: 0x06019894 RID: 104596 RVA: 0x007D5548 File Offset: 0x007D3748
	[NullableContext(1)]
	public unsafe static void OnChangeRole([Nullable(2)] EntityHandle lastRole, EntityHandle newRole, bool useGoBattleSkill, double coolDownTime, bool goDownWaitSkillEnd, bool allowRefreshTransform, bool forceInheritTransform)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SceneTeam;
		ELogAuthor author = ELogAuthor.LYY;
		string message = "执行战斗换人";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Last", (lastRole != null) ? new int?(lastRole.Id) : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("New", newRole.Id);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		RoleTeamComponent roleTeamComponent;
		if (lastRole == null)
		{
			roleTeamComponent = null;
		}
		else
		{
			WorldEntity entity = lastRole.Entity;
			roleTeamComponent = ((entity != null) ? entity.GetComponent<RoleTeamComponent>() : null);
		}
		RoleTeamComponent roleTeamComponent2 = roleTeamComponent;
		RoleTeamComponent component = newRole.Entity.GetComponent<RoleTeamComponent>();
		WorldEntity entity2 = newRole.Entity;
		CreatureDataComponent creatureDataComponent = (entity2 != null) ? entity2.GetComponent<CreatureDataComponent>() : null;
		WorldEntity entity3 = newRole.Entity;
		CreatureDataComponent creatureDataComponent2 = (entity3 != null) ? entity3.GetComponent<CreatureDataComponent>() : null;
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.SceneTeam;
		ELogAuthor author2 = ELogAuthor.HYJ;
		string message2 = "Bug 追踪 RoleTeamComponent OnChangeRole";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Last is valid", lastRole != null && lastRole.Valid);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Last is removing", creatureDataComponent == null || creatureDataComponent.GetRemoveState());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("new is valid", newRole != null && newRole.Valid);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("new is removing", creatureDataComponent2 == null || creatureDataComponent2.GetRemoveState());
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
		ETeamGroupType valueOrDefault = SceneTeamModel.Instance.CurrentGroupType.GetValueOrDefault();
		bool flag = SceneTeamDefine.needInheritTypeSet.Contains(valueOrDefault);
		CharacterSkillComponent characterSkillComponent = (roleTeamComponent2 != null) ? roleTeamComponent2.SkillComp : null;
		if (goDownWaitSkillEnd && characterSkillComponent != null && characterSkillComponent.CurrentSkill != null && !characterSkillComponent.IsMainSkillReadyEnd)
		{
			EntityHandle entityHandle = characterSkillComponent.SkillTarget;
			if (entityHandle == null && FormationDataController.Instance.GlobalIsInFight)
			{
				CharacterLockOnComponent lockOnComp = roleTeamComponent2.LockOnComp;
				if (lockOnComp != null)
				{
					lockOnComp.DetectSoftLockTarget(new SkillTargetImpl(), true);
				}
				entityHandle = ((lockOnComp != null) ? lockOnComp.GetCurrentTarget() : null);
			}
			CharacterBuffComponent buffComponent = roleTeamComponent2.BuffComponent;
			if (entityHandle != null && buffComponent != null && buffComponent.HasBuffAuthority())
			{
				buffComponent.AddBuff(1101006002L, new AddBuffParam
				{
					InstigatorId = buffComponent.CreatureDataId,
					Reason = "战斗换人"
				});
			}
		}
		bool specialRollInAir = false;
		bool flag2 = false;
		BaseTagComponent baseTagComponent = (roleTeamComponent2 != null) ? roleTeamComponent2.TagComponent : null;
		if (baseTagComponent != null)
		{
			flag2 = (baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.攀爬"]) || baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.水中"]));
			specialRollInAir = baseTagComponent.HasAllTag(new int[]
			{
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.特殊滚动"]
			});
		}
		component.PerformPossess();
		if (roleTeamComponent2 != null && roleTeamComponent2 != component)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.SceneTeam;
			ELogAuthor author3 = ELogAuthor.LYY;
			string message3 = "角色下场";
			string item = "Entity";
			Entity entity4 = roleTeamComponent2.Entity;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (entity4 != null) ? new int?(entity4.Id) : null);
			instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (GlobalData.GameInstance != null)
			{
				GlobalData.BpEventManager.当换人完成时.Broadcast();
			}
			CharacterManipulateComponent manipulateComp = component.ManipulateComp;
			if (manipulateComp != null)
			{
				manipulateComp.SetDataFromOldRole(lastRole);
			}
			CharacterManipulateInteractComponent manipulateInteractComp = component.ManipulateInteractComp;
			if (manipulateInteractComp != null)
			{
				manipulateInteractComp.SetDataFromOldRole(lastRole);
			}
			CharacterExploreComponent characterExploreComp = component.CharacterExploreComp;
			if (characterExploreComp != null)
			{
				characterExploreComp.SetDataFromOldRole(lastRole);
			}
			RoleSceneInteractComponent roleSceneInteractComp = component.RoleSceneInteractComp;
			if (roleSceneInteractComp != null)
			{
				roleSceneInteractComp.SetDataFromOldRole(lastRole);
			}
			CharacterManipulateInteractComponent manipulateInteractComp2 = roleTeamComponent2.ManipulateInteractComp;
			if (manipulateInteractComp2 != null)
			{
				manipulateInteractComp2.ClearTarget();
			}
			roleTeamComponent2.ClearMovePlatformAttach();
			if (flag || !roleTeamComponent2.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.切人不隐藏"]))
			{
				roleTeamComponent2.SkillComp.StopGroup1Skill("RoleTeamComponent.OnChangeRole");
			}
			bool skill = roleTeamComponent2.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]) && !roleTeamComponent2.SkillComp.IsMainSkillReadyEnd;
			RoleInheritComponent.StateInherit(roleTeamComponent2.InheritComp, component.InheritComp, (!component.QteComp.IsInQte) ? ERoleInheritType.NORMAL : ERoleInheritType.QTE, skill);
			roleTeamComponent2.GoDown(flag);
			roleTeamComponent2.CommitChangeRoleCoolDown(coolDownTime);
		}
		bool forceInherit = flag2 || forceInheritTransform || flag;
		component.RefreshPosition(lastRole, specialRollInAir, allowRefreshTransform, forceInherit);
		component.GoBattle(!flag2 && useGoBattleSkill);
	}

	// Token: 0x06019895 RID: 104597 RVA: 0x007D59BC File Offset: 0x007D3BBC
	private unsafe void PerformPossess()
	{
		AController characterController = Global.CharacterController;
		TsBaseCharacter actor = this.ActorComp.Actor;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Battle;
		ELogAuthor author = ELogAuthor.HYJ;
		string message = "RoleTeam PerformPossess";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("roleActor", actor);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("valid:", actor.IsValid());
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		if (characterController.Pawn != actor)
		{
			actor.Mesh.AddTickPrerequisiteActor(characterController);
			characterController.Possess(actor);
			this.MoveComp.StopMove(false, "RoleTeamComponent.PerformPossess");
			CharacterInputComponent inputComp = this.InputComp;
			if (inputComp == null || !inputComp.Active)
			{
				CharacterInputComponent inputComp2 = this.InputComp;
				if (inputComp2 == null)
				{
					return;
				}
				inputComp2.SetActive(true);
			}
		}
	}

	// Token: 0x06019896 RID: 104598 RVA: 0x007D5A90 File Offset: 0x007D3C90
	private void RefreshPosition(EntityHandle lastRole, bool specialRollInAir, bool allowRefresh, bool forceInherit)
	{
		this.InheritedTransform = false;
		bool clearInputFacing = lastRole == null;
		if (AutoRunModel.Instance.IsInLogicTreeGmMode())
		{
			Log.Instance.Info(ELogModule.SceneTeam, ELogAuthor.LYY, "人物上场，GM推进中，继承位置", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.InheritTransform(clearInputFacing, lastRole);
			return;
		}
		if (!allowRefresh)
		{
			Log.Instance.Info(ELogModule.SceneTeam, ELogAuthor.LYY, "人物上场，不允许改变位置", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (forceInherit)
		{
			Log.Instance.Info(ELogModule.SceneTeam, ELogAuthor.LYY, "人物上场，强制继承位置", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.InheritTransform(clearInputFacing, lastRole);
			return;
		}
		if (this.QteComp.IsInQte)
		{
			Log.Instance.Info(ELogModule.SceneTeam, ELogAuthor.LYY, "人物上场，角色QTE中，不更新位置", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		BaseTagComponent baseTagComponent;
		if (lastRole == null)
		{
			baseTagComponent = null;
		}
		else
		{
			WorldEntity entity = lastRole.Entity;
			baseTagComponent = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
		}
		BaseTagComponent baseTagComponent2 = baseTagComponent;
		if (baseTagComponent2 == null || !baseTagComponent2.HasAnyTag(new int[]
		{
			GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.前台不受控制"],
			GameplayTagDefine.EGameplayTagId["角色.BaseRole.技能通用标识.幻象变身中"],
			GameplayTagDefine.EGameplayTagId["角色.Common.切人不隐藏"],
			GameplayTagDefine.EGameplayTagId["功能.功能制作.被击硬直时间"]
		}))
		{
			Log.Instance.Info(ELogModule.SceneTeam, ELogAuthor.LYY, "人物上场，上个角色不在场，继承位置", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.InheritTransform(clearInputFacing, lastRole);
			return;
		}
		Log.Instance.Info(ELogModule.SceneTeam, ELogAuthor.LYY, "人物上场，上个角色还在场，进行寻点", default(ReadOnlySpan<ValueTuple<string, object>>));
		bool flag = specialRollInAir || (!baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.切人强制地面寻点"]) && baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"]));
		base.Entity.GetComponent<RoleQteComponent>().SetQtePosition(new IOffsetParam
		{
			Rotate = (flag ? 35f : 80f),
			Length = (flag ? 150f : 200f),
			Height = (flag ? -100f : 0f),
			ReferenceTarget = false,
			QteType = (flag ? EQteType.InAir : EQteType.OnLand)
		});
		EMovementMode mode = flag ? EMovementMode.MOVE_Falling : EMovementMode.MOVE_Walking;
		CharacterMoveComponent moveComp = this.MoveComp;
		if (moveComp == null)
		{
			return;
		}
		CharacterActorComponent actorComp = moveComp.ActorComp;
		if (actorComp == null)
		{
			return;
		}
		actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
		{
			Mode = mode,
			Context = "[RoleTeamComponent.RefreshPosition]"
		});
	}

	// Token: 0x06019897 RID: 104599 RVA: 0x007D5CF4 File Offset: 0x007D3EF4
	public bool InheritTransform(bool clearInputFacing = false, EntityHandle lastRole = null)
	{
		this.InheritedTransform = true;
		FTransformDouble? spawnTransform = SceneTeamModel.Instance.GetSpawnTransform();
		if (spawnTransform == null)
		{
			Log.Instance.Error(ELogModule.SceneTeam, ELogAuthor.LYY, "继承位置失败，获取角色Transform为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		FTransformDouble value = spawnTransform.Value;
		CharacterDriveVehicleComponent component = base.Entity.GetComponent<CharacterDriveVehicleComponent>();
		if (component == null || !component.IsOnVehicle)
		{
			if (this.MoveComp.IsStandardGravity)
			{
				FQuat fquat = new FRotator(0f, value.Rotator().Yaw, 0f).Quaternion();
				value.SetRotation(fquat);
			}
			else
			{
				this.TempQuat.FromUeQuat(value.GetRotation());
				this.TempQuat.RotateVector(Vector.ForwardVectorProxy, this.TempVector);
				MathUtils.Instance.LookRotationUpFirst(this.TempVector, this.MoveComp.GravityUp, this.TempRotator);
				this.TempRotator.Quaternion(this.TempQuat);
				FQuat fquat = this.TempQuat.ToUeQuat();
				value.SetRotation(fquat);
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SceneTeam;
		ELogAuthor author = ELogAuthor.LYY;
		string message = "继承位置";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Location", value.GetLocation());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.ActorComp.SetActorTransform(value, "换人.上场", false, null);
		if (clearInputFacing)
		{
			this.ActorComp.SetInputFacing(this.ActorComp.ActorForwardProxy, false);
		}
		SceneTeamModel.Instance.SetLastTransform(null);
		CharacterUnifiedStateComponent stateComp = this.StateComp;
		CharacterFloatingComponent characterFloatingComponent = (lastRole != null && lastRole.Valid) ? lastRole.Entity.GetComponent<CharacterFloatingComponent>() : null;
		bool flag = characterFloatingComponent != null && characterFloatingComponent.Valid && characterFloatingComponent.WasNearGround;
		if (stateComp.PositionState == ECharPositionState.Ground && SceneTeamModel.Instance.LastEntityIsOnGround)
		{
			this.FixSwitchLocation("换人.地面修正", lastRole);
		}
		else if (stateComp.MoveState == ECharMoveState.Slide || stateComp.MoveState == ECharMoveState.NormalSki)
		{
			this.FixSwitchLocation("换人.滑行修正", lastRole);
		}
		else
		{
			if (!flag)
			{
				CharacterFloatingComponent floatingComp = this.FloatingComp;
				if (floatingComp == null || !floatingComp.InFloatingState)
				{
					return true;
				}
			}
			this.FixSwitchLocation("换人.悬浮修正", lastRole);
		}
		return true;
	}

	// Token: 0x06019898 RID: 104600 RVA: 0x007D5F34 File Offset: 0x007D4134
	[NullableContext(1)]
	private void FixSwitchLocation(string context, [Nullable(2)] EntityHandle lastRole = null)
	{
		float num = 0f;
		CharacterFloatingComponent characterFloatingComponent = (lastRole != null && lastRole.Valid) ? lastRole.Entity.GetComponent<CharacterFloatingComponent>() : null;
		if (characterFloatingComponent != null && characterFloatingComponent.Valid && characterFloatingComponent.WasNearGround)
		{
			CharacterActorComponent component = lastRole.Entity.GetComponent<CharacterActorComponent>();
			if (component != null && component.Valid)
			{
				num = this.ActorComp.HalfHeight - component.HalfHeight;
			}
			num -= characterFloatingComponent.WasNearGroundDist;
		}
		this.ActorComp.FixSwitchLocation(context, true, true, num);
	}

	// Token: 0x06019899 RID: 104601 RVA: 0x007D5FB8 File Offset: 0x007D41B8
	private void GoBattle(bool useGoBattleSkill)
	{
		if (this.QteComp.IsInQte)
		{
			this.GoBattleSkill = false;
		}
		else
		{
			bool flag = this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.无QTE则强制出场技"]);
			this.LockOnComp.DetectSoftLockTarget(new SkillTargetImpl(), true);
			EntityHandle currentTarget = this.LockOnComp.GetCurrentTarget();
			bool flag2 = this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.后台"]);
			this.GoBattleSkill = (flag || (useGoBattleSkill && flag2 && currentTarget != null));
		}
		this.ClearWaiters();
		foreach (int value in CharacterUnifiedStateComponent.outGameRoleTags)
		{
			this.TagComponent.RemoveTag(new int?(value));
		}
		this.SetTeamTag(ETeamState.OnStage);
		if (!PlotModel.Instance.InSeamlessFormation)
		{
			base.Entity.EnableByKey(EEntityDisableKey.GoDown, true);
		}
		else
		{
			base.Entity.DisableByKey(EEntityDisableKey.GoDown, true);
		}
		EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.OnRoleGoUpEnable);
		TickProcessSystem.Instance.RegisterOnceTickProcess(ETickingGroup.TG_PostUpdateWork, true, new Action<float>(this.NextSpawnGoBattleMaterial));
		this.ActorComp.KuroMoveAlongFloor(Vector.ZeroVector, 0f, "GoBattle");
		if (!UiCameraModel.Instance.IsActivate())
		{
			CameraController.Instance.ExitCameraMode(ECustomCameraMode.Widget, 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, "MainCamera", null);
		}
		if (this.GoBattleSkill)
		{
			bool flag3 = this.StateComp.PositionState == ECharPositionState.Air;
			bool flag4;
			if (this.StateComp.PositionState == ECharPositionState.Floating)
			{
				CharacterFloatingComponent floatingComp = this.FloatingComp;
				flag4 = (floatingComp != null && !floatingComp.IsOnGround);
			}
			else
			{
				flag4 = false;
			}
			bool flag5 = flag4;
			this.ActorComp.Actor.FightCommand(flag3 || flag5);
		}
		EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.OnRoleGoUp);
	}

	// Token: 0x0601989A RID: 104602 RVA: 0x007D618D File Offset: 0x007D438D
	private void NextSpawnGoBattleMaterial(float delta)
	{
		TimerSystem.Instance.Next(delegate(float _)
		{
			this.SpawnGoBattleMaterial();
		}, null, null);
	}

	// Token: 0x0601989B RID: 104603 RVA: 0x007D61A8 File Offset: 0x007D43A8
	private void SpawnGoBattleMaterial()
	{
		if (!base.Entity.Active)
		{
			return;
		}
		if (SceneTeamModel.Instance.CurrentGroupType.GetValueOrDefault() == ETeamGroupType.Plot)
		{
			int roleId = base.Entity.GetComponent<CreatureDataComponent>().GetRoleId();
			int baseRoleId = RoleConfig.Instance.GetBaseRoleId(roleId);
			UObject goBattleMaterial = PlotModel.Instance.GoBattleMaterial;
			if (goBattleMaterial != null && RoleModel.Instance.IsMainRole(baseRoleId))
			{
				this.ActorComp.Actor.CharRenderingComponent.AddMaterialControllerData(goBattleMaterial);
			}
			return;
		}
		if (this.GoBattleMaterial != null)
		{
			this.ActorComp.Actor.CharRenderingComponent.AddMaterialControllerDataGroup(this.GoBattleMaterial);
		}
		EffectSystem instance = EffectSystem.Instance;
		UObject world = GlobalData.World;
		FTransformDouble? ftransformDouble = new FTransformDouble?(this.ActorComp.ActorTransform);
		int id = instance.SpawnEffect(world, ftransformDouble, "/Game/Aki/Effect/EffectGroup/Common/DA_Fx_Group_ChangeRole_Play.DA_Fx_Group_ChangeRole_Play", "[RoleTeamComponent.SpawnGoBattleMaterial]", new EffectContext(new int?(base.Entity.Id), null, false), EEffectType.Scene, null, null, null, false, false);
		EffectSystem.Instance.SetAdditionTimeScale(ETimeScaleSourceType.SelfCentered, id, CharacterModel.Instance.InverseSelfCenteredTimeDilation);
		if (EffectSystem.Instance.IsValid(id))
		{
			EffectSystem.Instance.GetEffectActor(id).K2_AttachToComponent(this.ActorComp.SkeletalMesh, new FName?(FNameUtil.NONE), EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, true);
		}
	}

	// Token: 0x0601989C RID: 104604 RVA: 0x007D62E4 File Offset: 0x007D44E4
	private void GoDown(bool forceGoDown)
	{
		BaseTagComponent tagComponent = this.TagComponent;
		bool flag = tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.切人不隐藏"]);
		BaseTagComponent tagComponent2 = this.TagComponent;
		bool flag2 = tagComponent2 != null && tagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.被击硬直时间"]);
		if (forceGoDown || (!flag && !flag2))
		{
			Log.Instance.Info(ELogModule.SceneTeam, ELogAuthor.LYY, "角色下场，立即隐藏", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.SetTeamTag(ETeamState.UnderStage);
			base.Entity.DisableByKey(EEntityDisableKey.GoDown, true);
			this.ActorComp.RestoreDefaultController();
			CharacterMoveComponent moveComp = this.MoveComp;
			if (moveComp != null)
			{
				moveComp.StopAllAddMove();
			}
			EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.OnRoleGoDownFinish);
			return;
		}
		Log.Instance.Info(ELogModule.SceneTeam, ELogAuthor.LYY, "角色下场，等待切人不隐藏Tag、硬直时间Tag移除再隐藏角色", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (flag && this.NotHideTagTask == null)
		{
			this.NotHideTagTask = this.TagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.切人不隐藏"]), delegate(int tagId, bool tagExist)
			{
				if (!tagExist)
				{
					ITagTask notHideTagTask = this.NotHideTagTask;
					if (notHideTagTask != null)
					{
						notHideTagTask.EndTask();
					}
					this.NotHideTagTask = null;
					this.TryGoDown();
				}
			}, null);
		}
		if (flag2 && this.IsStiffTagTask == null)
		{
			this.IsStiffTagTask = this.TagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.被击硬直时间"]), delegate(int tagId, bool tagExist)
			{
				if (!tagExist)
				{
					ITagTask isStiffTagTask = this.IsStiffTagTask;
					if (isStiffTagTask != null)
					{
						isStiffTagTask.EndTask();
					}
					this.IsStiffTagTask = null;
					this.TryGoDown();
				}
			}, null);
		}
		this.SetTeamTag(ETeamState.OnStageWithoutControl);
		this.ActorComp.RestoreDefaultController();
		CharacterMoveComponent moveComp2 = this.MoveComp;
		if (moveComp2 == null)
		{
			return;
		}
		moveComp2.StopAllAddMove();
	}

	// Token: 0x0601989D RID: 104605 RVA: 0x007D6464 File Offset: 0x007D4664
	private void TryGoDown()
	{
		bool flag = this.NotHideTagTask == null && this.IsStiffTagTask == null;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SceneTeam;
		ELogAuthor author = ELogAuthor.LYY;
		string message = "角色下场，尝试隐藏角色";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CanGoDown", flag);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (!flag)
		{
			return;
		}
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		int? num = (getCurrentEntity != null) ? new int?(getCurrentEntity.Id) : null;
		int id = base.Entity.Id;
		if (!(num.GetValueOrDefault() == id & num != null))
		{
			this.DisableRoleWithEffect();
		}
	}

	// Token: 0x0601989E RID: 104606 RVA: 0x007D6504 File Offset: 0x007D4704
	public void InterruptDisableWithEffect()
	{
		if (this.WaitQuitEffectTimer != null)
		{
			TimerSystem.Instance.Remove(this.WaitQuitEffectTimer);
			this.WaitQuitEffectTimer = null;
		}
		int quitEffectHandle = this.QuitEffectHandle;
		if (quitEffectHandle != 0)
		{
			this.ActorComp.Actor.CharRenderingComponent.RemoveMaterialControllerData(quitEffectHandle);
			this.QuitEffectHandle = 0;
		}
	}

	// Token: 0x0601989F RID: 104607 RVA: 0x007D6558 File Offset: 0x007D4758
	public void DisableRoleWithEffect()
	{
		if (this.WaitQuitEffectTimer != null)
		{
			Log.Instance.Info(ELogModule.SceneTeam, ELogAuthor.LYY, "角色下场，正在播放特效等待隐藏", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		Log.Instance.Info(ELogModule.SceneTeam, ELogAuthor.LYY, "角色下场，播放特效后再隐藏", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (this.GoDownMaterial != null)
		{
			this.QuitEffectHandle = this.ActorComp.Actor.CharRenderingComponent.AddMaterialControllerData(this.GoDownMaterial);
		}
		this.WaitQuitEffectTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.WaitQuitEffectTimer = null;
			this.DisableRole();
		}, 300f, null, null, true, CharacterModel.Instance.InverseSelfCenteredTimeDilation);
		if (GameModeModel.Instance.IsMulti)
		{
			SceneTeamController.Instance.RoleGoDownPush(base.Entity);
		}
	}

	// Token: 0x060198A0 RID: 104608 RVA: 0x007D661C File Offset: 0x007D481C
	public void DisableRoleWithoutEffect()
	{
		Log.Instance.Info(ELogModule.SceneTeam, ELogAuthor.LYY, "角色下场，立刻隐藏", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (this.WaitQuitEffectTimer != null)
		{
			TimerSystem.Instance.Remove(this.WaitQuitEffectTimer);
			this.WaitQuitEffectTimer = null;
		}
		this.DisableRole();
		if (GameModeModel.Instance.IsMulti)
		{
			SceneTeamController.Instance.RoleGoDownPush(base.Entity);
		}
	}

	// Token: 0x060198A1 RID: 104609 RVA: 0x007D6688 File Offset: 0x007D4888
	private void DisableRole()
	{
		int quitEffectHandle = this.QuitEffectHandle;
		if (quitEffectHandle != 0)
		{
			this.ActorComp.Actor.CharRenderingComponent.RemoveMaterialControllerData(quitEffectHandle);
			this.QuitEffectHandle = 0;
		}
		this.SkillComp.StopAllSkills("RoleTeamComponent.DisableRole");
		this.UpdateStealthTag(false);
		this.SetTeamTag(ETeamState.UnderStage);
		CharacterMoveComponent moveComp = this.MoveComp;
		if (moveComp != null)
		{
			UCharacterMovementComponent characterMovement = moveComp.CharacterMovement;
			if (characterMovement != null)
			{
				characterMovement.SetDefaultMovementMode();
			}
		}
		base.Entity.DisableByKey(EEntityDisableKey.GoDown, true);
		EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.OnRoleGoDownFinish);
	}

	// Token: 0x060198A2 RID: 104610 RVA: 0x007D671C File Offset: 0x007D491C
	private void CommitChangeRoleCoolDown(double coolDown)
	{
		double num = coolDown * 1000.0;
		this.ChangeRoleCdEndTime = num + Time.Instance.PlayerWorldTime;
		EventSystem.Instance.EmitWithTarget<double>(base.Entity, EEventName.OnChangeRoleCoolDownChanged, coolDown);
	}

	// Token: 0x060198A3 RID: 104611 RVA: 0x007D675E File Offset: 0x007D495E
	public bool IsChangeRoleCoolDown()
	{
		if (this.GetChangeRoleCoolDown() > 0.0)
		{
			return true;
		}
		this.ChangeRoleCdEndTime = -1.0;
		return false;
	}

	// Token: 0x060198A4 RID: 104612 RVA: 0x007D6783 File Offset: 0x007D4983
	public double GetChangeRoleCoolDown()
	{
		if (this.ChangeRoleCdEndTime <= 0.0)
		{
			return -1.0;
		}
		return this.ChangeRoleCdEndTime - Time.Instance.PlayerWorldTime;
	}

	// Token: 0x060198A5 RID: 104613 RVA: 0x007D67B1 File Offset: 0x007D49B1
	public void SetTeamTag(ETeamState state)
	{
		this.TeamState = new ETeamState?(state);
		if (base.Entity.IsInit)
		{
			this.RefreshTeamTag();
		}
	}

	// Token: 0x060198A6 RID: 104614 RVA: 0x007D67D4 File Offset: 0x007D49D4
	private void RefreshTeamTag()
	{
		if (this.TeamState == null)
		{
			return;
		}
		ETeamState? teamState = this.TeamState;
		if (teamState != null)
		{
			switch (teamState.GetValueOrDefault())
			{
			case ETeamState.OnStage:
				this.TagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.前台"]));
				this.UpdateStealthTag(false);
				if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.后台"]))
				{
					this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.后台"]));
				}
				if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.前台不受控制"]))
				{
					this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.前台不受控制"]));
					return;
				}
				break;
			case ETeamState.OnStageWithoutControl:
				this.TagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.前台不受控制"]));
				this.UpdateStealthTag(true);
				if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.后台"]))
				{
					this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.后台"]));
				}
				if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.前台"]))
				{
					this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.前台"]));
					return;
				}
				break;
			case ETeamState.UnderStage:
				if (this.ActorComp.IsAutonomousProxy)
				{
					this.TagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.后台"]));
				}
				if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.前台"]))
				{
					this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.前台"]));
				}
				if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.前台不受控制"]))
				{
					this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.前台不受控制"]));
				}
				break;
			default:
				return;
			}
		}
	}

	// Token: 0x060198A7 RID: 104615 RVA: 0x007D6A05 File Offset: 0x007D4C05
	public ETeamState? GetTeamState()
	{
		return this.TeamState;
	}

	// Token: 0x060198A8 RID: 104616 RVA: 0x007D6A10 File Offset: 0x007D4C10
	private void UpdateStealthTag(bool onStageWithoutControl)
	{
		if (onStageWithoutControl)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent == null)
			{
				return;
			}
			tagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.不被敌方子弹命中.前台不受控制"]));
			return;
		}
		else
		{
			BaseTagComponent tagComponent2 = this.TagComponent;
			if (tagComponent2 == null)
			{
				return;
			}
			tagComponent2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.不被敌方子弹命中.前台不受控制"]));
			return;
		}
	}

	// Token: 0x060198A9 RID: 104617 RVA: 0x007D6A6A File Offset: 0x007D4C6A
	public void OutOfControl()
	{
		this.SetTeamTag(ETeamState.OnStageWithoutControl);
		if (!base.Entity.IsInit)
		{
			this.DelayOutOfControl = true;
			return;
		}
		this.ExecuteOutOfControl();
	}

	// Token: 0x060198AA RID: 104618 RVA: 0x007D6A90 File Offset: 0x007D4C90
	private void ExecuteOutOfControl()
	{
		this.SkillComp.StopAllSkills("RoleTeamComponent.OutOfControl");
		CharacterInputComponent inputComp = this.InputComp;
		if (inputComp != null)
		{
			inputComp.ClearMoveVectorCache();
		}
		CharacterInputComponent inputComp2 = this.InputComp;
		if (inputComp2 != null)
		{
			inputComp2.SetActive(false);
		}
		this.ActorComp.ClearInput(false, true);
		CharacterMoveComponent moveComp = this.MoveComp;
		if (moveComp != null)
		{
			moveComp.StopMove(true, "RoleTeamComponent.ExecuteOutOfControl");
		}
		this.ActorComp.RestoreDefaultController();
		CharacterMoveComponent moveComp2 = this.MoveComp;
		if (moveComp2 == null)
		{
			return;
		}
		moveComp2.StopAllAddMove();
	}

	// Token: 0x060198AB RID: 104619 RVA: 0x007D6B10 File Offset: 0x007D4D10
	[NullableContext(1)]
	public static void OnSimulateChangeRole(EntityHandle lastEntityHandle, EntityHandle newEntityHandle, bool onStageWithoutControl, [Nullable(2)] Vector location = null, [Nullable(2)] Rotator rotation = null)
	{
		Entity entity = lastEntityHandle.Entity;
		Entity entity2 = newEntityHandle.Entity;
		if (entity2 == null || entity == null)
		{
			return;
		}
		entity2.GetComponent<RoleTeamComponent>().SimulateGoBattle();
		bool flag = location != null && rotation != null;
		if (entity2.IsInit)
		{
			CharacterActorComponent component = entity2.GetComponent<CharacterActorComponent>();
			if (flag)
			{
				component.SetActorLocationAndRotation(location.ToUeVector(false), rotation.ToUeRotator(), "SwitchRoleNotify", false, null);
			}
			else
			{
				component.SetActorTransform(entity.GetComponent<CharacterActorComponent>().ActorTransform, "SwitchRoleNotify", false, null);
				if (entity.GetComponent<BaseTagComponent>().HasAnyTag(SceneTeamDefine.needFixLocationTagList))
				{
					component.FixSwitchLocation("模拟端换人地面修正", true, true, 0f);
				}
			}
			component.SetInputFacing(component.ActorForwardProxy, false);
		}
		UObject mainAnimInstance = entity2.GetComponent<CharacterAnimationComponent>().MainAnimInstance;
		UObject mainAnimInstance2 = entity.GetComponent<CharacterAnimationComponent>().MainAnimInstance;
		if (UKuroStaticLibrary.IsObjectClassByName(mainAnimInstance, CharacterNameDefines.Instance.ABP_BASEROLE) && UKuroStaticLibrary.IsObjectClassByName(mainAnimInstance2, CharacterNameDefines.Instance.ABP_BASEROLE))
		{
			((ABP_BaseRole_C)mainAnimInstance).替换角色时同步动作数据((ABP_BaseRole_C)mainAnimInstance2);
		}
		if (!flag)
		{
			BaseMovementSyncComponent component2 = entity2.GetComponent<CharacterMovementSyncComponent>();
			CharacterMovementSyncComponent component3 = entity.GetComponent<CharacterMovementSyncComponent>();
			component2.CloneMoveSampleInfos(component3);
		}
		if (!onStageWithoutControl)
		{
			entity.GetComponent<RoleTeamComponent>().SimulateGoDown(false);
		}
	}

	// Token: 0x060198AC RID: 104620 RVA: 0x007D6C5B File Offset: 0x007D4E5B
	public void SimulateGoBattle()
	{
		this.InterruptDisableWithEffect();
		base.Entity.GetComponent<CreatureDataComponent>().SetVisible(true);
		base.Entity.EnableByKey(EEntityDisableKey.GoDown, true);
	}

	// Token: 0x060198AD RID: 104621 RVA: 0x007D6C84 File Offset: 0x007D4E84
	public void SimulateGoDown(bool onStageWithoutControl)
	{
		if (!onStageWithoutControl)
		{
			this.SimulateDisableRole();
			return;
		}
		if (this.WaitQuitEffectTimer != null)
		{
			Log.Instance.Info(ELogModule.SceneTeam, ELogAuthor.LYY, "模拟端角色下场，正在播放特效等待隐藏", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		Log.Instance.Info(ELogModule.SceneTeam, ELogAuthor.LYY, "模拟端角色下场，播放特效后再隐藏", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (this.GoDownMaterial != null)
		{
			CharacterActorComponent actorComp = this.ActorComp;
			int? num;
			if (actorComp == null)
			{
				num = null;
			}
			else
			{
				TsBaseCharacter actor = actorComp.Actor;
				if (actor == null)
				{
					num = null;
				}
				else
				{
					CharRenderingComponent charRenderingComponent = actor.CharRenderingComponent;
					num = ((charRenderingComponent != null) ? new int?(charRenderingComponent.AddMaterialControllerData(this.GoDownMaterial)) : null);
				}
			}
			int? num2 = num;
			this.QuitEffectHandle = num2.GetValueOrDefault();
		}
		this.WaitQuitEffectTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.WaitQuitEffectTimer = null;
			this.SimulateDisableRole();
		}, 300f, null, null, true, CharacterModel.Instance.InverseSelfCenteredTimeDilation);
	}

	// Token: 0x060198AE RID: 104622 RVA: 0x007D6D70 File Offset: 0x007D4F70
	private void SimulateDisableRole()
	{
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		if (component != null)
		{
			component.SetVisible(false);
		}
		base.Entity.DisableByKey(EEntityDisableKey.GoDown, true);
		EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.OnOtherRoleGoDownFinish);
	}

	// Token: 0x060198AF RID: 104623 RVA: 0x007D6DAC File Offset: 0x007D4FAC
	public void ClearMovePlatformAttach()
	{
		this.DriveVehicleComp.IsAttachToMoveSceneItem = false;
		this.MoveComp.NeedRootMotionWhenAttached = false;
		this.MoveComp.CharacterMovement.bKuroStopUpdateBasedMovement = false;
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null)
		{
			AActor owner = actorComp.Owner;
			if (owner != null)
			{
				owner.K2_DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
			}
		}
		CharacterMovementSyncComponent movementSyncComp = this.MovementSyncComp;
		if (movementSyncComp == null)
		{
			return;
		}
		movementSyncComp.ClearBasePlatform();
	}

	// Token: 0x060198B0 RID: 104624 RVA: 0x007D6E14 File Offset: 0x007D5014
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleTeamComponent roleTeamComponent = (RoleTeamComponent)componentTemplate;
		if (roleTeamComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (roleTeamComponent.BuffComponent == null)
		{
			this.BuffComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BuffComponent), "BuffComponent"))
		{
			return false;
		}
		if (roleTeamComponent.TagComponent == null)
		{
			this.TagComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComponent), "TagComponent"))
		{
			return false;
		}
		if (roleTeamComponent.StateComp == null)
		{
			this.StateComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StateComp), "StateComp"))
		{
			return false;
		}
		if (roleTeamComponent.FloatingComp == null)
		{
			this.FloatingComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FloatingComp), "FloatingComp"))
		{
			return false;
		}
		if (roleTeamComponent.InheritComp == null)
		{
			this.InheritComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.InheritComp), "InheritComp"))
		{
			return false;
		}
		if (roleTeamComponent.SkillComp == null)
		{
			this.SkillComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SkillComp), "SkillComp"))
		{
			return false;
		}
		if (roleTeamComponent.QteComp == null)
		{
			this.QteComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.QteComp), "QteComp"))
		{
			return false;
		}
		if (roleTeamComponent.MoveComp == null)
		{
			this.MoveComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
		{
			return false;
		}
		if (roleTeamComponent.InputComp == null)
		{
			this.InputComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.InputComp), "InputComp"))
		{
			return false;
		}
		if (roleTeamComponent.LockOnComp == null)
		{
			this.LockOnComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LockOnComp), "LockOnComp"))
		{
			return false;
		}
		if (roleTeamComponent.ManipulateComp == null)
		{
			this.ManipulateComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ManipulateComp), "ManipulateComp"))
		{
			return false;
		}
		if (roleTeamComponent.ManipulateInteractComp == null)
		{
			this.ManipulateInteractComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ManipulateInteractComp), "ManipulateInteractComp"))
		{
			return false;
		}
		if (roleTeamComponent.CharacterExploreComp == null)
		{
			this.CharacterExploreComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CharacterExploreComp), "CharacterExploreComp"))
		{
			return false;
		}
		if (roleTeamComponent.RoleSceneInteractComp == null)
		{
			this.RoleSceneInteractComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RoleSceneInteractComp), "RoleSceneInteractComp"))
		{
			return false;
		}
		if (roleTeamComponent.MovementSyncComp == null)
		{
			this.MovementSyncComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MovementSyncComp), "MovementSyncComp"))
		{
			return false;
		}
		if (roleTeamComponent.DriveVehicleComp == null)
		{
			this.DriveVehicleComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DriveVehicleComp), "DriveVehicleComp"))
		{
			return false;
		}
		if (roleTeamComponent.GoBattleMaterial == null)
		{
			this.GoBattleMaterial = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.GoBattleMaterial), "GoBattleMaterial"))
		{
			return false;
		}
		if (roleTeamComponent.GoDownMaterial == null)
		{
			this.GoDownMaterial = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.GoDownMaterial), "GoDownMaterial"))
		{
			return false;
		}
		this.ChangeRoleCdEndTime = roleTeamComponent.ChangeRoleCdEndTime;
		this.TeamState = roleTeamComponent.TeamState;
		this.GoBattleSkill = roleTeamComponent.GoBattleSkill;
		if (roleTeamComponent.NotHideTagTask == null)
		{
			this.NotHideTagTask = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.NotHideTagTask), "NotHideTagTask"))
		{
			return false;
		}
		if (roleTeamComponent.IsStiffTagTask == null)
		{
			this.IsStiffTagTask = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.IsStiffTagTask), "IsStiffTagTask"))
		{
			return false;
		}
		this.QuitEffectHandle = roleTeamComponent.QuitEffectHandle;
		if (roleTeamComponent.WaitQuitEffectTimer == null)
		{
			this.WaitQuitEffectTimer = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.WaitQuitEffectTimer), "WaitQuitEffectTimer"))
		{
			return false;
		}
		this.InheritedTransform = roleTeamComponent.InheritedTransform;
		this.DelayOutOfControl = roleTeamComponent.DelayOutOfControl;
		return (roleTeamComponent.TempVector == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector), "TempVector")) && (roleTeamComponent.TempRotator == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempRotator), "TempRotator")) && (roleTeamComponent.TempQuat == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempQuat), "TempQuat"));
	}

	// Token: 0x170028C5 RID: 10437
	// (get) Token: 0x060198B1 RID: 104625 RVA: 0x007D7294 File Offset: 0x007D5494
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170028C6 RID: 10438
	// (get) Token: 0x060198B2 RID: 104626 RVA: 0x007D7297 File Offset: 0x007D5497
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170028C7 RID: 10439
	// (get) Token: 0x060198B3 RID: 104627 RVA: 0x007D729A File Offset: 0x007D549A
	public override bool NeedPostActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170028C8 RID: 10440
	// (get) Token: 0x060198B4 RID: 104628 RVA: 0x007D729D File Offset: 0x007D549D
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400DFD3 RID: 57299
	private CharacterActorComponent ActorComp;

	// Token: 0x0400DFD4 RID: 57300
	private CharacterBuffComponent BuffComponent;

	// Token: 0x0400DFD5 RID: 57301
	private BaseTagComponent TagComponent;

	// Token: 0x0400DFD6 RID: 57302
	private CharacterUnifiedStateComponent StateComp;

	// Token: 0x0400DFD7 RID: 57303
	private CharacterFloatingComponent FloatingComp;

	// Token: 0x0400DFD8 RID: 57304
	private RoleInheritComponent InheritComp;

	// Token: 0x0400DFD9 RID: 57305
	private CharacterSkillComponent SkillComp;

	// Token: 0x0400DFDA RID: 57306
	private RoleQteComponent QteComp;

	// Token: 0x0400DFDB RID: 57307
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400DFDC RID: 57308
	private CharacterInputComponent InputComp;

	// Token: 0x0400DFDD RID: 57309
	private CharacterLockOnComponent LockOnComp;

	// Token: 0x0400DFDE RID: 57310
	private CharacterManipulateComponent ManipulateComp;

	// Token: 0x0400DFDF RID: 57311
	private CharacterManipulateInteractComponent ManipulateInteractComp;

	// Token: 0x0400DFE0 RID: 57312
	private CharacterExploreComponent CharacterExploreComp;

	// Token: 0x0400DFE1 RID: 57313
	private RoleSceneInteractComponent RoleSceneInteractComp;

	// Token: 0x0400DFE2 RID: 57314
	private CharacterMovementSyncComponent MovementSyncComp;

	// Token: 0x0400DFE3 RID: 57315
	private CharacterDriveVehicleComponent DriveVehicleComp;

	// Token: 0x0400DFE4 RID: 57316
	private PD_CharacterControllerDataGroup_C GoBattleMaterial;

	// Token: 0x0400DFE5 RID: 57317
	private PD_CharacterControllerData_C GoDownMaterial;

	// Token: 0x0400DFE6 RID: 57318
	private double ChangeRoleCdEndTime = -1.0;

	// Token: 0x0400DFE7 RID: 57319
	private ETeamState? TeamState;

	// Token: 0x0400DFE8 RID: 57320
	public bool GoBattleSkill;

	// Token: 0x0400DFE9 RID: 57321
	private ITagTask NotHideTagTask;

	// Token: 0x0400DFEA RID: 57322
	private ITagTask IsStiffTagTask;

	// Token: 0x0400DFEB RID: 57323
	private int QuitEffectHandle;

	// Token: 0x0400DFEC RID: 57324
	private TimerHandle WaitQuitEffectTimer;

	// Token: 0x0400DFED RID: 57325
	private bool InheritedTransform;

	// Token: 0x0400DFEE RID: 57326
	private bool DelayOutOfControl;

	// Token: 0x0400DFEF RID: 57327
	[Nullable(1)]
	private readonly Vector TempVector = Vector.Create();

	// Token: 0x0400DFF0 RID: 57328
	[Nullable(1)]
	private readonly Rotator TempRotator = Rotator.Create();

	// Token: 0x0400DFF1 RID: 57329
	[Nullable(1)]
	private readonly Quat TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);
}
