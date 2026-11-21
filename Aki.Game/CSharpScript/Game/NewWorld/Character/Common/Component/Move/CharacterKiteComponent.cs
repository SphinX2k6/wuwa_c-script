using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Data.Fight.AssestStruct;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.SeamlessTravel;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using CSharpScript.Game.NewWorld.Character.Role.Component;
using CSharpScript.Game.NewWorld.Common.Component;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x02006395 RID: 25493
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterKiteComponent : EntityComponent
	{
		// Token: 0x1700753D RID: 30013
		// (get) Token: 0x0603DCAC RID: 253100 RVA: 0x011EAE83 File Offset: 0x011E9083
		public override Type[] Dependencies
		{
			get
			{
				return new Type[]
				{
					typeof(CharacterMoveComponent)
				};
			}
		}

		// Token: 0x0603DCAD RID: 253101 RVA: 0x011EAE98 File Offset: 0x011E9098
		protected void OnMoveStateChanged(global::ECharMoveState oldMoveState, global::ECharMoveState newMoveState)
		{
			if (oldMoveState == global::ECharMoveState.Kite)
			{
				if (this.InMonsterKiteMove)
				{
					this.ExitKiteOnlyMonster(this.CurrentTarget);
				}
				this.CurrentTarget = null;
			}
		}

		// Token: 0x0603DCAE RID: 253102 RVA: 0x011EAEBC File Offset: 0x011E90BC
		public void KiteMove(float deltaSeconds)
		{
			if (SeamlessTravelModel.Instance.GetIsKeepingCurrentMovementMode() || TeleportModel.Instance.GetIsKeepingCurrentMovementMode())
			{
				this.PrevLocation.DeepCopy(this.MoveComp.ActorComp.ActorLocationProxy);
				this.PrevLocationTime = 0f;
				this.PrevLocationBlockCount = 0;
				return;
			}
			GrapplingHookPointComponent currentTarget = this.CurrentTarget;
			if (currentTarget != null && currentTarget.Valid)
			{
				Entity entity = this.CurrentTarget.Entity;
				bool? flag;
				if (entity == null)
				{
					flag = null;
				}
				else
				{
					LevelTagComponent component = entity.GetComponent<LevelTagComponent>();
					flag = ((component != null) ? new bool?(component.HasTag(CharacterKiteComponent.hookKeepAttachedTag)) : null);
				}
				bool? flag2 = flag;
				if (!flag2.GetValueOrDefault())
				{
					GrapplingHookPointComponent currentTarget2 = this.CurrentTarget;
					if (currentTarget2 == null || !currentTarget2.Valid || this.LastTargetEndCount != this.CurrentTarget.SplineMoveEndCount)
					{
						int lastTargetMoveBrokenCount = this.LastTargetMoveBrokenCount;
						GrapplingHookPointComponent currentTarget3 = this.CurrentTarget;
						int? num = (currentTarget3 != null) ? new int?(currentTarget3.SplineMoveBrokenCount) : null;
						if (!(lastTargetMoveBrokenCount == num.GetValueOrDefault() & num != null))
						{
							RoleSceneInteractComponent component2 = base.Entity.GetComponent<RoleSceneInteractComponent>();
							if (component2 != null)
							{
								component2.SetIsHookEndByInterrupt(true);
							}
						}
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
							Mode = EMovementMode.MOVE_Falling,
							Context = "[CharacterKiteComponent.KiteMove.End]"
						});
						return;
					}
					else
					{
						CharacterMoveComponent moveComp2 = this.MoveComp;
						bool flag3;
						if (moveComp2 == null)
						{
							flag3 = (null != null);
						}
						else
						{
							UCharacterMovementComponent characterMovement = moveComp2.CharacterMovement;
							flag3 = (((characterMovement != null) ? characterMovement.Kuro_GetBlockActorWhenMove() : null) != null);
						}
						if (flag3 && global::Vector.DistSquared(this.PrevLocation, this.MoveComp.ActorComp.ActorLocationProxy) < 40000.0)
						{
							if (this.PrevLocationTime > 1f)
							{
								int num2 = this.PrevLocationBlockCount + 1;
								this.PrevLocationBlockCount = num2;
								if (num2 >= 3)
								{
									RoleSceneInteractComponent component3 = base.Entity.GetComponent<RoleSceneInteractComponent>();
									if (component3 != null)
									{
										component3.SetIsHookEndByInterrupt(true);
									}
									CharacterMoveComponent moveComp3 = this.MoveComp;
									if (moveComp3 != null)
									{
										CharacterActorComponent actorComp2 = moveComp3.ActorComp;
										if (actorComp2 != null)
										{
											actorComp2.Actor.KuroSetMovementMode(new SetMovementModeInfo
											{
												Mode = EMovementMode.MOVE_Falling,
												Context = "[CharacterKiteComponent.KiteMove.Block]"
											});
										}
									}
								}
							}
							this.PrevLocationTime += deltaSeconds;
						}
						else
						{
							this.PrevLocation.DeepCopy(this.MoveComp.ActorComp.ActorLocationProxy);
							this.PrevLocationTime = 0f;
							this.PrevLocationBlockCount = 0;
						}
					}
				}
				if (this.UseNewKiteMode)
				{
					this.KiteMoveNew(deltaSeconds);
				}
				else
				{
					this.KiteMoveOld(deltaSeconds);
				}
				this.TargetPrevPos.DeepCopy(this.CurrentTarget.HookLocation);
				return;
			}
			CharacterMoveComponent moveComp4 = this.MoveComp;
			if (moveComp4 == null)
			{
				return;
			}
			CharacterActorComponent actorComp3 = moveComp4.ActorComp;
			if (actorComp3 == null)
			{
				return;
			}
			actorComp3.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = EMovementMode.MOVE_Falling,
				Context = "[CharacterKiteComponent.KiteMove.End]"
			});
		}

		// Token: 0x0603DCAF RID: 253103 RVA: 0x011EB184 File Offset: 0x011E9384
		private void KiteMoveOld(float deltaSeconds)
		{
			FVector targetPrevPos = UKismetMathLibrary.WD_WorldToLocal(GlobalData.World, this.TargetPrevPos.ToUeVector(false));
			FVector targetNextPos = UKismetMathLibrary.WD_WorldToLocal(GlobalData.World, this.CurrentTarget.HookLocation.ToUeVector(false));
			UKuroMovementBPLibrary.KuroKite(deltaSeconds, this.MoveComp.CharacterMovement, targetPrevPos, targetNextPos, 300f, 900f, 1200f, 18000f, 0.98f, ref this.RefTargetForward, 240f, 0.9f);
		}

		// Token: 0x0603DCB0 RID: 253104 RVA: 0x011EB204 File Offset: 0x011E9404
		private void KiteMoveNew(float deltaSeconds)
		{
			UCharacterMovementComponent characterMovement = this.MoveComp.CharacterMovement;
			CharacterActorComponent actorComp = this.MoveComp.ActorComp;
			global::Vector tmpTargetPos = CharacterKiteComponent.TmpTargetPos;
			tmpTargetPos.DeepCopy(this.CurrentTarget.HookLocation);
			GravityUtils.Instance.AddZnInGravityForActor(actorComp, tmpTargetPos, (double)(-(double)actorComp.ScaledHalfHeight));
			this.MoveComp.GravityDirect.Multiply((double)(this.KiteConfigData.Gravity * deltaSeconds), CharacterKiteComponent.TmpGravityDelta);
			double inB = Math.Pow((double)this.KiteConfigData.InertiaDecay, (double)deltaSeconds);
			this.KiteVelocity.MultiplyEqual(inB);
			this.KiteVelocity.AdditionEqual(CharacterKiteComponent.TmpGravityDelta);
			CharacterKiteComponent.TmpTentativePos.DeepCopy(actorComp.ActorLocationProxy);
			this.KiteVelocity.Multiply((double)deltaSeconds, CharacterKiteComponent.TmpMoveDelta);
			CharacterKiteComponent.TmpTentativePos.AdditionEqual(CharacterKiteComponent.TmpMoveDelta);
			tmpTargetPos.Subtraction(CharacterKiteComponent.TmpTentativePos, CharacterKiteComponent.TmpToTarget);
			double num = CharacterKiteComponent.TmpToTarget.Size();
			double num2 = this.KiteDistToTarget - (double)(this.KiteConfigData.ShrinkSpeed * deltaSeconds);
			if (num2 < (double)this.KiteConfigData.MinDist)
			{
				num2 = (double)this.KiteConfigData.MinDist;
			}
			if (num > num2)
			{
				CharacterKiteComponent.TmpToTarget.MultiplyEqual(num2 / num);
				tmpTargetPos.Subtraction(CharacterKiteComponent.TmpToTarget, CharacterKiteComponent.TmpTentativePos);
				CharacterKiteComponent.TmpTentativePos.Subtraction(actorComp.ActorLocationProxy, CharacterKiteComponent.TmpMoveDelta);
			}
			this.UpdateFacing(deltaSeconds, tmpTargetPos, actorComp);
			UKuroMovementBPLibrary.KuroMoveByOffset(deltaSeconds, characterMovement, CharacterKiteComponent.TmpMoveDelta.ToUeVectorOld(), EMoveSlideType.Free, default(FVector));
			actorComp.ResetLocationCachedTime();
			tmpTargetPos.Subtraction(actorComp.ActorLocationProxy, CharacterKiteComponent.TmpToTarget);
			GravityUtils.Instance.AddZnInGravityForActor(actorComp, CharacterKiteComponent.TmpToTarget, (double)(-(double)actorComp.ScaledHalfHeight));
			this.KiteDistToTarget = global::Vector.Dist(tmpTargetPos, actorComp.ActorLocationProxy);
		}

		// Token: 0x0603DCB1 RID: 253105 RVA: 0x011EB3D4 File Offset: 0x011E95D4
		private void UpdateFacing(float deltaSeconds, global::Vector targetPos, BaseActorComponent actorComp)
		{
			CharacterKiteComponent.TmpActorForward.DeepCopy(actorComp.ActorForwardProxy);
			if (!this.TargetForwardInited)
			{
				this.TargetForward.DeepCopy(CharacterKiteComponent.TmpActorForward);
				this.TargetForwardInited = true;
			}
			global::Vector actorLocationProxy = this.MoveComp.ActorComp.ActorLocationProxy;
			CharacterKiteComponent.TmpNewTargetForward.DeepCopy(targetPos);
			CharacterKiteComponent.TmpNewTargetForward.SubtractionEqual(actorLocationProxy);
			GravityUtils.Instance.ConvertToPlanarVectorForActor(this.MoveComp.ActorComp, CharacterKiteComponent.TmpNewTargetForward);
			double num = CharacterKiteComponent.TmpNewTargetForward.Size();
			if (num > 1E-08)
			{
				CharacterKiteComponent.TmpNewTargetForward.MultiplyEqual(1.0 / num);
				double num2 = Math.Abs(Math.Acos(Math.Min(Math.Max(global::Vector.DotProduct(CharacterKiteComponent.TmpNewTargetForward, this.TargetForward), -1.0), 1.0)));
				if (num2 > 1E-08)
				{
					float num3 = 4.1887903f * deltaSeconds;
					if ((double)num3 >= num2)
					{
						this.TargetForward.DeepCopy(CharacterKiteComponent.TmpNewTargetForward);
					}
					else
					{
						double num4 = (double)num3 / num2;
						Quat.FindBetween(this.TargetForward, CharacterKiteComponent.TmpNewTargetForward, CharacterKiteComponent.TmpQuat);
						Quat.Slerp(Quat.IdentityProxy, CharacterKiteComponent.TmpQuat, (float)num4, CharacterKiteComponent.TmpQuat);
						CharacterKiteComponent.TmpQuat.RotateVector(this.TargetForward, this.TargetForward);
					}
				}
			}
			if (global::Vector.DotProduct(CharacterKiteComponent.TmpActorForward, this.TargetForward) < 0.9999)
			{
				Quat.FindBetween(CharacterKiteComponent.TmpActorForward, this.TargetForward, CharacterKiteComponent.TmpQuat2);
				double num5 = 1.0 - Math.Pow(0.10000002384185791, (double)deltaSeconds);
				Quat.Slerp(Quat.IdentityProxy, CharacterKiteComponent.TmpQuat2, (float)num5, CharacterKiteComponent.TmpQuat2);
				CharacterKiteComponent.TmpQuat2.RotateVector(CharacterKiteComponent.TmpActorForward, CharacterKiteComponent.TmpActorForward);
			}
			global::Vector gravityUp = this.MoveComp.GravityUp;
			MathUtils.Instance.LookRotationUpFirst(CharacterKiteComponent.TmpActorForward, gravityUp, CharacterKiteComponent.TmpRotator);
			actorComp.SetActorRotation(CharacterKiteComponent.TmpRotator.ToUeRotator(), "KiteMoveNew.Facing", false);
		}

		// Token: 0x0603DCB2 RID: 253106 RVA: 0x011EB5DF File Offset: 0x011E97DF
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0603DCB3 RID: 253107 RVA: 0x011EB5E2 File Offset: 0x011E97E2
		protected override bool OnStart()
		{
			this.MoveComp = base.Entity.GetComponent<CharacterMoveComponent>();
			EventSystem.Instance.AddWithTarget<global::ECharMoveState, global::ECharMoveState>(base.Entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<global::ECharMoveState, global::ECharMoveState>(this.OnMoveStateChanged));
			return true;
		}

		// Token: 0x0603DCB4 RID: 253108 RVA: 0x011EB618 File Offset: 0x011E9818
		protected override bool OnEnd()
		{
			EventSystem.Instance.RemoveWithTarget<global::ECharMoveState, global::ECharMoveState>(base.Entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<global::ECharMoveState, global::ECharMoveState>(this.OnMoveStateChanged));
			this.RemoveKiteCue();
			return true;
		}

		// Token: 0x0603DCB5 RID: 253109 RVA: 0x011EB644 File Offset: 0x011E9844
		[NullableContext(2)]
		public unsafe bool EnterKite(GrapplingHookPointComponent target)
		{
			if (target != null)
			{
				CharacterMoveComponent moveComp = this.MoveComp;
				if (((moveComp != null) ? moveComp.CharacterMovement : null) != null)
				{
					this.CurrentTarget = target;
					IKiteHook kiteHook = target.GetHookInteractConfig() as IKiteHook;
					string text = (kiteHook != null) ? kiteHook.HookDataAssetOverride : null;
					if (!string.IsNullOrEmpty(text))
					{
						BP_KiteConfig_C bp_KiteConfig_C = ResourceSystem.Instance.Load<BP_KiteConfig_C>(text, "js_undefined");
						if (bp_KiteConfig_C != null)
						{
							this.KiteConfigData = new CharacterKiteComponent.KiteConfig
							{
								Gravity = bp_KiteConfig_C.重力强度,
								InertiaDecay = bp_KiteConfig_C.速度衰减系数_每秒保留比例_,
								MinDist = bp_KiteConfig_C.最短收缩距离,
								ShrinkSpeed = bp_KiteConfig_C.收缩速度
							};
						}
						else
						{
							this.KiteConfigData = null;
						}
					}
					else
					{
						this.KiteConfigData = null;
					}
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Movement;
					ELogAuthor author = ELogAuthor.LCZ;
					string message = "[CharacterKiteComponent.EnterKite]";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("KiteConfig", this.KiteConfigData != null);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					this.LastTargetEndCount = target.SplineMoveEndCount;
					this.LastTargetMoveBrokenCount = target.SplineMoveBrokenCount;
					CharacterMoveComponent moveComp2 = this.MoveComp;
					if (moveComp2 != null)
					{
						CharacterActorComponent actorComp = moveComp2.ActorComp;
						if (actorComp != null)
						{
							actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
							{
								Mode = EMovementMode.MOVE_Custom,
								CustomMode = 10,
								Context = "[CharacterKiteComponent.EnterKite]"
							});
						}
					}
					this.TargetPrevPos.DeepCopy(this.CurrentTarget.HookLocation);
					this.PrevLocationTime = 0f;
					this.PrevLocation.DeepCopy(this.MoveComp.ActorComp.ActorLocationProxy);
					this.UseNewKiteMode = (this.KiteConfigData != null);
					if (this.UseNewKiteMode)
					{
						this.KiteVelocity.Set(0.0, 0.0, 0.0);
						global::Vector tmpTargetPos = CharacterKiteComponent.TmpTargetPos;
						tmpTargetPos.DeepCopy(this.CurrentTarget.HookLocation);
						CharacterActorComponent actorComp2 = this.MoveComp.ActorComp;
						GravityUtils.Instance.AddZnInGravityForActor(actorComp2, tmpTargetPos, (double)(-(double)actorComp2.ScaledHalfHeight));
						global::Vector actorLocationProxy = this.MoveComp.ActorComp.ActorLocationProxy;
						this.KiteDistToTarget = global::Vector.Dist(tmpTargetPos, actorLocationProxy);
						this.TargetForwardInited = false;
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603DCB6 RID: 253110 RVA: 0x011EB898 File Offset: 0x011E9A98
		[NullableContext(2)]
		public unsafe void EnterKiteOnlyMonster(GrapplingHookPointComponent hookComp, Action onSuccess = null, Action onFailure = null)
		{
			if (hookComp == null)
			{
				Action onFailure2 = onFailure;
				if (onFailure2 != null)
				{
					onFailure2();
				}
				Log.Instance.Error(ELogModule.Character, ELogAuthor.CWZ, "[CharacterKiteComponent.EnterKiteOnlyMonster] 执行失败，没有HookPoint组件", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			Entity entity = base.Entity;
			BaseExploreComponent baseExploreComponent = (entity != null) ? entity.GetComponent<BaseExploreComponent>() : null;
			if (baseExploreComponent != null)
			{
				baseExploreComponent.InteractingTarget = hookComp;
			}
			Entity entity2 = base.Entity;
			CharacterGameplayCueComponent characterGameplayCueComponent = (entity2 != null) ? entity2.GetComponent<CharacterGameplayCueComponent>() : null;
			if (this.KiteHookCueHandle != 0 && characterGameplayCueComponent != null)
			{
				characterGameplayCueComponent.RemoveCueByHandle((long)this.KiteHookCueHandle);
			}
			this.KiteHookCueHandle = ((characterGameplayCueComponent != null) ? characterGameplayCueComponent.AddCue(7000000100L, null) : 0);
			long? num;
			if (hookComp == null)
			{
				num = null;
			}
			else
			{
				Entity entity3 = hookComp.Entity;
				if (entity3 == null)
				{
					num = null;
				}
				else
				{
					CreatureDataComponent component = entity3.GetComponent<CreatureDataComponent>();
					num = ((component != null) ? new long?(component.GetCreatureDataId()) : null);
				}
			}
			long? num2 = num;
			if (num2 != null)
			{
				long? num3 = num2;
				long num4 = 0L;
				if (!(num3.GetValueOrDefault() == num4 & num3 != null))
				{
					HookLockPointRequest hookLockPointRequest = HookLockPointRequest.Create();
					hookLockPointRequest.EntityId = MathUtils.Instance.NumberToLong(num2.GetValueOrDefault());
					this.EnterKite(hookComp);
					this.InMonsterKiteMove = true;
					FixHookClientLevelEventExecutor.ExecuteHookActions(FixHookClientLevelEventExecutor.EHookPointStage.ClientHook, hookComp);
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Character;
					ELogAuthor author = ELogAuthor.CWZ;
					string message = "[CharacterKiteComponent.EnterKiteOnlyMonster]";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("HookEntityId", hookComp.Entity.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("HookCreatureDataId", num2);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("CueHandle", this.KiteHookCueHandle);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
					Net.Instance.Call(ERequestMessageId.HookLockPointRequest, hookLockPointRequest, delegate(IMessage msg, Net.CallbackStatus _)
					{
						HookLockPointResponse hookLockPointResponse = (HookLockPointResponse)msg;
						if (hookLockPointResponse == null || hookLockPointResponse.ErrorCode > ErrorCode.Success)
						{
							Action onFailure4 = onFailure;
							if (onFailure4 != null)
							{
								onFailure4();
							}
							Log instance2 = Log.Instance;
							ELogModule module2 = ELogModule.Character;
							ELogAuthor author2 = ELogAuthor.CWZ;
							string message2 = "[CharacterKiteComponent.EnterKiteOnlyMonster] 执行失败";
							ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ErrorCode", (hookLockPointResponse != null) ? new ErrorCode?(hookLockPointResponse.ErrorCode) : null);
							instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
							return;
						}
						Action onSuccess2 = onSuccess;
						if (onSuccess2 == null)
						{
							return;
						}
						onSuccess2();
					}, 0);
					return;
				}
			}
			Action onFailure3 = onFailure;
			if (onFailure3 != null)
			{
				onFailure3();
			}
			Log.Instance.Error(ELogModule.Character, ELogAuthor.CWZ, "[CharacterKiteComponent.EnterKiteOnlyMonster] 执行失败，没有creatureDataId", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0603DCB7 RID: 253111 RVA: 0x011EBAF4 File Offset: 0x011E9CF4
		private void RemoveKiteCue()
		{
			if (this.KiteHookCueHandle != 0)
			{
				Entity entity = base.Entity;
				CharacterGameplayCueComponent characterGameplayCueComponent = (entity != null) ? entity.GetComponent<CharacterGameplayCueComponent>() : null;
				if (characterGameplayCueComponent != null)
				{
					characterGameplayCueComponent.RemoveCueByHandle((long)this.KiteHookCueHandle);
				}
				this.KiteHookCueHandle = 0;
			}
		}

		// Token: 0x0603DCB8 RID: 253112 RVA: 0x011EBB2C File Offset: 0x011E9D2C
		[NullableContext(2)]
		private unsafe void ExitKiteOnlyMonster(GrapplingHookPointComponent target)
		{
			if (target != null && target.Valid)
			{
				Entity entity = base.Entity;
				bool flag;
				if (entity == null)
				{
					flag = true;
				}
				else
				{
					BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
					flag = !((component != null) ? new bool?(component.IsAutonomousProxy) : null).GetValueOrDefault();
				}
				if (!flag)
				{
					this.InMonsterKiteMove = false;
					long creatureDataId = target.Entity.GetComponent<CreatureDataComponent>().GetCreatureDataId();
					HookLockPointExitRequest hookLockPointExitRequest = HookLockPointExitRequest.Create();
					hookLockPointExitRequest.EntityId = MathUtils.Instance.NumberToLong(creatureDataId);
					hookLockPointExitRequest.HookLockPointExitWay = HookLockPointExitWay.Endpoint;
					FixHookClientLevelEventExecutor.ExecuteHookActions(FixHookClientLevelEventExecutor.EHookPointStage.ClientEndpoint, target);
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Character;
					ELogAuthor author = ELogAuthor.CWZ;
					string message = "[CharacterKiteComponent.ExitKiteOnlyMonster]";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("HookEntityId", target.Entity.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("HookCreatureDataId", creatureDataId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("CueHandle", this.KiteHookCueHandle);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
					this.RemoveKiteCue();
					Net.Instance.Call(ERequestMessageId.HookLockPointExitRequest, hookLockPointExitRequest, delegate(IMessage response, Net.CallbackStatus _)
					{
					}, 0);
					if (target.WillBeDestroyedAfterHook)
					{
						HookLockPointFinishRequest hookLockPointFinishRequest = HookLockPointFinishRequest.Create();
						hookLockPointFinishRequest.EntityId = creatureDataId;
						Net.Instance.Call(ERequestMessageId.HookLockPointFinishRequest, hookLockPointFinishRequest, delegate(IMessage response, Net.CallbackStatus _)
						{
						}, 0);
						return;
					}
					if (target.WillBeHideAfterHook)
					{
						CreatureController.Instance.SetEntityEnable(target.Entity, false, "ExitKiteOnlyMonster.SendHookEndRequest", true);
					}
					return;
				}
			}
		}

		// Token: 0x0603DCB9 RID: 253113 RVA: 0x011EBD10 File Offset: 0x011E9F10
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterKiteComponent characterKiteComponent = (CharacterKiteComponent)componentTemplate;
			if (characterKiteComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
			{
				return false;
			}
			if (characterKiteComponent.TargetPrevPos != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TargetPrevPos), "TargetPrevPos"))
			{
				return false;
			}
			if (characterKiteComponent.CurrentTarget == null)
			{
				this.CurrentTarget = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurrentTarget), "CurrentTarget"))
			{
				return false;
			}
			this.LastTargetEndCount = characterKiteComponent.LastTargetEndCount;
			this.LastTargetMoveBrokenCount = characterKiteComponent.LastTargetMoveBrokenCount;
			if (characterKiteComponent.PrevLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.PrevLocation), "PrevLocation"))
			{
				return false;
			}
			this.PrevLocationTime = characterKiteComponent.PrevLocationTime;
			this.PrevLocationBlockCount = characterKiteComponent.PrevLocationBlockCount;
			this.RefTargetForward = characterKiteComponent.RefTargetForward;
			this.UseNewKiteMode = characterKiteComponent.UseNewKiteMode;
			if (characterKiteComponent.KiteVelocity != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.KiteVelocity), "KiteVelocity"))
			{
				return false;
			}
			this.KiteDistToTarget = characterKiteComponent.KiteDistToTarget;
			if (characterKiteComponent.TargetForward != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TargetForward), "TargetForward"))
			{
				return false;
			}
			this.TargetForwardInited = characterKiteComponent.TargetForwardInited;
			if (characterKiteComponent.KiteConfigData == null)
			{
				this.KiteConfigData = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.KiteConfigData), "KiteConfigData"))
			{
				return false;
			}
			this.InMonsterKiteMove = characterKiteComponent.InMonsterKiteMove;
			this.KiteHookCueHandle = characterKiteComponent.KiteHookCueHandle;
			return true;
		}

		// Token: 0x1700753E RID: 30014
		// (get) Token: 0x0603DCBA RID: 253114 RVA: 0x011EBEB1 File Offset: 0x011EA0B1
		public override bool NeedInitInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700753F RID: 30015
		// (get) Token: 0x0603DCBB RID: 253115 RVA: 0x011EBEB4 File Offset: 0x011EA0B4
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007540 RID: 30016
		// (get) Token: 0x0603DCBC RID: 253116 RVA: 0x011EBEB7 File Offset: 0x011EA0B7
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020C8C RID: 134284
		private const float KITE_MIN_ACCEL_DIST = 300f;

		// Token: 0x04020C8D RID: 134285
		private const float KITE_MAX_ACCEL_DIST = 900f;

		// Token: 0x04020C8E RID: 134286
		private const float KITE_MIN_ACCEL = 1200f;

		// Token: 0x04020C8F RID: 134287
		private const float KITE_MAX_ACCEL = 18000f;

		// Token: 0x04020C90 RID: 134288
		private const float KITE_FRICTION = 0.98f;

		// Token: 0x04020C91 RID: 134289
		private const float KITE_FACING_LERP_SPEED = 240f;

		// Token: 0x04020C92 RID: 134290
		private const float KITE_FACING_LERP_RATE = 0.9f;

		// Token: 0x04020C93 RID: 134291
		private const float KITE_MAX_BLOCK = 1f;

		// Token: 0x04020C94 RID: 134292
		private const float BLOCK_DIST_THRESHOLD_SQUARED = 40000f;

		// Token: 0x04020C95 RID: 134293
		private const int KITE_BLOCK_COUNT = 3;

		// Token: 0x04020C96 RID: 134294
		private static readonly int hookKeepAttachedTag = GameplayTagDefine.EGameplayTagId["关卡.Common.表现.钩锁不自动脱离"];

		// Token: 0x04020C97 RID: 134295
		private const long HOOK_BUFF_EFFECT_CUE = 7000000100L;

		// Token: 0x04020C98 RID: 134296
		[Nullable(2)]
		private CharacterMoveComponent MoveComp;

		// Token: 0x04020C99 RID: 134297
		private readonly global::Vector TargetPrevPos = global::Vector.Create();

		// Token: 0x04020C9A RID: 134298
		[Nullable(2)]
		private GrapplingHookPointComponent CurrentTarget;

		// Token: 0x04020C9B RID: 134299
		private int LastTargetEndCount;

		// Token: 0x04020C9C RID: 134300
		private int LastTargetMoveBrokenCount;

		// Token: 0x04020C9D RID: 134301
		private readonly global::Vector PrevLocation = global::Vector.Create();

		// Token: 0x04020C9E RID: 134302
		private float PrevLocationTime;

		// Token: 0x04020C9F RID: 134303
		private int PrevLocationBlockCount;

		// Token: 0x04020CA0 RID: 134304
		private FVector RefTargetForward;

		// Token: 0x04020CA1 RID: 134305
		private bool UseNewKiteMode = true;

		// Token: 0x04020CA2 RID: 134306
		private readonly global::Vector KiteVelocity = global::Vector.Create();

		// Token: 0x04020CA3 RID: 134307
		private double KiteDistToTarget;

		// Token: 0x04020CA4 RID: 134308
		private readonly global::Vector TargetForward = global::Vector.Create();

		// Token: 0x04020CA5 RID: 134309
		private bool TargetForwardInited;

		// Token: 0x04020CA6 RID: 134310
		[Nullable(2)]
		private CharacterKiteComponent.KiteConfig KiteConfigData;

		// Token: 0x04020CA7 RID: 134311
		[StaticVariableRuleIgnore]
		private static readonly global::Vector TmpTargetPos = global::Vector.Create();

		// Token: 0x04020CA8 RID: 134312
		[StaticVariableRuleIgnore]
		private static readonly global::Vector TmpGravityDelta = global::Vector.Create();

		// Token: 0x04020CA9 RID: 134313
		[StaticVariableRuleIgnore]
		private static readonly global::Vector TmpTentativePos = global::Vector.Create();

		// Token: 0x04020CAA RID: 134314
		[StaticVariableRuleIgnore]
		private static readonly global::Vector TmpMoveDelta = global::Vector.Create();

		// Token: 0x04020CAB RID: 134315
		[StaticVariableRuleIgnore]
		private static readonly global::Vector TmpToTarget = global::Vector.Create();

		// Token: 0x04020CAC RID: 134316
		[StaticVariableRuleIgnore]
		private static readonly global::Vector TmpNewTargetForward = global::Vector.Create();

		// Token: 0x04020CAD RID: 134317
		[StaticVariableRuleIgnore]
		private static readonly global::Vector TmpActorForward = global::Vector.Create();

		// Token: 0x04020CAE RID: 134318
		[StaticVariableRuleIgnore]
		private static readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04020CAF RID: 134319
		[StaticVariableRuleIgnore]
		private static readonly Quat TmpQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04020CB0 RID: 134320
		[StaticVariableRuleIgnore]
		private static readonly global::Rotator TmpRotator = global::Rotator.Create();

		// Token: 0x04020CB1 RID: 134321
		private bool InMonsterKiteMove;

		// Token: 0x04020CB2 RID: 134322
		private int KiteHookCueHandle;

		// Token: 0x0200BB69 RID: 47977
		[NullableContext(0)]
		private class KiteConfig
		{
			// Token: 0x040399F5 RID: 236021
			public float Gravity;

			// Token: 0x040399F6 RID: 236022
			public float InertiaDecay;

			// Token: 0x040399F7 RID: 236023
			public float MinDist;

			// Token: 0x040399F8 RID: 236024
			public float ShrinkSpeed;
		}
	}
}
