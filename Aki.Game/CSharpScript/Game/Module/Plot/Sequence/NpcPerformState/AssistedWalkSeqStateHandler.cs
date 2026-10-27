using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Data.Level.AssistedWalk;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move.AssistedWalk;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move.AttachMove;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence.NpcPerformState
{
	// Token: 0x02005028 RID: 20520
	[NullableContext(1)]
	[Nullable(0)]
	public class AssistedWalkSeqStateHandler : SeqNpcPerformStateHandler
	{
		// Token: 0x17008020 RID: 32800
		// (get) Token: 0x0603484C RID: 215116 RVA: 0x00C5FC61 File Offset: 0x00C5DE61
		public override ENpcGroupPerformType PerformType
		{
			get
			{
				return ENpcGroupPerformType.SupportedWalking;
			}
		}

		// Token: 0x17008021 RID: 32801
		// (get) Token: 0x0603484D RID: 215117 RVA: 0x00C5FC64 File Offset: 0x00C5DE64
		public override ENpcRelationType RelationType
		{
			get
			{
				return ENpcRelationType.AssistedWalk;
			}
		}

		// Token: 0x0603484E RID: 215118 RVA: 0x00C5FC68 File Offset: 0x00C5DE68
		[return: Nullable(2)]
		public override NpcRelation Capture(string key)
		{
			AttachMoveRelation relation = AttachMoveUtils.Instance.GetRelation(key);
			if (relation == null)
			{
				return null;
			}
			return new AssistedWalkSeqRelation
			{
				Key = key,
				LeaderEntityId = relation.LeaderEntityId,
				FollowerEntityId = relation.FollowerEntityId
			};
		}

		// Token: 0x0603484F RID: 215119 RVA: 0x00C5FCAC File Offset: 0x00C5DEAC
		public unsafe override void Restore(NpcRelation relation, string reason)
		{
			AssistedWalkSeqRelation assistedWalkSeqRelation = relation as AssistedWalkSeqRelation;
			Entity entity = EntitySystem.Instance.Get(assistedWalkSeqRelation.LeaderEntityId);
			Entity entity2 = EntitySystem.Instance.Get(assistedWalkSeqRelation.FollowerEntityId);
			CharacterActorComponent characterActorComponent = (entity != null) ? entity.GetComponent<CharacterActorComponent>() : null;
			BaseActorComponent baseActorComponent = (entity2 != null) ? entity2.GetComponent<BaseActorComponent>() : null;
			BaseMoveComponent baseMoveComponent = (entity2 != null) ? entity2.GetComponent<BaseMoveComponent>() : null;
			if (characterActorComponent == null || !characterActorComponent.Valid || (baseActorComponent == null || !baseActorComponent.Valid) || baseMoveComponent == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "[SeqNpcPerformState] 搀扶恢复失败：Leader / Follower 组件无效";
				<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Key", assistedWalkSeqRelation.Key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("LeaderEntityId", assistedWalkSeqRelation.LeaderEntityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("FollowerEntityId", assistedWalkSeqRelation.FollowerEntityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("LeaderValid", (characterActorComponent != null) ? new bool?(characterActorComponent.Valid) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("FollowerValid", (baseActorComponent != null) ? new bool?(baseActorComponent.Valid) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("FollowerMoveComp", baseMoveComponent != null);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
				return;
			}
			this.StartAssistedWalkImmediate(assistedWalkSeqRelation.Key, characterActorComponent, baseActorComponent, baseMoveComponent, reason);
		}

		// Token: 0x06034850 RID: 215120 RVA: 0x00C5FE58 File Offset: 0x00C5E058
		private unsafe void StartAssistedWalkImmediate(string key, CharacterActorComponent leader, BaseActorComponent followerActor, BaseMoveComponent followerMoveComp, string reason)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "[AttachMove][AssistedWalk] RequestStartImmediate";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Key", key);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "Leader";
			Entity entity = leader.Entity;
			ptr = new ValueTuple<string, object>(item, (entity != null) ? new int?(entity.Id) : null);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
			string item2 = "Follower";
			Entity entity2 = followerActor.Entity;
			ptr2 = new ValueTuple<string, object>(item2, (entity2 != null) ? new int?(entity2.Id) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Reason", reason);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			Entity entity3 = leader.Entity;
			int leaderId = (entity3 != null) ? entity3.Id : 0;
			Entity entity4 = followerActor.Entity;
			int followerId = (entity4 != null) ? entity4.Id : 0;
			AttachMoveUtils.Instance.DeduplicateRelations(key, leaderId, followerId, "[AttachMove][AssistedWalk][Immediate]");
			BP_AssistedWalkConfig_C bp_AssistedWalkConfig_C = ResourceSystem.Instance.Load<BP_AssistedWalkConfig_C>("/Game/Aki/Data/Level/AssistedWalk/DA_DefaultAssistedWalkConfig.DA_DefaultAssistedWalkConfig", "js_undefined");
			if (bp_AssistedWalkConfig_C == null || !bp_AssistedWalkConfig_C.IsValid())
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.Movement;
				ELogAuthor author2 = ELogAuthor.HYF;
				string message2 = "[AttachMove][AssistedWalk][Immediate] 获取搀扶配置DA失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("DaPath", "/Game/Aki/Data/Level/AssistedWalk/DA_DefaultAssistedWalkConfig.DA_DefaultAssistedWalkConfig");
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			AssistedWalkParams assistedWalkParams = new AssistedWalkParams(bp_AssistedWalkConfig_C);
			AssistedWalkUtils.Instance.SendHoldHandRequest(leader, followerActor, global::EHandType.Right, true);
			this.TeleportFollowerToAttachPose(leader, followerActor, assistedWalkParams.AttachSocket, assistedWalkParams.StartTransform);
			bool exited = false;
			AssistedWalkUtils.Instance.StartAssistedWalkBoth(leader, followerMoveComp, bp_AssistedWalkConfig_C, false, delegate(bool isLeader)
			{
				if (exited)
				{
					return;
				}
				exited = true;
				if (isLeader)
				{
					MoveToLocationController moveController = followerMoveComp.MoveController;
					if (moveController != null)
					{
						moveController.StopAssistedWalk();
					}
				}
				else
				{
					BaseMoveComponent moveComp = leader.MoveComp;
					if (moveComp != null)
					{
						MoveToLocationController moveController2 = moveComp.MoveController;
						if (moveController2 != null)
						{
							moveController2.StopAssistedWalk();
						}
					}
				}
				AssistedWalkUtils.Instance.PushOutLeader(leader, followerActor);
				AttachMoveUtils.Instance.DeleteRelation(key, "底层 endCallback 自然结束(Immediate)");
			});
			AttachMoveUtils.Instance.AddRelation(key, leader, followerActor, followerMoveComp, delegate
			{
				BaseMoveComponent moveComp = leader.MoveComp;
				if (moveComp != null)
				{
					MoveToLocationController moveController = moveComp.MoveController;
					if (moveController != null)
					{
						moveController.StopAssistedWalk();
					}
				}
				MoveToLocationController moveController2 = followerMoveComp.MoveController;
				if (moveController2 == null)
				{
					return;
				}
				moveController2.StopAssistedWalk();
			});
		}

		// Token: 0x06034851 RID: 215121 RVA: 0x00C60098 File Offset: 0x00C5E298
		private unsafe void TeleportFollowerToAttachPose(CharacterActorComponent leader, BaseActorComponent followerActor, string socket, global::Transform attachTransform)
		{
			TsBaseCharacter actor = leader.Actor;
			USkeletalMeshComponent uskeletalMeshComponent = (actor != null) ? actor.Mesh : null;
			if (uskeletalMeshComponent == null || !uskeletalMeshComponent.IsValid() || socket.Length < 1)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "[AttachMove][AssistedWalk][Immediate] 瞬移 Follower 失败：Leader Mesh / Socket 无效";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Socket", socket);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("LeaderPbId", leader.CreatureData.GetPbDataId());
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			FName inSocketName = new FName(socket);
			FTransformDouble ftransformDouble = uskeletalMeshComponent.D_GetSocketTransform(inSocketName, ERelativeTransformSpace.RTS_Actor);
			FTransformDouble ftransformDouble2 = attachTransform.ToUeTransform();
			FTransformDouble ftransformDouble3 = UKismetMathLibrary.D_ComposeTransforms(ftransformDouble2, ftransformDouble);
			global::Transform transform = global::Transform.Create(leader.ActorTransform);
			ftransformDouble2 = transform.ToUeTransform();
			FTransformDouble ftransformDouble4 = UKismetMathLibrary.D_ComposeTransforms(ftransformDouble3, ftransformDouble2);
			FQuat rotation = ftransformDouble4.GetRotation();
			FRotator rotation2 = UKismetMathLibrary.Quat_Rotator(rotation);
			followerActor.SetActorLocationAndRotation(ftransformDouble4.GetTranslation(), rotation2, "AssistedWalk.ImmediateTeleport", false, null);
			this.SyncNpcLocationToServer(followerActor);
		}

		// Token: 0x06034852 RID: 215122 RVA: 0x00C601B8 File Offset: 0x00C5E3B8
		private unsafe void SyncNpcLocationToServer(BaseActorComponent followerActor)
		{
			Entity entity = followerActor.Entity;
			int? num = (entity != null) ? new int?(entity.Id) : null;
			if (num == null)
			{
				return;
			}
			if (WorldFunctionLibrary.GetEntityTypeByEntity(num.Value) != 1)
			{
				return;
			}
			EntitySimplyMoveInfoPackagePush entitySimplyMoveInfoPackagePush = EntitySimplyMoveInfoPackagePush.Create();
			EntitySimplyMoveInfo entitySimplyMoveInfo = EntitySimplyMoveInfo.Create();
			entitySimplyMoveInfo.EntityId = MathUtils.Instance.NumberToLong(followerActor.CreatureData.GetCreatureDataId());
			entitySimplyMoveInfo.Location = followerActor.ActorLocationProxy.ToProtocolVector();
			entitySimplyMoveInfo.Rotation = followerActor.ActorRotationProxy.ToProtocolRotator();
			entitySimplyMoveInfoPackagePush.MoveInfos.Add(entitySimplyMoveInfo);
			Net.Instance.Send(EPushMessageId.EntitySimplyMoveInfoPackagePush, entitySimplyMoveInfoPackagePush);
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "[AttachMove][AssistedWalk][Immediate] 向服务器同步NPC位置";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("实体ID", entitySimplyMoveInfo.EntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("X", entitySimplyMoveInfo.Location.X);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Y", entitySimplyMoveInfo.Location.Y);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Z", entitySimplyMoveInfo.Location.Z);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
	}
}
