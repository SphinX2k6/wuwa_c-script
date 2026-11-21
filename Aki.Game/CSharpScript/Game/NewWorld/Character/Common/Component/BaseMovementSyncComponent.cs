using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.CombatMessage;
using CSharpScript.Game.Utils;
using CSharpScript.Typing;
using Google.Protobuf.Collections;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x02006321 RID: 25377
	[NullableContext(1)]
	[Nullable(0)]
	public class BaseMovementSyncComponent : EntityComponent, IMoveSync
	{
		// Token: 0x0603D6C2 RID: 251586 RVA: 0x011C2EA3 File Offset: 0x011C10A3
		protected virtual bool DefaultEnableMovementSync()
		{
			return false;
		}

		// Token: 0x1700747D RID: 29821
		// (get) Token: 0x0603D6C3 RID: 251587 RVA: 0x011C2EA6 File Offset: 0x011C10A6
		// (set) Token: 0x0603D6C4 RID: 251588 RVA: 0x011C2EB0 File Offset: 0x011C10B0
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

		// Token: 0x0603D6C5 RID: 251589 RVA: 0x011C2F3F File Offset: 0x011C113F
		protected override bool OnInit()
		{
			this.EnableMovementSync = this.DefaultEnableMovementSync();
			return true;
		}

		// Token: 0x0603D6C6 RID: 251590 RVA: 0x011C2F50 File Offset: 0x011C1150
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

		// Token: 0x0603D6C7 RID: 251591 RVA: 0x011C2FD0 File Offset: 0x011C11D0
		protected override bool OnEnd()
		{
			if (!CombatMessageModel.Instance.DeleteMoveSync(this))
			{
				CombatLog.Instance.Warn(CombatLog.EDebugModule.Move, base.Entity, "移除移动同步失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.EnableMovementSync = false;
			return true;
		}

		// Token: 0x0603D6C8 RID: 251592 RVA: 0x011C3012 File Offset: 0x011C1212
		protected virtual void ApplyInput(int input, global::Rotator rotation)
		{
		}

		// Token: 0x1700747E RID: 29822
		// (get) Token: 0x0603D6C9 RID: 251593 RVA: 0x011C3014 File Offset: 0x011C1214
		// (set) Token: 0x0603D6CA RID: 251594 RVA: 0x011C301C File Offset: 0x011C121C
		public List<MoveReplaySample> PendingMoveInfos { get; set; } = new List<MoveReplaySample>();

		// Token: 0x0603D6CB RID: 251595 RVA: 0x011C3028 File Offset: 0x011C1228
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

		// Token: 0x0603D6CC RID: 251596 RVA: 0x011C3160 File Offset: 0x011C1360
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

		// Token: 0x0603D6CD RID: 251597 RVA: 0x011C32C8 File Offset: 0x011C14C8
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
			}
		}

		// Token: 0x0603D6CE RID: 251598 RVA: 0x011C3330 File Offset: 0x011C1530
		protected virtual void RecordLastData(bool isMove = false)
		{
			this.LastLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
			this.LastRotation.DeepCopy(this.ActorComp.ActorRotationProxy);
			this.LastMoveAutonomousProxy = this.ActorComp.IsMoveAutonomousProxy;
			this.LastMove = isMove;
		}

		// Token: 0x0603D6CF RID: 251599 RVA: 0x011C3381 File Offset: 0x011C1581
		protected override void OnTick(float delta)
		{
			this.LastLogicTickTime = this.NowLogicTickTime;
			this.NowLogicTickTime = Time.Instance.NowSeconds;
		}

		// Token: 0x0603D6D0 RID: 251600 RVA: 0x011C339F File Offset: 0x011C159F
		private void CustomPreTick(float delta)
		{
			this.CustomPreTickInternal(delta);
		}

		// Token: 0x0603D6D1 RID: 251601 RVA: 0x011C33A8 File Offset: 0x011C15A8
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

		// Token: 0x0603D6D2 RID: 251602 RVA: 0x011C3494 File Offset: 0x011C1694
		protected virtual bool GetIsMoving()
		{
			return !this.LastLocation.Equals(this.ActorComp.ActorLocationProxy, 9.999999747378752E-05) || !this.LastRotation.Equals(this.ActorComp.ActorRotationProxy, 0.0001f);
		}

		// Token: 0x0603D6D3 RID: 251603 RVA: 0x011C34E2 File Offset: 0x011C16E2
		protected virtual bool GetImportantMove(bool moving)
		{
			return !moving && this.LastMove;
		}

		// Token: 0x0603D6D4 RID: 251604 RVA: 0x011C34EF File Offset: 0x011C16EF
		protected virtual bool GetSecondaryImportantMove()
		{
			return false;
		}

		// Token: 0x0603D6D5 RID: 251605 RVA: 0x011C34F2 File Offset: 0x011C16F2
		private void CustomAfterTick(float delta)
		{
			this.CustomAfterTickInternal(delta);
		}

		// Token: 0x0603D6D6 RID: 251606 RVA: 0x011C34FC File Offset: 0x011C16FC
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

		// Token: 0x0603D6D7 RID: 251607 RVA: 0x011C35BC File Offset: 0x011C17BC
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

		// Token: 0x0603D6D8 RID: 251608 RVA: 0x011C36E4 File Offset: 0x011C18E4
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

		// Token: 0x0603D6D9 RID: 251609 RVA: 0x011C38B4 File Offset: 0x011C1AB4
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

		// Token: 0x0603D6DA RID: 251610 RVA: 0x011C3994 File Offset: 0x011C1B94
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
				this.LastSendTime = Time.Instance.NowSeconds;
				return;
			}
			CombatMessageModel.Instance.NeedPushMove = true;
		}

		// Token: 0x0603D6DB RID: 251611 RVA: 0x011C3A30 File Offset: 0x011C1C30
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
			this.LastSendTime = Time.Instance.NowSeconds;
		}

		// Token: 0x0603D6DC RID: 251612 RVA: 0x011C3AF0 File Offset: 0x011C1CF0
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
			return movingEntityData;
		}

		// Token: 0x0603D6DD RID: 251613 RVA: 0x011C3E28 File Offset: 0x011C2028
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

		// Token: 0x0603D6DE RID: 251614 RVA: 0x011C40EC File Offset: 0x011C22EC
		public bool GetEnableMovementSync()
		{
			return this.EnableMovementSync;
		}

		// Token: 0x0603D6DF RID: 251615 RVA: 0x011C40F4 File Offset: 0x011C22F4
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

		// Token: 0x0603D6E0 RID: 251616 RVA: 0x011C4164 File Offset: 0x011C2364
		public void AddReplaySample(ReplaySample sample)
		{
			while (!this.ReplaySampleQueue.Empty && this.ReplaySampleQueue.Rear.TimeStamp > sample.TimeStamp)
			{
				this.ReplaySampleQueue.RemoveRear();
			}
			this.ReplaySampleQueue.AddRear(sample);
			this.LastReceiveMoveSample = sample;
		}

		// Token: 0x0603D6E1 RID: 251617 RVA: 0x011C41B7 File Offset: 0x011C23B7
		public void ClearReplaySamples()
		{
			this.ReplaySampleQueue.Clear();
			this.LastApplyMoveSample = null;
		}

		// Token: 0x0603D6E2 RID: 251618 RVA: 0x011C41CB File Offset: 0x011C23CB
		public void ClearPendingMoveInfos()
		{
			this.PendingMoveInfos.Clear();
			this.IsPending = false;
		}

		// Token: 0x0603D6E3 RID: 251619 RVA: 0x011C41DF File Offset: 0x011C23DF
		public void CloneMoveSampleInfos(BaseMovementSyncComponent otherMoveSyncComp)
		{
			this.ReplaySampleQueue.Clone(otherMoveSyncComp.ReplaySampleQueue);
		}

		// Token: 0x0603D6E4 RID: 251620 RVA: 0x011C41F2 File Offset: 0x011C23F2
		protected virtual bool CalcRelativeMove(ReplaySample sample1, ReplaySample sample2, float lerpPercent, global::Vector outLocation, global::Rotator outRotator)
		{
			return false;
		}

		// Token: 0x0603D6E5 RID: 251621 RVA: 0x011C41F5 File Offset: 0x011C23F5
		[return: Nullable(2)]
		protected virtual EntityHandle CheckRelativeMove(ReplaySample sample1, ReplaySample sample2, float lerpPercent, global::Vector outLocation, global::Rotator outRotator)
		{
			return null;
		}

		// Token: 0x0603D6E6 RID: 251622 RVA: 0x011C41F8 File Offset: 0x011C23F8
		protected virtual bool TransformFromRelativeMove(EntityHandle handle, global::Vector location, global::Rotator rotator, global::Vector outLocation, global::Rotator outRotator)
		{
			return false;
		}

		// Token: 0x0603D6E7 RID: 251623 RVA: 0x011C41FC File Offset: 0x011C23FC
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

		// Token: 0x0603D6E8 RID: 251624 RVA: 0x011C4540 File Offset: 0x011C2740
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

		// Token: 0x0603D6E9 RID: 251625 RVA: 0x011C46E0 File Offset: 0x011C28E0
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

		// Token: 0x0603D6EA RID: 251626 RVA: 0x011C476C File Offset: 0x011C296C
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

		// Token: 0x0603D6EB RID: 251627 RVA: 0x011C47F8 File Offset: 0x011C29F8
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

		// Token: 0x0603D6EC RID: 251628 RVA: 0x011C4974 File Offset: 0x011C2B74
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

		// Token: 0x0603D6ED RID: 251629 RVA: 0x011C49E8 File Offset: 0x011C2BE8
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

		// Token: 0x0603D6EE RID: 251630 RVA: 0x011C4A5C File Offset: 0x011C2C5C
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

		// Token: 0x0603D6EF RID: 251631 RVA: 0x011C4B30 File Offset: 0x011C2D30
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

		// Token: 0x0603D6F0 RID: 251632 RVA: 0x011C4BE8 File Offset: 0x011C2DE8
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

		// Token: 0x0603D6F1 RID: 251633 RVA: 0x011C4C8C File Offset: 0x011C2E8C
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

		// Token: 0x0603D6F2 RID: 251634 RVA: 0x011C4D30 File Offset: 0x011C2F30
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			BaseMovementSyncComponent baseMovementSyncComponent = (BaseMovementSyncComponent)componentTemplate;
			if (baseMovementSyncComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (baseMovementSyncComponent.TimeScaleComp == null)
			{
				this.TimeScaleComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TimeScaleComp), "TimeScaleComp"))
			{
				return false;
			}
			if (baseMovementSyncComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
			{
				return false;
			}
			if (baseMovementSyncComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			this.EnableMovementSyncInternal = baseMovementSyncComponent.EnableMovementSyncInternal;
			if (baseMovementSyncComponent.CacheBaseEntityHandle == null)
			{
				this.CacheBaseEntityHandle = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CacheBaseEntityHandle), "CacheBaseEntityHandle"))
			{
				return false;
			}
			if (baseMovementSyncComponent.CacheRelativeLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CacheRelativeLocation), "CacheRelativeLocation"))
			{
				return false;
			}
			if (baseMovementSyncComponent.CacheRelativeRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CacheRelativeRotator), "CacheRelativeRotator"))
			{
				return false;
			}
			if (baseMovementSyncComponent.CacheFinalLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CacheFinalLocation), "CacheFinalLocation"))
			{
				return false;
			}
			if (baseMovementSyncComponent.CacheFinalRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CacheFinalRotator), "CacheFinalRotator"))
			{
				return false;
			}
			if (baseMovementSyncComponent.CacheVelocity != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CacheVelocity), "CacheVelocity"))
			{
				return false;
			}
			this.ControllerPlayerId = baseMovementSyncComponent.ControllerPlayerId;
			if (baseMovementSyncComponent.TmpVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpVector), "TmpVector"))
			{
				return false;
			}
			if (baseMovementSyncComponent.TmpVector2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpVector2), "TmpVector2"))
			{
				return false;
			}
			this.LastHasBaseMovement = baseMovementSyncComponent.LastHasBaseMovement;
			if (baseMovementSyncComponent.LastBasePlatform == null)
			{
				this.LastBasePlatform = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastBasePlatform), "LastBasePlatform"))
			{
				return false;
			}
			this.LastMoveAutonomousProxy = baseMovementSyncComponent.LastMoveAutonomousProxy;
			this.LastRelativeMove = baseMovementSyncComponent.LastRelativeMove;
			this.LastMove = baseMovementSyncComponent.LastMove;
			this.LastSendTime = baseMovementSyncComponent.LastSendTime;
			this.LastReceiveControllerPlayerId = baseMovementSyncComponent.LastReceiveControllerPlayerId;
			if (baseMovementSyncComponent.LastSendLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastSendLocation), "LastSendLocation"))
			{
				return false;
			}
			if (baseMovementSyncComponent.LastSendRotation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastSendRotation), "LastSendRotation"))
			{
				return false;
			}
			if (baseMovementSyncComponent.LastLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastLocation), "LastLocation"))
			{
				return false;
			}
			if (baseMovementSyncComponent.LastRotation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastRotation), "LastRotation"))
			{
				return false;
			}
			this.IsPending = baseMovementSyncComponent.IsPending;
			this.PendingTime = baseMovementSyncComponent.PendingTime;
			this.SingleModeSendInterval = baseMovementSyncComponent.SingleModeSendInterval;
			if (baseMovementSyncComponent.PendingMoveInfos == null)
			{
				this.PendingMoveInfos = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PendingMoveInfos), "PendingMoveInfos"))
			{
				return false;
			}
			if (baseMovementSyncComponent.LastReceiveMoveSample == null)
			{
				this.LastReceiveMoveSample = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastReceiveMoveSample), "LastReceiveMoveSample"))
			{
				return false;
			}
			if (baseMovementSyncComponent.LastApplyMoveSample == null)
			{
				this.LastApplyMoveSample = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastApplyMoveSample), "LastApplyMoveSample"))
			{
				return false;
			}
			if (baseMovementSyncComponent.LastMoveSample == null)
			{
				this.LastMoveSample = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastMoveSample), "LastMoveSample"))
			{
				return false;
			}
			this.LastApplyMoveSampleUsed = baseMovementSyncComponent.LastApplyMoveSampleUsed;
			this.NowLogicTickTime = baseMovementSyncComponent.NowLogicTickTime;
			this.LastLogicTickTime = baseMovementSyncComponent.LastLogicTickTime;
			this.LastApplyLogicTickTime = baseMovementSyncComponent.LastApplyLogicTickTime;
			this.Activated = baseMovementSyncComponent.Activated;
			this.PkgLastTimeScale = baseMovementSyncComponent.PkgLastTimeScale;
			if (baseMovementSyncComponent.ReplaySampleQueue != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.ReplaySampleQueue), "ReplaySampleQueue"))
			{
				return false;
			}
			if (baseMovementSyncComponent.TmpLocation == null)
			{
				this.TmpLocation = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpLocation), "TmpLocation"))
			{
				return false;
			}
			if (baseMovementSyncComponent.TmpLocation2 == null)
			{
				this.TmpLocation2 = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpLocation2), "TmpLocation2"))
			{
				return false;
			}
			if (baseMovementSyncComponent.TmpRotation == null)
			{
				this.TmpRotation = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpRotation), "TmpRotation"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x1700747F RID: 29823
		// (get) Token: 0x0603D6F3 RID: 251635 RVA: 0x011C51E3 File Offset: 0x011C33E3
		public override bool NeedInitInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007480 RID: 29824
		// (get) Token: 0x0603D6F4 RID: 251636 RVA: 0x011C51E6 File Offset: 0x011C33E6
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007481 RID: 29825
		// (get) Token: 0x0603D6F5 RID: 251637 RVA: 0x011C51E9 File Offset: 0x011C33E9
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007482 RID: 29826
		// (get) Token: 0x0603D6F6 RID: 251638 RVA: 0x011C51EC File Offset: 0x011C33EC
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007483 RID: 29827
		// (get) Token: 0x0603D6F7 RID: 251639 RVA: 0x011C51EF File Offset: 0x011C33EF
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0603D6FA RID: 251642 RVA: 0x011C531C File Offset: 0x011C351C
		Entity IMoveSync.get_Entity()
		{
			return base.Entity;
		}

		// Token: 0x04020930 RID: 133424
		private static readonly int IsWithEditor = (KuroApplication.IsWithEditor() > false) ? 1 : 0;

		// Token: 0x04020931 RID: 133425
		[Nullable(2)]
		protected BaseActorComponent ActorComp;

		// Token: 0x04020932 RID: 133426
		[Nullable(2)]
		protected CharacterTimeScaleComponent TimeScaleComp;

		// Token: 0x04020933 RID: 133427
		[Nullable(2)]
		protected BaseMoveComponent MoveComp;

		// Token: 0x04020934 RID: 133428
		[Nullable(2)]
		protected CreatureDataComponent CreatureDataComp;

		// Token: 0x04020935 RID: 133429
		protected bool EnableMovementSyncInternal;

		// Token: 0x04020936 RID: 133430
		[Nullable(2)]
		protected EntityHandle CacheBaseEntityHandle;

		// Token: 0x04020937 RID: 133431
		protected readonly global::Vector CacheRelativeLocation = global::Vector.Create();

		// Token: 0x04020938 RID: 133432
		protected readonly global::Rotator CacheRelativeRotator = global::Rotator.Create();

		// Token: 0x04020939 RID: 133433
		protected readonly global::Vector CacheFinalLocation = global::Vector.Create();

		// Token: 0x0402093A RID: 133434
		protected readonly global::Rotator CacheFinalRotator = global::Rotator.Create();

		// Token: 0x0402093B RID: 133435
		protected readonly global::Vector CacheVelocity = global::Vector.Create();

		// Token: 0x0402093C RID: 133436
		public int ControllerPlayerId;

		// Token: 0x0402093D RID: 133437
		private readonly float MaxExtraOffset = 1f;

		// Token: 0x0402093E RID: 133438
		protected readonly global::Vector TmpVector = global::Vector.Create();

		// Token: 0x0402093F RID: 133439
		protected readonly global::Vector TmpVector2 = global::Vector.Create();

		// Token: 0x04020940 RID: 133440
		protected bool LastHasBaseMovement;

		// Token: 0x04020941 RID: 133441
		[Nullable(2)]
		protected BasePlatform LastBasePlatform;

		// Token: 0x04020942 RID: 133442
		public bool LastMoveAutonomousProxy;

		// Token: 0x04020943 RID: 133443
		protected bool LastRelativeMove;

		// Token: 0x04020944 RID: 133444
		protected bool LastMove;

		// Token: 0x04020945 RID: 133445
		protected double LastSendTime;

		// Token: 0x04020946 RID: 133446
		protected int LastReceiveControllerPlayerId;

		// Token: 0x04020947 RID: 133447
		protected readonly global::Vector LastSendLocation = global::Vector.Create();

		// Token: 0x04020948 RID: 133448
		protected readonly global::Rotator LastSendRotation = global::Rotator.Create();

		// Token: 0x04020949 RID: 133449
		protected readonly global::Vector LastLocation = global::Vector.Create();

		// Token: 0x0402094A RID: 133450
		protected readonly global::Rotator LastRotation = global::Rotator.Create();

		// Token: 0x0402094B RID: 133451
		protected bool IsPending;

		// Token: 0x0402094C RID: 133452
		protected double PendingTime;

		// Token: 0x0402094D RID: 133453
		public static readonly float PendingMoveCacheTime = 0.08f;

		// Token: 0x0402094E RID: 133454
		public static readonly float MaxPendingMoveCacheTime = 1f;

		// Token: 0x0402094F RID: 133455
		public float SingleModeSendInterval = 1f;

		// Token: 0x04020950 RID: 133456
		public static readonly float SingleModeSendLocationTolerance = 10f;

		// Token: 0x04020951 RID: 133457
		public static readonly float SingleModeSendRotationTolerance = 5f;

		// Token: 0x04020952 RID: 133458
		public static readonly float SingleModeSendLocationToleranceMax = 600f;

		// Token: 0x04020954 RID: 133460
		[Nullable(2)]
		protected ReplaySample LastReceiveMoveSample;

		// Token: 0x04020955 RID: 133461
		[Nullable(2)]
		protected ReplaySample LastApplyMoveSample;

		// Token: 0x04020956 RID: 133462
		[Nullable(2)]
		protected MoveReplaySample LastMoveSample;

		// Token: 0x04020957 RID: 133463
		protected bool LastApplyMoveSampleUsed;

		// Token: 0x04020958 RID: 133464
		protected double NowLogicTickTime;

		// Token: 0x04020959 RID: 133465
		protected double LastLogicTickTime;

		// Token: 0x0402095A RID: 133466
		protected double LastApplyLogicTickTime;

		// Token: 0x0402095B RID: 133467
		private bool Activated;

		// Token: 0x0402095C RID: 133468
		private float PkgLastTimeScale;

		// Token: 0x0402095D RID: 133469
		private readonly Deque<ReplaySample> ReplaySampleQueue = new Deque<ReplaySample>(4);

		// Token: 0x0402095E RID: 133470
		public global::Vector TmpLocation = global::Vector.Create();

		// Token: 0x0402095F RID: 133471
		public global::Vector TmpLocation2 = global::Vector.Create();

		// Token: 0x04020960 RID: 133472
		public global::Rotator TmpRotation = global::Rotator.Create();
	}
}
