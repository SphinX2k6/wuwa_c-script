using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.AttachMove;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move.AttachMove
{
	// Token: 0x020063B8 RID: 25528
	[NullableContext(1)]
	[Nullable(0)]
	public class AttachMoveUtils : Singleton
	{
		// Token: 0x0603DE46 RID: 253510 RVA: 0x011F6A62 File Offset: 0x011F4C62
		public AttachMoveUtils()
		{
			this.Relations = new Dictionary<string, AttachMoveRelation>();
		}

		// Token: 0x0603DE47 RID: 253511 RVA: 0x011F6A78 File Offset: 0x011F4C78
		[return: Nullable(2)]
		public AttachMoveRelation GetRelation(string key)
		{
			AttachMoveRelation result;
			this.Relations.TryGetValue(key, out result);
			return result;
		}

		// Token: 0x0603DE48 RID: 253512 RVA: 0x011F6A98 File Offset: 0x011F4C98
		[NullableContext(2)]
		public AttachMoveRelation GetRelationByEntityId(int entityId)
		{
			if (entityId <= 0)
			{
				return null;
			}
			foreach (AttachMoveRelation attachMoveRelation in this.Relations.Values)
			{
				if (attachMoveRelation.LeaderEntityId == entityId || attachMoveRelation.FollowerEntityId == entityId)
				{
					return attachMoveRelation;
				}
			}
			return null;
		}

		// Token: 0x0603DE49 RID: 253513 RVA: 0x011F6B08 File Offset: 0x011F4D08
		public unsafe AttachMoveRelation AddRelation(string key, CharacterActorComponent leader, BaseActorComponent followerActor, BaseMoveComponent followerMoveComp, [Nullable(2)] Action stopFn = null)
		{
			AttachMoveRelation attachMoveRelation = new AttachMoveRelation();
			attachMoveRelation.Key = key;
			attachMoveRelation.Leader = leader;
			attachMoveRelation.FollowerActor = followerActor;
			attachMoveRelation.FollowerMoveComp = followerMoveComp;
			AttachMoveRelation attachMoveRelation2 = attachMoveRelation;
			Entity entity = leader.Entity;
			attachMoveRelation2.LeaderEntityId = ((entity != null) ? entity.Id : 0);
			AttachMoveRelation attachMoveRelation3 = attachMoveRelation;
			Entity entity2 = followerActor.Entity;
			attachMoveRelation3.FollowerEntityId = ((entity2 != null) ? entity2.Id : 0);
			attachMoveRelation.StopFn = stopFn;
			this.Relations[key] = attachMoveRelation;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[AttachMove] AddRelation";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Key", key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Leader", attachMoveRelation.LeaderEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Follower", attachMoveRelation.FollowerEntityId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return attachMoveRelation;
		}

		// Token: 0x0603DE4A RID: 253514 RVA: 0x011F6C00 File Offset: 0x011F4E00
		public unsafe void DeleteRelation(string key, string reason)
		{
			AttachMoveRelation attachMoveRelation;
			this.Relations.TryGetValue(key, out attachMoveRelation);
			if (attachMoveRelation == null)
			{
				return;
			}
			this.Relations.Remove(key);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[AttachMove] DeleteRelation";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Key", key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Reason", reason);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0603DE4B RID: 253515 RVA: 0x011F6C80 File Offset: 0x011F4E80
		public void DeduplicateRelations(string key, int leaderId, int followerId, string reason)
		{
			if (this.Relations.ContainsKey(key))
			{
				this.RequestStop(key, reason + ": 同 Key 重复添加");
			}
			AttachMoveRelation relationByEntityId = this.GetRelationByEntityId(leaderId);
			if (relationByEntityId != null && relationByEntityId.Key != key)
			{
				this.RequestStop(relationByEntityId.Key, reason + ": Leader 已在依附移动中重复添加");
			}
			AttachMoveRelation relationByEntityId2 = this.GetRelationByEntityId(followerId);
			if (relationByEntityId2 != null && relationByEntityId2.Key != key)
			{
				this.RequestStop(relationByEntityId2.Key, reason + ": Follower 已在依附移动中重复添加");
			}
		}

		// Token: 0x0603DE4C RID: 253516 RVA: 0x011F6D10 File Offset: 0x011F4F10
		public unsafe void RequestStartAttachMove(string key, CharacterActorComponent leader, BaseActorComponent followerActor, BaseMoveComponent followerMoveComp, string daPath, string reason = "")
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[AttachMove] RequestStart";
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
			this.DeduplicateRelations(key, leaderId, followerId, reason);
			BP_AttachMoveConfig_C bp_AttachMoveConfig_C = this.LoadConfigDataAsset(leader.Entity, daPath);
			if (bp_AttachMoveConfig_C == null)
			{
				return;
			}
			MoveToLocationController moveController = followerMoveComp.MoveController;
			if (moveController != null)
			{
				moveController.StartAttachMoveWithData(leader, bp_AttachMoveConfig_C, delegate
				{
					this.DeleteRelation(key, "底层 endCallback 自然结束");
				});
			}
			this.AddRelation(key, leader, followerActor, followerMoveComp, delegate
			{
				MoveToLocationController moveController2 = followerMoveComp.MoveController;
				if (moveController2 == null)
				{
					return;
				}
				moveController2.StopAttachMove();
			});
		}

		// Token: 0x0603DE4D RID: 253517 RVA: 0x011F6E9C File Offset: 0x011F509C
		public unsafe void RequestStop(string key, string reason = "")
		{
			AttachMoveRelation attachMoveRelation;
			this.Relations.TryGetValue(key, out attachMoveRelation);
			if (attachMoveRelation == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "[AttachMove] RequestStop key 不存在";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Key", key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Reason", reason);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Movement;
			ELogAuthor author2 = ELogAuthor.CWZ;
			string message2 = "[AttachMove] RequestStop";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Key", key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Reason", reason);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			Action stopFn = attachMoveRelation.StopFn;
			if (stopFn != null)
			{
				stopFn();
			}
			this.DeleteRelation(key, reason);
		}

		// Token: 0x0603DE4E RID: 253518 RVA: 0x011F6F7C File Offset: 0x011F517C
		[NullableContext(2)]
		public unsafe BP_AttachMoveConfig_C LoadConfigDataAsset(Entity entity, [Nullable(1)] string daPath)
		{
			BP_AttachMoveConfig_C bp_AttachMoveConfig_C = ResourceSystem.Instance.Load<BP_AttachMoveConfig_C>(daPath, "js_undefined");
			if (bp_AttachMoveConfig_C == null || !bp_AttachMoveConfig_C.IsValid())
			{
				CharacterActorComponent characterActorComponent = (entity != null) ? entity.GetComponent<CharacterActorComponent>() : null;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "[AttachMove] 获取配置DA失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("DaPath", daPath);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", (characterActorComponent != null) ? new int?(characterActorComponent.CreatureData.GetPbDataId()) : null);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return null;
			}
			return bp_AttachMoveConfig_C;
		}

		// Token: 0x0603DE4F RID: 253519 RVA: 0x011F7034 File Offset: 0x011F5234
		[return: TupleElementNames(new string[]
		{
			"Transform",
			"TurnAngle"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public ValueTuple<Transform, float>? PreviewLeaderTransform(CharacterActorComponent leader, BaseActorComponent npc, string socket, Transform transfrom)
		{
			TsBaseCharacter actor = leader.Actor;
			USkeletalMeshComponent uskeletalMeshComponent = (actor != null) ? actor.Mesh : null;
			if (actor == null || !actor.IsValid() || (uskeletalMeshComponent == null || !uskeletalMeshComponent.IsValid()))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "[AttachMove] Preview 失败：Leader Actor/Mesh 无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("LeaderPbId", leader.CreatureData.GetPbDataId());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			if (socket.Length < 1)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Movement;
				ELogAuthor author2 = ELogAuthor.CWZ;
				string message2 = "[AttachMove] Preview 失败：DA AttachSocket 为空";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("LeaderPbId", leader.CreatureData.GetPbDataId());
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return null;
			}
			FName inSocketName = new FName(socket);
			FTransformDouble ftransformDouble = uskeletalMeshComponent.D_GetSocketTransform(inSocketName, ERelativeTransformSpace.RTS_Actor);
			FTransformDouble ftransformDouble2 = transfrom.ToUeTransform();
			FTransformDouble ftransformDouble3 = UKismetMathLibrary.D_ComposeTransforms(ftransformDouble2, ftransformDouble);
			FTransformDouble ftransformDouble4 = UKismetMathLibrary.D_InvertTransform(ftransformDouble3);
			Transform transform = Transform.Create(npc.ActorTransform);
			ftransformDouble2 = transform.ToUeTransform();
			FTransformDouble ftransformDouble5 = UKismetMathLibrary.D_ComposeTransforms(ftransformDouble4, ftransformDouble2);
			Transform item = Transform.Create(ftransformDouble5);
			FQuat fquat = ftransformDouble5.GetRotation();
			ref FRotator ptr = UKismetMathLibrary.Quat_Rotator(fquat);
			fquat = transform.GetRotation().ToUeQuat();
			FRotator frotator = UKismetMathLibrary.Quat_Rotator(fquat);
			float item2 = ptr.Yaw - frotator.Yaw;
			return new ValueTuple<Transform, float>?(new ValueTuple<Transform, float>(item, item2));
		}

		// Token: 0x17007599 RID: 30105
		// (get) Token: 0x0603DE50 RID: 253520 RVA: 0x011F71A3 File Offset: 0x011F53A3
		public static AttachMoveUtils Instance
		{
			get
			{
				if (AttachMoveUtils._instance == null)
				{
					AttachMoveUtils._instance = new AttachMoveUtils();
					AttachMoveUtils._instance.OnInit();
				}
				return AttachMoveUtils._instance;
			}
		}

		// Token: 0x0603DE51 RID: 253521 RVA: 0x011F71C6 File Offset: 0x011F53C6
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603DE52 RID: 253522 RVA: 0x011F71C8 File Offset: 0x011F53C8
		public static void ResetStaticDefaultValue()
		{
			AttachMoveUtils instance = AttachMoveUtils._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			AttachMoveUtils._instance = null;
		}

		// Token: 0x0603DE53 RID: 253523 RVA: 0x011F71E1 File Offset: 0x011F53E1
		static AttachMoveUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AttachMoveUtils.CreateStaticDefaultValue), new Action(AttachMoveUtils.ResetStaticDefaultValue));
		}

		// Token: 0x04020DE5 RID: 134629
		private readonly Dictionary<string, AttachMoveRelation> Relations;

		// Token: 0x04020DE6 RID: 134630
		[Nullable(2)]
		private static AttachMoveUtils _instance;
	}
}
