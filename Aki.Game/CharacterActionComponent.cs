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

// Token: 0x02003006 RID: 12294
[NullableContext(1)]
[Nullable(0)]
public class CharacterActionComponent : EntityComponent, IComponentDependency
{
	// Token: 0x170023C6 RID: 9158
	// (get) Token: 0x0601A09A RID: 106650 RVA: 0x006D1761 File Offset: 0x006CF961
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Type[] Dependencies
	{
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
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

	// Token: 0x170023C7 RID: 9159
	// (get) Token: 0x0601A09B RID: 106651 RVA: 0x006D1790 File Offset: 0x006CF990
	public bool IsSitDown
	{
		get
		{
			return this.IsSitDownInternal;
		}
	}

	// Token: 0x170023C8 RID: 9160
	// (get) Token: 0x0601A09C RID: 106652 RVA: 0x006D1798 File Offset: 0x006CF998
	public bool IsSummonSitDownLocked
	{
		get
		{
			return this.SummonSitDownLockedInternal;
		}
	}

	// Token: 0x0601A09D RID: 106653 RVA: 0x006D17A0 File Offset: 0x006CF9A0
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

	// Token: 0x0601A09E RID: 106654 RVA: 0x006D17E4 File Offset: 0x006CF9E4
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

	// Token: 0x0601A09F RID: 106655 RVA: 0x006D1828 File Offset: 0x006CFA28
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

	// Token: 0x170023C9 RID: 9161
	// (get) Token: 0x0601A0A0 RID: 106656 RVA: 0x006D1968 File Offset: 0x006CFB68
	// (set) Token: 0x0601A0A1 RID: 106657 RVA: 0x006D1970 File Offset: 0x006CFB70
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

	// Token: 0x0601A0A2 RID: 106658 RVA: 0x006D1A57 File Offset: 0x006CFC57
	private void OnRemoveChair(ERemoveEntityType removeType, EntityHandle handle)
	{
		this.Chair = null;
	}

	// Token: 0x0601A0A3 RID: 106659 RVA: 0x006D1A60 File Offset: 0x006CFC60
	private void OnSitDownEndChanged(int tagId, bool tagExist)
	{
		if (!tagExist)
		{
			this.LeaveSitDownAction();
		}
	}

	// Token: 0x0601A0A4 RID: 106660 RVA: 0x006D1A6C File Offset: 0x006CFC6C
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

	// Token: 0x0601A0A5 RID: 106661 RVA: 0x006D1AB0 File Offset: 0x006CFCB0
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

	// Token: 0x0601A0A6 RID: 106662 RVA: 0x006D1BA4 File Offset: 0x006CFDA4
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

	// Token: 0x0601A0A7 RID: 106663 RVA: 0x006D1C8D File Offset: 0x006CFE8D
	private void TeleportStart(bool b)
	{
		if (this.IsSitDown)
		{
			this.PreLeaveSitDownAction("TeleportStart");
		}
	}

	// Token: 0x0601A0A8 RID: 106664 RVA: 0x006D1CA2 File Offset: 0x006CFEA2
	private void PlotNetworkStart(PlotInfo plotInfo)
	{
		if (this.IsSitDown && plotInfo.PlotLevel != EPlotLevel.LevelD && plotInfo.PlotLevel != EPlotLevel.LevelE && !plotInfo.KeepMainRolePose)
		{
			this.PreLeaveSitDownAction("PlotNetworkStart");
		}
	}

	// Token: 0x0601A0A9 RID: 106665 RVA: 0x006D1CD4 File Offset: 0x006CFED4
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

	// Token: 0x0601A0AA RID: 106666 RVA: 0x006D1DAC File Offset: 0x006CFFAC
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

	// Token: 0x0601A0AB RID: 106667 RVA: 0x006D1FFC File Offset: 0x006D01FC
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

	// Token: 0x0601A0AC RID: 106668 RVA: 0x006D20EC File Offset: 0x006D02EC
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

	// Token: 0x0601A0AD RID: 106669 RVA: 0x006D2146 File Offset: 0x006D0346
	public bool GetSitDownState()
	{
		return this.IsSitDown;
	}

	// Token: 0x0601A0AE RID: 106670 RVA: 0x006D2150 File Offset: 0x006D0350
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

	// Token: 0x0601A0AF RID: 106671 RVA: 0x006D21A4 File Offset: 0x006D03A4
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

	// Token: 0x0601A0B0 RID: 106672 RVA: 0x006D21F8 File Offset: 0x006D03F8
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

	// Token: 0x0601A0B1 RID: 106673 RVA: 0x006D23B8 File Offset: 0x006D05B8
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

	// Token: 0x0601A0B2 RID: 106674 RVA: 0x006D2463 File Offset: 0x006D0663
	private void RegisterSitSpecialAnimMachineState()
	{
		this.RequestSitDownAction(null, null);
	}

	// Token: 0x0601A0B3 RID: 106675 RVA: 0x006D2470 File Offset: 0x006D0670
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

	// Token: 0x0601A0B4 RID: 106676 RVA: 0x006D2518 File Offset: 0x006D0718
	public void OnResponseSit(bool isSitDown, int errorCode)
	{
		if (errorCode != 0)
		{
			this.SetIsSitDown(!isSitDown, "服务器返回错误");
		}
	}

	// Token: 0x0601A0B5 RID: 106677 RVA: 0x006D252C File Offset: 0x006D072C
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

	// Token: 0x0601A0B6 RID: 106678 RVA: 0x006D2630 File Offset: 0x006D0830
	private void IgnoreCollision()
	{
		SceneItemActorComponent component = this.Chair.GetComponent<SceneItemActorComponent>();
		if (component != null && component.Entity != null)
		{
			this.IgnoreActorsCollision(component, true);
		}
		this.ActorComp.Actor.CapsuleComponent.SetCollisionResponseToChannel(ECollisionChannel.ECC_Pawn, ECollisionResponse.ECR_Ignore);
	}

	// Token: 0x0601A0B7 RID: 106679 RVA: 0x006D2674 File Offset: 0x006D0874
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

	// Token: 0x0601A0B8 RID: 106680 RVA: 0x006D26C8 File Offset: 0x006D08C8
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

	// Token: 0x0601A0B9 RID: 106681 RVA: 0x006D27F1 File Offset: 0x006D09F1
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

	// Token: 0x0601A0BA RID: 106682 RVA: 0x006D2820 File Offset: 0x006D0A20
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

	// Token: 0x0601A0BB RID: 106683 RVA: 0x006D28D0 File Offset: 0x006D0AD0
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

	// Token: 0x0601A0BC RID: 106684 RVA: 0x006D29BD File Offset: 0x006D0BBD
	public void StartCatapult(Entity entity, ICatapult config)
	{
		this.StartCatapultInternal(entity, new OneOf<ICatapult, ISuperCatapult>?(config));
	}

	// Token: 0x0601A0BD RID: 106685 RVA: 0x006D29D1 File Offset: 0x006D0BD1
	public void StartCatapult(Entity entity, ISuperCatapult config)
	{
		this.StartCatapultInternal(entity, new OneOf<ICatapult, ISuperCatapult>?(config));
	}

	// Token: 0x0601A0BE RID: 106686 RVA: 0x006D29E8 File Offset: 0x006D0BE8
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

	// Token: 0x0601A0BF RID: 106687 RVA: 0x006D2B64 File Offset: 0x006D0D64
	public void EndCatapult()
	{
	}

	// Token: 0x0601A0C0 RID: 106688 RVA: 0x006D2B68 File Offset: 0x006D0D68
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

	// Token: 0x0601A0C1 RID: 106689 RVA: 0x006D2BCC File Offset: 0x006D0DCC
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

	// Token: 0x0601A0C2 RID: 106690 RVA: 0x006D2C18 File Offset: 0x006D0E18
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

	// Token: 0x0601A0C3 RID: 106691 RVA: 0x006D2CC0 File Offset: 0x006D0EC0
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

	// Token: 0x0601A0C4 RID: 106692 RVA: 0x006D2D24 File Offset: 0x006D0F24
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

	// Token: 0x0601A0C5 RID: 106693 RVA: 0x006D2D98 File Offset: 0x006D0F98
	public global::Vector GetInteractionTargetLocation()
	{
		return this.InteractionTargetLocation;
	}

	// Token: 0x0601A0C6 RID: 106694 RVA: 0x006D2DA0 File Offset: 0x006D0FA0
	private void OnSuperJumpStateChanged(int tagId, bool tagExist)
	{
		if (!tagExist)
		{
			this.MoveComp.JumpUpRate = 1f;
		}
	}

	// Token: 0x170023CA RID: 9162
	// (get) Token: 0x0601A0C7 RID: 106695 RVA: 0x006D2DB8 File Offset: 0x006D0FB8
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

	// Token: 0x0601A0C8 RID: 106696 RVA: 0x006D2E28 File Offset: 0x006D1028
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

	// Token: 0x0601A0C9 RID: 106697 RVA: 0x006D2E5F File Offset: 0x006D105F
	private float GetAnimChangeAngle()
	{
		if (this.AnimChangeAngle == null)
		{
			this.AnimChangeAngle = ConfigCommonParamById.GetFloatConfig("CatapultAnimAngle");
		}
		return this.AnimChangeAngle.Value;
	}

	// Token: 0x0601A0CA RID: 106698 RVA: 0x006D2E8C File Offset: 0x006D108C
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

	// Token: 0x0601A0CB RID: 106699 RVA: 0x006D2F6C File Offset: 0x006D116C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterActionComponent characterActionComponent = (CharacterActionComponent)componentTemplate;
		if (base.CanResetComponentProperty("StateComp"))
		{
			if (characterActionComponent.StateComp == null)
			{
				this.StateComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterUnifiedStateComponent>(this.StateComp), "StateComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagComp"))
		{
			if (characterActionComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (characterActionComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MoveComp"))
		{
			if (characterActionComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterMoveComponent>(this.MoveComp), "MoveComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SkillComp"))
		{
			if (characterActionComponent.SkillComp == null)
			{
				this.SkillComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterSkillComponent>(this.SkillComp), "SkillComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("OriginCapsuleHalfHeight"))
		{
			this.OriginCapsuleHalfHeight = characterActionComponent.OriginCapsuleHalfHeight;
		}
		if (base.CanResetComponentProperty("OriginCapsuleRadius"))
		{
			this.OriginCapsuleRadius = characterActionComponent.OriginCapsuleRadius;
		}
		if (base.CanResetComponentProperty("IsSitDownInternal"))
		{
			this.IsSitDownInternal = characterActionComponent.IsSitDownInternal;
		}
		if (base.CanResetComponentProperty("SummonSitDownLockedInternal"))
		{
			this.SummonSitDownLockedInternal = characterActionComponent.SummonSitDownLockedInternal;
		}
		if (base.CanResetComponentProperty("IsStandingUp"))
		{
			this.IsStandingUp = characterActionComponent.IsStandingUp;
		}
		if (base.CanResetComponentProperty("ChairInternal"))
		{
			if (characterActionComponent.ChairInternal == null)
			{
				this.ChairInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Entity>(this.ChairInternal), "ChairInternal"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ChairNeedSetMorph"))
		{
			this.ChairNeedSetMorph = characterActionComponent.ChairNeedSetMorph;
		}
		if (base.CanResetComponentProperty("SitDownTypeIndex"))
		{
			this.SitDownTypeIndex = characterActionComponent.SitDownTypeIndex;
		}
		if (base.CanResetComponentProperty("EnterSitDownIndex"))
		{
			this.EnterSitDownIndex = characterActionComponent.EnterSitDownIndex;
		}
		if (base.CanResetComponentProperty("LeaveSitDownIndex"))
		{
			this.LeaveSitDownIndex = characterActionComponent.LeaveSitDownIndex;
		}
		if (base.CanResetComponentProperty("IsUseCatapultUpAnim"))
		{
			this.IsUseCatapultUpAnim = characterActionComponent.IsUseCatapultUpAnim;
		}
		if (base.CanResetComponentProperty("AnimChangeAngle"))
		{
			this.AnimChangeAngle = characterActionComponent.AnimChangeAngle;
		}
		if (base.CanResetComponentProperty("ExecutionVisibleTrace"))
		{
			if (characterActionComponent.ExecutionVisibleTrace == null)
			{
				this.ExecutionVisibleTrace = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UTraceLineElement>(this.ExecutionVisibleTrace), "ExecutionVisibleTrace"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TempVector") && characterActionComponent.TempVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TempVector), "TempVector"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TempVector2") && characterActionComponent.TempVector2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TempVector2), "TempVector2"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TempRotator") && characterActionComponent.TempRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Rotator>(this.TempRotator), "TempRotator"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("OnSitDownEndChangedTask"))
		{
			if (characterActionComponent.OnSitDownEndChangedTask == null)
			{
				this.OnSitDownEndChangedTask = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.OnSitDownEndChangedTask), "OnSitDownEndChangedTask"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("OnSuperJumpTask"))
		{
			if (characterActionComponent.OnSuperJumpTask == null)
			{
				this.OnSuperJumpTask = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.OnSuperJumpTask), "OnSuperJumpTask"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagListeners") && characterActionComponent.TagListeners != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<ITagTask>>(this.TagListeners), "TagListeners"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("MarkForResetCollision"))
		{
			this.MarkForResetCollision = characterActionComponent.MarkForResetCollision;
		}
		if (base.CanResetComponentProperty("MainChairDir"))
		{
			if (characterActionComponent.MainChairDir == null)
			{
				this.MainChairDir = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector2D>(this.MainChairDir), "MainChairDir"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("StandUpActorForward"))
		{
			if (characterActionComponent.StandUpActorForward == null)
			{
				this.StandUpActorForward = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector2D>(this.StandUpActorForward), "StandUpActorForward"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IsInit"))
		{
			this.IsInit = characterActionComponent.IsInit;
		}
		if (base.CanResetComponentProperty("Giant"))
		{
			if (characterActionComponent.Giant == null)
			{
				this.Giant = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AActor>(this.Giant), "Giant"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IsRotatingBeforeManipulate"))
		{
			this.IsRotatingBeforeManipulate = characterActionComponent.IsRotatingBeforeManipulate;
		}
		if (base.CanResetComponentProperty("InteractionTargetLocation") && characterActionComponent.InteractionTargetLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.InteractionTargetLocation), "InteractionTargetLocation"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("OnLeaveSitDown"))
		{
			if (characterActionComponent.OnLeaveSitDown == null)
			{
				this.OnLeaveSitDown = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Action>(this.OnLeaveSitDown), "OnLeaveSitDown"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("LimitStandUpFromOneSide"))
		{
			this.LimitStandUpFromOneSide = characterActionComponent.LimitStandUpFromOneSide;
		}
		return true;
	}

	// Token: 0x0400C524 RID: 50468
	private const int FOURTY_FIVE = 45;

	// Token: 0x0400C525 RID: 50469
	private const float ZERO_EIGHT = 0.8f;

	// Token: 0x0400C526 RID: 50470
	private const int FIVETY = 50;

	// Token: 0x0400C527 RID: 50471
	private const int ONE_HUNDRED_FOURTY = 140;

	// Token: 0x0400C528 RID: 50472
	private const int COLLISION_RADIUS_IN = 15;

	// Token: 0x0400C529 RID: 50473
	private const int COLLISION_RADIUS_OUT = 50;

	// Token: 0x0400C52A RID: 50474
	private const int COLLISION_RESET_ANGLE = 91;

	// Token: 0x0400C52B RID: 50475
	private const float DEFAULT_CATAPULT_TIME = 0.6f;

	// Token: 0x0400C52C RID: 50476
	private const int DEFAULT_CATAPULT_GRAVITY = 1960;

	// Token: 0x0400C52D RID: 50477
	private const int CATAPULT_SKILL_ID = 400102;

	// Token: 0x0400C52E RID: 50478
	private const int SUPER_CATAPULT_SKILL_ID = 400107;

	// Token: 0x0400C52F RID: 50479
	private const int BOUNCE_SKILL_ID = 400104;

	// Token: 0x0400C530 RID: 50480
	private const int FAITH_JUMP_SKILL_MALE = 1501103;

	// Token: 0x0400C531 RID: 50481
	private const int FAITH_JUMP_SKILL_FEMALE = 1502103;

	// Token: 0x0400C532 RID: 50482
	public const int LEAVE_VEHICLE_BOUNCE_SKILL_ID = 100035;

	// Token: 0x0400C533 RID: 50483
	private const int MAX_ANIM_STATE_CHANGE_COUNT = 600;

	// Token: 0x0400C534 RID: 50484
	private const int PI_DEG_DOUBLE = 360;

	// Token: 0x0400C535 RID: 50485
	[Nullable(2)]
	private CharacterUnifiedStateComponent StateComp;

	// Token: 0x0400C536 RID: 50486
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400C537 RID: 50487
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400C538 RID: 50488
	[Nullable(2)]
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400C539 RID: 50489
	[Nullable(2)]
	private CharacterSkillComponent SkillComp;

	// Token: 0x0400C53A RID: 50490
	public float OriginCapsuleHalfHeight;

	// Token: 0x0400C53B RID: 50491
	public float OriginCapsuleRadius;

	// Token: 0x0400C53C RID: 50492
	public bool IsSitDownInternal;

	// Token: 0x0400C53D RID: 50493
	private bool SummonSitDownLockedInternal;

	// Token: 0x0400C53E RID: 50494
	public bool IsStandingUp;

	// Token: 0x0400C53F RID: 50495
	[Nullable(2)]
	private Entity ChairInternal;

	// Token: 0x0400C540 RID: 50496
	private bool ChairNeedSetMorph;

	// Token: 0x0400C541 RID: 50497
	public int SitDownTypeIndex;

	// Token: 0x0400C542 RID: 50498
	public int EnterSitDownIndex;

	// Token: 0x0400C543 RID: 50499
	public int LeaveSitDownIndex;

	// Token: 0x0400C544 RID: 50500
	public bool IsUseCatapultUpAnim;

	// Token: 0x0400C545 RID: 50501
	private float? AnimChangeAngle;

	// Token: 0x0400C546 RID: 50502
	[Nullable(2)]
	private UTraceLineElement ExecutionVisibleTrace;

	// Token: 0x0400C547 RID: 50503
	private readonly global::Vector TempVector = global::Vector.Create();

	// Token: 0x0400C548 RID: 50504
	private readonly global::Vector TempVector2 = global::Vector.Create();

	// Token: 0x0400C549 RID: 50505
	private readonly global::Rotator TempRotator = global::Rotator.Create();

	// Token: 0x0400C54A RID: 50506
	[Nullable(2)]
	private ITagTask OnSitDownEndChangedTask;

	// Token: 0x0400C54B RID: 50507
	[Nullable(2)]
	private ITagTask OnSuperJumpTask;

	// Token: 0x0400C54C RID: 50508
	private readonly List<ITagTask> TagListeners = new List<ITagTask>();

	// Token: 0x0400C54D RID: 50509
	private bool MarkForResetCollision;

	// Token: 0x0400C54E RID: 50510
	[Nullable(2)]
	private Vector2D MainChairDir;

	// Token: 0x0400C54F RID: 50511
	[Nullable(2)]
	private Vector2D StandUpActorForward;

	// Token: 0x0400C550 RID: 50512
	private bool IsInit;

	// Token: 0x0400C551 RID: 50513
	[Nullable(2)]
	public AActor Giant;

	// Token: 0x0400C552 RID: 50514
	private bool IsRotatingBeforeManipulate;

	// Token: 0x0400C553 RID: 50515
	private readonly global::Vector InteractionTargetLocation = global::Vector.Create();

	// Token: 0x0400C554 RID: 50516
	[Nullable(2)]
	public Action OnLeaveSitDown;

	// Token: 0x0400C555 RID: 50517
	[StaticVariableRuleIgnore]
	private static readonly int[] DisableTags = new int[]
	{
		GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"],
		GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击"],
		GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"],
		GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中.全身动作"]
	};

	// Token: 0x0400C556 RID: 50518
	private bool LimitStandUpFromOneSide;

	// Token: 0x0400C557 RID: 50519
	[StaticVariableRuleIgnore]
	private static readonly global::Vector TmpVector = global::Vector.Create();

	// Token: 0x0400C558 RID: 50520
	[StaticVariableRuleIgnore]
	private static readonly global::Vector TmpVector2 = global::Vector.Create();

	// Token: 0x0400C559 RID: 50521
	[StaticVariableRuleIgnore]
	private static readonly CatapultToTargetResult CatapultResult = new CatapultToTargetResult();
}
