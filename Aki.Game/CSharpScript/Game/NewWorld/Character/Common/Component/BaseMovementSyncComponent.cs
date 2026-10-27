using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.CombatMessage;
using CSharpScript.Game.Utils;
using CSharpScript.Typing;
using Google.Protobuf;
using Google.Protobuf.Collections;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x020070BD RID: 28861
	[NullableContext(1)]
	[Nullable(0)]
	public class BaseMovementSyncComponent : EntityComponent, IMoveSync
	{
		// Token: 0x060465E9 RID: 288233 RVA: 0x011A31BF File Offset: 0x011A13BF
		protected virtual bool DefaultEnableMovementSync()
		{
			return false;
		}

		// Token: 0x17009C85 RID: 40069
		// (get) Token: 0x060465EA RID: 288234 RVA: 0x011A31C2 File Offset: 0x011A13C2
		// (set) Token: 0x060465EB RID: 288235 RVA: 0x011A31CC File Offset: 0x011A13CC
		protected bool EnableMovementSync
		{
			get
			{
				return this.EnableMovementSyncInternal;
			}
			set
			{
				if (this.EnableMovementSyncInternal == value)
				{
					return;
				}
				this.EnableMovementSyncInternal = value;
				if (!this.Activated)
				{
					return;
				}
				if (value)
				{
					this.RecordLastData(false);
					this.ClearPendingMoveInfos();
					this.CollectSampleAndSend(false);
					CombatMessageController.Instance.RegisterPreTick(this, new Action<float>(this.CustomPreTick));
					CombatMessageController.Instance.RegisterAfterTick(this, new Action<float>(this.CustomAfterTick));
					return;
				}
				this.ClearReplaySamples();
				this.ClearPendingMoveInfos();
				CombatMessageController.Instance.UnregisterPreTick(this);
				CombatMessageController.Instance.UnregisterAfterTick(this);
			}
		}

		// Token: 0x060465EC RID: 288236 RVA: 0x011A325B File Offset: 0x011A145B
		protected override bool OnInit()
		{
			this.EnableMovementSync = this.DefaultEnableMovementSync();
			return true;
		}

		// Token: 0x060465ED RID: 288237 RVA: 0x011A326C File Offset: 0x011A146C
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<BaseActorComponent>();
			this.TimeScaleComp = base.Entity.GetComponent<CharacterTimeScaleComponent>();
			this.MoveComp = base.Entity.GetComponent<BaseMoveComponent>();
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			if (!CombatMessageModel.Instance.AddMoveSync(this))
			{
				CombatLog.Instance.Warn(CombatLog.EDebugModule.Move, base.Entity, "重复添加移动同步", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return true;
		}

		// Token: 0x060465EE RID: 288238 RVA: 0x011A32EC File Offset: 0x011A14EC
		protected override bool OnEnd()
		{
			if (!CombatMessageModel.Instance.DeleteMoveSync(this))
			{
				CombatLog.Instance.Warn(CombatLog.EDebugModule.Move, base.Entity, "移除移动同步失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.EnableMovementSync = false;
			return true;
		}

		// Token: 0x060465EF RID: 288239 RVA: 0x011A332E File Offset: 0x011A152E
		protected virtual void ApplyInput(int input, global::Rotator rotation)
		{
		}

		// Token: 0x17009C86 RID: 40070
		// (get) Token: 0x060465F0 RID: 288240 RVA: 0x011A3330 File Offset: 0x011A1530
		// (set) Token: 0x060465F1 RID: 288241 RVA: 0x011A3338 File Offset: 0x011A1538
		public List<MoveReplaySample> PendingMoveInfos { get; set; } = new List<MoveReplaySample>();

		// Token: 0x060465F2 RID: 288242 RVA: 0x011A3344 File Offset: 0x011A1544
		protected override void OnActivate()
		{
			if (this.LastReceiveMoveSample != null && Time.Instance.NowSeconds >= this.LastReceiveMoveSample.TimeStamp)
			{
				this.ActorComp.SetActorLocationAndRotation(this.LastReceiveMoveSample.Location.ToUeVector(false), this.LastReceiveMoveSample.Rotation.ToUeRotator(), "角色移动同步.处理出生位置刷新", false, null);
				this.LastLocation.DeepCopy(this.LastReceiveMoveSample.Location);
				this.LastRotation.DeepCopy(this.LastReceiveMoveSample.Rotation);
			}
			else
			{
				global::Vector lastLocation = this.LastLocation;
				FVectorDouble fvectorDouble = this.ActorComp.Owner.D_K2_GetActorLocation();
				lastLocation.DeepCopy(fvectorDouble);
				global::Rotator lastRotation = this.LastRotation;
				FRotator frotator = this.ActorComp.Owner.K2_GetActorRotation();
				lastRotation.DeepCopy(frotator);
			}
			if (this.ActorComp.IsMoveAutonomousProxy)
			{
				this.CollectSampleAndSend(false);
			}
			this.LastMoveAutonomousProxy = this.ActorComp.IsMoveAutonomousProxy;
			if (this.EnableMovementSyncInternal)
			{
				CombatMessageController.Instance.RegisterPreTick(this, new Action<float>(this.CustomPreTick));
				CombatMessageController.Instance.RegisterAfterTick(this, new Action<float>(this.CustomAfterTick));
			}
			this.Activated = true;
		}

		// Token: 0x060465F3 RID: 288243 RVA: 0x011A347C File Offset: 0x011A167C
		public virtual MoveReplaySample GetCurrentMoveSample()
		{
			MoveReplaySample moveReplaySample = MoveReplaySample.Create();
			moveReplaySample.Location = new Aki.Protocol.Vector
			{
				X = (float)this.ActorComp.ActorLocationProxy.X,
				Y = (float)this.ActorComp.ActorLocationProxy.Y,
				Z = (float)this.ActorComp.ActorLocationProxy.Z
			};
			moveReplaySample.Rotation = new Aki.Protocol.Rotator
			{
				Pitch = this.ActorComp.ActorRotationProxy.Pitch,
				Roll = this.ActorComp.ActorRotationProxy.Roll,
				Yaw = this.ActorComp.ActorRotationProxy.Yaw
			};
			moveReplaySample.ServerTimeStamp = (long)Time.Instance.CombatServerTime;
			moveReplaySample.TimeStamp = (float)Time.Instance.NowSeconds;
			if (base.Entity.GetTickInterval() > 1 && this.LastLogicTickTime > 0.0 && this.NowLogicTickTime > 0.0)
			{
				moveReplaySample.TickInterval = (int)((this.NowLogicTickTime - this.LastLogicTickTime) * 1000.0);
			}
			moveReplaySample.RTT = (int)Net.Instance.RttMs;
			MoveReplaySample moveReplaySample2 = moveReplaySample;
			float timeDilation = base.Entity.TimeDilation;
			CharacterTimeScaleComponent timeScaleComp = this.TimeScaleComp;
			moveReplaySample2.TimeScale = timeDilation * ((timeScaleComp != null) ? timeScaleComp.CurrentTimeScale : 1f);
			this.LastMoveSample = moveReplaySample;
			this.CompressData(moveReplaySample);
			return moveReplaySample;
		}

		// Token: 0x060465F4 RID: 288244 RVA: 0x011A35E4 File Offset: 0x011A17E4
		protected void CompressData(MoveReplaySample data)
		{
			if (!GameModeModel.Instance.IsMulti)
			{
				data.LinearVelocity = null;
				data.MovementMode = 0;
				data.InputDirection = 0;
				data.RelativeMoveReplaySample = null;
				data.ControllerPitch = 0f;
				data.TimeScale = 0f;
				data.ServerTimeStamp = 0L;
				data.RTT = 0;
				data.SlideForward = null;
				data.TickInterval = 0;
				return;
			}
			if (Info.Instance.IsBuildDevelopmentOrDebug)
			{
				data.ServerTimeStamp = 0L;
				data.RTT = 0;
			}
		}

		// Token: 0x060465F5 RID: 288245 RVA: 0x011A3668 File Offset: 0x011A1868
		protected virtual void RecordLastData(bool isMove = false)
		{
			this.LastLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
			this.LastRotation.DeepCopy(this.ActorComp.ActorRotationProxy);
			this.LastMoveAutonomousProxy = this.ActorComp.IsMoveAutonomousProxy;
			this.LastMove = isMove;
		}

		// Token: 0x060465F6 RID: 288246 RVA: 0x011A36B9 File Offset: 0x011A18B9
		protected override void OnTick(float delta)
		{
			this.LastLogicTickTime = this.NowLogicTickTime;
			this.NowLogicTickTime = Time.Instance.NowSeconds;
		}

		// Token: 0x060465F7 RID: 288247 RVA: 0x011A36D7 File Offset: 0x011A18D7
		private void CustomPreTick(float delta)
		{
			this.CustomPreTickInternal(delta);
		}

		// Token: 0x060465F8 RID: 288248 RVA: 0x011A36E0 File Offset: 0x011A18E0
		protected unsafe virtual void CustomPreTickInternal(float delta)
		{
			if (this.ActorComp.IsMoveAutonomousProxy)
			{
				return;
			}
			if (base.Entity.GetComponent<BaseTagComponent>().HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.被抓取"]))
			{
				return;
			}
			this.IsPending = false;
			this.PendingMoveInfos.Clear();
			this.TickReplaySamples();
			if (this.LastMoveAutonomousProxy)
			{
				double num = global::Vector.Dist(this.LastLocation, this.ActorComp.ActorLocationProxy);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MultiplayerCombat;
				ELogAuthor author = ELogAuthor.WCL;
				string message = "ChangeControl";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("control", this.ActorComp.IsMoveAutonomousProxy);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("diffDistance", num);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.ReportMoveDataDragDistance((float)num, false);
			}
		}

		// Token: 0x060465F9 RID: 288249 RVA: 0x011A37CC File Offset: 0x011A19CC
		protected virtual bool GetIsMoving()
		{
			return !this.LastLocation.Equals(this.ActorComp.ActorLocationProxy, 9.999999747378752E-05) || !this.LastRotation.Equals(this.ActorComp.ActorRotationProxy, 0.0001f);
		}

		// Token: 0x060465FA RID: 288250 RVA: 0x011A381A File Offset: 0x011A1A1A
		protected virtual bool GetImportantMove(bool moving)
		{
			return !moving && this.LastMove;
		}

		// Token: 0x060465FB RID: 288251 RVA: 0x011A3827 File Offset: 0x011A1A27
		protected virtual bool GetSecondaryImportantMove()
		{
			return false;
		}

		// Token: 0x060465FC RID: 288252 RVA: 0x011A382A File Offset: 0x011A1A2A
		private void CustomAfterTick(float delta)
		{
			this.CustomAfterTickInternal(delta);
		}

		// Token: 0x060465FD RID: 288253 RVA: 0x011A3834 File Offset: 0x011A1A34
		protected virtual void CustomAfterTickInternal(float delta)
		{
			if (!this.EnableMovementSync || !this.ActorComp.IsMoveAutonomousProxy)
			{
				this.RecordLastData(false);
				return;
			}
			if (this.LastApplyLogicTickTime > 0.0 && this.LastApplyLogicTickTime == this.NowLogicTickTime)
			{
				return;
			}
			this.LastApplyLogicTickTime = this.NowLogicTickTime;
			this.ControllerPlayerId = CreatureModel.Instance.GetPlayerId();
			this.ClearReplaySamples();
			bool isMoving = this.GetIsMoving();
			bool importantMove = this.GetImportantMove(isMoving);
			if (!GameModeModel.Instance.IsMulti)
			{
				this.TryPushMoveSingle(isMoving, this.ActorComp.ActorLocationProxy, this.ActorComp.ActorRotationProxy);
			}
			else
			{
				this.TryPushMoveMulti(isMoving, importantMove, this.ActorComp.ActorLocationProxy);
			}
			this.RecordLastData(isMoving);
		}

		// Token: 0x060465FE RID: 288254 RVA: 0x011A38F4 File Offset: 0x011A1AF4
		protected void TryPushMoveSingle(bool isMoving, global::Vector location, global::Rotator rotation)
		{
			bool flag = Time.Instance.NowSeconds - this.LastSendTime >= (double)this.SingleModeSendInterval;
			bool flag2 = !this.LastSendLocation.Equals(location, (double)BaseMovementSyncComponent.SingleModeSendLocationTolerance) || !this.LastSendRotation.Equals(rotation, BaseMovementSyncComponent.SingleModeSendRotationTolerance);
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			int? num = (baseCharacter != null) ? new int?(baseCharacter.EntityId) : null;
			int id = base.Entity.Id;
			bool flag3 = (num.GetValueOrDefault() == id & num != null) && !this.LastSendLocation.Equals(location, (double)BaseMovementSyncComponent.SingleModeSendLocationToleranceMax);
			if (!isMoving && this.LastMove)
			{
				MoveReplaySample currentMoveSample = this.GetCurrentMoveSample();
				this.PendingMoveInfos.Add(currentMoveSample);
				CombatMessageModel.Instance.NeedPushMove = true;
				return;
			}
			if ((isMoving && flag2) || flag3)
			{
				if (flag || flag3)
				{
					MoveReplaySample currentMoveSample2 = this.GetCurrentMoveSample();
					this.PendingMoveInfos.Add(currentMoveSample2);
					CombatMessageModel.Instance.NeedPushMove = true;
					return;
				}
				if (this.GetSecondaryImportantMove())
				{
					MoveReplaySample currentMoveSample3 = this.GetCurrentMoveSample();
					this.PendingMoveInfos.Add(currentMoveSample3);
				}
			}
		}

		// Token: 0x060465FF RID: 288255 RVA: 0x011A3A1C File Offset: 0x011A1C1C
		protected unsafe void TryPushMoveMulti(bool isMoving, bool importantMove, global::Vector location)
		{
			if (!this.LastMoveAutonomousProxy)
			{
				double num = global::Vector.Dist(this.LastLocation, location);
				this.ReportMoveDataDragDistance((float)num, true);
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Move;
				Entity entity = base.Entity;
				string message = "移动来源切换自身";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("上个控制者", this.ControllerPlayerId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("当前控制者", CreatureModel.Instance.GetPlayerId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("位移距离", num);
				instance.Info(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
			if (CombatDebugDrawController.Instance.DebugMonsterMovePath && component.GetEntityType() == EEntityType.Monster)
			{
				UKismetSystemLibrary.D_DrawDebugLine(GlobalData.World, this.LastLocation.ToUeVector(false), location.ToUeVector(false), new FLinearColor(0f, 1f, 0f, 1f), 15f, 0f);
			}
			if (!CombatMessageModel.Instance.MoveSyncUdpMode)
			{
				if (!this.IsPending)
				{
					if (!isMoving)
					{
						return;
					}
					this.IsPending = true;
					this.PendingTime = Time.Instance.NowSeconds;
					this.PendingMoveInfos.Clear();
				}
				MoveReplaySample currentMoveSample = this.GetCurrentMoveSample();
				new ReplaySample(currentMoveSample, CreatureModel.Instance.GetPlayerId(), Time.Instance.NowSeconds).TimeStamp = Time.Instance.NowSeconds;
				this.PendingMoveInfos.Add(currentMoveSample);
				if (Time.Instance.NowSeconds >= this.PendingTime + (double)BaseMovementSyncComponent.PendingMoveCacheTime || !isMoving)
				{
					CombatMessageModel.Instance.NeedPushMove = true;
				}
				return;
			}
			if (importantMove)
			{
				this.CollectSampleAndSend(true);
				return;
			}
			if (isMoving)
			{
				this.CollectSampleAndSendUdp();
			}
		}

		// Token: 0x06046600 RID: 288256 RVA: 0x011A3BEC File Offset: 0x011A1DEC
		protected void UpdateForcePushFlag(MovePackagePush movePkg)
		{
			if (!GameModeModel.Instance.IsMulti)
			{
				return;
			}
			if (!this.ActorComp || !this.ActorComp.IsAutonomousProxy)
			{
				return;
			}
			foreach (MovingEntityData movingEntityData in movePkg.MovingEntities)
			{
				foreach (MoveReplaySample moveReplaySample in movingEntityData.MoveInfos)
				{
					if (this.PkgLastTimeScale != 1f && moveReplaySample.TimeScale == 1f)
					{
						movingEntityData.ForcePush = true;
						this.PkgLastTimeScale = 1f;
						break;
					}
					this.PkgLastTimeScale = moveReplaySample.TimeScale;
				}
			}
		}

		// Token: 0x06046601 RID: 288257 RVA: 0x011A3CCC File Offset: 0x011A1ECC
		public virtual void CollectSampleAndSend(bool immediately = false)
		{
			MoveReplaySample currentMoveSample = this.GetCurrentMoveSample();
			this.PendingMoveInfos.Add(currentMoveSample);
			if (immediately)
			{
				MovePackagePush movePackagePush = MovePackagePush.Create();
				movePackagePush.SceneOwnerId = (GameModeModel.Instance.IsMulti ? OnlineModel.Instance.OwnerId : CreatureModel.Instance.GetPlayerId());
				MovingEntityData movingEntityData = this.CollectPendingMoveInfos();
				if (movingEntityData != null)
				{
					movePackagePush.MovingEntities.Add(movingEntityData);
					this.UpdateForcePushFlag(movePackagePush);
				}
				Net.Instance.Send(EPushMessageId.MovePackagePush, movePackagePush);
				if (Info.Instance.IsBuildDevelopmentOrDebug)
				{
					string data = Json.Encode(new Dictionary<string, object>
					{
						{
							"scene_id",
							CreatureModel.Instance.GetSceneId()
						},
						{
							"instance_id",
							CreatureModel.Instance.GetInstanceId()
						},
						{
							"msg_id",
							24756
						},
						{
							"immediately",
							true
						},
						{
							"sub_count",
							movePackagePush.MovingEntities.Count
						},
						{
							"is_multi",
							GameModeModel.Instance.IsMulti
						},
						{
							"ed",
							BaseMovementSyncComponent.IsWithEditor
						},
						{
							"br",
							LogAnalyzer.Instance.GetBranch()
						}
					}, null);
					CombatDebugController.Instance.DataReport("COMBAT_MESSAGE_COUNT", data);
				}
				this.LastSendTime = Time.Instance.NowSeconds;
				return;
			}
			CombatMessageModel.Instance.NeedPushMove = true;
		}

		// Token: 0x06046602 RID: 288258 RVA: 0x011A3E48 File Offset: 0x011A2048
		public void CollectSampleAndSendUdp()
		{
			if (Time.Instance.NowSeconds - this.LastSendTime < (double)CombatMessageModel.Instance.MoveSyncUdpSendInterval)
			{
				if (CombatMessageModel.Instance.MoveSyncUdpFullSampling)
				{
					MoveReplaySample currentMoveSample = this.GetCurrentMoveSample();
					this.PendingMoveInfos.Add(currentMoveSample);
				}
				return;
			}
			MoveReplaySample currentMoveSample2 = this.GetCurrentMoveSample();
			this.PendingMoveInfos.Add(currentMoveSample2);
			UDPMovePackagePush udpmovePackagePush = UDPMovePackagePush.Create();
			udpmovePackagePush.SceneOwnerId = (GameModeModel.Instance.IsMulti ? OnlineModel.Instance.OwnerId : CreatureModel.Instance.GetPlayerId());
			udpmovePackagePush.MovingEntities.Add(this.CollectPendingMoveInfos());
			Net.Instance.Send(EPushMessageId.UDPMovePackagePush, udpmovePackagePush);
			if (Info.Instance.IsBuildDevelopmentOrDebug)
			{
				string data = Json.Encode(new Dictionary<string, object>
				{
					{
						"scene_id",
						CreatureModel.Instance.GetSceneId()
					},
					{
						"instance_id",
						CreatureModel.Instance.GetInstanceId()
					},
					{
						"msg_id",
						24978
					},
					{
						"immediately",
						true
					},
					{
						"is_multi",
						GameModeModel.Instance.IsMulti
					},
					{
						"ed",
						BaseMovementSyncComponent.IsWithEditor
					},
					{
						"br",
						LogAnalyzer.Instance.GetBranch()
					}
				}, null);
				CombatDebugController.Instance.DataReport("COMBAT_MESSAGE_COUNT", data);
			}
			this.LastSendTime = Time.Instance.NowSeconds;
		}

		// Token: 0x06046603 RID: 288259 RVA: 0x011A3FCC File Offset: 0x011A21CC
		[NullableContext(2)]
		public unsafe MovingEntityData CollectPendingMoveInfos()
		{
			int i = 0;
			foreach (MoveReplaySample moveReplaySample in this.PendingMoveInfos)
			{
				if (Time.Instance.NowSeconds < (double)(moveReplaySample.TimeStamp + BaseMovementSyncComponent.MaxPendingMoveCacheTime))
				{
					break;
				}
				i++;
			}
			if (this.PendingMoveInfos.Count > 50)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MultiplayerCombat;
				ELogAuthor author = ELogAuthor.WCL;
				string message = "移动包过多";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("diff", Time.Instance.NowSeconds - (double)this.PendingMoveInfos[0].TimeStamp);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("NowSeconds", Time.Instance.NowSeconds);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("TimeStamp", this.PendingMoveInfos[0].TimeStamp);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("length", this.PendingMoveInfos.Count);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			}
			if (i > 0)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.MultiplayerCombat;
				ELogAuthor author2 = ELogAuthor.WCL;
				string message2 = "移动包过期";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("diff", Time.Instance.NowSeconds - (double)this.PendingMoveInfos[0].TimeStamp);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("NowSeconds", Time.Instance.NowSeconds);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("TimeStamp", this.PendingMoveInfos[0].TimeStamp);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				while (i > 0)
				{
					this.PendingMoveInfos.RemoveAt(0);
					i--;
				}
			}
			if (this.PendingMoveInfos.Count == 0)
			{
				return null;
			}
			MovingEntityData movingEntityData = MovingEntityData.Create();
			movingEntityData.EntityId = this.ActorComp.CreatureData.GetCreatureDataId();
			movingEntityData.Originator = (long)CreatureModel.Instance.GetPlayerId();
			movingEntityData.MoveInfos.AddRange(this.PendingMoveInfos);
			List<MoveReplaySample> pendingMoveInfos = this.PendingMoveInfos;
			MoveReplaySample moveReplaySample2 = pendingMoveInfos[pendingMoveInfos.Count - 1];
			this.LastSendLocation.X = (double)moveReplaySample2.Location.X;
			this.LastSendLocation.Y = (double)moveReplaySample2.Location.Y;
			this.LastSendLocation.Z = (double)moveReplaySample2.Location.Z;
			this.LastSendRotation.Roll = moveReplaySample2.Rotation.Roll;
			this.LastSendRotation.Pitch = moveReplaySample2.Rotation.Pitch;
			this.LastSendRotation.Yaw = moveReplaySample2.Rotation.Yaw;
			this.IsPending = false;
			this.LastSendTime = Time.Instance.NowSeconds;
			this.PendingMoveInfos = new List<MoveReplaySample>();
			if (Info.Instance.IsBuildDevelopmentOrDebug)
			{
				byte[] array = movingEntityData.ToByteArray();
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				int? num = (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null;
				CreatureDataComponent creatureDataComp2 = this.CreatureDataComp;
				EEntityType? eentityType = (creatureDataComp2 != null) ? new EEntityType?(creatureDataComp2.GetEntityType()) : null;
				CreatureDataComponent creatureDataComp3 = this.CreatureDataComp;
				long? num2 = (creatureDataComp3 != null) ? new long?(creatureDataComp3.GetCreatureDataId()) : null;
				if (array.Length != 0)
				{
					string data = Json.Encode(new Dictionary<string, object>
					{
						{
							"scene_id",
							CreatureModel.Instance.GetSceneId()
						},
						{
							"instance_id",
							CreatureModel.Instance.GetInstanceId()
						},
						{
							"creature_id",
							num2
						},
						{
							"pb_data_id",
							num
						},
						{
							"entity_type",
							eentityType
						},
						{
							"msg_id",
							-1
						},
						{
							"length",
							array.Length
						},
						{
							"is_multi",
							GameModeModel.Instance.IsMulti
						},
						{
							"is_send",
							true
						},
						{
							"ed",
							BaseMovementSyncComponent.IsWithEditor
						},
						{
							"br",
							LogAnalyzer.Instance.GetBranch()
						}
					}, null);
					CombatDebugController.Instance.DataReport("COMBAT_MESSAGE_INFO", data);
				}
			}
			return movingEntityData;
		}

		// Token: 0x06046604 RID: 288260 RVA: 0x011A4484 File Offset: 0x011A2684
		public unsafe void ReceiveMoveInfos(RepeatedField<MoveReplaySample> moveInfos, int originator, float timestamp)
		{
			if (moveInfos.Count == 0)
			{
				CombatLog.Instance.Warn(CombatLog.EDebugModule.Move, base.Entity, "收移动包失败，移动包长度为0", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			CombatMessageBuffer messageBufferByEntityId = CombatMessageModel.Instance.GetMessageBufferByEntityId(base.Entity.Id);
			if (messageBufferByEntityId == null)
			{
				CombatLog.Instance.Warn(CombatLog.EDebugModule.Move, base.Entity, "收移动包失败，缓冲器查询失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			double num = (double)timestamp + messageBufferByEntityId.TimelineOffset;
			if (Time.Instance.NowSeconds > num)
			{
				double num2 = Time.Instance.NowSeconds - num;
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Move;
				Entity entity = base.Entity;
				string message = "移动缓冲不足";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("missTime", num2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TimeStamp", timestamp);
				instance.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.ReportMoveDataBufferMissTime((float)(num2 * 1000.0));
			}
			if (this.LastReceiveControllerPlayerId != originator)
			{
				CombatLog instance2 = CombatLog.Instance;
				CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Move;
				Entity entity2 = base.Entity;
				string message2 = "移动协议包切换";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("上个控制者", this.LastReceiveControllerPlayerId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("当前控制者", originator);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("TimeStamp", timestamp);
				instance2.Info(flag2, entity2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			}
			foreach (MoveReplaySample moveReplaySample in moveInfos)
			{
				if (moveReplaySample.TimeStamp <= 0f)
				{
					Log instance3 = Log.Instance;
					ELogModule module = ELogModule.MultiplayerCombat;
					ELogAuthor author = ELogAuthor.WCL;
					string message3 = "[BaseMovementSyncComponent.ReceiveMoveInfos] TimeStamp不能小于等于0";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TimeStamp", moveReplaySample.TimeStamp);
					instance3.Error(module, author, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				float num3 = (moveReplaySample.TickInterval > 0) ? ((float)moveReplaySample.TickInterval * 0.001f) : 0f;
				if (num3 > 0f)
				{
					num3 = MathUtils.Instance.Clamp(num3, 0f, this.MaxExtraOffset);
					CombatLog instance4 = CombatLog.Instance;
					CombatLog.EDebugModule flag3 = CombatLog.EDebugModule.Move;
					Entity entity3 = base.Entity;
					string message4 = "额外移动缓冲";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("extraOffset", num3);
					instance4.Info(flag3, entity3, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
				ReplaySample sample = new ReplaySample(moveReplaySample, originator, (double)moveReplaySample.TimeStamp + messageBufferByEntityId.TimelineOffset + (double)num3);
				this.AddReplaySample(sample);
			}
			this.LastReceiveControllerPlayerId = originator;
		}

		// Token: 0x06046605 RID: 288261 RVA: 0x011A4748 File Offset: 0x011A2948
		public bool GetEnableMovementSync()
		{
			return this.EnableMovementSync;
		}

		// Token: 0x06046606 RID: 288262 RVA: 0x011A4750 File Offset: 0x011A2950
		public unsafe void SetEnableMovementSync(bool enable, string reason = "")
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Move;
			Entity entity = base.Entity;
			string message = "SetEnableMovementSync";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("enable", enable);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reason", reason);
			instance.Info(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.EnableMovementSync = enable;
		}

		// Token: 0x06046607 RID: 288263 RVA: 0x011A47C0 File Offset: 0x011A29C0
		public void AddReplaySample(ReplaySample sample)
		{
			while (!this.ReplaySampleQueue.Empty && this.ReplaySampleQueue.Rear.TimeStamp > sample.TimeStamp)
			{
				this.ReplaySampleQueue.RemoveRear();
			}
			this.ReplaySampleQueue.AddRear(sample);
			this.LastReceiveMoveSample = sample;
		}

		// Token: 0x06046608 RID: 288264 RVA: 0x011A4813 File Offset: 0x011A2A13
		public void ClearReplaySamples()
		{
			this.ReplaySampleQueue.Clear();
			this.LastApplyMoveSample = null;
		}

		// Token: 0x06046609 RID: 288265 RVA: 0x011A4827 File Offset: 0x011A2A27
		public void ClearPendingMoveInfos()
		{
			this.PendingMoveInfos.Clear();
			this.IsPending = false;
		}

		// Token: 0x0604660A RID: 288266 RVA: 0x011A483B File Offset: 0x011A2A3B
		public void CloneMoveSampleInfos(BaseMovementSyncComponent otherMoveSyncComp)
		{
			this.ReplaySampleQueue.Clone(otherMoveSyncComp.ReplaySampleQueue);
		}

		// Token: 0x0604660B RID: 288267 RVA: 0x011A484E File Offset: 0x011A2A4E
		protected virtual bool CalcRelativeMove(ReplaySample sample1, ReplaySample sample2, float lerpPercent, global::Vector outLocation, global::Rotator outRotator)
		{
			return false;
		}

		// Token: 0x0604660C RID: 288268 RVA: 0x011A4851 File Offset: 0x011A2A51
		[return: Nullable(2)]
		protected virtual EntityHandle CheckRelativeMove(ReplaySample sample1, ReplaySample sample2, float lerpPercent, global::Vector outLocation, global::Rotator outRotator)
		{
			return null;
		}

		// Token: 0x0604660D RID: 288269 RVA: 0x011A4854 File Offset: 0x011A2A54
		protected virtual bool TransformFromRelativeMove(EntityHandle handle, global::Vector location, global::Rotator rotator, global::Vector outLocation, global::Rotator outRotator)
		{
			return false;
		}

		// Token: 0x0604660E RID: 288270 RVA: 0x011A4858 File Offset: 0x011A2A58
		public virtual void TickReplaySamples()
		{
			double nowSeconds = Time.Instance.NowSeconds;
			if (this.LastApplyMoveSample != null && nowSeconds - this.LastApplyMoveSample.TimeStamp > 1.0)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Move;
				Entity entity = base.Entity;
				string message = "不连贯的样条点丢弃";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("diff", nowSeconds - this.LastApplyMoveSample.TimeStamp);
				instance.Info(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.LastApplyMoveSample = null;
			}
			while (!this.ReplaySampleQueue.Empty)
			{
				ReplaySample lastApplyMoveSample = this.LastApplyMoveSample;
				ReplaySample front = this.ReplaySampleQueue.Front;
				if (nowSeconds >= front.TimeStamp)
				{
					this.LastApplyMoveSample = front;
					this.LastApplyMoveSampleUsed = false;
					this.ReplaySampleQueue.RemoveFront();
				}
				else
				{
					if (lastApplyMoveSample != null)
					{
						float num = (float)MathUtils.Instance.RangeClamp(nowSeconds, lastApplyMoveSample.TimeStamp, front.TimeStamp, 0.0, 1.0);
						this.CacheBaseEntityHandle = this.CheckRelativeMove(lastApplyMoveSample, front, num, this.CacheRelativeLocation, this.CacheRelativeRotator);
						if (this.CacheBaseEntityHandle != null && this.TransformFromRelativeMove(this.CacheBaseEntityHandle, this.CacheRelativeLocation, this.CacheRelativeRotator, this.CacheFinalLocation, this.CacheFinalRotator))
						{
							bool lastRelativeMove = this.LastRelativeMove;
							this.LastRelativeMove = true;
						}
						else
						{
							global::Vector.Lerp(lastApplyMoveSample.Location, front.Location, (double)num, this.CacheFinalLocation);
							global::Rotator.Lerp(lastApplyMoveSample.Rotation, front.Rotation, num, this.CacheFinalRotator);
							bool lastRelativeMove2 = this.LastRelativeMove;
							this.LastRelativeMove = false;
						}
						global::Vector.Lerp(lastApplyMoveSample.LinearVelocity, front.LinearVelocity, (double)num, this.CacheVelocity);
						float controllerPitch = MathUtils.Instance.Lerp(MathCommon.WrapAngle(lastApplyMoveSample.ControllerPitch), MathCommon.WrapAngle(front.ControllerPitch), num);
						this.ApplyMoveSample(lastApplyMoveSample.MovementMode, this.CacheFinalLocation, this.CacheFinalRotator, lastApplyMoveSample.LinearVelocity, lastApplyMoveSample.SlideForward, front.ControllerPlayerId, lastApplyMoveSample.Input, controllerPitch, lastApplyMoveSample.TimeScale, lastApplyMoveSample.ServerTimeStamp, (float)lastApplyMoveSample.Rtt);
						this.LastApplyMoveSampleUsed = true;
						break;
					}
					break;
				}
			}
			if (this.ReplaySampleQueue.Empty && !this.LastApplyMoveSampleUsed && this.LastApplyMoveSample != null)
			{
				ReplaySample lastApplyMoveSample2 = this.LastApplyMoveSample;
				this.CacheBaseEntityHandle = this.CheckRelativeMove(lastApplyMoveSample2, lastApplyMoveSample2, 1f, this.CacheRelativeLocation, this.CacheRelativeRotator);
				bool flag2 = this.CacheBaseEntityHandle != null && this.TransformFromRelativeMove(this.CacheBaseEntityHandle, this.CacheRelativeLocation, this.CacheRelativeRotator, this.CacheFinalLocation, this.CacheFinalRotator);
				this.ApplyMoveSample(this.LastApplyMoveSample.MovementMode, flag2 ? this.CacheFinalLocation : lastApplyMoveSample2.Location, flag2 ? this.CacheFinalRotator : lastApplyMoveSample2.Rotation, this.LastApplyMoveSample.LinearVelocity, this.LastApplyMoveSample.SlideForward, this.LastApplyMoveSample.ControllerPlayerId, this.LastApplyMoveSample.Input, this.LastApplyMoveSample.ControllerPitch, this.LastApplyMoveSample.TimeScale, this.LastApplyMoveSample.ServerTimeStamp, (float)this.LastApplyMoveSample.Rtt);
				this.LastApplyMoveSampleUsed = true;
			}
		}

		// Token: 0x0604660F RID: 288271 RVA: 0x011A4B9C File Offset: 0x011A2D9C
		protected unsafe virtual void ApplyMoveSample(int movementMode, global::Vector location, global::Rotator rotator, global::Vector linearVelocity, global::Vector slideForward, int controllerPlayerId, int input, float controllerPitch, float timeScale, long serverTimeStamp, float originRtt)
		{
			if (this.LastMoveAutonomousProxy || this.ControllerPlayerId != controllerPlayerId)
			{
				double num = global::Vector.Dist(this.LastLocation, this.CacheFinalLocation);
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Move;
				Entity entity = base.Entity;
				string message = "移动来源切换";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("上个控制者", this.ControllerPlayerId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("当前控制者", controllerPlayerId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("位移距离", num.ToString("#"));
				instance.Info(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
			if (CombatDebugDrawController.Instance.DebugMonsterMovePath && component.GetEntityType() == EEntityType.Monster)
			{
				UKismetSystemLibrary.D_DrawDebugLine(GlobalData.World, this.LastLocation.ToUeVector(false), this.CacheFinalLocation.ToUeVector(false), new FLinearColor(1f, 0f, 0f, 1f), 15f, 0f);
			}
			this.ControllerPlayerId = controllerPlayerId;
			this.ActorComp.SetActorLocationAndRotation(location.ToUeVector(false), rotator.ToUeRotator(), "角色移动同步.添加简单位移", false, null);
			float bufferTime = 0f;
			if (this.LastReceiveMoveSample != null)
			{
				bufferTime = (float)((this.LastReceiveMoveSample.TimeStamp - Time.Instance.NowSeconds) * 1000.0);
			}
			this.ReportMoveDataApplyInfo((float)(Time.Instance.CombatServerTime - (double)serverTimeStamp), bufferTime, originRtt);
		}

		// Token: 0x06046610 RID: 288272 RVA: 0x011A4D3C File Offset: 0x011A2F3C
		public string VectorToString([Nullable(2)] Aki.Protocol.Vector vector)
		{
			if (vector == null)
			{
				return "[-]";
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 3);
			defaultInterpolatedStringHandler.AppendLiteral("[");
			defaultInterpolatedStringHandler.AppendFormatted<float>(vector.X, "#");
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<float>(vector.Y, "#");
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<float>(vector.Z, "#");
			defaultInterpolatedStringHandler.AppendLiteral("]");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06046611 RID: 288273 RVA: 0x011A4DC8 File Offset: 0x011A2FC8
		public string VectorToString([Nullable(2)] global::Vector vector)
		{
			if (vector == null)
			{
				return "[-]";
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 3);
			defaultInterpolatedStringHandler.AppendLiteral("[");
			defaultInterpolatedStringHandler.AppendFormatted<double>(vector.X, "#");
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<double>(vector.Y, "#");
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<double>(vector.Z, "#");
			defaultInterpolatedStringHandler.AppendLiteral("]");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06046612 RID: 288274 RVA: 0x011A4E54 File Offset: 0x011A3054
		public string MoveInfosToString(IList<MoveReplaySample> moveInfos)
		{
			MoveReplaySample moveReplaySample = moveInfos[0];
			MoveReplaySample moveReplaySample2 = moveInfos[moveInfos.Count - 1];
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(49, 9);
			defaultInterpolatedStringHandler.AppendLiteral("length:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(moveInfos.Count);
			defaultInterpolatedStringHandler.AppendLiteral(", t:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(moveReplaySample.TimeStamp, "F3");
			defaultInterpolatedStringHandler.AppendLiteral("-");
			defaultInterpolatedStringHandler.AppendFormatted<float>(moveReplaySample2.TimeStamp, "F3");
			defaultInterpolatedStringHandler.AppendLiteral(", position:");
			defaultInterpolatedStringHandler.AppendFormatted(this.VectorToString(moveReplaySample.Location));
			defaultInterpolatedStringHandler.AppendLiteral("-");
			defaultInterpolatedStringHandler.AppendFormatted(this.VectorToString(moveReplaySample2.Location));
			defaultInterpolatedStringHandler.AppendLiteral(", refPos:");
			RelativeMoveReplaySample relativeMoveReplaySample = moveReplaySample2.RelativeMoveReplaySample;
			defaultInterpolatedStringHandler.AppendFormatted(this.VectorToString((relativeMoveReplaySample != null) ? relativeMoveReplaySample.RelativeLocation : null));
			defaultInterpolatedStringHandler.AppendLiteral(" r:");
			Aki.Protocol.Rotator rotation = moveReplaySample.Rotation;
			defaultInterpolatedStringHandler.AppendFormatted<float?>((rotation != null) ? new float?(rotation.Yaw) : null, "#");
			defaultInterpolatedStringHandler.AppendLiteral("-");
			Aki.Protocol.Rotator rotation2 = moveReplaySample2.Rotation;
			defaultInterpolatedStringHandler.AppendFormatted<float?>((rotation2 != null) ? new float?(rotation2.Yaw) : null, "#");
			defaultInterpolatedStringHandler.AppendLiteral(", timeScale:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(moveReplaySample2.TimeScale);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06046613 RID: 288275 RVA: 0x011A4FD0 File Offset: 0x011A31D0
		public string MoveInfoToString(MoveReplaySample moveInfo)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 3);
			defaultInterpolatedStringHandler.AppendLiteral("t:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(moveInfo.TimeStamp, "F3");
			defaultInterpolatedStringHandler.AppendLiteral(", position:");
			defaultInterpolatedStringHandler.AppendFormatted(this.VectorToString(moveInfo.Location));
			defaultInterpolatedStringHandler.AppendLiteral(", timeScale:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(moveInfo.TimeScale);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06046614 RID: 288276 RVA: 0x011A5044 File Offset: 0x011A3244
		public string MoveInfoToString(ReplaySample moveInfo)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 3);
			defaultInterpolatedStringHandler.AppendLiteral("t:");
			defaultInterpolatedStringHandler.AppendFormatted<double>(moveInfo.TimeStamp, "F3");
			defaultInterpolatedStringHandler.AppendLiteral(", position:");
			defaultInterpolatedStringHandler.AppendFormatted(this.VectorToString(moveInfo.Location));
			defaultInterpolatedStringHandler.AppendLiteral(", timeScale:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(moveInfo.TimeScale);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06046615 RID: 288277 RVA: 0x011A50B8 File Offset: 0x011A32B8
		public void ReportMoveDataApplyInfo(float delayMs, float bufferTime, float originRtt)
		{
			string data = Json.Encode(new Dictionary<string, object>
			{
				{
					"udp_mode",
					CombatMessageModel.Instance.MoveSyncUdpMode
				},
				{
					"creature_id",
					this.CreatureDataComp.GetCreatureDataId()
				},
				{
					"pb_data_id",
					this.CreatureDataComp.GetPbDataId()
				},
				{
					"rtt",
					Net.Instance.RttMs
				},
				{
					"rtt_total",
					Net.Instance.RttMs + originRtt
				},
				{
					"delay",
					delayMs
				},
				{
					"buffer_time",
					bufferTime
				}
			}, null);
			CombatDebugController.Instance.DataReport("MOVE_SYNC_INFO", data);
		}

		// Token: 0x06046616 RID: 288278 RVA: 0x011A518C File Offset: 0x011A338C
		public void ReportMoveDataDragDistance(float distance, bool toSelf)
		{
			string data = Json.Encode(new Dictionary<string, object>
			{
				{
					"udp_mode",
					CombatMessageModel.Instance.MoveSyncUdpMode
				},
				{
					"creature_id",
					this.CreatureDataComp.GetCreatureDataId()
				},
				{
					"pb_data_id",
					this.CreatureDataComp.GetPbDataId()
				},
				{
					"rtt",
					Net.Instance.RttMs
				},
				{
					"to_self",
					toSelf
				},
				{
					"distance",
					distance
				}
			}, null);
			CombatDebugController.Instance.DataReport("MOVE_SYNC_DRAG_DISTANCE", data);
		}

		// Token: 0x06046617 RID: 288279 RVA: 0x011A5244 File Offset: 0x011A3444
		public void ReportMoveDataBufferMissTime(float missTime)
		{
			string data = Json.Encode(new Dictionary<string, object>
			{
				{
					"udp_mode",
					CombatMessageModel.Instance.MoveSyncUdpMode
				},
				{
					"creature_id",
					this.CreatureDataComp.GetCreatureDataId()
				},
				{
					"pb_data_id",
					this.CreatureDataComp.GetPbDataId()
				},
				{
					"rtt",
					Net.Instance.RttMs
				},
				{
					"miss_time",
					missTime
				}
			}, null);
			CombatDebugController.Instance.DataReport("MOVE_SYNC_BUFFER_MISS_TIME", data);
		}

		// Token: 0x06046618 RID: 288280 RVA: 0x011A52E8 File Offset: 0x011A34E8
		public void ReportMoveDataInnerBufferMissTime(float missTime)
		{
			string data = Json.Encode(new Dictionary<string, object>
			{
				{
					"udp_mode",
					CombatMessageModel.Instance.MoveSyncUdpMode
				},
				{
					"creature_id",
					this.CreatureDataComp.GetCreatureDataId()
				},
				{
					"pb_data_id",
					this.CreatureDataComp.GetPbDataId()
				},
				{
					"rtt",
					Net.Instance.RttMs
				},
				{
					"miss_time",
					missTime
				}
			}, null);
			CombatDebugController.Instance.DataReport("MOVE_SYNC_INNER_BUFFER_MISS_TIME", data);
		}

		// Token: 0x06046619 RID: 288281 RVA: 0x011A538C File Offset: 0x011A358C
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			BaseMovementSyncComponent baseMovementSyncComponent = (BaseMovementSyncComponent)componentTemplate;
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (baseMovementSyncComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TimeScaleComp"))
			{
				if (baseMovementSyncComponent.TimeScaleComp == null)
				{
					this.TimeScaleComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterTimeScaleComponent>(this.TimeScaleComp), "TimeScaleComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("MoveComp"))
			{
				if (baseMovementSyncComponent.MoveComp == null)
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
				if (baseMovementSyncComponent.CreatureDataComp == null)
				{
					this.CreatureDataComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComp), "CreatureDataComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("EnableMovementSyncInternal"))
			{
				this.EnableMovementSyncInternal = baseMovementSyncComponent.EnableMovementSyncInternal;
			}
			if (base.CanResetComponentProperty("CacheBaseEntityHandle"))
			{
				if (baseMovementSyncComponent.CacheBaseEntityHandle == null)
				{
					this.CacheBaseEntityHandle = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<EntityHandle>(this.CacheBaseEntityHandle), "CacheBaseEntityHandle"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CacheRelativeLocation") && baseMovementSyncComponent.CacheRelativeLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.CacheRelativeLocation), "CacheRelativeLocation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("CacheRelativeRotator") && baseMovementSyncComponent.CacheRelativeRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Rotator>(this.CacheRelativeRotator), "CacheRelativeRotator"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("CacheFinalLocation") && baseMovementSyncComponent.CacheFinalLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.CacheFinalLocation), "CacheFinalLocation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("CacheFinalRotator") && baseMovementSyncComponent.CacheFinalRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Rotator>(this.CacheFinalRotator), "CacheFinalRotator"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("CacheVelocity") && baseMovementSyncComponent.CacheVelocity != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.CacheVelocity), "CacheVelocity"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("ControllerPlayerId"))
			{
				this.ControllerPlayerId = baseMovementSyncComponent.ControllerPlayerId;
			}
			if (base.CanResetComponentProperty("TmpVector") && baseMovementSyncComponent.TmpVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TmpVector), "TmpVector"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TmpVector2") && baseMovementSyncComponent.TmpVector2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TmpVector2), "TmpVector2"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("LastHasBaseMovement"))
			{
				this.LastHasBaseMovement = baseMovementSyncComponent.LastHasBaseMovement;
			}
			if (base.CanResetComponentProperty("LastBasePlatform"))
			{
				if (baseMovementSyncComponent.LastBasePlatform == null)
				{
					this.LastBasePlatform = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BasePlatform>(this.LastBasePlatform), "LastBasePlatform"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("LastMoveAutonomousProxy"))
			{
				this.LastMoveAutonomousProxy = baseMovementSyncComponent.LastMoveAutonomousProxy;
			}
			if (base.CanResetComponentProperty("LastRelativeMove"))
			{
				this.LastRelativeMove = baseMovementSyncComponent.LastRelativeMove;
			}
			if (base.CanResetComponentProperty("LastMove"))
			{
				this.LastMove = baseMovementSyncComponent.LastMove;
			}
			if (base.CanResetComponentProperty("LastSendTime"))
			{
				this.LastSendTime = baseMovementSyncComponent.LastSendTime;
			}
			if (base.CanResetComponentProperty("LastReceiveControllerPlayerId"))
			{
				this.LastReceiveControllerPlayerId = baseMovementSyncComponent.LastReceiveControllerPlayerId;
			}
			if (base.CanResetComponentProperty("LastSendLocation") && baseMovementSyncComponent.LastSendLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.LastSendLocation), "LastSendLocation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("LastSendRotation") && baseMovementSyncComponent.LastSendRotation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Rotator>(this.LastSendRotation), "LastSendRotation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("LastLocation") && baseMovementSyncComponent.LastLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.LastLocation), "LastLocation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("LastRotation") && baseMovementSyncComponent.LastRotation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Rotator>(this.LastRotation), "LastRotation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("IsPending"))
			{
				this.IsPending = baseMovementSyncComponent.IsPending;
			}
			if (base.CanResetComponentProperty("PendingTime"))
			{
				this.PendingTime = baseMovementSyncComponent.PendingTime;
			}
			if (base.CanResetComponentProperty("SingleModeSendInterval"))
			{
				this.SingleModeSendInterval = baseMovementSyncComponent.SingleModeSendInterval;
			}
			if (base.CanResetComponentProperty("<PendingMoveInfos>k__BackingField"))
			{
				if (baseMovementSyncComponent.PendingMoveInfos == null)
				{
					this.PendingMoveInfos = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<MoveReplaySample>>(this.PendingMoveInfos), "<PendingMoveInfos>k__BackingField"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("LastReceiveMoveSample"))
			{
				if (baseMovementSyncComponent.LastReceiveMoveSample == null)
				{
					this.LastReceiveMoveSample = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ReplaySample>(this.LastReceiveMoveSample), "LastReceiveMoveSample"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("LastApplyMoveSample"))
			{
				if (baseMovementSyncComponent.LastApplyMoveSample == null)
				{
					this.LastApplyMoveSample = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ReplaySample>(this.LastApplyMoveSample), "LastApplyMoveSample"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("LastMoveSample"))
			{
				if (baseMovementSyncComponent.LastMoveSample == null)
				{
					this.LastMoveSample = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<MoveReplaySample>(this.LastMoveSample), "LastMoveSample"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("LastApplyMoveSampleUsed"))
			{
				this.LastApplyMoveSampleUsed = baseMovementSyncComponent.LastApplyMoveSampleUsed;
			}
			if (base.CanResetComponentProperty("NowLogicTickTime"))
			{
				this.NowLogicTickTime = baseMovementSyncComponent.NowLogicTickTime;
			}
			if (base.CanResetComponentProperty("LastLogicTickTime"))
			{
				this.LastLogicTickTime = baseMovementSyncComponent.LastLogicTickTime;
			}
			if (base.CanResetComponentProperty("LastApplyLogicTickTime"))
			{
				this.LastApplyLogicTickTime = baseMovementSyncComponent.LastApplyLogicTickTime;
			}
			if (base.CanResetComponentProperty("Activated"))
			{
				this.Activated = baseMovementSyncComponent.Activated;
			}
			if (base.CanResetComponentProperty("PkgLastTimeScale"))
			{
				this.PkgLastTimeScale = baseMovementSyncComponent.PkgLastTimeScale;
			}
			if (base.CanResetComponentProperty("ReplaySampleQueue") && baseMovementSyncComponent.ReplaySampleQueue != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Deque<ReplaySample>>(this.ReplaySampleQueue), "ReplaySampleQueue"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TmpLocation"))
			{
				if (baseMovementSyncComponent.TmpLocation == null)
				{
					this.TmpLocation = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TmpLocation), "TmpLocation"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TmpLocation2"))
			{
				if (baseMovementSyncComponent.TmpLocation2 == null)
				{
					this.TmpLocation2 = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TmpLocation2), "TmpLocation2"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TmpRotation"))
			{
				if (baseMovementSyncComponent.TmpRotation == null)
				{
					this.TmpRotation = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Rotator>(this.TmpRotation), "TmpRotation"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0604661C RID: 288284 RVA: 0x011A5B8C File Offset: 0x011A3D8C
		Entity IMoveSync.get_Entity()
		{
			return base.Entity;
		}

		// Token: 0x04024DF2 RID: 151026
		private static readonly int IsWithEditor = (KuroApplication.IsWithEditor() > false) ? 1 : 0;

		// Token: 0x04024DF3 RID: 151027
		[Nullable(2)]
		protected BaseActorComponent ActorComp;

		// Token: 0x04024DF4 RID: 151028
		[Nullable(2)]
		protected CharacterTimeScaleComponent TimeScaleComp;

		// Token: 0x04024DF5 RID: 151029
		[Nullable(2)]
		protected BaseMoveComponent MoveComp;

		// Token: 0x04024DF6 RID: 151030
		[Nullable(2)]
		protected CreatureDataComponent CreatureDataComp;

		// Token: 0x04024DF7 RID: 151031
		protected bool EnableMovementSyncInternal;

		// Token: 0x04024DF8 RID: 151032
		[Nullable(2)]
		protected EntityHandle CacheBaseEntityHandle;

		// Token: 0x04024DF9 RID: 151033
		protected readonly global::Vector CacheRelativeLocation = global::Vector.Create();

		// Token: 0x04024DFA RID: 151034
		protected readonly global::Rotator CacheRelativeRotator = global::Rotator.Create();

		// Token: 0x04024DFB RID: 151035
		protected readonly global::Vector CacheFinalLocation = global::Vector.Create();

		// Token: 0x04024DFC RID: 151036
		protected readonly global::Rotator CacheFinalRotator = global::Rotator.Create();

		// Token: 0x04024DFD RID: 151037
		protected readonly global::Vector CacheVelocity = global::Vector.Create();

		// Token: 0x04024DFE RID: 151038
		public int ControllerPlayerId;

		// Token: 0x04024DFF RID: 151039
		private readonly float MaxExtraOffset = 1f;

		// Token: 0x04024E00 RID: 151040
		protected readonly global::Vector TmpVector = global::Vector.Create();

		// Token: 0x04024E01 RID: 151041
		protected readonly global::Vector TmpVector2 = global::Vector.Create();

		// Token: 0x04024E02 RID: 151042
		protected bool LastHasBaseMovement;

		// Token: 0x04024E03 RID: 151043
		[Nullable(2)]
		protected BasePlatform LastBasePlatform;

		// Token: 0x04024E04 RID: 151044
		public bool LastMoveAutonomousProxy;

		// Token: 0x04024E05 RID: 151045
		protected bool LastRelativeMove;

		// Token: 0x04024E06 RID: 151046
		protected bool LastMove;

		// Token: 0x04024E07 RID: 151047
		protected double LastSendTime;

		// Token: 0x04024E08 RID: 151048
		protected int LastReceiveControllerPlayerId;

		// Token: 0x04024E09 RID: 151049
		protected readonly global::Vector LastSendLocation = global::Vector.Create();

		// Token: 0x04024E0A RID: 151050
		protected readonly global::Rotator LastSendRotation = global::Rotator.Create();

		// Token: 0x04024E0B RID: 151051
		protected readonly global::Vector LastLocation = global::Vector.Create();

		// Token: 0x04024E0C RID: 151052
		protected readonly global::Rotator LastRotation = global::Rotator.Create();

		// Token: 0x04024E0D RID: 151053
		protected bool IsPending;

		// Token: 0x04024E0E RID: 151054
		protected double PendingTime;

		// Token: 0x04024E0F RID: 151055
		public static readonly float PendingMoveCacheTime = 0.08f;

		// Token: 0x04024E10 RID: 151056
		public static readonly float MaxPendingMoveCacheTime = 1f;

		// Token: 0x04024E11 RID: 151057
		public float SingleModeSendInterval = 1f;

		// Token: 0x04024E12 RID: 151058
		public static readonly float SingleModeSendLocationTolerance = 10f;

		// Token: 0x04024E13 RID: 151059
		public static readonly float SingleModeSendRotationTolerance = 5f;

		// Token: 0x04024E14 RID: 151060
		public static readonly float SingleModeSendLocationToleranceMax = 600f;

		// Token: 0x04024E16 RID: 151062
		[Nullable(2)]
		protected ReplaySample LastReceiveMoveSample;

		// Token: 0x04024E17 RID: 151063
		[Nullable(2)]
		protected ReplaySample LastApplyMoveSample;

		// Token: 0x04024E18 RID: 151064
		[Nullable(2)]
		protected MoveReplaySample LastMoveSample;

		// Token: 0x04024E19 RID: 151065
		protected bool LastApplyMoveSampleUsed;

		// Token: 0x04024E1A RID: 151066
		protected double NowLogicTickTime;

		// Token: 0x04024E1B RID: 151067
		protected double LastLogicTickTime;

		// Token: 0x04024E1C RID: 151068
		protected double LastApplyLogicTickTime;

		// Token: 0x04024E1D RID: 151069
		private bool Activated;

		// Token: 0x04024E1E RID: 151070
		private float PkgLastTimeScale;

		// Token: 0x04024E1F RID: 151071
		private readonly Deque<ReplaySample> ReplaySampleQueue = new Deque<ReplaySample>(4);

		// Token: 0x04024E20 RID: 151072
		public global::Vector TmpLocation = global::Vector.Create();

		// Token: 0x04024E21 RID: 151073
		public global::Vector TmpLocation2 = global::Vector.Create();

		// Token: 0x04024E22 RID: 151074
		public global::Rotator TmpRotation = global::Rotator.Create();
	}
}
