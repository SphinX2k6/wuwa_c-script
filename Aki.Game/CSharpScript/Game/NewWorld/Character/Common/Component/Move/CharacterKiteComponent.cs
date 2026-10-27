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
	// Token: 0x020070E5 RID: 28901
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterKiteComponent : EntityComponent, IComponentDependency
	{
		// Token: 0x17009CBA RID: 40122
		// (get) Token: 0x060468B9 RID: 288953 RVA: 0x011BB9BF File Offset: 0x011B9BBF
		public static Type[] Dependencies
		{
			get
			{
				return new Type[]
				{
					typeof(CharacterMoveComponent)
				};
			}
		}

		// Token: 0x060468BA RID: 288954 RVA: 0x011BB9D4 File Offset: 0x011B9BD4
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

		// Token: 0x060468BB RID: 288955 RVA: 0x011BB9F8 File Offset: 0x011B9BF8
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

		// Token: 0x060468BC RID: 288956 RVA: 0x011BBCC0 File Offset: 0x011B9EC0
		private void KiteMoveOld(float deltaSeconds)
		{
			FVector targetPrevPos = UKismetMathLibrary.WD_WorldToLocal(GlobalData.World, this.TargetPrevPos.ToUeVector(false));
			FVector targetNextPos = UKismetMathLibrary.WD_WorldToLocal(GlobalData.World, this.CurrentTarget.HookLocation.ToUeVector(false));
			UKuroMovementBPLibrary.KuroKite(deltaSeconds, this.MoveComp.CharacterMovement, targetPrevPos, targetNextPos, 300f, 900f, 1200f, 18000f, 0.98f, ref this.RefTargetForward, 240f, 0.9f);
		}

		// Token: 0x060468BD RID: 288957 RVA: 0x011BBD40 File Offset: 0x011B9F40
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

		// Token: 0x060468BE RID: 288958 RVA: 0x011BBF10 File Offset: 0x011BA110
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

		// Token: 0x060468BF RID: 288959 RVA: 0x011BC11B File Offset: 0x011BA31B
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x060468C0 RID: 288960 RVA: 0x011BC11E File Offset: 0x011BA31E
		protected override bool OnStart()
		{
			this.MoveComp = base.Entity.GetComponent<CharacterMoveComponent>();
			EventSystem.Instance.AddWithTarget<global::ECharMoveState, global::ECharMoveState>(base.Entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<global::ECharMoveState, global::ECharMoveState>(this.OnMoveStateChanged));
			return true;
		}

		// Token: 0x060468C1 RID: 288961 RVA: 0x011BC154 File Offset: 0x011BA354
		protected override bool OnEnd()
		{
			EventSystem.Instance.RemoveWithTarget<global::ECharMoveState, global::ECharMoveState>(base.Entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<global::ECharMoveState, global::ECharMoveState>(this.OnMoveStateChanged));
			this.RemoveKiteCue();
			return true;
		}

		// Token: 0x060468C2 RID: 288962 RVA: 0x011BC180 File Offset: 0x011BA380
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

		// Token: 0x060468C3 RID: 288963 RVA: 0x011BC3D4 File Offset: 0x011BA5D4
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

		// Token: 0x060468C4 RID: 288964 RVA: 0x011BC630 File Offset: 0x011BA830
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

		// Token: 0x060468C5 RID: 288965 RVA: 0x011BC668 File Offset: 0x011BA868
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

		// Token: 0x060468C6 RID: 288966 RVA: 0x011BC84C File Offset: 0x011BAA4C
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterKiteComponent characterKiteComponent = (CharacterKiteComponent)componentTemplate;
			if (base.CanResetComponentProperty("MoveComp"))
			{
				if (characterKiteComponent.MoveComp == null)
				{
					this.MoveComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterMoveComponent>(this.MoveComp), "MoveComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TargetPrevPos") && characterKiteComponent.TargetPrevPos != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TargetPrevPos), "TargetPrevPos"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("CurrentTarget"))
			{
				if (characterKiteComponent.CurrentTarget == null)
				{
					this.CurrentTarget = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<GrapplingHookPointComponent>(this.CurrentTarget), "CurrentTarget"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("LastTargetEndCount"))
			{
				this.LastTargetEndCount = characterKiteComponent.LastTargetEndCount;
			}
			if (base.CanResetComponentProperty("LastTargetMoveBrokenCount"))
			{
				this.LastTargetMoveBrokenCount = characterKiteComponent.LastTargetMoveBrokenCount;
			}
			if (base.CanResetComponentProperty("PrevLocation") && characterKiteComponent.PrevLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.PrevLocation), "PrevLocation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("PrevLocationTime"))
			{
				this.PrevLocationTime = characterKiteComponent.PrevLocationTime;
			}
			if (base.CanResetComponentProperty("PrevLocationBlockCount"))
			{
				this.PrevLocationBlockCount = characterKiteComponent.PrevLocationBlockCount;
			}
			if (base.CanResetComponentProperty("RefTargetForward"))
			{
				this.RefTargetForward = characterKiteComponent.RefTargetForward;
			}
			if (base.CanResetComponentProperty("UseNewKiteMode"))
			{
				this.UseNewKiteMode = characterKiteComponent.UseNewKiteMode;
			}
			if (base.CanResetComponentProperty("KiteVelocity") && characterKiteComponent.KiteVelocity != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.KiteVelocity), "KiteVelocity"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("KiteDistToTarget"))
			{
				this.KiteDistToTarget = characterKiteComponent.KiteDistToTarget;
			}
			if (base.CanResetComponentProperty("TargetForward") && characterKiteComponent.TargetForward != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TargetForward), "TargetForward"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TargetForwardInited"))
			{
				this.TargetForwardInited = characterKiteComponent.TargetForwardInited;
			}
			if (base.CanResetComponentProperty("KiteConfigData"))
			{
				if (characterKiteComponent.KiteConfigData == null)
				{
					this.KiteConfigData = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterKiteComponent.KiteConfig>(this.KiteConfigData), "KiteConfigData"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("InMonsterKiteMove"))
			{
				this.InMonsterKiteMove = characterKiteComponent.InMonsterKiteMove;
			}
			if (base.CanResetComponentProperty("KiteHookCueHandle"))
			{
				this.KiteHookCueHandle = characterKiteComponent.KiteHookCueHandle;
			}
			return true;
		}

		// Token: 0x04024FF7 RID: 151543
		private const float KITE_MIN_ACCEL_DIST = 300f;

		// Token: 0x04024FF8 RID: 151544
		private const float KITE_MAX_ACCEL_DIST = 900f;

		// Token: 0x04024FF9 RID: 151545
		private const float KITE_MIN_ACCEL = 1200f;

		// Token: 0x04024FFA RID: 151546
		private const float KITE_MAX_ACCEL = 18000f;

		// Token: 0x04024FFB RID: 151547
		private const float KITE_FRICTION = 0.98f;

		// Token: 0x04024FFC RID: 151548
		private const float KITE_FACING_LERP_SPEED = 240f;

		// Token: 0x04024FFD RID: 151549
		private const float KITE_FACING_LERP_RATE = 0.9f;

		// Token: 0x04024FFE RID: 151550
		private const float KITE_MAX_BLOCK = 1f;

		// Token: 0x04024FFF RID: 151551
		private const float BLOCK_DIST_THRESHOLD_SQUARED = 40000f;

		// Token: 0x04025000 RID: 151552
		private const int KITE_BLOCK_COUNT = 3;

		// Token: 0x04025001 RID: 151553
		private static readonly int hookKeepAttachedTag = GameplayTagDefine.EGameplayTagId["关卡.Common.表现.钩锁不自动脱离"];

		// Token: 0x04025002 RID: 151554
		private const long HOOK_BUFF_EFFECT_CUE = 7000000100L;

		// Token: 0x04025003 RID: 151555
		[Nullable(2)]
		private CharacterMoveComponent MoveComp;

		// Token: 0x04025004 RID: 151556
		private readonly global::Vector TargetPrevPos = global::Vector.Create();

		// Token: 0x04025005 RID: 151557
		[Nullable(2)]
		private GrapplingHookPointComponent CurrentTarget;

		// Token: 0x04025006 RID: 151558
		private int LastTargetEndCount;

		// Token: 0x04025007 RID: 151559
		private int LastTargetMoveBrokenCount;

		// Token: 0x04025008 RID: 151560
		private readonly global::Vector PrevLocation = global::Vector.Create();

		// Token: 0x04025009 RID: 151561
		private float PrevLocationTime;

		// Token: 0x0402500A RID: 151562
		private int PrevLocationBlockCount;

		// Token: 0x0402500B RID: 151563
		private FVector RefTargetForward;

		// Token: 0x0402500C RID: 151564
		private bool UseNewKiteMode = true;

		// Token: 0x0402500D RID: 151565
		private readonly global::Vector KiteVelocity = global::Vector.Create();

		// Token: 0x0402500E RID: 151566
		private double KiteDistToTarget;

		// Token: 0x0402500F RID: 151567
		private readonly global::Vector TargetForward = global::Vector.Create();

		// Token: 0x04025010 RID: 151568
		private bool TargetForwardInited;

		// Token: 0x04025011 RID: 151569
		[Nullable(2)]
		private CharacterKiteComponent.KiteConfig KiteConfigData;

		// Token: 0x04025012 RID: 151570
		[StaticVariableRuleIgnore]
		private static readonly global::Vector TmpTargetPos = global::Vector.Create();

		// Token: 0x04025013 RID: 151571
		[StaticVariableRuleIgnore]
		private static readonly global::Vector TmpGravityDelta = global::Vector.Create();

		// Token: 0x04025014 RID: 151572
		[StaticVariableRuleIgnore]
		private static readonly global::Vector TmpTentativePos = global::Vector.Create();

		// Token: 0x04025015 RID: 151573
		[StaticVariableRuleIgnore]
		private static readonly global::Vector TmpMoveDelta = global::Vector.Create();

		// Token: 0x04025016 RID: 151574
		[StaticVariableRuleIgnore]
		private static readonly global::Vector TmpToTarget = global::Vector.Create();

		// Token: 0x04025017 RID: 151575
		[StaticVariableRuleIgnore]
		private static readonly global::Vector TmpNewTargetForward = global::Vector.Create();

		// Token: 0x04025018 RID: 151576
		[StaticVariableRuleIgnore]
		private static readonly global::Vector TmpActorForward = global::Vector.Create();

		// Token: 0x04025019 RID: 151577
		[StaticVariableRuleIgnore]
		private static readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0402501A RID: 151578
		[StaticVariableRuleIgnore]
		private static readonly Quat TmpQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0402501B RID: 151579
		[StaticVariableRuleIgnore]
		private static readonly global::Rotator TmpRotator = global::Rotator.Create();

		// Token: 0x0402501C RID: 151580
		private bool InMonsterKiteMove;

		// Token: 0x0402501D RID: 151581
		private int KiteHookCueHandle;

		// Token: 0x0200CE70 RID: 52848
		[NullableContext(0)]
		private class KiteConfig
		{
			// Token: 0x0403E250 RID: 254544
			public float Gravity;

			// Token: 0x0403E251 RID: 254545
			public float InertiaDecay;

			// Token: 0x0403E252 RID: 254546
			public float MinDist;

			// Token: 0x0403E253 RID: 254547
			public float ShrinkSpeed;
		}
	}
}
