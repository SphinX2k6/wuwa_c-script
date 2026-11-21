using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Role.Common.Data.Structure;
using AkiClient.Game.Aki.Data.Level.KeepFollowing;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.LevelGamePlay;
using NpcSitOnChair;
using UnrealEngine;

// Token: 0x020025BD RID: 9661
[NullableContext(2)]
[Nullable(0)]
public class CharacterHoldingHandsComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x06017FE0 RID: 98272 RVA: 0x0072ED70 File Offset: 0x0072CF70
	static CharacterHoldingHandsComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterHoldingHandsComponent.CreateStaticDefaultValue), new Action(CharacterHoldingHandsComponent.ResetStaticDefaultValue));
	}

	// Token: 0x06017FE1 RID: 98273 RVA: 0x0072ED90 File Offset: 0x0072CF90
	public static void CreateStaticDefaultValue()
	{
		CharacterHoldingHandsComponent.CommonParams = null;
		CharacterHoldingHandsComponent.ListenSkillIds = new HashSet<long>();
		CharacterHoldingHandsComponent.ListenSkillIds.Add(401101L);
		CharacterHoldingHandsComponent.ListenSkillIds.Add(401102L);
		CharacterHoldingHandsComponent.DisableInputTagIds = new List<int>();
		CharacterHoldingHandsComponent.DisableInputTagIds.Add(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止攻击"]);
		CharacterHoldingHandsComponent.DisableInputTagIds.Add(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止技能"]);
		CharacterHoldingHandsComponent.DisableInputTagIds.Add(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止大招"]);
		CharacterHoldingHandsComponent.DisableInputTagIds.Add(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止闪避"]);
		CharacterHoldingHandsComponent.DisableInputTagIds.Add(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止幻象1"]);
		CharacterHoldingHandsComponent.DisableInputTagIds.Add(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止跳跃"]);
		CharacterHoldingHandsComponent.DisableInputTagIds.Add(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止攀爬"]);
		CharacterHoldingHandsComponent.DisableInputTagIds.Add(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止幻象2"]);
		CharacterHoldingHandsComponent.DisableInputTagIds.Add(GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.不能切人"]);
	}

	// Token: 0x06017FE2 RID: 98274 RVA: 0x0072EEBA File Offset: 0x0072D0BA
	public static void ResetStaticDefaultValue()
	{
		CharacterHoldingHandsComponent.CommonParams = null;
		CharacterHoldingHandsComponent.ListenSkillIds = null;
		CharacterHoldingHandsComponent.DisableInputTagIds = null;
	}

	// Token: 0x1700257C RID: 9596
	// (get) Token: 0x06017FE3 RID: 98275 RVA: 0x0072EECE File Offset: 0x0072D0CE
	[Nullable(1)]
	public HoldingHandsParams Params
	{
		[NullableContext(1)]
		get
		{
			if (CharacterHoldingHandsComponent.CommonParams == null)
			{
				CharacterHoldingHandsComponent.CommonParams = CharacterHoldingHandsComponent.LoadCommonParams();
			}
			return CharacterHoldingHandsComponent.CommonParams;
		}
	}

	// Token: 0x1700257D RID: 9597
	// (get) Token: 0x06017FE4 RID: 98276 RVA: 0x0072EEE8 File Offset: 0x0072D0E8
	public BP_KeepFollowingConfig_C KeepFollowingConfig
	{
		get
		{
			if (this.KeepFollowingConfigInternal == null && this.Params.KeepFollowingDa != null)
			{
				this.KeepFollowingConfigInternal = ResourceSystem.Instance.Load<BP_KeepFollowingConfig_C>(this.Params.KeepFollowingDa.ToAssetPathName(), "KeepFollowingConfig");
			}
			return this.KeepFollowingConfigInternal;
		}
	}

	// Token: 0x06017FE5 RID: 98277 RVA: 0x0072EF3C File Offset: 0x0072D13C
	protected override bool OnStart()
	{
		this.CreatureDataComp = base.Entity.CheckGetComponent<CreatureDataComponent>();
		EEntityType entityType = this.CreatureDataComp.GetEntityType();
		if (entityType == EEntityType.Monster && !this.CreatureDataComp.IsCharacterMonster())
		{
			base.Disable("[CharacterHoldingHandsComponent.OnStart]");
			return true;
		}
		this.IsAutonomous = (entityType == EEntityType.Player);
		this.ActorComp = base.Entity.CheckGetComponent<CharacterActorComponent>();
		this.AnimComp = base.Entity.CheckGetComponent<CharacterAnimationComponent>();
		this.TagComp = base.Entity.CheckGetComponent<BaseTagComponent>();
		this.UnifiedStateComp = base.Entity.CheckGetComponent<BaseUnifiedStateComponent>();
		this.MoveComp = base.Entity.CheckGetComponent<BaseMoveComponent>();
		this.SkillComp = base.Entity.GetComponent<BaseSkillComponent>();
		CharacterActorComponent actorComp = this.ActorComp;
		this.SkelMesh = ((actorComp != null) ? actorComp.Actor.Mesh : null);
		CharacterAnimationComponent animComp = this.AnimComp;
		this.AnimInstance = (((animComp != null) ? animComp.MainAnimInstance : null) as UKuroAnimInstanceChar);
		return true;
	}

	// Token: 0x06017FE6 RID: 98278 RVA: 0x0072F030 File Offset: 0x0072D230
	protected override void OnActivate()
	{
		CharacterAnimationComponent animComp = this.AnimComp;
		UAnimInstance @object = (animComp != null) ? animComp.MainAnimInstance : null;
		if (!UKuroStaticLibrary.IsObjectClassByName(@object, CharacterNameDefines.Instance.ABP_BASEROLENPC) && !UKuroStaticLibrary.IsObjectClassByName(@object, CharacterNameDefines.Instance.ABP_BASEROLE))
		{
			base.Disable("[CharacterHoldingHandsComponent.OnActivate]");
			return;
		}
		CreatureDataComponent creatureDataComp = this.CreatureDataComp;
		bool flag;
		if (creatureDataComp == null)
		{
			flag = false;
		}
		else
		{
			long holdHandTargetEntityId = creatureDataComp.HoldHandTargetEntityId;
			flag = true;
		}
		if (flag && !this.CreatureDataComp.HoldHandIsFollow)
		{
			string key = this.CreatureDataComp.GetCreatureDataId().ToString() + this.CreatureDataComp.HoldHandTargetEntityId.ToString();
			EntityHandle entity = CreatureModel.Instance.GetEntity(this.CreatureDataComp.HoldHandTargetEntityId);
			CharacterHoldingHandsComponent characterHoldingHandsComponent;
			if (entity == null)
			{
				characterHoldingHandsComponent = null;
			}
			else
			{
				WorldEntity entity2 = entity.Entity;
				characterHoldingHandsComponent = ((entity2 != null) ? entity2.GetComponent<CharacterHoldingHandsComponent>() : null);
			}
			CharacterHoldingHandsComponent characterHoldingHandsComponent2 = characterHoldingHandsComponent;
			if (characterHoldingHandsComponent2 != null)
			{
				HoldingHandsController.Instance.AddBinding(key, this, characterHoldingHandsComponent2, (EHandType)this.CreatureDataComp.HoldHandType, false, false).NoLerpNextUpdate = true;
			}
		}
	}

	// Token: 0x06017FE7 RID: 98279 RVA: 0x0072F124 File Offset: 0x0072D324
	protected override bool OnEnd()
	{
		this.ReleaseAllHands("实体销毁", true, false);
		this.TryRemoveEvents();
		return true;
	}

	// Token: 0x06017FE8 RID: 98280 RVA: 0x0072F13C File Offset: 0x0072D33C
	protected override void OnTick(float deltaTime)
	{
		if (this.HandRuntimes.Count == 0)
		{
			return;
		}
		EHoldingHandsRoleState roleState = this.GetRoleState();
		if (roleState == EHoldingHandsRoleState.None)
		{
			foreach (HandRuntime handRuntime in this.HandRuntimes.Values)
			{
				handRuntime.LerpAlphas(this.Params.IkAlphaDamping, (double)deltaTime);
			}
			return;
		}
		if (this.CheckDisableTags(roleState))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LJF;
			string message = "[CharacterHoldingHandsComponent] 因DisableTags断开牵手";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", base.Entity.Id);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.ReleaseAllHands("DisableTags", false, true);
			return;
		}
		this.TickTurnInterrupt();
		this.TickInputLimit(roleState, (double)deltaTime);
	}

	// Token: 0x06017FE9 RID: 98281 RVA: 0x0072F214 File Offset: 0x0072D414
	private bool CheckDisableTags(EHoldingHandsRoleState roleState)
	{
		return this.TagComp.HasAnyTag(this.Params.DisableTags);
	}

	// Token: 0x06017FEA RID: 98282 RVA: 0x0072F22C File Offset: 0x0072D42C
	private void TickInputLimit(EHoldingHandsRoleState roleState, double deltaTime)
	{
		if (roleState != EHoldingHandsRoleState.Leader)
		{
			this.MoveComp.SetInputMaxDegree(0f);
			this.MoveComp.SetInputScale(1f);
			return;
		}
		double num = this.Params.WalkRotateSpeedMax;
		BaseUnifiedStateComponent unifiedStateComp = this.UnifiedStateComp;
		if (unifiedStateComp != null && unifiedStateComp.MoveState == global::ECharMoveState.Run)
		{
			num = this.Params.RunRotateSpeedMax;
		}
		double num2 = num * deltaTime / 1000.0;
		this.MoveComp.SetInputMaxDegree((float)num2);
		if (this.UnifiedStateComp.MoveState == global::ECharMoveState.Run)
		{
			this.MoveComp.SetInputScale((float)this.Params.InputScaleRun);
			return;
		}
		this.MoveComp.SetInputScale(1f);
	}

	// Token: 0x1700257E RID: 9598
	// (get) Token: 0x06017FEB RID: 98283 RVA: 0x0072F2E1 File Offset: 0x0072D4E1
	public HoldingHandsModel Model
	{
		get
		{
			return HoldingHandsModel.Instance;
		}
	}

	// Token: 0x06017FEC RID: 98284 RVA: 0x0072F2E8 File Offset: 0x0072D4E8
	[NullableContext(1)]
	public HandRuntime GetHandRuntime(EHandType handType)
	{
		HandRuntime handRuntime;
		if (!this.HandRuntimes.TryGetValue(handType, out handRuntime))
		{
			handRuntime = new HandRuntime();
			handRuntime.HandType = handType;
			this.HandRuntimes[handType] = handRuntime;
		}
		return handRuntime;
	}

	// Token: 0x06017FED RID: 98285 RVA: 0x0072F320 File Offset: 0x0072D520
	public HoldingHandsRelation GetRelationByHand(EHandType handType)
	{
		string key;
		if (!this.RelationKeys.TryGetValue(handType, out key))
		{
			return null;
		}
		HoldingHandsModel model = this.Model;
		if (model == null)
		{
			return null;
		}
		return model.GetRelation(key);
	}

	// Token: 0x06017FEE RID: 98286 RVA: 0x0072F354 File Offset: 0x0072D554
	[NullableContext(1)]
	[return: Nullable(2)]
	public HoldingHandsRelation GetRelationByFollower(CharacterHoldingHandsComponent follower)
	{
		foreach (string key in this.RelationKeys.Values)
		{
			HoldingHandsModel model = this.Model;
			HoldingHandsRelation holdingHandsRelation = (model != null) ? model.GetRelation(key) : null;
			if (holdingHandsRelation != null && holdingHandsRelation.Follower == follower && holdingHandsRelation.Leader == this)
			{
				return holdingHandsRelation;
			}
		}
		return null;
	}

	// Token: 0x06017FEF RID: 98287 RVA: 0x0072F3D8 File Offset: 0x0072D5D8
	public IkTarget GetHandIkTarget(EHandType handType)
	{
		HandRuntime handRuntime;
		if (!this.HandRuntimes.TryGetValue(handType, out handRuntime))
		{
			return null;
		}
		return handRuntime.IkTarget;
	}

	// Token: 0x06017FF0 RID: 98288 RVA: 0x0072F400 File Offset: 0x0072D600
	public FIKTarget GetHandIkTargetUe(EHandType handType)
	{
		HandRuntime handRuntime;
		if (!this.HandRuntimes.TryGetValue(handType, out handRuntime))
		{
			return null;
		}
		if (handRuntime.IkTarget == null)
		{
			return null;
		}
		if (handRuntime.IkTargetUe == null)
		{
			handRuntime.IkTargetUe = new FIKTarget();
		}
		handRuntime.IkTargetUe.Location = handRuntime.IkTarget.Location.ToUeVectorOld();
		handRuntime.IkTargetUe.Rotation = handRuntime.IkTarget.Rotation.ToUeQuat();
		handRuntime.IkTargetUe.Alpha = (float)handRuntime.IkTarget.Alpha;
		return handRuntime.IkTargetUe;
	}

	// Token: 0x06017FF1 RID: 98289 RVA: 0x0072F498 File Offset: 0x0072D698
	public EHoldingHandsRoleState GetRoleState()
	{
		if (this.RelationKeys == null || this.RelationKeys.Count == 0)
		{
			return EHoldingHandsRoleState.None;
		}
		foreach (string key in this.RelationKeys.Values)
		{
			HoldingHandsModel model = this.Model;
			HoldingHandsRelation holdingHandsRelation = (model != null) ? model.GetRelation(key) : null;
			if (holdingHandsRelation != null && holdingHandsRelation is Binding)
			{
				if (holdingHandsRelation.Leader == this)
				{
					return EHoldingHandsRoleState.Leader;
				}
				if (holdingHandsRelation.Follower == this)
				{
					return EHoldingHandsRoleState.Follower;
				}
			}
		}
		return EHoldingHandsRoleState.None;
	}

	// Token: 0x06017FF2 RID: 98290 RVA: 0x0072F53C File Offset: 0x0072D73C
	public bool GetIsHoldingHands()
	{
		return this.GetRoleState() == EHoldingHandsRoleState.Leader;
	}

	// Token: 0x06017FF3 RID: 98291 RVA: 0x0072F547 File Offset: 0x0072D747
	public bool GetIsBeHoldingHands()
	{
		return this.GetRoleState() == EHoldingHandsRoleState.Follower;
	}

	// Token: 0x06017FF4 RID: 98292 RVA: 0x0072F552 File Offset: 0x0072D752
	public bool GetIsAcceptingInvitation()
	{
		return this.IsAcceptingInvitation;
	}

	// Token: 0x06017FF5 RID: 98293 RVA: 0x0072F55C File Offset: 0x0072D75C
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public ValueTuple<EHandType, CharacterHoldingHandsComponent>? GetLeaderInfo()
	{
		foreach (KeyValuePair<EHandType, string> keyValuePair in this.RelationKeys)
		{
			HoldingHandsModel model = this.Model;
			HoldingHandsRelation holdingHandsRelation = (model != null) ? model.GetRelation(keyValuePair.Value) : null;
			if (holdingHandsRelation != null && holdingHandsRelation.Follower == this)
			{
				return new ValueTuple<EHandType, CharacterHoldingHandsComponent>?(new ValueTuple<EHandType, CharacterHoldingHandsComponent>(keyValuePair.Key, holdingHandsRelation.Leader));
			}
		}
		return null;
	}

	// Token: 0x06017FF6 RID: 98294 RVA: 0x0072F5F4 File Offset: 0x0072D7F4
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public ValueTuple<EHandType, CharacterHoldingHandsComponent>? GetFollowerInfo()
	{
		foreach (KeyValuePair<EHandType, string> keyValuePair in this.RelationKeys)
		{
			HoldingHandsModel model = this.Model;
			HoldingHandsRelation holdingHandsRelation = (model != null) ? model.GetRelation(keyValuePair.Value) : null;
			if (holdingHandsRelation != null && holdingHandsRelation.Leader == this)
			{
				return new ValueTuple<EHandType, CharacterHoldingHandsComponent>?(new ValueTuple<EHandType, CharacterHoldingHandsComponent>(keyValuePair.Key, holdingHandsRelation.Follower));
			}
		}
		return null;
	}

	// Token: 0x06017FF7 RID: 98295 RVA: 0x0072F68C File Offset: 0x0072D88C
	public bool GetHandReachable(EHandType hand)
	{
		HoldingHandsRelation relationByHand = this.GetRelationByHand(hand);
		return relationByHand != null && relationByHand is Binding && (relationByHand as Binding).Reachable;
	}

	// Token: 0x06017FF8 RID: 98296 RVA: 0x0072F6B9 File Offset: 0x0072D8B9
	public bool GetIfHanding()
	{
		return this.GetRoleState() > EHoldingHandsRoleState.None;
	}

	// Token: 0x06017FF9 RID: 98297 RVA: 0x0072F6C4 File Offset: 0x0072D8C4
	[NullableContext(1)]
	public static double GetMaxReachableDistance(Binding binding)
	{
		return binding.LeaderRuntime.MaxBendLength + binding.FollowerRuntime.MaxBendLength;
	}

	// Token: 0x06017FFA RID: 98298 RVA: 0x0072F6DD File Offset: 0x0072D8DD
	[NullableContext(1)]
	public global::Vector GetFollowingPosition(CharacterHoldingHandsComponent leader)
	{
		BaseMoveComponent moveComp = this.MoveComp;
		if (moveComp != null)
		{
			moveComp.MoveController.GetFollowingPosition(this.TempVector, leader.ActorComp);
		}
		return this.TempVector;
	}

	// Token: 0x06017FFB RID: 98299 RVA: 0x0072F708 File Offset: 0x0072D908
	public unsafe void SetBindingsNoLerp()
	{
		foreach (string key in this.RelationKeys.Values)
		{
			HoldingHandsModel model = this.Model;
			HoldingHandsRelation holdingHandsRelation = (model != null) ? model.GetRelation(key) : null;
			if (holdingHandsRelation != null && holdingHandsRelation is Binding)
			{
				(holdingHandsRelation as Binding).NoLerpNextUpdate = true;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Character;
				ELogAuthor author = ELogAuthor.LJF;
				string message = "[CharacterHoldingHandsComponent.SetAllBindingsNoLerp]";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", holdingHandsRelation.Key);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item = "leader";
				CharacterHoldingHandsComponent leader = holdingHandsRelation.Leader;
				ptr = new ValueTuple<string, object>(item, (leader != null) ? new int?(leader.Entity.Id) : null);
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
				string item2 = "follower";
				CharacterHoldingHandsComponent follower = holdingHandsRelation.Follower;
				ptr2 = new ValueTuple<string, object>(item2, (follower != null) ? new int?(follower.Entity.Id) : null);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
		}
	}

	// Token: 0x06017FFC RID: 98300 RVA: 0x0072F860 File Offset: 0x0072DA60
	[NullableContext(1)]
	public static void StartInvitation(Invitation invitation, EHandType leaderHandType)
	{
		CharacterHoldingHandsComponent leader = invitation.Leader;
		CharacterHoldingHandsComponent follower = invitation.Follower;
		leader.RelationKeys[leaderHandType] = invitation.Key;
		follower.RelationKeys[EHandType.Right - (int)leaderHandType] = invitation.Key;
		global::Vector actorLocationProxy = follower.ActorComp.ActorLocationProxy;
		global::Vector actorLocationProxy2 = leader.ActorComp.ActorLocationProxy;
		global::Vector toLeader = leader.TempVector;
		actorLocationProxy2.Subtraction(actorLocationProxy, toLeader);
		toLeader.Normalize(9.99999993922529E-09);
		toLeader.MultiplyEqual(leader.Params.InvitationDistance);
		actorLocationProxy.Addition(toLeader, leader.MovePoint);
		BaseMoveComponent moveComp = leader.MoveComp;
		float? num;
		if (moveComp == null)
		{
			num = null;
		}
		else
		{
			SMovementSetting currentMovementSettings = moveComp.CurrentMovementSettings;
			num = ((currentMovementSettings != null) ? new float?(currentMovementSettings.WalkSpeed) : null);
		}
		float? num2 = num;
		float valueOrDefault = num2.GetValueOrDefault(100f);
		MoveCharacterPoint value = new MoveCharacterPoint
		{
			Index = 0,
			Position = leader.MovePoint,
			MoveState = new EPatrolMoveState?(EPatrolMoveState.Walk),
			MoveSpeed = new float?(valueOrDefault)
		};
		Action <>9__1;
		MoveCharacterConfig config = new MoveCharacterConfig
		{
			Points = value,
			Navigation = false,
			IsFly = false,
			DebugMode = true,
			Loop = false,
			Callback = delegate(ELevelEventState result)
			{
				CharacterHoldingHandsComponent leader;
				if (result == ELevelEventState.Success)
				{
					leader.MoveComp.StopMoveNew("CharacterHoldingHandsComponent.StartInvitation");
					global::Vector actorLocationProxy3 = follower.ActorComp.ActorLocationProxy;
					global::Vector actorLocationProxy4 = leader.ActorComp.ActorLocationProxy;
					global::Vector tempVector = leader.TempVector2;
					actorLocationProxy3.Subtraction(actorLocationProxy4, tempVector);
					tempVector.Normalize(9.99999993922529E-09);
					tempVector.Multiply(-1.0, toLeader);
					follower.TurnToTarget(toLeader, 0.0, null);
					leader = leader;
					global::Vector facing = tempVector;
					double minAngle = 10.0;
					Action onEnd;
					if ((onEnd = <>9__1) == null)
					{
						onEnd = (<>9__1 = delegate()
						{
							BaseSkillComponent skillComp = leader.SkillComp;
							if (skillComp == null)
							{
								return;
							}
							skillComp.BeginSkill(401101, new SkillParam
							{
								Reason = "开始牵手邀约"
							});
						});
					}
					leader.TurnToTarget(facing, minAngle, onEnd);
					return;
				}
				leader.MoveComp.StopMoveNew("CharacterHoldingHandsComponent.StartInvitation");
				leader.ReleaseAllHands("邀请时Leader移动失败", false, true);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Character;
				ELogAuthor author = ELogAuthor.LJF;
				string message = "[CharacterHoldingHandsComponent] Leader无法走到邀请点，退出牵手";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("leader", leader.Entity.Id);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			},
			TurnSpeed = new float?(leader.Params.InvitationTurnSpeed),
			ReturnTimeoutFailed = new float?((float)2),
			ReturnFalseWhenNavigationFailed = false,
			Distance = new float?(leader.Params.InvitationDistanceTolerance)
		};
		if (leader.SkillComp != null)
		{
			leader.SkillComp.StopAllSkills("牵手邀请");
		}
		leader.MoveComp.MoveAlongPath(config, "CharacterHoldingHandsComponent.StartInvitation");
		leader.AddOrRemoveInvitationTags(true, EHoldingHandsRoleState.Leader);
	}

	// Token: 0x06017FFD RID: 98301 RVA: 0x0072FA94 File Offset: 0x0072DC94
	public void FollowerAccept()
	{
		foreach (string key in this.RelationKeys.Values)
		{
			HoldingHandsModel model = this.Model;
			Invitation invitation = (Invitation)((model != null) ? model.GetRelation(key) : null);
			if (invitation != null && invitation.Follower != null && invitation.Leader != null)
			{
				CharacterHoldingHandsComponent follower = invitation.Follower;
				follower.IsAcceptingInvitation = true;
				if (follower.DelayEndInvitationTimer != null)
				{
					follower.DelayEndInvitationTimer.Remove();
				}
				follower.DelayEndInvitationTimer = TimerSystem.FlowTimeInstance.Delay(delegate(float _)
				{
					if (follower != null)
					{
						if (follower.DelayEndInvitationTimer != null)
						{
							follower.DelayEndInvitationTimer.Remove();
							follower.DelayEndInvitationTimer = null;
						}
						follower.ReleaseAllHands("邀请时未触发AN", false, true);
						follower.IsAcceptingInvitation = false;
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Character;
						ELogAuthor author = ELogAuthor.LJF;
						string message = "[CharacterHoldingHandsComponent] Follower邀请接受AN未触发，退出牵手";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("follower", follower.Entity.Id);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
				}, 3000f, null, null, true, 1f);
				break;
			}
		}
	}

	// Token: 0x06017FFE RID: 98302 RVA: 0x0072FB84 File Offset: 0x0072DD84
	public void InvitationToBinding()
	{
		foreach (string key in this.RelationKeys.Values)
		{
			HoldingHandsModel model = this.Model;
			Invitation invitation = (Invitation)((model != null) ? model.GetRelation(key) : null);
			if (invitation != null && invitation.Follower != null && invitation.Leader != null)
			{
				CharacterHoldingHandsComponent follower = invitation.Follower;
				CharacterHoldingHandsComponent leader = invitation.Leader;
				if (follower.DelayEndInvitationTimer != null)
				{
					follower.DelayEndInvitationTimer.Remove();
					follower.DelayEndInvitationTimer = null;
				}
				follower.IsAcceptingInvitation = false;
				HoldingHandsController.Instance.AddBinding(invitation.Key, leader, follower, invitation.LeaderHandType, true, false);
				BaseSkillComponent skillComp = leader.SkillComp;
				if (skillComp != null)
				{
					skillComp.EndSkill(401101, "牵手邀请结束");
				}
				BaseSkillComponent skillComp2 = invitation.Leader.SkillComp;
				if (skillComp2 != null)
				{
					skillComp2.BeginSkill(401102, new SkillParam
					{
						Reason = "牵手邀请结束回到站立"
					});
				}
				global::Vector actorLocationProxy = follower.ActorComp.ActorLocationProxy;
				global::Vector actorLocationProxy2 = leader.ActorComp.ActorLocationProxy;
				global::Vector tempVector = leader.TempVector;
				actorLocationProxy.Subtraction(actorLocationProxy2, tempVector);
				tempVector.Normalize(9.99999993922529E-09);
				tempVector.MultiplyEqual(leader.Params.InvitationEndDistance);
				actorLocationProxy2.Addition(tempVector, follower.MovePoint);
				BaseUnifiedStateComponent component = follower.Entity.GetComponent<BaseUnifiedStateComponent>();
				if (component != null)
				{
					component.SetMoveState(global::ECharMoveState.Walk);
				}
				MoveCharacterPoint moveCharacterPoint = new MoveCharacterPoint
				{
					Index = 0,
					Position = follower.MovePoint,
					MoveState = new EPatrolMoveState?(EPatrolMoveState.Walk),
					MoveSpeed = new float?(leader.Params.InvitationEndMoveSpeed)
				};
				MoveCharacterConfig config = new MoveCharacterConfig
				{
					Points = new MoveCharacterPoint[]
					{
						moveCharacterPoint
					},
					Navigation = false,
					IsFly = false,
					DebugMode = true,
					Loop = false,
					Callback = delegate(ELevelEventState result)
					{
						if (result != ELevelEventState.Success)
						{
							follower.MoveComp.StopMoveNew("CharacterHoldingHandsComponent.FollowerAccept");
							follower.ReleaseAllHands("邀请时Follower移动失败", false, true);
							Log instance = Log.Instance;
							ELogModule module = ELogModule.Character;
							ELogAuthor author = ELogAuthor.LJF;
							string message = "[CharacterHoldingHandsComponent] Follower无法走到结束邀请点，退出牵手";
							ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("follower", follower.Entity.Id);
							instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						}
					},
					ReturnTimeoutFailed = new float?((float)2),
					ReturnFalseWhenNavigationFailed = false,
					Distance = new float?(leader.Params.InvitationEndDistanceTolerance)
				};
				follower.MoveComp.MoveAlongPath(config, "CharacterHoldingHandsComponent.FollowerAccept");
				break;
			}
		}
	}

	// Token: 0x06017FFF RID: 98303 RVA: 0x0072FE3C File Offset: 0x0072E03C
	public void OnInvitationAnimEnd()
	{
		foreach (string key in this.RelationKeys.Values)
		{
			CharacterHoldingHandsComponent.<>c__DisplayClass65_0 CS$<>8__locals1 = new CharacterHoldingHandsComponent.<>c__DisplayClass65_0();
			CharacterHoldingHandsComponent.<>c__DisplayClass65_0 CS$<>8__locals2 = CS$<>8__locals1;
			HoldingHandsModel model = this.Model;
			CS$<>8__locals2.binding = ((model != null) ? model.GetRelation(key) : null);
			if (CS$<>8__locals1.binding != null && CS$<>8__locals1.binding is Binding && CS$<>8__locals1.binding.Follower != null && CS$<>8__locals1.binding.Leader != null)
			{
				CharacterHoldingHandsComponent leader = CS$<>8__locals1.binding.Leader;
				CharacterHoldingHandsComponent follower = CS$<>8__locals1.binding.Follower;
				global::Vector actorLocationProxy = leader.ActorComp.ActorLocationProxy;
				global::Vector actorLocationProxy2 = follower.ActorComp.ActorLocationProxy;
				global::Vector tempVector = this.TempVector;
				actorLocationProxy2.Subtraction(actorLocationProxy, tempVector);
				global::Vector actorUpProxy = leader.ActorComp.ActorUpProxy;
				global::Vector tempVector2 = this.TempVector2;
				global::Vector.CrossProduct(tempVector, actorUpProxy, tempVector2);
				tempVector2.Normalize(9.99999993922529E-09);
				if (CS$<>8__locals1.binding.LeaderHandType == EHandType.Left)
				{
					tempVector2.MultiplyEqual(-1.0);
				}
				follower.TurnToTarget(tempVector2, 0.0, null);
				leader.TurnToTarget(tempVector2, 0.0, delegate
				{
					CharacterHoldingHandsComponent.OnInvitationEndTurnComplete((Binding)CS$<>8__locals1.binding);
				});
				break;
			}
		}
	}

	// Token: 0x06018000 RID: 98304 RVA: 0x0072FFBC File Offset: 0x0072E1BC
	[NullableContext(1)]
	private static void OnInvitationEndTurnComplete(Binding binding)
	{
		if (binding == null || binding == null || binding.Follower == null || binding.Leader == null)
		{
			return;
		}
		CharacterHoldingHandsComponent leader = binding.Leader;
		CharacterHoldingHandsComponent follower = binding.Follower;
		if (leader.TurnEndTimer != null)
		{
			leader.TurnEndTimer.Remove();
			leader.TurnEndTimer = null;
		}
		EventSystem.Instance.Emit<string>(EEventName.ForceReleaseInput, "进入牵手状态");
		leader.OnEnterHoldingHands(binding.LeaderHandType);
		follower.OnEnterHoldingHands(binding.FollowerHandType);
		if (follower.KeepFollowingConfig != null)
		{
			BaseMoveComponent moveComp = follower.MoveComp;
			if (moveComp == null)
			{
				return;
			}
			moveComp.MoveController.StartKeepFollowingWithDataAsset(leader.ActorComp, follower.KeepFollowingConfig, new EHandType?(binding.FollowerHandType), false, null, null);
		}
	}

	// Token: 0x06018001 RID: 98305 RVA: 0x00730078 File Offset: 0x0072E278
	[NullableContext(1)]
	private void TurnToTarget(global::Vector facing, double minAngle, [Nullable(2)] Action onEnd = null)
	{
		CharacterHoldingHandsComponent.<>c__DisplayClass67_0 CS$<>8__locals1 = new CharacterHoldingHandsComponent.<>c__DisplayClass67_0();
		CS$<>8__locals1.onEnd = onEnd;
		CS$<>8__locals1.<>4__this = this;
		double num = facing.HeadingAngle() * 57.295780181884766;
		double num2 = (double)this.ActorComp.ActorRotationProxy.Yaw;
		double num3 = Math.Abs(num - num2);
		num3 = ((num3 > 180.0) ? (360.0 - num3) : num3);
		if (num3 >= minAngle)
		{
			this.ActorComp.SetInputFacing(facing, true);
			this.ActorComp.SetOverrideTurnSpeed(new float?(this.Params.InvitationTurnSpeed));
			if (CS$<>8__locals1.onEnd != null)
			{
				double num4 = num3 / (double)this.Params.InvitationTurnSpeed * 1000.0 + (double)((num3 > 45.0) ? 500 : 0);
				if (this.TurnEndTimer != null && this.TurnEndTimer.Valid())
				{
					this.TurnEndTimer.Remove();
				}
				this.TurnEndAction = new TTimerAction(CS$<>8__locals1.<TurnToTarget>g__OnEndAction|0);
				this.TurnEndTimer = TimerSystem.FlowTimeInstance.Delay(this.TurnEndAction, (float)num4, null, null, true, 1f);
			}
			return;
		}
		Action onEnd2 = CS$<>8__locals1.onEnd;
		if (onEnd2 == null)
		{
			return;
		}
		onEnd2();
	}

	// Token: 0x06018002 RID: 98306 RVA: 0x007301B0 File Offset: 0x0072E3B0
	private void TickTurnInterrupt()
	{
		if (this.TurnEndTimer != null && this.TurnEndTimer.Valid())
		{
			BaseMoveComponent moveComp = this.MoveComp;
			if (moveComp != null && moveComp.HasMoveInput)
			{
				this.TurnEndTimer.Remove();
				this.TurnEndTimer = null;
				TTimerAction turnEndAction = this.TurnEndAction;
				if (turnEndAction != null)
				{
					turnEndAction(0f);
				}
				this.TurnEndAction = null;
			}
		}
	}

	// Token: 0x06018003 RID: 98307 RVA: 0x00730218 File Offset: 0x0072E418
	[NullableContext(1)]
	public void OnAddBinding(EHandType handType, string bindingKey, bool invitation = false)
	{
		this.RelationKeys[handType] = bindingKey;
		HandRuntime handRuntime = this.GetHandRuntime(handType);
		handRuntime.InBind = true;
		if (handRuntime.IkTarget == null)
		{
			handRuntime.IkTarget = new IkTarget(null, null, null);
		}
		if (!invitation)
		{
			this.OnEnterHoldingHands(handType);
		}
	}

	// Token: 0x06018004 RID: 98308 RVA: 0x0073026C File Offset: 0x0072E46C
	public unsafe void OnEnterHoldingHands(EHandType handType)
	{
		EHoldingHandsRoleState roleState = this.GetRoleState();
		if (roleState == EHoldingHandsRoleState.None)
		{
			return;
		}
		this.SetDisableInputTags(false);
		this.AddOrRemoveInvitationTags(false, roleState);
		this.AddOrRemoveBindingTags(true, roleState);
		if (roleState == EHoldingHandsRoleState.Leader)
		{
			this.MoveComp.CharacterMovement.HitPriority = this.Params.LeaderHitPriority;
			this.MoveComp.CharacterMovement.Mass = this.Params.LeaderMass;
		}
		else if (roleState == EHoldingHandsRoleState.Follower)
		{
			this.MoveComp.CharacterMovement.HitPriority = this.Params.FollowerHitPriority;
			this.MoveComp.CharacterMovement.Mass = this.Params.FollowerMass;
		}
		EventSystem.Instance.Emit<int, bool, EHoldingHandsRoleState, EHandType>(EEventName.CharHoldingHandsChanged, base.Entity.Id, true, roleState, handType);
		EventSystem.Instance.EmitWithTarget<int, bool, EHoldingHandsRoleState, EHandType>(base.Entity, EEventName.CharHoldingHandsChanged, base.Entity.Id, true, roleState, handType);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Character;
		ELogAuthor author = ELogAuthor.CWZ;
		string message = "[CharacterHoldingHandsComponent] 进入牵手状态";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("entityId", base.Entity.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("roleState", roleState);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("handType", handType);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		if (this.IsAutonomous)
		{
			this.CreateInputLayer();
		}
		this.TryAddEvents();
	}

	// Token: 0x06018005 RID: 98309 RVA: 0x007303EC File Offset: 0x0072E5EC
	[NullableContext(1)]
	public void ReleaseAllHands(string reason = "", bool lerp = false, bool sendRequest = true)
	{
		foreach (string key in this.RelationKeys.Values)
		{
			HoldingHandsController.Instance.RequestReleaseHands(key, reason, lerp, sendRequest);
		}
		this.SetDisableInputTags(false);
		if (this.SavedRelation != null)
		{
			CharacterHoldingHandsComponent follower = this.SavedRelation.Follower;
			if (follower != null)
			{
				follower.SetDisableInputTags(false);
			}
			CharacterHoldingHandsComponent leader = this.SavedRelation.Leader;
			if (leader == null)
			{
				return;
			}
			leader.SetDisableInputTags(false);
		}
	}

	// Token: 0x06018006 RID: 98310 RVA: 0x00730488 File Offset: 0x0072E688
	public void OnDeleteRelation(EHandType handType, bool isLeader, bool lerp = true)
	{
		HoldingHandsRelation relationByHand = this.GetRelationByHand(handType);
		this.RelationKeys.Remove(handType);
		bool flag = relationByHand is Binding;
		if (flag)
		{
			HandRuntime handRuntime = this.GetHandRuntime(handType);
			handRuntime.InBind = false;
			handRuntime.TargetAlpha = 0f;
			if (!lerp && handRuntime.IkTarget != null)
			{
				handRuntime.IkTarget.Alpha = 0.0;
			}
		}
		this.OnExitHoldingHands(isLeader, handType, flag);
	}

	// Token: 0x06018007 RID: 98311 RVA: 0x007304F8 File Offset: 0x0072E6F8
	private unsafe void OnExitHoldingHands(bool isLeader, EHandType handType, bool isBinding)
	{
		EHoldingHandsRoleState eholdingHandsRoleState = isLeader ? EHoldingHandsRoleState.Leader : EHoldingHandsRoleState.Follower;
		this.SetDisableInputTags(false);
		this.AddOrRemoveBindingTags(false, eholdingHandsRoleState);
		this.AddOrRemoveInvitationTags(false, eholdingHandsRoleState);
		if (this.DelayEndInvitationTimer != null)
		{
			this.DelayEndInvitationTimer.Remove();
			this.DelayEndInvitationTimer = null;
		}
		if (this.TurnEndTimer != null && this.TurnEndTimer.Valid())
		{
			this.TurnEndTimer.Remove();
			this.TurnEndTimer = null;
		}
		this.IsAcceptingInvitation = false;
		if (isLeader)
		{
			BaseSkillComponent skillComp = this.SkillComp;
			if (skillComp != null)
			{
				skillComp.EndSkill(401101, "退出牵手");
			}
		}
		else
		{
			BaseMoveComponent moveComp = this.MoveComp;
			if (moveComp != null)
			{
				moveComp.MoveController.StopKeepHoldingHands();
			}
		}
		if (isBinding)
		{
			this.OnReachable(false, handType);
			this.MoveComp.SetInputMaxDegree(0f);
			this.MoveComp.SetInputScale(1f);
			this.MoveComp.ResetHitPriorityAndGoThrough();
			this.MoveComp.ResetMass();
			EventSystem.Instance.Emit<int, bool, EHoldingHandsRoleState, EHandType>(EEventName.CharHoldingHandsChanged, base.Entity.Id, false, eholdingHandsRoleState, handType);
			EventSystem.Instance.EmitWithTarget<int, bool, EHoldingHandsRoleState, EHandType>(base.Entity, EEventName.CharHoldingHandsChanged, base.Entity.Id, false, eholdingHandsRoleState, handType);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[CharacterHoldingHandsComponent] 退出牵手状态";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("entityId", base.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("roleState", eholdingHandsRoleState);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("handType", handType);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (this.IsAutonomous)
			{
				this.RemoveInputLayer();
			}
		}
		this.TryRemoveEvents();
	}

	// Token: 0x06018008 RID: 98312 RVA: 0x007306C4 File Offset: 0x0072E8C4
	private void AddOrRemoveInvitationTags(bool add, EHoldingHandsRoleState roleState)
	{
		if (roleState != EHoldingHandsRoleState.Leader)
		{
			return;
		}
		if (add)
		{
			using (List<int>.Enumerator enumerator = this.Params.InvitingTags.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					int value = enumerator.Current;
					BaseTagComponent tagComp = this.TagComp;
					if (tagComp != null)
					{
						tagComp.AddTag(new int?(value));
					}
				}
				return;
			}
		}
		foreach (int value2 in this.Params.InvitingTags)
		{
			BaseTagComponent tagComp2 = this.TagComp;
			if (tagComp2 != null)
			{
				tagComp2.RemoveTag(new int?(value2));
			}
		}
	}

	// Token: 0x06018009 RID: 98313 RVA: 0x0073078C File Offset: 0x0072E98C
	private void AddOrRemoveBindingTags(bool add, EHoldingHandsRoleState roleState)
	{
		List<int> list = null;
		if (roleState == EHoldingHandsRoleState.Leader)
		{
			list = this.Params.LeadingTags;
		}
		else if (roleState == EHoldingHandsRoleState.Follower)
		{
			list = this.Params.FollowingTags;
		}
		if (list == null)
		{
			return;
		}
		if (add)
		{
			using (List<int>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					int value = enumerator.Current;
					BaseTagComponent tagComp = this.TagComp;
					if (tagComp != null)
					{
						tagComp.AddTag(new int?(value));
					}
				}
				return;
			}
		}
		foreach (int value2 in list)
		{
			BaseTagComponent tagComp2 = this.TagComp;
			if (tagComp2 != null)
			{
				tagComp2.RemoveTag(new int?(value2));
			}
		}
	}

	// Token: 0x0601800A RID: 98314 RVA: 0x00730864 File Offset: 0x0072EA64
	public void OnReachable(bool reachable, EHandType handType)
	{
		int reachableTag = this.Params.ReachableTag;
		if (reachable)
		{
			BaseTagComponent tagComp = this.TagComp;
			if (tagComp != null)
			{
				tagComp.AddTag(new int?(reachableTag));
			}
			this.EnableAdditiveArmAnim(true, handType);
			return;
		}
		BaseTagComponent tagComp2 = this.TagComp;
		if (tagComp2 != null)
		{
			tagComp2.RemoveTag(new int?(reachableTag));
		}
		this.EnableAdditiveArmAnim(false, handType);
	}

	// Token: 0x0601800B RID: 98315 RVA: 0x007308C0 File Offset: 0x0072EAC0
	private void EnableAdditiveArmAnim(bool enable, EHandType handType)
	{
		int value = (handType == EHandType.Right) ? GameplayTagDefine.EGameplayTagId["功能.功能制作.融合.叠加层仅右手"] : GameplayTagDefine.EGameplayTagId["功能.功能制作.融合.叠加层仅左手"];
		if (enable)
		{
			BaseTagComponent tagComp = this.TagComp;
			if (tagComp != null)
			{
				tagComp.AddTag(new int?(value));
			}
		}
		else
		{
			BaseTagComponent tagComp2 = this.TagComp;
			if (tagComp2 != null)
			{
				tagComp2.RemoveTag(new int?(value));
			}
		}
		if (this.AnimComp != null)
		{
			if (handType == EHandType.Right)
			{
				this.AnimComp.EnableRightArmBlend = enable;
				return;
			}
			this.AnimComp.EnableLeftArmBlend = enable;
		}
	}

	// Token: 0x0601800C RID: 98316 RVA: 0x0073094B File Offset: 0x0072EB4B
	public void OnlyStopAiMove()
	{
		BaseMoveComponent moveComp = this.MoveComp;
		if (moveComp == null)
		{
			return;
		}
		moveComp.MoveController.StopKeepHoldingHands();
	}

	// Token: 0x0601800D RID: 98317 RVA: 0x00730964 File Offset: 0x0072EB64
	public void OnlyStartAiMove()
	{
		ValueTuple<EHandType, CharacterHoldingHandsComponent>? leaderInfo = this.GetLeaderInfo();
		if (leaderInfo == null || leaderInfo.Value.Item2 == null || leaderInfo.Value.Item2.ActorComp == null)
		{
			return;
		}
		if (this.KeepFollowingConfig != null)
		{
			BaseMoveComponent moveComp = this.MoveComp;
			if (moveComp != null)
			{
				moveComp.MoveController.StartKeepFollowingWithDataAsset(leaderInfo.Value.Item2.ActorComp, this.KeepFollowingConfig, new EHandType?(leaderInfo.Value.Item1), false, null, null);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.JYS;
			string message = "[CharacterHoldingHandsComponent]OnlyStartAiMove成功";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", base.Entity.Id);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
	}

	// Token: 0x0601800E RID: 98318 RVA: 0x00730A30 File Offset: 0x0072EC30
	public void TryAddEvents()
	{
		if (this.EventsAdded)
		{
			return;
		}
		EventSystem.Instance.AddWithTarget<int, int>(base.Entity, EEventName.OnSkillEnd, new Action<int, int>(this.OnSkillEnd));
		EventSystem.Instance.Add<int, int>(EEventName.CharInterruptSkill, new Action<int, int>(this.OnSillEndByInterrupt));
		EventSystem.Instance.AddWithTarget<bool>(base.Entity, EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
		if (this.IsAutonomous)
		{
			EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		}
		this.EventsAdded = true;
	}

	// Token: 0x0601800F RID: 98319 RVA: 0x00730ACC File Offset: 0x0072ECCC
	public void TryRemoveEvents()
	{
		if (!this.EventsAdded)
		{
			return;
		}
		EventSystem.Instance.RemoveWithTarget<int, int>(base.Entity, EEventName.OnSkillEnd, new Action<int, int>(this.OnSkillEnd));
		EventSystem.Instance.Remove<int, int>(EEventName.CharInterruptSkill, new Action<int, int>(this.OnSillEndByInterrupt));
		EventSystem.Instance.RemoveWithTarget<bool>(base.Entity, EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
		if (this.IsAutonomous)
		{
			EventSystem.Instance.Remove<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		}
		this.EventsAdded = false;
	}

	// Token: 0x06018010 RID: 98320 RVA: 0x00730B68 File Offset: 0x0072ED68
	private unsafe void OnSkillEnd(int entityId, int skillId)
	{
		if (CharacterHoldingHandsComponent.ListenSkillIds.Contains((long)skillId))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LJF;
			string message = "[CharacterHoldingHandsComponent.OnSkillEnd]";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("entityId", entityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("skillId", skillId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (skillId == 401102)
			{
				this.OnInvitationAnimEnd();
			}
		}
	}

	// Token: 0x06018011 RID: 98321 RVA: 0x00730BF0 File Offset: 0x0072EDF0
	private unsafe void OnSillEndByInterrupt(int entityId, int skillId)
	{
		if (entityId == base.Entity.Id && CharacterHoldingHandsComponent.ListenSkillIds.Contains((long)skillId))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LJF;
			string message = "[CharacterHoldingHandsComponent.OnSillEndByInterrupt]";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("entityId", entityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("skillId", skillId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (this.CanSkillInterrupt)
			{
				this.ReleaseAllHands("邀请技能被打断", false, true);
			}
		}
	}

	// Token: 0x06018012 RID: 98322 RVA: 0x00730C90 File Offset: 0x0072EE90
	[NullableContext(1)]
	protected void OnStateInherit(Entity other, bool notInheritMoveAndAnim)
	{
		if (other == null || !other.Valid || notInheritMoveAndAnim)
		{
			return;
		}
		CharacterHoldingHandsComponent component = other.GetComponent<CharacterHoldingHandsComponent>();
		if (component == null)
		{
			return;
		}
		foreach (KeyValuePair<EHandType, string> keyValuePair in this.RelationKeys)
		{
			EHandType key = keyValuePair.Key;
			string value = keyValuePair.Value;
			HoldingHandsModel model = this.Model;
			HoldingHandsRelation holdingHandsRelation = (model != null) ? model.GetRelation(value) : null;
			if (holdingHandsRelation != null)
			{
				bool flag = holdingHandsRelation is Binding;
				bool isLeader = false;
				if (holdingHandsRelation.Follower == this)
				{
					holdingHandsRelation.Follower = component;
					if (flag)
					{
						(holdingHandsRelation as Binding).FollowerRuntime = component.GetHandRuntime(key);
						(holdingHandsRelation as Binding).FollowerRuntime.IkTarget.Alpha = 1.0;
					}
				}
				else if (holdingHandsRelation.Leader == this)
				{
					holdingHandsRelation.Leader = component;
					if (flag)
					{
						(holdingHandsRelation as Binding).LeaderRuntime = component.GetHandRuntime(key);
						(holdingHandsRelation as Binding).LeaderRuntime.IkTarget.Alpha = 1.0;
					}
					isLeader = true;
				}
				component.OnAddBinding(key, value, false);
				this.OnDeleteRelation(key, isLeader, false);
			}
		}
	}

	// Token: 0x06018013 RID: 98323 RVA: 0x00730DF4 File Offset: 0x0072EFF4
	[NullableContext(1)]
	private void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		this.ReleaseAllHands("换人", false, true);
	}

	// Token: 0x06018014 RID: 98324 RVA: 0x00730E03 File Offset: 0x0072F003
	private void OnTeleportStart(bool _)
	{
		this.ReleaseAllHands("传送开始", false, true);
	}

	// Token: 0x06018015 RID: 98325 RVA: 0x00730E14 File Offset: 0x0072F014
	[NullableContext(1)]
	public bool CheckObstacle(CharacterHoldingHandsComponent other)
	{
		if (this.ActorComp == null || other.ActorComp == null)
		{
			return false;
		}
		if (this.TraceElement == null)
		{
			this.CreateTraceElement();
		}
		this.TempVector.DeepCopy(this.ActorComp.ActorLocationProxy);
		this.TempVector2.DeepCopy(this.ActorComp.ActorUpProxy);
		this.TempVector2.MultiplyEqual((double)this.ActorComp.HalfHeight);
		this.TempVector.AdditionEqual(this.TempVector2);
		TraceElementCommon.Instance.SetStartLocation(this.TraceElement, this.TempVector);
		this.TempVector.DeepCopy(other.ActorComp.ActorLocationProxy);
		this.TempVector2.DeepCopy(other.ActorComp.ActorUpProxy);
		this.TempVector2.MultiplyEqual((double)other.ActorComp.HalfHeight);
		this.TempVector.AdditionEqual(this.TempVector2);
		TraceElementCommon.Instance.SetEndLocation(this.TraceElement, this.TempVector);
		return TraceElementCommon.Instance.SphereTrace(this.TraceElement, "CharacterHoldingHandsComponent.CheckBindingObstacle");
	}

	// Token: 0x06018016 RID: 98326 RVA: 0x00730F30 File Offset: 0x0072F130
	public void CreateTraceElement()
	{
		this.TraceElement = new UTraceSphereElement();
		this.TraceElement.bIsSingle = true;
		this.TraceElement.bIgnoreSelf = true;
		this.TraceElement.WorldContextObject = this.ActorComp.Owner;
		this.TraceElement.Radius = 10f;
		this.TraceElement.AddObjectTypeQuery(KuroObjectTypeQuery.WorldStatic);
		this.TraceElement.AddObjectTypeQuery(KuroObjectTypeQuery.WorldStaticIgnoreBullet);
	}

	// Token: 0x06018017 RID: 98327 RVA: 0x00730FA8 File Offset: 0x0072F1A8
	[NullableContext(1)]
	public static HoldingHandsParams LoadCommonParams()
	{
		string text = "/Game/Aki/Character/Role/Common/Data/DA/DA_HoldingHandsCommon.DA_HoldingHandsCommon";
		BP_HoldingHandsConfig_C bp_HoldingHandsConfig_C = ResourceSystem.Instance.Load<BP_HoldingHandsConfig_C>(text, "js_undefined");
		if (bp_HoldingHandsConfig_C == null || !bp_HoldingHandsConfig_C.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LJF;
			string message = "[CharacterHoldingHandsComponent.LoadCommonParams] 获取牵手参数DA失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("DaPath", text);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new HoldingHandsParams(null);
		}
		return CharacterHoldingHandsComponent.CommonParams = new HoldingHandsParams(bp_HoldingHandsConfig_C);
	}

	// Token: 0x06018018 RID: 98328 RVA: 0x00731014 File Offset: 0x0072F214
	private void CreateInputLayer()
	{
		if (this.InputLayer != null)
		{
			this.RemoveInputLayer();
		}
		this.InputLayer = (InputController.Instance.CreateInputLayer(EInputLayer.HoldingHands) as HoldingHandsInputLayer);
		this.InputLayer.Init(this);
		InputController.Instance.AddInputLayer(base.Entity.Id, this.InputLayer);
	}

	// Token: 0x06018019 RID: 98329 RVA: 0x0073106D File Offset: 0x0072F26D
	private void RemoveInputLayer()
	{
		if (this.InputLayer != null)
		{
			InputController.Instance.RemoveInputLayer(this.InputLayer);
			this.InputLayer.Clear();
			this.InputLayer = null;
		}
	}

	// Token: 0x0601801A RID: 98330 RVA: 0x00731099 File Offset: 0x0072F299
	public double GetLongPressDuration(EInputAction actionType)
	{
		if (actionType == 6)
		{
			return this.Params.LongPressDuration;
		}
		return 0.0;
	}

	// Token: 0x0601801B RID: 98331 RVA: 0x007310B9 File Offset: 0x0072F2B9
	public bool IsHoldingAction(EInputAction actionType)
	{
		return this.InputLayer != null && this.InputLayer.IsHoldingAction(actionType);
	}

	// Token: 0x0601801C RID: 98332 RVA: 0x007310D4 File Offset: 0x0072F2D4
	public HoldingHandsRelation OnLeaderSitDown()
	{
		if (this.SavedRelation != null)
		{
			return this.SavedRelation;
		}
		foreach (string key in this.RelationKeys.Values)
		{
			CharacterHoldingHandsComponent.<>c__DisplayClass94_0 CS$<>8__locals1 = new CharacterHoldingHandsComponent.<>c__DisplayClass94_0();
			CharacterHoldingHandsComponent.<>c__DisplayClass94_0 CS$<>8__locals2 = CS$<>8__locals1;
			HoldingHandsModel model = this.Model;
			CS$<>8__locals2.relation = ((model != null) ? model.GetRelation(key) : null);
			if (CS$<>8__locals1.relation != null && CS$<>8__locals1.relation is Binding && CS$<>8__locals1.relation.Follower != null)
			{
				this.SavedRelation = CS$<>8__locals1.relation;
				CS$<>8__locals1.relation.Follower.SavedRelation = CS$<>8__locals1.relation;
				CS$<>8__locals1.actionComp = base.Entity.GetComponent<CharacterActionComponent>();
				if (CS$<>8__locals1.actionComp != null)
				{
					CS$<>8__locals1.actionComp.OnLeaveSitDown = delegate()
					{
						CS$<>8__locals1.actionComp.OnLeaveSitDown = null;
						if (CS$<>8__locals1.relation == null)
						{
							return;
						}
						CharacterHoldingHandsComponent leader = CS$<>8__locals1.relation.Leader;
						if (leader != null)
						{
							leader.SetDisableInputTags(false);
						}
						CharacterHoldingHandsComponent follower = CS$<>8__locals1.relation.Follower;
						if (follower != null)
						{
							follower.SetDisableInputTags(false);
						}
						if (CS$<>8__locals1.relation.IsValid())
						{
							if (!CS$<>8__locals1.relation.Follower.IsSitDown())
							{
								CS$<>8__locals1.relation.Leader.OnLeaderAndFollowerStandUp();
							}
							return;
						}
						CharacterHoldingHandsComponent leader2 = CS$<>8__locals1.relation.Leader;
						if (leader2 != null)
						{
							leader2.ClearSavedRelation();
						}
						CharacterHoldingHandsComponent follower2 = CS$<>8__locals1.relation.Follower;
						if (follower2 == null)
						{
							return;
						}
						follower2.ClearSavedRelation();
					};
				}
				HoldingHandsController.Instance.RequestReleaseHands(key, "坐下临时断开", false, false);
				this.SetDisableInputTags(true);
				CS$<>8__locals1.relation.Follower.SetDisableInputTags(true);
				return CS$<>8__locals1.relation;
			}
		}
		return null;
	}

	// Token: 0x0601801D RID: 98333 RVA: 0x0073120C File Offset: 0x0072F40C
	public void ClearSavedRelation()
	{
		this.SavedRelation = null;
	}

	// Token: 0x0601801E RID: 98334 RVA: 0x00731218 File Offset: 0x0072F418
	public void OnLeaderAndFollowerStandUp()
	{
		if (this.SavedRelation == null)
		{
			return;
		}
		if (this.SavedRelation.IsValid())
		{
			HoldingHandsController.Instance.AddBinding(this.SavedRelation.Key, this.SavedRelation.Leader, this.SavedRelation.Follower, this.SavedRelation.LeaderHandType, false, false);
		}
		if (this.SavedRelation.Follower != null)
		{
			this.SavedRelation.Follower.ClearSavedRelation();
		}
		this.ClearSavedRelation();
	}

	// Token: 0x0601801F RID: 98335 RVA: 0x00731298 File Offset: 0x0072F498
	public bool IsSitDown()
	{
		Entity entity = base.Entity;
		CharacterActionComponent characterActionComponent = (entity != null) ? entity.GetComponent<CharacterActionComponent>() : null;
		if (characterActionComponent != null)
		{
			return characterActionComponent.IsSitDown;
		}
		Entity entity2 = base.Entity;
		NpcSitOnChairComponent npcSitOnChairComponent = (entity2 != null) ? entity2.GetComponent<NpcSitOnChairComponent>() : null;
		return npcSitOnChairComponent != null && npcSitOnChairComponent.Phase > NpcSitOnChair.ETaskPhase.None;
	}

	// Token: 0x06018020 RID: 98336 RVA: 0x007312E3 File Offset: 0x0072F4E3
	public bool IsSitDownWithHoldingHands()
	{
		return this.SavedRelation != null && this.IsSitDown();
	}

	// Token: 0x06018021 RID: 98337 RVA: 0x007312F8 File Offset: 0x0072F4F8
	public Entity GetHoldingHandsOtherEntity()
	{
		if (this.IsSitDownWithHoldingHands())
		{
			Entity entity = this.SavedRelation.Leader.Entity;
			Entity entity2 = this.SavedRelation.Follower.Entity;
			if (base.Entity != entity)
			{
				return entity;
			}
			return entity2;
		}
		else
		{
			EHoldingHandsRoleState roleState = this.GetRoleState();
			if (roleState == EHoldingHandsRoleState.Follower)
			{
				return this.GetLeaderInfo().Value.Item2.Entity;
			}
			if (roleState != EHoldingHandsRoleState.Leader)
			{
				return null;
			}
			return this.GetFollowerInfo().Value.Item2.Entity;
		}
	}

	// Token: 0x06018022 RID: 98338 RVA: 0x00731380 File Offset: 0x0072F580
	public void SetDisableInputTags(bool add = true)
	{
		if (this.TagComp == null)
		{
			return;
		}
		if (add && !this.DisableInputTagAdded)
		{
			foreach (int value in CharacterHoldingHandsComponent.DisableInputTagIds)
			{
				BaseTagComponent tagComp = this.TagComp;
				if (tagComp != null)
				{
					tagComp.AddTag(new int?(value));
				}
				this.DisableInputTagAdded = true;
			}
		}
		if (!add && this.DisableInputTagAdded)
		{
			foreach (int value2 in CharacterHoldingHandsComponent.DisableInputTagIds)
			{
				BaseTagComponent tagComp2 = this.TagComp;
				if (tagComp2 != null)
				{
					tagComp2.RemoveTag(new int?(value2));
				}
				this.DisableInputTagAdded = false;
			}
		}
	}

	// Token: 0x06018023 RID: 98339 RVA: 0x00731464 File Offset: 0x0072F664
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterHoldingHandsComponent characterHoldingHandsComponent = (CharacterHoldingHandsComponent)componentTemplate;
		if (characterHoldingHandsComponent.AnimInstance == null)
		{
			this.AnimInstance = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimInstance), "AnimInstance"))
		{
			return false;
		}
		if (characterHoldingHandsComponent.SkelMesh == null)
		{
			this.SkelMesh = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SkelMesh), "SkelMesh"))
		{
			return false;
		}
		if (characterHoldingHandsComponent.TraceElement == null)
		{
			this.TraceElement = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TraceElement), "TraceElement"))
		{
			return false;
		}
		if (characterHoldingHandsComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (characterHoldingHandsComponent.TagComp == null)
		{
			this.TagComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
		{
			return false;
		}
		if (characterHoldingHandsComponent.AnimComp == null)
		{
			this.AnimComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimComp), "AnimComp"))
		{
			return false;
		}
		if (characterHoldingHandsComponent.UnifiedStateComp == null)
		{
			this.UnifiedStateComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.UnifiedStateComp), "UnifiedStateComp"))
		{
			return false;
		}
		if (characterHoldingHandsComponent.MoveComp == null)
		{
			this.MoveComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
		{
			return false;
		}
		if (characterHoldingHandsComponent.CreatureDataComp == null)
		{
			this.CreatureDataComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
		{
			return false;
		}
		if (characterHoldingHandsComponent.SkillComp == null)
		{
			this.SkillComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SkillComp), "SkillComp"))
		{
			return false;
		}
		if (characterHoldingHandsComponent.InputLayer == null)
		{
			this.InputLayer = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.InputLayer), "InputLayer"))
		{
			return false;
		}
		if (characterHoldingHandsComponent.HandRuntimes == null)
		{
			this.HandRuntimes = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.HandRuntimes), "HandRuntimes"))
		{
			return false;
		}
		if (characterHoldingHandsComponent.RelationKeys == null)
		{
			this.RelationKeys = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RelationKeys), "RelationKeys"))
		{
			return false;
		}
		if (characterHoldingHandsComponent.TempVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector), "TempVector"))
		{
			return false;
		}
		if (characterHoldingHandsComponent.TempVector2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector2), "TempVector2"))
		{
			return false;
		}
		if (characterHoldingHandsComponent.MovePoint != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.MovePoint), "MovePoint"))
		{
			return false;
		}
		this.IsAutonomous = characterHoldingHandsComponent.IsAutonomous;
		this.IsAcceptingInvitation = characterHoldingHandsComponent.IsAcceptingInvitation;
		if (characterHoldingHandsComponent.SavedRelation == null)
		{
			this.SavedRelation = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SavedRelation), "SavedRelation"))
		{
			return false;
		}
		if (characterHoldingHandsComponent.DelayEndInvitationTimer == null)
		{
			this.DelayEndInvitationTimer = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DelayEndInvitationTimer), "DelayEndInvitationTimer"))
		{
			return false;
		}
		if (characterHoldingHandsComponent.TurnEndTimer == null)
		{
			this.TurnEndTimer = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TurnEndTimer), "TurnEndTimer"))
		{
			return false;
		}
		if (characterHoldingHandsComponent.TurnEndAction == null)
		{
			this.TurnEndAction = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TurnEndAction), "TurnEndAction"))
		{
			return false;
		}
		this.CanSkillInterrupt = characterHoldingHandsComponent.CanSkillInterrupt;
		this.EventsAdded = characterHoldingHandsComponent.EventsAdded;
		this.DisableInputTagAdded = characterHoldingHandsComponent.DisableInputTagAdded;
		if (characterHoldingHandsComponent.KeepFollowingConfigInternal == null)
		{
			this.KeepFollowingConfigInternal = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.KeepFollowingConfigInternal), "KeepFollowingConfigInternal"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x1700257F RID: 9599
	// (get) Token: 0x06018024 RID: 98340 RVA: 0x0073182C File Offset: 0x0072FA2C
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002580 RID: 9600
	// (get) Token: 0x06018025 RID: 98341 RVA: 0x0073182F File Offset: 0x0072FA2F
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002581 RID: 9601
	// (get) Token: 0x06018026 RID: 98342 RVA: 0x00731832 File Offset: 0x0072FA32
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002582 RID: 9602
	// (get) Token: 0x06018027 RID: 98343 RVA: 0x00731835 File Offset: 0x0072FA35
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400CE0A RID: 52746
	private const int SKILL_ID_INVITATION_START = 401101;

	// Token: 0x0400CE0B RID: 52747
	private const int SKILL_ID_INVITATION_END = 401102;

	// Token: 0x0400CE0C RID: 52748
	public UKuroAnimInstanceChar AnimInstance;

	// Token: 0x0400CE0D RID: 52749
	public USkeletalMeshComponent SkelMesh;

	// Token: 0x0400CE0E RID: 52750
	public UTraceSphereElement TraceElement;

	// Token: 0x0400CE0F RID: 52751
	public CharacterActorComponent ActorComp;

	// Token: 0x0400CE10 RID: 52752
	private BaseTagComponent TagComp;

	// Token: 0x0400CE11 RID: 52753
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400CE12 RID: 52754
	private BaseUnifiedStateComponent UnifiedStateComp;

	// Token: 0x0400CE13 RID: 52755
	public BaseMoveComponent MoveComp;

	// Token: 0x0400CE14 RID: 52756
	private CreatureDataComponent CreatureDataComp;

	// Token: 0x0400CE15 RID: 52757
	private BaseSkillComponent SkillComp;

	// Token: 0x0400CE16 RID: 52758
	private HoldingHandsInputLayer InputLayer;

	// Token: 0x0400CE17 RID: 52759
	[Nullable(1)]
	private Dictionary<EHandType, HandRuntime> HandRuntimes = new Dictionary<EHandType, HandRuntime>();

	// Token: 0x0400CE18 RID: 52760
	[Nullable(1)]
	private Dictionary<EHandType, string> RelationKeys = new Dictionary<EHandType, string>();

	// Token: 0x0400CE19 RID: 52761
	[Nullable(1)]
	private readonly global::Vector TempVector = global::Vector.Create();

	// Token: 0x0400CE1A RID: 52762
	[Nullable(1)]
	private readonly global::Vector TempVector2 = global::Vector.Create();

	// Token: 0x0400CE1B RID: 52763
	[Nullable(1)]
	private readonly global::Vector MovePoint = global::Vector.Create();

	// Token: 0x0400CE1C RID: 52764
	private bool IsAutonomous;

	// Token: 0x0400CE1D RID: 52765
	private bool IsAcceptingInvitation;

	// Token: 0x0400CE1E RID: 52766
	private HoldingHandsRelation SavedRelation;

	// Token: 0x0400CE1F RID: 52767
	private TimerHandle DelayEndInvitationTimer;

	// Token: 0x0400CE20 RID: 52768
	private TimerHandle TurnEndTimer;

	// Token: 0x0400CE21 RID: 52769
	private TTimerAction TurnEndAction;

	// Token: 0x0400CE22 RID: 52770
	public bool CanSkillInterrupt = true;

	// Token: 0x0400CE23 RID: 52771
	private bool EventsAdded;

	// Token: 0x0400CE24 RID: 52772
	private bool DisableInputTagAdded;

	// Token: 0x0400CE25 RID: 52773
	private BP_KeepFollowingConfig_C KeepFollowingConfigInternal;

	// Token: 0x0400CE26 RID: 52774
	private static HoldingHandsParams CommonParams;

	// Token: 0x0400CE27 RID: 52775
	[Nullable(1)]
	private static HashSet<long> ListenSkillIds;

	// Token: 0x0400CE28 RID: 52776
	[Nullable(1)]
	private static List<int> DisableInputTagIds;
}
