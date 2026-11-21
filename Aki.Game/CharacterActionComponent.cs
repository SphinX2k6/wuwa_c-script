using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.Utils;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200255C RID: 9564
[NullableContext(1)]
[Nullable(0)]
public class CharacterActionComponent : EntityComponent
{
	// Token: 0x1700248E RID: 9358
	// (get) Token: 0x060179DC RID: 96732 RVA: 0x006F98FA File Offset: 0x006F7AFA
	public override Type[] Dependencies
	{
		get
		{
			return new Type[]
			{
				typeof(CharacterActorComponent),
				typeof(CharacterUnifiedStateComponent),
				typeof(BaseTagComponent)
			};
		}
	}

	// Token: 0x1700248F RID: 9359
	// (get) Token: 0x060179DD RID: 96733 RVA: 0x006F9929 File Offset: 0x006F7B29
	public bool IsSitDown
	{
		get
		{
			return this.IsSitDownInternal;
		}
	}

	// Token: 0x17002490 RID: 9360
	// (get) Token: 0x060179DE RID: 96734 RVA: 0x006F9931 File Offset: 0x006F7B31
	public bool IsSummonSitDownLocked
	{
		get
		{
			return this.SummonSitDownLockedInternal;
		}
	}

	// Token: 0x060179DF RID: 96735 RVA: 0x006F993C File Offset: 0x006F7B3C
	public void ApplySummonSitDownLock(string reason)
	{
		if (this.SummonSitDownLockedInternal)
		{
			return;
		}
		this.SummonSitDownLockedInternal = true;
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.Character;
		ELogAuthor author = ELogAuthor.WLJ;
		string message = "ApplySummonSitDownLock";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reason", reason);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060179E0 RID: 96736 RVA: 0x006F9980 File Offset: 0x006F7B80
	public void ReleaseSummonSitDownLock(string reason)
	{
		if (!this.SummonSitDownLockedInternal)
		{
			return;
		}
		this.SummonSitDownLockedInternal = false;
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.Character;
		ELogAuthor author = ELogAuthor.WLJ;
		string message = "ReleaseSummonSitDownLock";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reason", reason);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060179E1 RID: 96737 RVA: 0x006F99C4 File Offset: 0x006F7BC4
	public unsafe void SetIsSitDown(bool isSitDown, string reason)
	{
		if (this.IsSitDownInternal != isSitDown)
		{
			if (!isSitDown && this.ChairInternal != null && this.ChairNeedSetMorph)
			{
				AnimController.Instance.SetSeatMorph(this.ChairInternal, base.Entity.Id, 0.0);
			}
			this.IsSitDownInternal = isSitDown;
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.ClearInput(false, true);
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.WLJ;
			string message = "SetIsSitDown";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("isSitDown", isSitDown);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reason", reason);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (this.IsSitDownInternal)
			{
				BaseTagComponent tagComp = this.TagComp;
				if (tagComp != null)
				{
					tagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.不能切人"]));
				}
			}
			else
			{
				this.ReleaseSummonSitDownLock("SetIsSitDown false: " + reason);
				BaseTagComponent tagComp2 = this.TagComp;
				if (tagComp2 != null)
				{
					tagComp2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.不能切人"]));
				}
			}
			EventSystem.Instance.EmitWithTarget<ECharacterActionType, bool>(base.Entity, EEventName.CharActionStateChange, ECharacterActionType.Sit, isSitDown);
		}
	}

	// Token: 0x17002491 RID: 9361
	// (get) Token: 0x060179E2 RID: 96738 RVA: 0x006F9B04 File Offset: 0x006F7D04
	// (set) Token: 0x060179E3 RID: 96739 RVA: 0x006F9B0C File Offset: 0x006F7D0C
	[Nullable(2)]
	public Entity Chair
	{
		[NullableContext(2)]
		get
		{
			return this.ChairInternal;
		}
		[NullableContext(2)]
		set
		{
			if (this.ChairInternal != value)
			{
				if (this.ChairInternal != null && EventSystem.Instance.HasWithTarget(this.ChairInternal, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveChair)))
				{
					EventSystem.Instance.RemoveWithTarget(this.ChairInternal, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveChair));
				}
				if (value != null && !EventSystem.Instance.HasWithTarget(value, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveChair)))
				{
					EventSystem.Instance.AddWithTarget<ERemoveEntityType, EntityHandle>(value, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveChair));
				}
				this.ChairInternal = value;
				bool? flag;
				if (value == null)
				{
					flag = null;
				}
				else
				{
					SceneItemProceduralMaterialComponent component = value.GetComponent<SceneItemProceduralMaterialComponent>();
					flag = ((component != null) ? new bool?(component.HasCustomType(SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType.Chair)) : null);
				}
				bool? flag2 = flag;
				this.ChairNeedSetMorph = flag2.GetValueOrDefault();
			}
		}
	}

	// Token: 0x060179E4 RID: 96740 RVA: 0x006F9BF3 File Offset: 0x006F7DF3
	private void OnRemoveChair(ERemoveEntityType removeType, EntityHandle handle)
	{
		this.Chair = null;
	}

	// Token: 0x060179E5 RID: 96741 RVA: 0x006F9BFC File Offset: 0x006F7DFC
	private void OnSitDownEndChanged(int tagId, bool tagExist)
	{
		if (!tagExist)
		{
			this.LeaveSitDownAction();
		}
	}

	// Token: 0x060179E6 RID: 96742 RVA: 0x006F9C08 File Offset: 0x006F7E08
	private void OnDisableTagChanged(int tagId, bool tagExist)
	{
		if (tagExist && this.IsSitDown)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
			defaultInterpolatedStringHandler.AppendLiteral("OnDisableTagChanged ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(tagId);
			this.PreLeaveSitDownAction(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	// Token: 0x060179E7 RID: 96743 RVA: 0x006F9C4C File Offset: 0x006F7E4C
	protected override bool OnStart()
	{
		this.ActorComp = base.Entity.CheckGetComponent<CharacterActorComponent>();
		this.OriginCapsuleRadius = this.ActorComp.Radius;
		this.OriginCapsuleHalfHeight = this.ActorComp.HalfHeight;
		this.StateComp = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
		this.MoveComp = base.Entity.GetComponent<CharacterMoveComponent>();
		this.SkillComp = base.Entity.GetComponent<CharacterSkillComponent>();
		if (this.StateComp == null)
		{
			return false;
		}
		this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
		if (this.TagComp == null)
		{
			return false;
		}
		this.SetIsSitDown(false, "OnStart");
		this.Chair = null;
		this.Giant = null;
		this.MarkForResetCollision = false;
		this.IsInit = false;
		this.OnSuperJumpTask = this.TagComp.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.超级跳跃"]), new BaseTagComponent.TTagSwitchedCallback(this.OnSuperJumpStateChanged), null);
		return true;
	}

	// Token: 0x060179E8 RID: 96744 RVA: 0x006F9D40 File Offset: 0x006F7F40
	protected override void OnActivate()
	{
		if (!this.ActorComp.IsAutonomousProxy || this.IsInit)
		{
			return;
		}
		this.OnSitDownEndChangedTask = this.TagComp.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["角色.BaseRole.状态通用标识.动作.坐下.结束"]), new BaseTagComponent.TTagSwitchedCallback(this.OnSitDownEndChanged), null);
		BaseTagComponent tagComp = this.TagComp;
		if (tagComp != null && tagComp.Valid)
		{
			foreach (int value in CharacterActionComponent.DisableTags)
			{
				this.TagListeners.Add(this.TagComp.ListenForTagAddOrRemove(new int?(value), new BaseTagComponent.TTagSwitchedCallback(this.OnDisableTagChanged), null));
			}
		}
		EventSystem.Instance.Add<bool>(EEventName.TeleportStart, new Action<bool>(this.TeleportStart));
		EventSystem.Instance.Add<PlotInfo>(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.PlotNetworkStart));
		this.IsInit = true;
	}

	// Token: 0x060179E9 RID: 96745 RVA: 0x006F9E29 File Offset: 0x006F8029
	private void TeleportStart(bool b)
	{
		if (this.IsSitDown)
		{
			this.PreLeaveSitDownAction("TeleportStart");
		}
	}

	// Token: 0x060179EA RID: 96746 RVA: 0x006F9E3E File Offset: 0x006F803E
	private void PlotNetworkStart(PlotInfo plotInfo)
	{
		if (this.IsSitDown && plotInfo.PlotLevel != EPlotLevel.LevelD && plotInfo.PlotLevel != EPlotLevel.LevelE && !plotInfo.KeepMainRolePose)
		{
			this.PreLeaveSitDownAction("PlotNetworkStart");
		}
	}

	// Token: 0x060179EB RID: 96747 RVA: 0x006F9E70 File Offset: 0x006F8070
	protected override bool OnEnd()
	{
		if (!this.IsInit)
		{
			return true;
		}
		if (this.IsSitDown)
		{
			this.PreLeaveSitDownAction("OnEnd");
		}
		this.OnSitDownEndChangedTask.EndTask();
		this.OnSitDownEndChangedTask = null;
		this.OnSuperJumpTask.EndTask();
		this.OnSuperJumpTask = null;
		foreach (ITagTask tagTask in this.TagListeners)
		{
			tagTask.EndTask();
		}
		this.TagListeners.Clear();
		EventSystem.Instance.Remove(EEventName.TeleportStart, new Action<bool>(this.TeleportStart));
		EventSystem.Instance.Remove(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.PlotNetworkStart));
		return true;
	}

	// Token: 0x060179EC RID: 96748 RVA: 0x006F9F48 File Offset: 0x006F8148
	protected override void OnTick(float delta)
	{
		if (!this.ActorComp.IsAutonomousProxy)
		{
			return;
		}
		if (this.IsSitDown)
		{
			if (this.Chair != null && this.ChairNeedSetMorph)
			{
				CharacterActorComponent actorComp = this.ActorComp;
				float? num;
				if (actorComp == null)
				{
					num = null;
				}
				else
				{
					USkeletalMeshComponent mesh = actorComp.Actor.Mesh;
					if (mesh == null)
					{
						num = null;
					}
					else
					{
						UAnimInstance animInstance = mesh.GetAnimInstance();
						num = ((animInstance != null) ? new float?(animInstance.GetCurveValue(CharacterNameDefines.Instance.SEAT_MORPH)) : null);
					}
				}
				float? num2 = num;
				float valueOrDefault = num2.GetValueOrDefault();
				AnimController.Instance.SetSeatMorph(this.Chair, base.Entity.Id, (double)valueOrDefault);
			}
			if (this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["角色.BaseRole.状态通用标识.动作.坐下.持续"]) && this.MoveComp.HasMoveInput && !this.IsSummonedChairLeaveBlocked())
			{
				this.PreLeaveSitDownAction("HasMoveInput");
			}
		}
		if (this.MarkForResetCollision)
		{
			global::Vector actorLocationProxy = this.Chair.GetComponent<SceneItemActorComponent>().ActorLocationProxy;
			global::Vector actorLocationProxy2 = this.ActorComp.ActorLocationProxy;
			global::Vector actorForwardProxy = this.ActorComp.ActorForwardProxy;
			double num3 = Vector2D.Create(actorLocationProxy2.X - actorLocationProxy.X, actorLocationProxy2.Y - actorLocationProxy.Y).DotProduct(this.MainChairDir);
			Vector2D vector2D = Vector2D.Create(actorForwardProxy.X, actorForwardProxy.Y);
			vector2D.Normalize(9.99999993922529E-09);
			float value = (float)(Math.Acos(this.StandUpActorForward.DotProduct(vector2D)) * 57.295780181884766);
			if (num3 < 15.0 || (num3 > 50.0 && this.MoveComp.HasMoveInput) || Math.Abs(value) > 91f)
			{
				this.ResetCollision();
			}
		}
		if (this.IsRotatingBeforeManipulate && this.ActorComp.ActorRotationProxy.Equals(this.ActorComp.InputRotatorProxy, 0.0001f))
		{
			this.IsRotatingBeforeManipulate = false;
			this.TagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["角色.BaseRole.状态通用标识.动作.操控巨物.开始"]));
			CharacterInputComponent component = base.Entity.GetComponent<CharacterInputComponent>();
			InputController.Instance.AddInputHandler(component);
			CameraController.Instance.SetInputEnable(Global.BaseCharacter, true, "MainCamera");
		}
	}

	// Token: 0x060179ED RID: 96749 RVA: 0x006FA198 File Offset: 0x006F8398
	private void IgnoreActorsCollision(SceneItemActorComponent actorComp, bool bCollision)
	{
		CreatureDataComponent component = actorComp.Entity.GetComponent<CreatureDataComponent>();
		int pbDataId = (component != null) ? component.GetPbDataId() : 0;
		int? ownerEntity = CreatureModel.Instance.GetOwnerEntity(pbDataId);
		SceneItemActorComponent sceneItemActorComponent;
		if (ownerEntity != null)
		{
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(ownerEntity.Value);
			if (entityByPbDataId != null && entityByPbDataId.Valid)
			{
				sceneItemActorComponent = entityByPbDataId.Entity.GetComponent<SceneItemActorComponent>();
			}
			else
			{
				sceneItemActorComponent = actorComp;
			}
		}
		else
		{
			sceneItemActorComponent = actorComp;
		}
		TArray<AActor> tarray = new TArray<AActor>();
		sceneItemActorComponent.Owner.GetAttachedActors(ref tarray, true);
		int num = tarray.Num();
		for (int i = 0; i < num; i++)
		{
			AActor aactor = tarray.Get(i);
			TArray<AActor> tarray2 = new TArray<AActor>();
			aactor.GetAttachedActors(ref tarray2, true);
			int num2 = tarray2.Num();
			for (int j = 0; j < num2; j++)
			{
				this.ActorComp.Actor.CapsuleComponent.IgnoreActorWhenMoving(tarray2.Get(j), bCollision);
			}
		}
	}

	// Token: 0x060179EE RID: 96750 RVA: 0x006FA288 File Offset: 0x006F8488
	public void ResetCollision()
	{
		this.MarkForResetCollision = false;
		this.ActorComp.Actor.CapsuleComponent.SetCollisionResponseToChannel(ECollisionChannel.ECC_Pawn, ECollisionResponse.ECR_Block);
		if (this.Chair == null)
		{
			return;
		}
		SceneItemActorComponent component = this.Chair.GetComponent<SceneItemActorComponent>();
		if (component != null && component.Entity != null)
		{
			this.IgnoreActorsCollision(component, false);
		}
		this.Chair = null;
	}

	// Token: 0x060179EF RID: 96751 RVA: 0x006FA2E2 File Offset: 0x006F84E2
	public bool GetSitDownState()
	{
		return this.IsSitDown;
	}

	// Token: 0x060179F0 RID: 96752 RVA: 0x006FA2EC File Offset: 0x006F84EC
	private bool IsSummonedChairSitBlocked(Entity sceneItem)
	{
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		int num = (component != null) ? component.GetPlayerId() : 0;
		if (num <= 0)
		{
			return false;
		}
		IPlayerFollowerChairHandler playerFollowerChairHandler = FollowUtils.GetPlayerFollowHandler(num, EPlayerFollowerHandlerType.Chair) as IPlayerFollowerChairHandler;
		return (playerFollowerChairHandler != null && playerFollowerChairHandler.IsSummonedChairManualSitBlocked(sceneItem)) || (playerFollowerChairHandler != null && playerFollowerChairHandler.IsChairSpaceOccupied(sceneItem));
	}

	// Token: 0x060179F1 RID: 96753 RVA: 0x006FA340 File Offset: 0x006F8540
	public bool IsSummonedChairLeaveBlocked()
	{
		if (this.Chair == null)
		{
			return false;
		}
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		int num = (component != null) ? component.GetPlayerId() : 0;
		if (num <= 0)
		{
			return false;
		}
		IPlayerFollowerChairHandler playerFollowerChairHandler = FollowUtils.GetPlayerFollowHandler(num, EPlayerFollowerHandlerType.Chair) as IPlayerFollowerChairHandler;
		return playerFollowerChairHandler != null && playerFollowerChairHandler.IsSummonedChairSitDownNotSettled(this.Chair);
	}

	// Token: 0x060179F2 RID: 96754 RVA: 0x006FA394 File Offset: 0x006F8594
	private unsafe bool CanEnterSitDownAction(Entity sceneItem)
	{
		if (this.TagComp.HasAnyTag(new int[]
		{
			GameplayTagDefine.EGameplayTagId["角色.BaseRole.状态通用标识.动作.坐下"],
			GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止坐下"],
			GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]
		}))
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[CharacterActionComponent] 进入坐下失败: 当前处于坐下/禁止坐下/技能中互斥状态";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", base.Entity.Id);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (TeleportModel.Instance.IsTeleport)
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.Character;
			ELogAuthor author2 = ELogAuthor.CK;
			string message2 = "[CharacterActionComponent] 进入坐下失败: 传送期间禁止坐下";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("EntityId", base.Entity.Id);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		if (this.IsSummonedChairSitBlocked(sceneItem))
		{
			global::Log instance3 = global::Log.Instance;
			ELogModule module3 = ELogModule.Character;
			ELogAuthor author3 = ELogAuthor.CK;
			string message3 = "[CharacterActionComponent] 进入坐下失败: 召唤椅尚未进入已起身态或被占用, 禁止重新坐下";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SceneItemId", sceneItem.Id);
			instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		if (sceneItem.GetComponent<SceneItemActorComponent>() == null)
		{
			global::Log instance4 = global::Log.Instance;
			ELogModule module4 = ELogModule.Character;
			ELogAuthor author4 = ELogAuthor.CK;
			string message4 = "[CharacterActionComponent] 进入坐下失败: 目标实体缺少 SceneItemActorComponent, 非可坐场景物";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("SceneItemId", sceneItem.Id);
			instance4.Warn(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return false;
		}
		return true;
	}

	// Token: 0x060179F3 RID: 96755 RVA: 0x006FA554 File Offset: 0x006F8754
	public bool EnterSitDownAction(Entity sceneItem, int type, bool limitStandUpFromOneSide = false)
	{
		if (!this.CanEnterSitDownAction(sceneItem))
		{
			return false;
		}
		SceneItemActorComponent component = sceneItem.GetComponent<SceneItemActorComponent>();
		if (this.MarkForResetCollision && this.Chair != null)
		{
			this.ResetCollision();
		}
		this.SkillComp.StopAllSkills("CharacterActionComponent.EnterSitDownAction");
		this.SitDownTypeIndex = type;
		this.EnterSitDownIndex = this.IsChairCanInteract(sceneItem) - EChairInteractDirection.Forward;
		this.LimitStandUpFromOneSide = limitStandUpFromOneSide;
		EventSystem.Instance.EmitWithTarget<ECharacterActionType>(base.Entity, EEventName.OnBeforeCharActionWithTarget, ECharacterActionType.Sit);
		this.SetIsSitDown(true, "角色进入坐下动作");
		this.MarkForResetCollision = false;
		this.Chair = sceneItem;
		this.RegisterSitSpecialAnimMachineState();
		HoldingHandsController.Instance.SitOnCharCheckHoldHands(base.Entity, component);
		return true;
	}

	// Token: 0x060179F4 RID: 96756 RVA: 0x006FA5FF File Offset: 0x006F87FF
	private void RegisterSitSpecialAnimMachineState()
	{
		this.RequestSitDownAction(null, null);
	}

	// Token: 0x060179F5 RID: 96757 RVA: 0x006FA60C File Offset: 0x006F880C
	[NullableContext(2)]
	private void RequestSitDownAction(List<int> states, List<int> specialStates)
	{
		long creatureDataId = 0L;
		if (this.Chair != null)
		{
			CreatureDataComponent component = this.Chair.GetComponent<CreatureDataComponent>();
			creatureDataId = ((component != null) ? component.GetCreatureDataId() : 0L);
		}
		AnimationStateChangedRequest animationStateChangedRequest = AnimationStateChangedRequest.Create();
		if (states != null)
		{
			animationStateChangedRequest.States.AddRange(states);
			if (animationStateChangedRequest.States.Count > 600)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Interaction;
				ELogAuthor author = ELogAuthor.ZQR;
				string message = "RequestSitDownAction同步数据过大";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("States", animationStateChangedRequest.States);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
		if (specialStates != null)
		{
			animationStateChangedRequest.SpecialStates.AddRange(specialStates);
		}
		LevelGamePlayController.Instance.RequestChairSit(creatureDataId, this.IsSitDown, animationStateChangedRequest);
	}

	// Token: 0x060179F6 RID: 96758 RVA: 0x006FA6B4 File Offset: 0x006F88B4
	public void OnResponseSit(bool isSitDown, int errorCode)
	{
		if (errorCode != 0)
		{
			this.SetIsSitDown(!isSitDown, "服务器返回错误");
		}
	}

	// Token: 0x060179F7 RID: 96759 RVA: 0x006FA6C8 File Offset: 0x006F88C8
	public void DoSitDownAction()
	{
		if (this.Chair == null)
		{
			return;
		}
		this.TempVector.Reset();
		this.MoveComp.SetForceSpeed(this.TempVector);
		SceneItemActorComponent component = this.Chair.GetComponent<SceneItemActorComponent>();
		PawnInteractNewComponent component2 = this.Chair.GetComponent<PawnInteractNewComponent>();
		this.TempVector.DeepCopy(component2.GetInteractPoint());
		this.TempVector.Z += (double)this.OriginCapsuleHalfHeight;
		this.TempRotator.DeepCopy(component.ActorRotationProxy);
		this.TempRotator.Yaw += 90f;
		this.ActorComp.SetInputRotator(this.TempRotator);
		this.ActorComp.SetActorLocationAndRotation(this.TempVector.ToUeVector(false), this.TempRotator.ToUeRotator(), "角色坐下", false, null);
		CameraController.Instance.MainModel.FightCamera.GetComponent<FightCameraLogicComponent>().ResetArmLocation(true, 0.5f);
		this.IgnoreCollision();
	}

	// Token: 0x060179F8 RID: 96760 RVA: 0x006FA7CC File Offset: 0x006F89CC
	private void IgnoreCollision()
	{
		SceneItemActorComponent component = this.Chair.GetComponent<SceneItemActorComponent>();
		if (component != null && component.Entity != null)
		{
			this.IgnoreActorsCollision(component, true);
		}
		this.ActorComp.Actor.CapsuleComponent.SetCollisionResponseToChannel(ECollisionChannel.ECC_Pawn, ECollisionResponse.ECR_Ignore);
	}

	// Token: 0x060179F9 RID: 96761 RVA: 0x006FA810 File Offset: 0x006F8A10
	public void PreLeaveSitDownAction(string reason = "")
	{
		this.SetIsSitDown(false, reason);
		this.IsStandingUp = true;
		if (this.LimitStandUpFromOneSide)
		{
			this.LeaveSitDownIndex = 0;
			this.LimitStandUpFromOneSide = false;
		}
		else
		{
			this.CalculateLeaveSitDownIndex();
		}
		this.RequestSitDownAction(null, null);
		Action onLeaveSitDown = this.OnLeaveSitDown;
		if (onLeaveSitDown == null)
		{
			return;
		}
		onLeaveSitDown();
	}

	// Token: 0x060179FA RID: 96762 RVA: 0x006FA864 File Offset: 0x006F8A64
	private void CalculateLeaveSitDownIndex()
	{
		if (this.Chair == null || this.Chair.IsEnd)
		{
			this.Chair = null;
			return;
		}
		this.ActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
		{
			Mode = EMovementMode.MOVE_Walking,
			Context = "[CharacterActionComponent.CalculateLeaveSitDownIndex]"
		});
		this.TempVector.DeepCopy(this.ActorComp.InputDirectProxy);
		this.TempVector.Normalize(9.99999993922529E-09);
		IInteractSectorRange sectorRange = this.Chair.GetComponent<PawnInteractNewComponent>().GetInteractController().SectorRange;
		if (this.TempVector.DotProduct(this.ActorComp.ActorForwardProxy) > 0.800000011920929 || sectorRange == null)
		{
			this.LeaveSitDownIndex = 0;
			return;
		}
		this.TempVector.CrossProduct(this.ActorComp.ActorForwardProxy, this.TempVector2);
		if (this.TempVector2.Z >= 0.0)
		{
			if (sectorRange.Begin < -45f)
			{
				this.LeaveSitDownIndex = 1;
				return;
			}
			this.LeaveSitDownIndex = 0;
			return;
		}
		else
		{
			if (sectorRange.End > 45f)
			{
				this.LeaveSitDownIndex = 2;
				return;
			}
			this.LeaveSitDownIndex = 0;
			return;
		}
	}

	// Token: 0x060179FB RID: 96763 RVA: 0x006FA98D File Offset: 0x006F8B8D
	public void LeaveSitDownAction()
	{
		this.IsStandingUp = false;
		if (this.Chair == null)
		{
			return;
		}
		if (!this.ActorComp.IsAutonomousProxy)
		{
			return;
		}
		this.MarkForResetCollision = true;
		this.CalculateChairDir();
	}

	// Token: 0x060179FC RID: 96764 RVA: 0x006FA9BC File Offset: 0x006F8BBC
	public void CalculateChairDir()
	{
		if (this.Chair == null || this.ActorComp == null)
		{
			return;
		}
		global::Vector actorLocationProxy = this.Chair.GetComponent<SceneItemActorComponent>().ActorLocationProxy;
		global::Vector actorLocationProxy2 = this.ActorComp.ActorLocationProxy;
		global::Vector actorForwardProxy = this.ActorComp.ActorForwardProxy;
		this.MainChairDir = Vector2D.Create(actorLocationProxy2.X - actorLocationProxy.X, actorLocationProxy2.Y - actorLocationProxy.Y);
		this.MainChairDir.Normalize(9.99999993922529E-09);
		this.StandUpActorForward = Vector2D.Create(actorForwardProxy.X, actorForwardProxy.Y);
		this.StandUpActorForward.Normalize(9.99999993922529E-09);
	}

	// Token: 0x060179FD RID: 96765 RVA: 0x006FAA6C File Offset: 0x006F8C6C
	public EChairInteractDirection IsChairCanInteract(Entity sceneItem)
	{
		SceneItemActorComponent component = sceneItem.GetComponent<SceneItemActorComponent>();
		if (component == null)
		{
			return EChairInteractDirection.None;
		}
		this.ActorComp.ActorLocationProxy.Subtraction(component.ActorLocationProxy, this.TempVector);
		this.TempVector.Z = 0.0;
		this.TempVector.Normalize(9.99999993922529E-09);
		float num = (float)(Math.Acos(this.TempVector.DotProduct(component.ActorRightProxy)) * 57.295780181884766);
		this.TempVector.CrossProduct(component.ActorRightProxy, this.TempVector2);
		if (this.TempVector2.Z < 0.0)
		{
			num *= -1f;
		}
		if (num >= -50f && num <= 50f)
		{
			return EChairInteractDirection.Forward;
		}
		if (num >= 50f && num <= 140f)
		{
			return EChairInteractDirection.Left;
		}
		if (num >= -140f && num <= -50f)
		{
			return EChairInteractDirection.Right;
		}
		return EChairInteractDirection.Backward;
	}

	// Token: 0x060179FE RID: 96766 RVA: 0x006FAB59 File Offset: 0x006F8D59
	public void StartCatapult(Entity entity, ICatapult config)
	{
		this.StartCatapultInternal(entity, new OneOf<ICatapult, ISuperCatapult>?(config));
	}

	// Token: 0x060179FF RID: 96767 RVA: 0x006FAB6D File Offset: 0x006F8D6D
	public void StartCatapult(Entity entity, ISuperCatapult config)
	{
		this.StartCatapultInternal(entity, new OneOf<ICatapult, ISuperCatapult>?(config));
	}

	// Token: 0x06017A00 RID: 96768 RVA: 0x006FAB84 File Offset: 0x006F8D84
	private void StartCatapultInternal(Entity entity, [Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<ICatapult, ISuperCatapult>? config)
	{
		if (entity == null)
		{
			return;
		}
		if (config.Value.IsT1 && config.Value.AsT1.Param == null)
		{
			return;
		}
		if (config.Value.IsT2 && config.Value.AsT2.Param == null)
		{
			return;
		}
		CharacterCatapultComponent catapultComp = base.Entity.GetComponent<CharacterCatapultComponent>();
		if (catapultComp == null)
		{
			return;
		}
		if (this.SkillComp == null)
		{
			return;
		}
		ELeisureInteract? eleisureInteract = null;
		ICatapultParam param = null;
		if (config.Value.IsT1)
		{
			eleisureInteract = new ELeisureInteract?(config.Value.AsT1.Type);
			param = config.Value.AsT1.Param;
		}
		else
		{
			eleisureInteract = new ELeisureInteract?(config.Value.AsT2.Type);
			param = config.Value.AsT2.Param;
		}
		bool isSuperCatapult = eleisureInteract.Value == ELeisureInteract.SuperCatapult;
		int skillId = isSuperCatapult ? 400107 : 400102;
		this.SkillComp.BeginSkillAsync(skillId, new SkillParam
		{
			Reason = "CharacterActionComponent.StartCatapult"
		}).ContinueWith(delegate(bool result)
		{
			if (result)
			{
				Entity entity2 = this.Entity;
				if (entity2 != null && entity2.Valid)
				{
					BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
					FTransformDouble? ftransformDouble = null;
					if (component != null && component.Valid)
					{
						AActor owner = component.Owner;
						ftransformDouble = ((owner != null) ? new FTransformDouble?(owner.D_GetTransform()) : null);
					}
					else
					{
						CreatureDataComponent component2 = entity.GetComponent<CreatureDataComponent>();
						ftransformDouble = ((component2 != null) ? new FTransformDouble?(component2.D_GetTransform()) : null);
					}
					global::Vector vector = global::Vector.Create(ftransformDouble.Value.GetLocation());
					Quat quat = Quat.Create(ftransformDouble.Value.GetRotation());
					float valueOrDefault = param.Time.GetValueOrDefault(0.6f);
					float valueOrDefault2 = param.Gravity.GetValueOrDefault(1960f);
					CharacterActionComponent.TmpVector.FromConfigVector(param.P1);
					quat.RotateVector(CharacterActionComponent.TmpVector, CharacterActionComponent.TmpVector);
					CharacterActionComponent.TmpVector.AdditionEqual(vector);
					CharacterActionComponent.TmpVector2.FromConfigVector(param.P2);
					quat.RotateVector(CharacterActionComponent.TmpVector2, CharacterActionComponent.TmpVector2);
					CharacterActionComponent.TmpVector2.AdditionEqual(vector);
					catapultComp.SetConfig(valueOrDefault, vector, global::Vector.Create(CharacterActionComponent.TmpVector), global::Vector.Create(CharacterActionComponent.TmpVector2), string.Empty, valueOrDefault2, null, (component != null) ? component.ActorGravityDirectProxy : null, isSuperCatapult);
					global::Vector vector2 = global::Vector.Create(CharacterActionComponent.TmpVector);
					vector2.SubtractionEqual(vector);
					vector2.Normalize(9.99999993922529E-09);
					global::Vector inA = global::Vector.Create(0.0, 0.0, 1.0);
					double num = MathUtils.Instance.DotProduct(inA, vector2);
					this.IsUseCatapultUpAnim = (num > Math.Cos((double)(this.GetAnimChangeAngle() / 2f / 180f) * 3.141592653589793));
					this.InteractionTargetLocation.DeepCopy(CharacterActionComponent.TmpVector2);
					return;
				}
			}
		});
	}

	// Token: 0x06017A01 RID: 96769 RVA: 0x006FAD00 File Offset: 0x006F8F00
	public void EndCatapult()
	{
	}

	// Token: 0x06017A02 RID: 96770 RVA: 0x006FAD04 File Offset: 0x006F8F04
	[return: Nullable(0)]
	public UniTask<bool> StartCatapultToTargetByTime(global::Vector targetLocation, global::Vector locationOffset, float time1, int skillId = 0)
	{
		CharacterActionComponent.<StartCatapultToTargetByTime>d__96 <StartCatapultToTargetByTime>d__;
		<StartCatapultToTargetByTime>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<StartCatapultToTargetByTime>d__.<>4__this = this;
		<StartCatapultToTargetByTime>d__.targetLocation = targetLocation;
		<StartCatapultToTargetByTime>d__.locationOffset = locationOffset;
		<StartCatapultToTargetByTime>d__.time1 = time1;
		<StartCatapultToTargetByTime>d__.skillId = skillId;
		<StartCatapultToTargetByTime>d__.<>1__state = -1;
		<StartCatapultToTargetByTime>d__.<>t__builder.Start<CharacterActionComponent.<StartCatapultToTargetByTime>d__96>(ref <StartCatapultToTargetByTime>d__);
		return <StartCatapultToTargetByTime>d__.<>t__builder.Task;
	}

	// Token: 0x06017A03 RID: 96771 RVA: 0x006FAD68 File Offset: 0x006F8F68
	public UniTask StartBounce(IBounce config)
	{
		CharacterActionComponent.<StartBounce>d__97 <StartBounce>d__;
		<StartBounce>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<StartBounce>d__.<>4__this = this;
		<StartBounce>d__.config = config;
		<StartBounce>d__.<>1__state = -1;
		<StartBounce>d__.<>t__builder.Start<CharacterActionComponent.<StartBounce>d__97>(ref <StartBounce>d__);
		return <StartBounce>d__.<>t__builder.Task;
	}

	// Token: 0x06017A04 RID: 96772 RVA: 0x006FADB4 File Offset: 0x006F8FB4
	public void StartBounceFromAns(float time, float height, string curvePath)
	{
		CharacterCatapultComponent component = base.Entity.GetComponent<CharacterCatapultComponent>();
		if (component == null)
		{
			return;
		}
		Entity entity = base.Entity;
		if (entity == null || !entity.Valid)
		{
			return;
		}
		global::Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
		CharacterActionComponent.TmpVector.DeepCopy(actorLocationProxy);
		GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, CharacterActionComponent.TmpVector, (double)height);
		component.SetConfig((time != 0f) ? time : 2f, actorLocationProxy, CharacterActionComponent.TmpVector, CharacterActionComponent.TmpVector, curvePath, 0f, this.ActorComp.ActorRotationProxy, this.ActorComp.ActorGravityDirectProxy, false);
		this.IsUseCatapultUpAnim = false;
	}

	// Token: 0x06017A05 RID: 96773 RVA: 0x006FAE5C File Offset: 0x006F905C
	[return: Nullable(0)]
	public UniTask<bool> StartBounceWithHorizontalOffset(float height, global::Vector offset, float time, string curve)
	{
		CharacterActionComponent.<StartBounceWithHorizontalOffset>d__99 <StartBounceWithHorizontalOffset>d__;
		<StartBounceWithHorizontalOffset>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<StartBounceWithHorizontalOffset>d__.<>4__this = this;
		<StartBounceWithHorizontalOffset>d__.height = height;
		<StartBounceWithHorizontalOffset>d__.offset = offset;
		<StartBounceWithHorizontalOffset>d__.time = time;
		<StartBounceWithHorizontalOffset>d__.curve = curve;
		<StartBounceWithHorizontalOffset>d__.<>1__state = -1;
		<StartBounceWithHorizontalOffset>d__.<>t__builder.Start<CharacterActionComponent.<StartBounceWithHorizontalOffset>d__99>(ref <StartBounceWithHorizontalOffset>d__);
		return <StartBounceWithHorizontalOffset>d__.<>t__builder.Task;
	}

	// Token: 0x06017A06 RID: 96774 RVA: 0x006FAEC0 File Offset: 0x006F90C0
	public void EndBounce()
	{
		if (this.SkillComp == null)
		{
			return;
		}
		global::Skill currentSkill = this.SkillComp.CurrentSkill;
		if (currentSkill != null && currentSkill.SkillId != 400104)
		{
			return;
		}
		CharacterMoveComponent component = base.Entity.GetComponent<CharacterMoveComponent>();
		component.SetForceSpeed(global::Vector.ZeroVectorProxy);
		CharacterActorComponent actorComp = component.ActorComp;
		if (actorComp == null)
		{
			return;
		}
		actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
		{
			Mode = EMovementMode.MOVE_Falling,
			Context = "[CharacterActionComponent.EndBounce]"
		});
	}

	// Token: 0x06017A07 RID: 96775 RVA: 0x006FAF34 File Offset: 0x006F9134
	public global::Vector GetInteractionTargetLocation()
	{
		return this.InteractionTargetLocation;
	}

	// Token: 0x06017A08 RID: 96776 RVA: 0x006FAF3C File Offset: 0x006F913C
	private void OnSuperJumpStateChanged(int tagId, bool tagExist)
	{
		if (!tagExist)
		{
			this.MoveComp.JumpUpRate = 1f;
		}
	}

	// Token: 0x17002492 RID: 9362
	// (get) Token: 0x06017A09 RID: 96777 RVA: 0x006FAF54 File Offset: 0x006F9154
	public UTraceLineElement ExecutionTrace
	{
		get
		{
			if (this.ExecutionVisibleTrace == null)
			{
				this.ExecutionVisibleTrace = new UTraceLineElement();
				this.ExecutionVisibleTrace.WorldContextObject = this.ActorComp.Owner;
				this.ExecutionVisibleTrace.bIgnoreSelf = true;
				this.ExecutionVisibleTrace.bIsSingle = true;
				this.ExecutionVisibleTrace.SetTraceTypeQuery(KuroTraceTypeQuery.Visible);
				this.ExecutionVisibleTrace.SetDrawDebugTrace(EDrawDebugTrace.None);
			}
			return this.ExecutionVisibleTrace;
		}
	}

	// Token: 0x06017A0A RID: 96778 RVA: 0x006FAFC4 File Offset: 0x006F91C4
	public void PlayCustomCommonSkill(int inSkillId)
	{
		CharacterSkillComponent skillComp = this.SkillComp;
		if (skillComp == null || !skillComp.CheckIsLoaded())
		{
			return;
		}
		this.SkillComp.BeginSkillAsync(inSkillId, new SkillParam
		{
			Reason = "CharacterActionComponent.PlayCustomCommonSkill"
		});
	}

	// Token: 0x06017A0B RID: 96779 RVA: 0x006FAFFB File Offset: 0x006F91FB
	private float GetAnimChangeAngle()
	{
		if (this.AnimChangeAngle == null)
		{
			this.AnimChangeAngle = ConfigCommonParamById.GetFloatConfig("CatapultAnimAngle");
		}
		return this.AnimChangeAngle.Value;
	}

	// Token: 0x06017A0C RID: 96780 RVA: 0x006FB028 File Offset: 0x006F9228
	public void PlayFaithJumpSkill()
	{
		CharacterSkillComponent skillComp = this.SkillComp;
		if (skillComp == null || !skillComp.CheckIsLoaded())
		{
			return;
		}
		if (this.SkillComp.HasAbility(1502103))
		{
			this.SkillComp.BeginSkill(1502103, new SkillParam
			{
				Reason = "CharacterActionComponent.PlayFaithJumpSkill"
			});
			return;
		}
		if (this.SkillComp.HasAbility(1501103))
		{
			this.SkillComp.BeginSkill(1501103, new SkillParam
			{
				Reason = "CharacterActionComponent.PlayFaithJumpSkill"
			});
			return;
		}
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.Interaction;
		ELogAuthor author = ELogAuthor.CWZ;
		string message = "角色没有信仰之跃技能";
		string item = "Role";
		CharacterActorComponent actorComp = this.ActorComp;
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06017A0D RID: 96781 RVA: 0x006FB108 File Offset: 0x006F9308
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterActionComponent characterActionComponent = (CharacterActionComponent)componentTemplate;
		if (characterActionComponent.StateComp == null)
		{
			this.StateComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StateComp), "StateComp"))
		{
			return false;
		}
		if (characterActionComponent.TagComp == null)
		{
			this.TagComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
		{
			return false;
		}
		if (characterActionComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (characterActionComponent.MoveComp == null)
		{
			this.MoveComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
		{
			return false;
		}
		if (characterActionComponent.SkillComp == null)
		{
			this.SkillComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SkillComp), "SkillComp"))
		{
			return false;
		}
		this.OriginCapsuleHalfHeight = characterActionComponent.OriginCapsuleHalfHeight;
		this.OriginCapsuleRadius = characterActionComponent.OriginCapsuleRadius;
		this.IsSitDownInternal = characterActionComponent.IsSitDownInternal;
		this.SummonSitDownLockedInternal = characterActionComponent.SummonSitDownLockedInternal;
		this.IsStandingUp = characterActionComponent.IsStandingUp;
		if (characterActionComponent.ChairInternal == null)
		{
			this.ChairInternal = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ChairInternal), "ChairInternal"))
		{
			return false;
		}
		this.ChairNeedSetMorph = characterActionComponent.ChairNeedSetMorph;
		this.SitDownTypeIndex = characterActionComponent.SitDownTypeIndex;
		this.EnterSitDownIndex = characterActionComponent.EnterSitDownIndex;
		this.LeaveSitDownIndex = characterActionComponent.LeaveSitDownIndex;
		this.IsUseCatapultUpAnim = characterActionComponent.IsUseCatapultUpAnim;
		this.AnimChangeAngle = characterActionComponent.AnimChangeAngle;
		if (characterActionComponent.ExecutionVisibleTrace == null)
		{
			this.ExecutionVisibleTrace = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ExecutionVisibleTrace), "ExecutionVisibleTrace"))
		{
			return false;
		}
		if (characterActionComponent.TempVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector), "TempVector"))
		{
			return false;
		}
		if (characterActionComponent.TempVector2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector2), "TempVector2"))
		{
			return false;
		}
		if (characterActionComponent.TempRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempRotator), "TempRotator"))
		{
			return false;
		}
		if (characterActionComponent.OnSitDownEndChangedTask == null)
		{
			this.OnSitDownEndChangedTask = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnSitDownEndChangedTask), "OnSitDownEndChangedTask"))
		{
			return false;
		}
		if (characterActionComponent.OnSuperJumpTask == null)
		{
			this.OnSuperJumpTask = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnSuperJumpTask), "OnSuperJumpTask"))
		{
			return false;
		}
		if (characterActionComponent.TagListeners != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagListeners), "TagListeners"))
		{
			return false;
		}
		this.MarkForResetCollision = characterActionComponent.MarkForResetCollision;
		if (characterActionComponent.MainChairDir == null)
		{
			this.MainChairDir = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MainChairDir), "MainChairDir"))
		{
			return false;
		}
		if (characterActionComponent.StandUpActorForward == null)
		{
			this.StandUpActorForward = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StandUpActorForward), "StandUpActorForward"))
		{
			return false;
		}
		this.IsInit = characterActionComponent.IsInit;
		if (characterActionComponent.Giant == null)
		{
			this.Giant = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Giant), "Giant"))
		{
			return false;
		}
		this.IsRotatingBeforeManipulate = characterActionComponent.IsRotatingBeforeManipulate;
		if (characterActionComponent.InteractionTargetLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.InteractionTargetLocation), "InteractionTargetLocation"))
		{
			return false;
		}
		if (characterActionComponent.OnLeaveSitDown == null)
		{
			this.OnLeaveSitDown = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnLeaveSitDown), "OnLeaveSitDown"))
		{
			return false;
		}
		this.LimitStandUpFromOneSide = characterActionComponent.LimitStandUpFromOneSide;
		return true;
	}

	// Token: 0x17002493 RID: 9363
	// (get) Token: 0x06017A0E RID: 96782 RVA: 0x006FB4B5 File Offset: 0x006F96B5
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002494 RID: 9364
	// (get) Token: 0x06017A0F RID: 96783 RVA: 0x006FB4B8 File Offset: 0x006F96B8
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002495 RID: 9365
	// (get) Token: 0x06017A10 RID: 96784 RVA: 0x006FB4BB File Offset: 0x006F96BB
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002496 RID: 9366
	// (get) Token: 0x06017A11 RID: 96785 RVA: 0x006FB4BE File Offset: 0x006F96BE
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400C8F1 RID: 51441
	private const int FOURTY_FIVE = 45;

	// Token: 0x0400C8F2 RID: 51442
	private const float ZERO_EIGHT = 0.8f;

	// Token: 0x0400C8F3 RID: 51443
	private const int FIVETY = 50;

	// Token: 0x0400C8F4 RID: 51444
	private const int ONE_HUNDRED_FOURTY = 140;

	// Token: 0x0400C8F5 RID: 51445
	private const int COLLISION_RADIUS_IN = 15;

	// Token: 0x0400C8F6 RID: 51446
	private const int COLLISION_RADIUS_OUT = 50;

	// Token: 0x0400C8F7 RID: 51447
	private const int COLLISION_RESET_ANGLE = 91;

	// Token: 0x0400C8F8 RID: 51448
	private const float DEFAULT_CATAPULT_TIME = 0.6f;

	// Token: 0x0400C8F9 RID: 51449
	private const int DEFAULT_CATAPULT_GRAVITY = 1960;

	// Token: 0x0400C8FA RID: 51450
	private const int CATAPULT_SKILL_ID = 400102;

	// Token: 0x0400C8FB RID: 51451
	private const int SUPER_CATAPULT_SKILL_ID = 400107;

	// Token: 0x0400C8FC RID: 51452
	private const int BOUNCE_SKILL_ID = 400104;

	// Token: 0x0400C8FD RID: 51453
	private const int FAITH_JUMP_SKILL_MALE = 1501103;

	// Token: 0x0400C8FE RID: 51454
	private const int FAITH_JUMP_SKILL_FEMALE = 1502103;

	// Token: 0x0400C8FF RID: 51455
	public const int LEAVE_VEHICLE_BOUNCE_SKILL_ID = 100035;

	// Token: 0x0400C900 RID: 51456
	private const int MAX_ANIM_STATE_CHANGE_COUNT = 600;

	// Token: 0x0400C901 RID: 51457
	private const int PI_DEG_DOUBLE = 360;

	// Token: 0x0400C902 RID: 51458
	[Nullable(2)]
	private CharacterUnifiedStateComponent StateComp;

	// Token: 0x0400C903 RID: 51459
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400C904 RID: 51460
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400C905 RID: 51461
	[Nullable(2)]
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400C906 RID: 51462
	[Nullable(2)]
	private CharacterSkillComponent SkillComp;

	// Token: 0x0400C907 RID: 51463
	public float OriginCapsuleHalfHeight;

	// Token: 0x0400C908 RID: 51464
	public float OriginCapsuleRadius;

	// Token: 0x0400C909 RID: 51465
	public bool IsSitDownInternal;

	// Token: 0x0400C90A RID: 51466
	private bool SummonSitDownLockedInternal;

	// Token: 0x0400C90B RID: 51467
	public bool IsStandingUp;

	// Token: 0x0400C90C RID: 51468
	[Nullable(2)]
	private Entity ChairInternal;

	// Token: 0x0400C90D RID: 51469
	private bool ChairNeedSetMorph;

	// Token: 0x0400C90E RID: 51470
	public int SitDownTypeIndex;

	// Token: 0x0400C90F RID: 51471
	public int EnterSitDownIndex;

	// Token: 0x0400C910 RID: 51472
	public int LeaveSitDownIndex;

	// Token: 0x0400C911 RID: 51473
	public bool IsUseCatapultUpAnim;

	// Token: 0x0400C912 RID: 51474
	private float? AnimChangeAngle;

	// Token: 0x0400C913 RID: 51475
	[Nullable(2)]
	private UTraceLineElement ExecutionVisibleTrace;

	// Token: 0x0400C914 RID: 51476
	private readonly global::Vector TempVector = global::Vector.Create();

	// Token: 0x0400C915 RID: 51477
	private readonly global::Vector TempVector2 = global::Vector.Create();

	// Token: 0x0400C916 RID: 51478
	private readonly global::Rotator TempRotator = global::Rotator.Create();

	// Token: 0x0400C917 RID: 51479
	[Nullable(2)]
	private ITagTask OnSitDownEndChangedTask;

	// Token: 0x0400C918 RID: 51480
	[Nullable(2)]
	private ITagTask OnSuperJumpTask;

	// Token: 0x0400C919 RID: 51481
	private readonly List<ITagTask> TagListeners = new List<ITagTask>();

	// Token: 0x0400C91A RID: 51482
	private bool MarkForResetCollision;

	// Token: 0x0400C91B RID: 51483
	[Nullable(2)]
	private Vector2D MainChairDir;

	// Token: 0x0400C91C RID: 51484
	[Nullable(2)]
	private Vector2D StandUpActorForward;

	// Token: 0x0400C91D RID: 51485
	private bool IsInit;

	// Token: 0x0400C91E RID: 51486
	[Nullable(2)]
	public AActor Giant;

	// Token: 0x0400C91F RID: 51487
	private bool IsRotatingBeforeManipulate;

	// Token: 0x0400C920 RID: 51488
	private readonly global::Vector InteractionTargetLocation = global::Vector.Create();

	// Token: 0x0400C921 RID: 51489
	[Nullable(2)]
	public Action OnLeaveSitDown;

	// Token: 0x0400C922 RID: 51490
	[StaticVariableRuleIgnore]
	private static readonly int[] DisableTags = new int[]
	{
		GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"],
		GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击"],
		GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"],
		GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中.全身动作"]
	};

	// Token: 0x0400C923 RID: 51491
	private bool LimitStandUpFromOneSide;

	// Token: 0x0400C924 RID: 51492
	[StaticVariableRuleIgnore]
	private static readonly global::Vector TmpVector = global::Vector.Create();

	// Token: 0x0400C925 RID: 51493
	[StaticVariableRuleIgnore]
	private static readonly global::Vector TmpVector2 = global::Vector.Create();

	// Token: 0x0400C926 RID: 51494
	[StaticVariableRuleIgnore]
	private static readonly CatapultToTargetResult CatapultResult = new CatapultToTargetResult();
}
