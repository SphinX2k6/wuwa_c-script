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

// Token: 0x02003067 RID: 12391
[NullableContext(2)]
[Nullable(0)]
public class CharacterHoldingHandsComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x0601A62C RID: 108076 RVA: 0x00708434 File Offset: 0x00706634
	static CharacterHoldingHandsComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterHoldingHandsComponent.CreateStaticDefaultValue), new Action(CharacterHoldingHandsComponent.ResetStaticDefaultValue));
	}

	// Token: 0x0601A62D RID: 108077 RVA: 0x00708454 File Offset: 0x00706654
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

	// Token: 0x0601A62E RID: 108078 RVA: 0x0070857E File Offset: 0x0070677E
	public static void ResetStaticDefaultValue()
	{
		CharacterHoldingHandsComponent.CommonParams = null;
		CharacterHoldingHandsComponent.ListenSkillIds = null;
		CharacterHoldingHandsComponent.DisableInputTagIds = null;
	}

	// Token: 0x1700244A RID: 9290
	// (get) Token: 0x0601A62F RID: 108079 RVA: 0x00708592 File Offset: 0x00706792
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

	// Token: 0x1700244B RID: 9291
	// (get) Token: 0x0601A630 RID: 108080 RVA: 0x007085AC File Offset: 0x007067AC
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

	// Token: 0x0601A631 RID: 108081 RVA: 0x00708600 File Offset: 0x00706800
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

	// Token: 0x0601A632 RID: 108082 RVA: 0x007086F4 File Offset: 0x007068F4
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

	// Token: 0x0601A633 RID: 108083 RVA: 0x007087E8 File Offset: 0x007069E8
	protected override bool OnEnd()
	{
		this.ReleaseAllHands("实体销毁", true, false);
		this.TryRemoveEvents();
		return true;
	}

	// Token: 0x0601A634 RID: 108084 RVA: 0x00708800 File Offset: 0x00706A00
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

	// Token: 0x0601A635 RID: 108085 RVA: 0x007088D8 File Offset: 0x00706AD8
	private bool CheckDisableTags(EHoldingHandsRoleState roleState)
	{
		return this.TagComp.HasAnyTag(this.Params.DisableTags);
	}

	// Token: 0x0601A636 RID: 108086 RVA: 0x007088F0 File Offset: 0x00706AF0
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

	// Token: 0x1700244C RID: 9292
	// (get) Token: 0x0601A637 RID: 108087 RVA: 0x007089A5 File Offset: 0x00706BA5
	public HoldingHandsModel Model
	{
		get
		{
			return HoldingHandsModel.Instance;
		}
	}

	// Token: 0x0601A638 RID: 108088 RVA: 0x007089AC File Offset: 0x00706BAC
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

	// Token: 0x0601A639 RID: 108089 RVA: 0x007089E4 File Offset: 0x00706BE4
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

	// Token: 0x0601A63A RID: 108090 RVA: 0x00708A18 File Offset: 0x00706C18
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

	// Token: 0x0601A63B RID: 108091 RVA: 0x00708A9C File Offset: 0x00706C9C
	public IkTarget GetHandIkTarget(EHandType handType)
	{
		HandRuntime handRuntime;
		if (!this.HandRuntimes.TryGetValue(handType, out handRuntime))
		{
			return null;
		}
		return handRuntime.IkTarget;
	}

	// Token: 0x0601A63C RID: 108092 RVA: 0x00708AC4 File Offset: 0x00706CC4
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

	// Token: 0x0601A63D RID: 108093 RVA: 0x00708B5C File Offset: 0x00706D5C
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

	// Token: 0x0601A63E RID: 108094 RVA: 0x00708C00 File Offset: 0x00706E00
	public bool GetIsHoldingHands()
	{
		return this.GetRoleState() == EHoldingHandsRoleState.Leader;
	}

	// Token: 0x0601A63F RID: 108095 RVA: 0x00708C0B File Offset: 0x00706E0B
	public bool GetIsBeHoldingHands()
	{
		return this.GetRoleState() == EHoldingHandsRoleState.Follower;
	}

	// Token: 0x0601A640 RID: 108096 RVA: 0x00708C16 File Offset: 0x00706E16
	public bool GetIsAcceptingInvitation()
	{
		return this.IsAcceptingInvitation;
	}

	// Token: 0x0601A641 RID: 108097 RVA: 0x00708C20 File Offset: 0x00706E20
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

	// Token: 0x0601A642 RID: 108098 RVA: 0x00708CB8 File Offset: 0x00706EB8
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

	// Token: 0x0601A643 RID: 108099 RVA: 0x00708D50 File Offset: 0x00706F50
	public bool GetHandReachable(EHandType hand)
	{
		HoldingHandsRelation relationByHand = this.GetRelationByHand(hand);
		return relationByHand != null && relationByHand is Binding && (relationByHand as Binding).Reachable;
	}

	// Token: 0x0601A644 RID: 108100 RVA: 0x00708D7D File Offset: 0x00706F7D
	public bool GetIfHanding()
	{
		return this.GetRoleState() > EHoldingHandsRoleState.None;
	}

	// Token: 0x0601A645 RID: 108101 RVA: 0x00708D88 File Offset: 0x00706F88
	[NullableContext(1)]
	public static double GetMaxReachableDistance(Binding binding)
	{
		return binding.LeaderRuntime.MaxBendLength + binding.FollowerRuntime.MaxBendLength;
	}

	// Token: 0x0601A646 RID: 108102 RVA: 0x00708DA1 File Offset: 0x00706FA1
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

	// Token: 0x0601A647 RID: 108103 RVA: 0x00708DCC File Offset: 0x00706FCC
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

	// Token: 0x0601A648 RID: 108104 RVA: 0x00708F24 File Offset: 0x00707124
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

	// Token: 0x0601A649 RID: 108105 RVA: 0x00709158 File Offset: 0x00707358
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

	// Token: 0x0601A64A RID: 108106 RVA: 0x00709248 File Offset: 0x00707448
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

	// Token: 0x0601A64B RID: 108107 RVA: 0x00709500 File Offset: 0x00707700
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

	// Token: 0x0601A64C RID: 108108 RVA: 0x00709680 File Offset: 0x00707880
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

	// Token: 0x0601A64D RID: 108109 RVA: 0x0070973C File Offset: 0x0070793C
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

	// Token: 0x0601A64E RID: 108110 RVA: 0x00709874 File Offset: 0x00707A74
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

	// Token: 0x0601A64F RID: 108111 RVA: 0x007098DC File Offset: 0x00707ADC
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

	// Token: 0x0601A650 RID: 108112 RVA: 0x00709930 File Offset: 0x00707B30
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

	// Token: 0x0601A651 RID: 108113 RVA: 0x00709AB0 File Offset: 0x00707CB0
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

	// Token: 0x0601A652 RID: 108114 RVA: 0x00709B4C File Offset: 0x00707D4C
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

	// Token: 0x0601A653 RID: 108115 RVA: 0x00709BBC File Offset: 0x00707DBC
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

	// Token: 0x0601A654 RID: 108116 RVA: 0x00709D88 File Offset: 0x00707F88
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

	// Token: 0x0601A655 RID: 108117 RVA: 0x00709E50 File Offset: 0x00708050
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

	// Token: 0x0601A656 RID: 108118 RVA: 0x00709F28 File Offset: 0x00708128
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

	// Token: 0x0601A657 RID: 108119 RVA: 0x00709F84 File Offset: 0x00708184
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

	// Token: 0x0601A658 RID: 108120 RVA: 0x0070A00F File Offset: 0x0070820F
	public void OnlyStopAiMove()
	{
		BaseMoveComponent moveComp = this.MoveComp;
		if (moveComp == null)
		{
			return;
		}
		moveComp.MoveController.StopKeepHoldingHands();
	}

	// Token: 0x0601A659 RID: 108121 RVA: 0x0070A028 File Offset: 0x00708228
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

	// Token: 0x0601A65A RID: 108122 RVA: 0x0070A0F4 File Offset: 0x007082F4
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

	// Token: 0x0601A65B RID: 108123 RVA: 0x0070A190 File Offset: 0x00708390
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

	// Token: 0x0601A65C RID: 108124 RVA: 0x0070A22C File Offset: 0x0070842C
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

	// Token: 0x0601A65D RID: 108125 RVA: 0x0070A2B4 File Offset: 0x007084B4
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

	// Token: 0x0601A65E RID: 108126 RVA: 0x0070A354 File Offset: 0x00708554
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

	// Token: 0x0601A65F RID: 108127 RVA: 0x0070A4B8 File Offset: 0x007086B8
	[NullableContext(1)]
	private void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		this.ReleaseAllHands("换人", false, true);
	}

	// Token: 0x0601A660 RID: 108128 RVA: 0x0070A4C7 File Offset: 0x007086C7
	private void OnTeleportStart(bool _)
	{
		this.ReleaseAllHands("传送开始", false, true);
	}

	// Token: 0x0601A661 RID: 108129 RVA: 0x0070A4D8 File Offset: 0x007086D8
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

	// Token: 0x0601A662 RID: 108130 RVA: 0x0070A5F4 File Offset: 0x007087F4
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

	// Token: 0x0601A663 RID: 108131 RVA: 0x0070A66C File Offset: 0x0070886C
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

	// Token: 0x0601A664 RID: 108132 RVA: 0x0070A6D8 File Offset: 0x007088D8
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

	// Token: 0x0601A665 RID: 108133 RVA: 0x0070A731 File Offset: 0x00708931
	private void RemoveInputLayer()
	{
		if (this.InputLayer != null)
		{
			InputController.Instance.RemoveInputLayer(this.InputLayer);
			this.InputLayer.Clear();
			this.InputLayer = null;
		}
	}

	// Token: 0x0601A666 RID: 108134 RVA: 0x0070A75D File Offset: 0x0070895D
	public double GetLongPressDuration(EInputAction actionType)
	{
		if (actionType == 6)
		{
			return this.Params.LongPressDuration;
		}
		return 0.0;
	}

	// Token: 0x0601A667 RID: 108135 RVA: 0x0070A77D File Offset: 0x0070897D
	public bool IsHoldingAction(EInputAction actionType)
	{
		return this.InputLayer != null && this.InputLayer.IsHoldingAction(actionType);
	}

	// Token: 0x0601A668 RID: 108136 RVA: 0x0070A798 File Offset: 0x00708998
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

	// Token: 0x0601A669 RID: 108137 RVA: 0x0070A8D0 File Offset: 0x00708AD0
	public void ClearSavedRelation()
	{
		this.SavedRelation = null;
	}

	// Token: 0x0601A66A RID: 108138 RVA: 0x0070A8DC File Offset: 0x00708ADC
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

	// Token: 0x0601A66B RID: 108139 RVA: 0x0070A95C File Offset: 0x00708B5C
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

	// Token: 0x0601A66C RID: 108140 RVA: 0x0070A9A7 File Offset: 0x00708BA7
	public bool IsSitDownWithHoldingHands()
	{
		return this.SavedRelation != null && this.IsSitDown();
	}

	// Token: 0x0601A66D RID: 108141 RVA: 0x0070A9BC File Offset: 0x00708BBC
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

	// Token: 0x0601A66E RID: 108142 RVA: 0x0070AA44 File Offset: 0x00708C44
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

	// Token: 0x0601A66F RID: 108143 RVA: 0x0070AB28 File Offset: 0x00708D28
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterHoldingHandsComponent characterHoldingHandsComponent = (CharacterHoldingHandsComponent)componentTemplate;
		if (base.CanResetComponentProperty("AnimInstance"))
		{
			if (characterHoldingHandsComponent.AnimInstance == null)
			{
				this.AnimInstance = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UKuroAnimInstanceChar>(this.AnimInstance), "AnimInstance"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SkelMesh"))
		{
			if (characterHoldingHandsComponent.SkelMesh == null)
			{
				this.SkelMesh = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<USkeletalMeshComponent>(this.SkelMesh), "SkelMesh"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TraceElement"))
		{
			if (characterHoldingHandsComponent.TraceElement == null)
			{
				this.TraceElement = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UTraceSphereElement>(this.TraceElement), "TraceElement"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (characterHoldingHandsComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagComp"))
		{
			if (characterHoldingHandsComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AnimComp"))
		{
			if (characterHoldingHandsComponent.AnimComp == null)
			{
				this.AnimComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterAnimationComponent>(this.AnimComp), "AnimComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("UnifiedStateComp"))
		{
			if (characterHoldingHandsComponent.UnifiedStateComp == null)
			{
				this.UnifiedStateComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseUnifiedStateComponent>(this.UnifiedStateComp), "UnifiedStateComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MoveComp"))
		{
			if (characterHoldingHandsComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseMoveComponent>(this.MoveComp), "MoveComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CreatureDataComp"))
		{
			if (characterHoldingHandsComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SkillComp"))
		{
			if (characterHoldingHandsComponent.SkillComp == null)
			{
				this.SkillComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseSkillComponent>(this.SkillComp), "SkillComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("InputLayer"))
		{
			if (characterHoldingHandsComponent.InputLayer == null)
			{
				this.InputLayer = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<HoldingHandsInputLayer>(this.InputLayer), "InputLayer"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("HandRuntimes"))
		{
			if (characterHoldingHandsComponent.HandRuntimes == null)
			{
				this.HandRuntimes = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<EHandType, HandRuntime>>(this.HandRuntimes), "HandRuntimes"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("RelationKeys"))
		{
			if (characterHoldingHandsComponent.RelationKeys == null)
			{
				this.RelationKeys = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<EHandType, string>>(this.RelationKeys), "RelationKeys"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TempVector") && characterHoldingHandsComponent.TempVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TempVector), "TempVector"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TempVector2") && characterHoldingHandsComponent.TempVector2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TempVector2), "TempVector2"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("MovePoint") && characterHoldingHandsComponent.MovePoint != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.MovePoint), "MovePoint"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("IsAutonomous"))
		{
			this.IsAutonomous = characterHoldingHandsComponent.IsAutonomous;
		}
		if (base.CanResetComponentProperty("IsAcceptingInvitation"))
		{
			this.IsAcceptingInvitation = characterHoldingHandsComponent.IsAcceptingInvitation;
		}
		if (base.CanResetComponentProperty("SavedRelation"))
		{
			if (characterHoldingHandsComponent.SavedRelation == null)
			{
				this.SavedRelation = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<HoldingHandsRelation>(this.SavedRelation), "SavedRelation"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("DelayEndInvitationTimer"))
		{
			if (characterHoldingHandsComponent.DelayEndInvitationTimer == null)
			{
				this.DelayEndInvitationTimer = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.DelayEndInvitationTimer), "DelayEndInvitationTimer"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TurnEndTimer"))
		{
			if (characterHoldingHandsComponent.TurnEndTimer == null)
			{
				this.TurnEndTimer = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.TurnEndTimer), "TurnEndTimer"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TurnEndAction"))
		{
			if (characterHoldingHandsComponent.TurnEndAction == null)
			{
				this.TurnEndAction = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TTimerAction>(this.TurnEndAction), "TurnEndAction"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CanSkillInterrupt"))
		{
			this.CanSkillInterrupt = characterHoldingHandsComponent.CanSkillInterrupt;
		}
		if (base.CanResetComponentProperty("EventsAdded"))
		{
			this.EventsAdded = characterHoldingHandsComponent.EventsAdded;
		}
		if (base.CanResetComponentProperty("DisableInputTagAdded"))
		{
			this.DisableInputTagAdded = characterHoldingHandsComponent.DisableInputTagAdded;
		}
		if (base.CanResetComponentProperty("KeepFollowingConfigInternal"))
		{
			if (characterHoldingHandsComponent.KeepFollowingConfigInternal == null)
			{
				this.KeepFollowingConfigInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BP_KeepFollowingConfig_C>(this.KeepFollowingConfigInternal), "KeepFollowingConfigInternal"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400CA30 RID: 51760
	private const int SKILL_ID_INVITATION_START = 401101;

	// Token: 0x0400CA31 RID: 51761
	private const int SKILL_ID_INVITATION_END = 401102;

	// Token: 0x0400CA32 RID: 51762
	public UKuroAnimInstanceChar AnimInstance;

	// Token: 0x0400CA33 RID: 51763
	public USkeletalMeshComponent SkelMesh;

	// Token: 0x0400CA34 RID: 51764
	public UTraceSphereElement TraceElement;

	// Token: 0x0400CA35 RID: 51765
	public CharacterActorComponent ActorComp;

	// Token: 0x0400CA36 RID: 51766
	private BaseTagComponent TagComp;

	// Token: 0x0400CA37 RID: 51767
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400CA38 RID: 51768
	private BaseUnifiedStateComponent UnifiedStateComp;

	// Token: 0x0400CA39 RID: 51769
	public BaseMoveComponent MoveComp;

	// Token: 0x0400CA3A RID: 51770
	private CreatureDataComponent CreatureDataComp;

	// Token: 0x0400CA3B RID: 51771
	private BaseSkillComponent SkillComp;

	// Token: 0x0400CA3C RID: 51772
	private HoldingHandsInputLayer InputLayer;

	// Token: 0x0400CA3D RID: 51773
	[Nullable(1)]
	private Dictionary<EHandType, HandRuntime> HandRuntimes = new Dictionary<EHandType, HandRuntime>();

	// Token: 0x0400CA3E RID: 51774
	[Nullable(1)]
	private Dictionary<EHandType, string> RelationKeys = new Dictionary<EHandType, string>();

	// Token: 0x0400CA3F RID: 51775
	[Nullable(1)]
	private readonly global::Vector TempVector = global::Vector.Create();

	// Token: 0x0400CA40 RID: 51776
	[Nullable(1)]
	private readonly global::Vector TempVector2 = global::Vector.Create();

	// Token: 0x0400CA41 RID: 51777
	[Nullable(1)]
	private readonly global::Vector MovePoint = global::Vector.Create();

	// Token: 0x0400CA42 RID: 51778
	private bool IsAutonomous;

	// Token: 0x0400CA43 RID: 51779
	private bool IsAcceptingInvitation;

	// Token: 0x0400CA44 RID: 51780
	private HoldingHandsRelation SavedRelation;

	// Token: 0x0400CA45 RID: 51781
	private TimerHandle DelayEndInvitationTimer;

	// Token: 0x0400CA46 RID: 51782
	private TimerHandle TurnEndTimer;

	// Token: 0x0400CA47 RID: 51783
	private TTimerAction TurnEndAction;

	// Token: 0x0400CA48 RID: 51784
	public bool CanSkillInterrupt = true;

	// Token: 0x0400CA49 RID: 51785
	private bool EventsAdded;

	// Token: 0x0400CA4A RID: 51786
	private bool DisableInputTagAdded;

	// Token: 0x0400CA4B RID: 51787
	private BP_KeepFollowingConfig_C KeepFollowingConfigInternal;

	// Token: 0x0400CA4C RID: 51788
	private static HoldingHandsParams CommonParams;

	// Token: 0x0400CA4D RID: 51789
	[Nullable(1)]
	private static HashSet<long> ListenSkillIds;

	// Token: 0x0400CA4E RID: 51790
	[Nullable(1)]
	private static List<int> DisableInputTagIds;
}
