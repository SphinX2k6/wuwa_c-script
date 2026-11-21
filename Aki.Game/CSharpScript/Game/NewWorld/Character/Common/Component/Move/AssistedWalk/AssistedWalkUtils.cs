using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.Level.AssistedWalk;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move.AttachMove;
using CSharpScript.Game.Utils;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move.AssistedWalk
{
	// Token: 0x020063BE RID: 25534
	[NullableContext(1)]
	[Nullable(0)]
	public class AssistedWalkUtils : Singleton
	{
		// Token: 0x0603DE8C RID: 253580 RVA: 0x011F8928 File Offset: 0x011F6B28
		public AssistedWalkUtils()
		{
			this.TmpVector = global::Vector.Create();
		}

		// Token: 0x0603DE8D RID: 253581 RVA: 0x011F893C File Offset: 0x011F6B3C
		public bool ArePartnerComponentsAlive(string logTag, [Nullable(2)] CharacterActorComponent actorComp, params bool[] validFlags)
		{
			for (int i = 0; i < validFlags.Length; i++)
			{
				if (!validFlags[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0603DE8E RID: 253582 RVA: 0x011F8964 File Offset: 0x011F6B64
		[NullableContext(2)]
		public SightLockMode SaveAndDisableSightLockMode(CharacterActorComponent actorComp)
		{
			object obj;
			if (actorComp == null)
			{
				obj = null;
			}
			else
			{
				TsBaseCharacter actor = actorComp.Actor;
				if (actor == null)
				{
					obj = null;
				}
				else
				{
					USkeletalMeshComponent mesh = actor.Mesh;
					obj = ((mesh != null) ? mesh.GetLinkedAnimGraphInstanceByTag(CharacterNameDefines.Instance.ABP_BASE) : null);
				}
			}
			UKuroAnimInstanceChar ukuroAnimInstanceChar = obj as UKuroAnimInstanceChar;
			if (ukuroAnimInstanceChar != null)
			{
				SightLockMode sightLockMode = ukuroAnimInstanceChar.SightLockMode;
				ukuroAnimInstanceChar.SightLockMode = SightLockMode.None;
				return sightLockMode;
			}
			return SightLockMode.None;
		}

		// Token: 0x0603DE8F RID: 253583 RVA: 0x011F89BC File Offset: 0x011F6BBC
		[NullableContext(2)]
		public void RestoreSightLockMode(CharacterActorComponent actorComp, SightLockMode savedMode = SightLockMode.None)
		{
			object obj;
			if (actorComp == null)
			{
				obj = null;
			}
			else
			{
				TsBaseCharacter actor = actorComp.Actor;
				if (actor == null)
				{
					obj = null;
				}
				else
				{
					USkeletalMeshComponent mesh = actor.Mesh;
					obj = ((mesh != null) ? mesh.GetLinkedAnimGraphInstanceByTag(CharacterNameDefines.Instance.ABP_BASE) : null);
				}
			}
			UKuroAnimInstanceChar ukuroAnimInstanceChar = obj as UKuroAnimInstanceChar;
			if (ukuroAnimInstanceChar != null)
			{
				ukuroAnimInstanceChar.SightLockMode = savedMode;
			}
		}

		// Token: 0x0603DE90 RID: 253584 RVA: 0x011F8A08 File Offset: 0x011F6C08
		public unsafe void RequestStartAssistedWalk(string key, CharacterActorComponent leader, BaseActorComponent followerActor, BaseMoveComponent followerMoveComp, string daPath, bool waitAnim, string reason = "", EHandType leaderHandType = EHandType.Right)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[AttachMove][AssistedWalk] RequestStart";
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
			AttachMoveUtils.Instance.DeduplicateRelations(key, leaderId, followerId, "[AttachMove][AssistedWalk]");
			this.SendHoldHandRequest(leader, followerActor, leaderHandType, true);
			this.StartAssistedWalkWithPrePosition(leader, followerActor, followerMoveComp, daPath, waitAnim, delegate
			{
				AttachMoveUtils.Instance.DeleteRelation(key, "底层 endCallback 自然结束");
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

		// Token: 0x0603DE91 RID: 253585 RVA: 0x011F8BA8 File Offset: 0x011F6DA8
		public void RequestStopAssistedWalk(string key, string reason = "", EHandType leaderHandType = EHandType.Right)
		{
			AttachMoveRelation relation = AttachMoveUtils.Instance.GetRelation(key);
			if (((relation != null) ? relation.Leader : null) != null && relation.FollowerActor != null)
			{
				this.SendHoldHandRequest(relation.Leader, relation.FollowerActor, leaderHandType, false);
			}
			AttachMoveUtils.Instance.RequestStop(key, reason);
		}

		// Token: 0x0603DE92 RID: 253586 RVA: 0x011F8BF7 File Offset: 0x011F6DF7
		[return: Nullable(2)]
		public AttachMoveRelation GetRelation(string key)
		{
			return AttachMoveUtils.Instance.GetRelation(key);
		}

		// Token: 0x0603DE93 RID: 253587 RVA: 0x011F8C04 File Offset: 0x011F6E04
		[NullableContext(2)]
		public AttachMoveRelation GetRelationByEntityId(int entityId)
		{
			return AttachMoveUtils.Instance.GetRelationByEntityId(entityId);
		}

		// Token: 0x0603DE94 RID: 253588 RVA: 0x011F8C14 File Offset: 0x011F6E14
		public void SendHoldHandRequest(CharacterActorComponent leader, BaseActorComponent follower, EHandType leaderHandType, bool isHold)
		{
			HoldHandRequest holdHandRequest = HoldHandRequest.Create();
			holdHandRequest.HostPlayerId = CreatureModel.Instance.GetWorldOwner();
			holdHandRequest.EntityId = leader.CreatureData.GetCreatureDataId();
			holdHandRequest.TargetEntityId = follower.CreatureData.GetCreatureDataId();
			holdHandRequest.HandType = (int)leaderHandType;
			holdHandRequest.IsHold = isHold;
			holdHandRequest.ActionType = 1;
			Net.Instance.Call(ERequestMessageId.HoldHandRequest, holdHandRequest, delegate(IMessage _, Net.CallbackStatus _)
			{
			}, 0);
		}

		// Token: 0x0603DE95 RID: 253589 RVA: 0x011F8CA0 File Offset: 0x011F6EA0
		private void StartAssistedWalkWithPrePosition(CharacterActorComponent leader, BaseActorComponent followerActor, BaseMoveComponent followerMoveComp, string daPath, bool waitAnim, [Nullable(2)] Action endCallback = null)
		{
			AssistedWalkUtils.<>c__DisplayClass10_0 CS$<>8__locals1 = new AssistedWalkUtils.<>c__DisplayClass10_0();
			CS$<>8__locals1.followerMoveComp = followerMoveComp;
			CS$<>8__locals1.leader = leader;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.followerActor = followerActor;
			CS$<>8__locals1.endCallback = endCallback;
			CS$<>8__locals1.waitAnim = waitAnim;
			AssistedWalkUtils.<>c__DisplayClass10_0 CS$<>8__locals2 = CS$<>8__locals1;
			Entity entity = CS$<>8__locals1.leader.Entity;
			CS$<>8__locals2.leaderActComp = ((entity != null) ? entity.GetComponent<CharacterCustomActionComponent>() : null);
			BaseMoveComponent moveComp = CS$<>8__locals1.leader.MoveComp;
			if (((moveComp != null) ? moveComp.MoveController : null) == null || CS$<>8__locals1.leaderActComp == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "[AttachMove][AssistedWalk] 前置编排缺少 Leader Move/Action 组件";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("DaPath", daPath);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			CS$<>8__locals1.data = ResourceSystem.Instance.Load<BP_AssistedWalkConfig_C>(daPath, "js_undefined");
			BP_AssistedWalkConfig_C data = CS$<>8__locals1.data;
			if (data == null || !data.IsValid())
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Movement;
				ELogAuthor author2 = ELogAuthor.CWZ;
				string message2 = "[AttachMove][AssistedWalk] 获取搀扶配置DA失败";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("DaPath", daPath);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			CS$<>8__locals1.@params = new AssistedWalkParams(CS$<>8__locals1.data);
			ValueTuple<global::Transform, float>? valueTuple3 = AttachMoveUtils.Instance.PreviewLeaderTransform(CS$<>8__locals1.leader, CS$<>8__locals1.followerActor, CS$<>8__locals1.@params.AttachSocket, CS$<>8__locals1.@params.StartTransform);
			if (valueTuple3 == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Movement;
				ELogAuthor author3 = ELogAuthor.CWZ;
				string message3 = "[AttachMove][AssistedWalk] 反推 Leader 站位失败，跳过预移动直接启动";
				ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("DaPath", daPath);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
				bool exited = false;
				this.StartAssistedWalkBoth(CS$<>8__locals1.leader, CS$<>8__locals1.followerMoveComp, CS$<>8__locals1.data, CS$<>8__locals1.waitAnim, delegate(bool isLeader)
				{
					if (exited)
					{
						return;
					}
					exited = true;
					if (isLeader)
					{
						MoveToLocationController moveController = CS$<>8__locals1.followerMoveComp.MoveController;
						if (moveController != null)
						{
							moveController.StopAssistedWalk();
						}
					}
					else
					{
						BaseMoveComponent moveComp2 = CS$<>8__locals1.leader.MoveComp;
						if (moveComp2 != null)
						{
							MoveToLocationController moveController2 = moveComp2.MoveController;
							if (moveController2 != null)
							{
								moveController2.StopAssistedWalk();
							}
						}
					}
					CS$<>8__locals1.<>4__this.PushOutLeader(CS$<>8__locals1.leader, CS$<>8__locals1.followerActor);
					Action endCallback2 = CS$<>8__locals1.endCallback;
					if (endCallback2 == null)
					{
						return;
					}
					endCallback2();
				});
				return;
			}
			this.TmpVector.DeepCopy(valueTuple3.Value.Item1.GetLocation());
			this.TmpVector.Z = CS$<>8__locals1.leader.ActorLocationProxy.Z;
			if (CS$<>8__locals1.data.Debug)
			{
				UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, this.TmpVector.ToUeVector(false), 30f, 10, new FLinearColor?(ColorUtils.LinearRed), 5f, 0f);
			}
			ValueTuple<global::Transform, float> value = valueTuple3.Value;
			CS$<>8__locals1.leaderActComp.AddCustomSetPlayerControl(true, null);
			CS$<>8__locals1.leaderActComp.AddCustomSetCollision(CS$<>8__locals1.followerActor, true, null);
			CS$<>8__locals1.leaderActComp.AddCustomMoveToLocation(this.TmpVector, delegate
			{
				double num = CS$<>8__locals1.<>4__this.CalculateFaceToFollowerTurnAngle(CS$<>8__locals1.@params.StartTransform.GetLocation());
				CharacterCustomActionComponent leaderActComp = CS$<>8__locals1.leaderActComp;
				BaseActorComponent followerActor2 = CS$<>8__locals1.followerActor;
				double angle = num;
				ECustomSetRotationType type = ECustomSetRotationType.FaceToTarget;
				Action callback;
				if ((callback = CS$<>8__locals1.<>9__2) == null)
				{
					callback = (CS$<>8__locals1.<>9__2 = delegate()
					{
						bool exited = false;
						CS$<>8__locals1.<>4__this.StartAssistedWalkBoth(CS$<>8__locals1.leader, CS$<>8__locals1.followerMoveComp, CS$<>8__locals1.data, CS$<>8__locals1.waitAnim, delegate(bool isLeader)
						{
							if (exited)
							{
								return;
							}
							exited = true;
							if (isLeader)
							{
								MoveToLocationController moveController = CS$<>8__locals1.followerMoveComp.MoveController;
								if (moveController != null)
								{
									moveController.StopAssistedWalk();
								}
							}
							else
							{
								BaseMoveComponent moveComp2 = CS$<>8__locals1.leader.MoveComp;
								if (moveComp2 != null)
								{
									MoveToLocationController moveController2 = moveComp2.MoveController;
									if (moveController2 != null)
									{
										moveController2.StopAssistedWalk();
									}
								}
							}
							CS$<>8__locals1.<>4__this.PushOutLeader(CS$<>8__locals1.leader, CS$<>8__locals1.followerActor);
							Entity entity2 = CS$<>8__locals1.leader.Entity;
							CharacterCustomActionComponent characterCustomActionComponent = (entity2 != null) ? entity2.GetComponent<CharacterCustomActionComponent>() : null;
							AActor owner = CS$<>8__locals1.followerActor.Owner;
							if (owner != null && owner.IsValid() && characterCustomActionComponent != null)
							{
								characterCustomActionComponent.AddCustomSetCollision(CS$<>8__locals1.followerActor, false, null);
							}
							Action endCallback2 = CS$<>8__locals1.endCallback;
							if (endCallback2 == null)
							{
								return;
							}
							endCallback2();
						});
					});
				}
				leaderActComp.AddCustomSetTurnToTarget(followerActor2, angle, type, callback, null);
			}, null);
		}

		// Token: 0x0603DE96 RID: 253590 RVA: 0x011F8F28 File Offset: 0x011F7128
		private double CalculateFaceToFollowerTurnAngle(global::Vector localOffset)
		{
			if (localOffset.X == 0.0 && localOffset.Y == 0.0)
			{
				return 0.0;
			}
			return MathUtils.Instance.WrapAngle(Math.Atan2(localOffset.Y, -localOffset.X) * 57.295780181884766);
		}

		// Token: 0x0603DE97 RID: 253591 RVA: 0x011F8F88 File Offset: 0x011F7188
		public void StartAssistedWalkBoth(CharacterActorComponent leader, BaseMoveComponent followerMoveComp, BP_AssistedWalkConfig_C data, bool waitAnim, [Nullable(2)] Action<bool> endCallback = null)
		{
			BaseMoveComponent moveComp = leader.MoveComp;
			if (moveComp != null)
			{
				moveComp.MoveController.StartLeaderAssistedWalkWithData(data, (endCallback != null) ? delegate()
				{
					endCallback(true);
				} : null, waitAnim);
			}
			followerMoveComp.MoveController.StartAssistedWalkWithData(leader, data, (endCallback != null) ? delegate()
			{
				endCallback(false);
			} : null, waitAnim);
		}

		// Token: 0x0603DE98 RID: 253592 RVA: 0x011F8FFC File Offset: 0x011F71FC
		public void PushOutLeader(CharacterActorComponent leader, BaseActorComponent followerActor)
		{
			TsBaseCharacter actor = leader.Actor;
			UCapsuleComponent ucapsuleComponent = (actor != null) ? actor.CapsuleComponent : null;
			ACharacter acharacter = followerActor.Owner as ACharacter;
			UCapsuleComponent ucapsuleComponent2 = (acharacter != null) ? acharacter.CapsuleComponent : null;
			if (ucapsuleComponent == null || !ucapsuleComponent.IsValid() || (ucapsuleComponent2 == null || !ucapsuleComponent2.IsValid()))
			{
				return;
			}
			float scaledCapsuleRadius = ucapsuleComponent.GetScaledCapsuleRadius();
			float scaledCapsuleRadius2 = ucapsuleComponent2.GetScaledCapsuleRadius();
			float num = scaledCapsuleRadius + scaledCapsuleRadius2;
			global::Vector actorLocationProxy = leader.ActorLocationProxy;
			global::Vector actorLocationProxy2 = followerActor.ActorLocationProxy;
			double num2 = global::Vector.Dist2D(actorLocationProxy, actorLocationProxy2);
			if (num2 >= (double)num)
			{
				return;
			}
			double inB = (double)num - num2 + 1.0;
			global::Vector tmpVector = this.TmpVector;
			actorLocationProxy.Subtraction(actorLocationProxy2, tmpVector);
			tmpVector.Z = 0.0;
			if (!tmpVector.Normalize(9.99999993922529E-09))
			{
				tmpVector.Set(1.0, 0.0, 0.0);
			}
			tmpVector.MultiplyEqual(inB);
			tmpVector.AdditionEqual(actorLocationProxy);
			leader.SetActorLocation(tmpVector.ToUeVector(false), "AssistedWalk.ExitPushOut", false);
		}

		// Token: 0x1700759E RID: 30110
		// (get) Token: 0x0603DE99 RID: 253593 RVA: 0x011F911B File Offset: 0x011F731B
		public static AssistedWalkUtils Instance
		{
			get
			{
				if (AssistedWalkUtils._instance == null)
				{
					AssistedWalkUtils._instance = new AssistedWalkUtils();
					AssistedWalkUtils._instance.OnInit();
				}
				return AssistedWalkUtils._instance;
			}
		}

		// Token: 0x0603DE9A RID: 253594 RVA: 0x011F913E File Offset: 0x011F733E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603DE9B RID: 253595 RVA: 0x011F9140 File Offset: 0x011F7340
		public static void ResetStaticDefaultValue()
		{
			AssistedWalkUtils instance = AssistedWalkUtils._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			AssistedWalkUtils._instance = null;
		}

		// Token: 0x0603DE9C RID: 253596 RVA: 0x011F9159 File Offset: 0x011F7359
		static AssistedWalkUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AssistedWalkUtils.CreateStaticDefaultValue), new Action(AssistedWalkUtils.ResetStaticDefaultValue));
		}

		// Token: 0x04020E1B RID: 134683
		private readonly global::Vector TmpVector;

		// Token: 0x04020E1C RID: 134684
		[Nullable(2)]
		private static AssistedWalkUtils _instance;
	}
}
