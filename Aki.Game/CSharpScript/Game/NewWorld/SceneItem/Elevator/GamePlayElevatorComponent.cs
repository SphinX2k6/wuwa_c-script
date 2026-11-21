using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Core.Common;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using CSharpScript.Game.Render;
using CSharpScript.Game.Utils;
using CSharpScript.Game.World.Controller;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Elevator
{
	// Token: 0x020062B7 RID: 25271
	[NullableContext(1)]
	[Nullable(0)]
	public class GamePlayElevatorComponent : EntityComponent
	{
		// Token: 0x17007377 RID: 29559
		// (get) Token: 0x0603D025 RID: 249893 RVA: 0x0118B66A File Offset: 0x0118986A
		// (set) Token: 0x0603D026 RID: 249894 RVA: 0x0118B672 File Offset: 0x01189872
		public int CurLiftFloor { get; private set; } = 1;

		// Token: 0x0603D027 RID: 249895 RVA: 0x0118B67C File Offset: 0x0118987C
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			LiftComponent liftComponent = args.GetP1<CreateEntityData>().GetParam<GamePlayElevatorComponent>() as LiftComponent;
			if (liftComponent == null)
			{
				throw new Exception("创建GamePlayElevatorComponent缺少配置参数");
			}
			this.CustomLiftBuffType = liftComponent.CustomLiftBuffType;
			this.TempVector = global::Vector.Create(0.0, 0.0, 0.0);
			this.TempLocation = global::Vector.Create(0.0, 0.0, 0.0);
			this.ActorHitElevator = new List<AActor>();
			this.ActorOnElevator = new List<AActor>();
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			this.EntityConfigId = new int?(this.CreatureDataComp.GetPbDataId());
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Elevator_");
			defaultInterpolatedStringHandler.AppendFormatted<int?>(this.EntityConfigId);
			this.AFMEKey = defaultInterpolatedStringHandler.ToStringAndClear();
			Aki.Protocol.Vector initLocation = this.CreatureDataComp.GetInitLocation();
			float initLocationX = (initLocation.X != 0f) ? initLocation.X : 0f;
			float initLocationY = (initLocation.Y != 0f) ? initLocation.Y : 0f;
			float initLocationZ = (initLocation.Z != 0f) ? initLocation.Z : 0f;
			this.CurLiftFloor = ((this.CreatureDataComp.LiftFloor > 0) ? this.CreatureDataComp.LiftFloor : 1);
			this.TargetFloor = 0;
			this.IsDescending = false;
			this.IsAutoMove = (liftComponent.AutoConfig != null);
			IAutoConfig autoConfig = liftComponent.AutoConfig;
			this.IsAnnular = (autoConfig != null && autoConfig.IsCircle);
			this.IsReverseAutoRunning = false;
			IAutoConfig autoConfig2 = liftComponent.AutoConfig;
			this.HoverTime = (float)((autoConfig2 != null) ? autoConfig2.Interval : 0);
			this.HoveringTime = 0f;
			this.EnableCustomTimeScale = liftComponent.IsAffectedByTimeDilation.GetValueOrDefault();
			if (liftComponent.SafePoint != null)
			{
				this.SafePosition = global::Vector.Create((double)liftComponent.SafePoint.X.GetValueOrDefault(), (double)liftComponent.SafePoint.Y.GetValueOrDefault(), (double)liftComponent.SafePoint.Z.GetValueOrDefault());
			}
			this.ActorComp = base.Entity.GetComponent<BaseActorComponent>();
			this.MoveCtx = new ElevatorContext();
			this.MoveCtx.ActorComp = this.ActorComp;
			this.MoveCtx.Entity = base.Entity;
			this.MoveCtx.EntityConfigId = this.EntityConfigId;
			this.MoveCtx.CurFloor = this.CurLiftFloor;
			this.MoveCtx.TargetFloor = this.TargetFloor;
			this.MoveCtx.State = this.State;
			this.MoveCtx.IsAnnular = this.IsAnnular;
			this.MoveCtx.MaxSpeed = new float?((float)liftComponent.MaxSpeed);
			this.MoveCtx.UniformMovement = new bool?(liftComponent.UniformMovement);
			this.MoveCtx.DelayMoveTime = new float?(liftComponent.TurnTime);
			if (liftComponent.UseFloorSeqMarkMapping.GetValueOrDefault())
			{
				this.MoveStrategy = new ElevatorSequenceMoveStrategy();
			}
			else
			{
				this.MoveStrategy = new ElevatorNormalMoveStrategy();
			}
			this.MoveStrategy.InitFromConfig(liftComponent, this.MoveCtx, initLocationX, initLocationY, initLocationZ);
			return true;
		}

		// Token: 0x0603D028 RID: 249896 RVA: 0x0118B9CA File Offset: 0x01189BCA
		protected override bool OnInit()
		{
			this.MoveStrategy.OnInit();
			return true;
		}

		// Token: 0x0603D029 RID: 249897 RVA: 0x0118B9D8 File Offset: 0x01189BD8
		protected override bool OnStart()
		{
			this.RangeComp = base.Entity.GetComponent<CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent>();
			if (this.RangeComp != null)
			{
				this.RangeComp.AddOnPlayerOverlapCallback(new Action<bool>(this.SetPlayerOnElevatorBuff));
				this.RangeComp.AddOnEntityOverlapCallback(new Action<bool, EntityHandle>(this.RecordManipulatableItem));
			}
			this.PropComp = base.Entity.GetComponent<SceneItemPropertyComponent>();
			this.MoveStrategy.OnStart(delegate
			{
				this.TryStartAutoMove();
			});
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnSceneInteractionLoadCompleted, new Action(this.OnSceneInteractionLoadCompleted));
			return true;
		}

		// Token: 0x0603D02A RID: 249898 RVA: 0x0118BA78 File Offset: 0x01189C78
		protected override bool OnClear()
		{
			if (this.RangeComp != null)
			{
				this.RangeComp.RemoveOnPlayerOverlapCallback(new Action<bool>(this.SetPlayerOnElevatorBuff));
				this.RangeComp.RemoveOnEntityOverlapCallback(new Action<bool, EntityHandle>(this.RecordManipulatableItem));
			}
			if (EventSystem.Instance.HasWithTarget(base.Entity, EEventName.OnSceneInteractionLoadCompleted, new Action(this.OnSceneInteractionLoadCompleted)))
			{
				EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnSceneInteractionLoadCompleted, new Action(this.OnSceneInteractionLoadCompleted));
			}
			this.EnableAFME();
			this.ClearStartMoveDelayTimer();
			this.MoveStrategy.OnClear();
			return true;
		}

		// Token: 0x0603D02B RID: 249899 RVA: 0x0118BB18 File Offset: 0x01189D18
		protected override void OnChangeTimeDilation(float timeDilation)
		{
			if (this.EnableCustomTimeScale)
			{
				PawnTimeScaleComponent component = base.Entity.GetComponent<PawnTimeScaleComponent>();
				this.CustomTimeScale = ((component != null) ? component.CurrentTimeScale : 1f);
			}
		}

		// Token: 0x0603D02C RID: 249900 RVA: 0x0118BB43 File Offset: 0x01189D43
		protected override void OnForceTick(float deltaSeconds)
		{
			this.ForceTickInternal(deltaSeconds);
		}

		// Token: 0x0603D02D RID: 249901 RVA: 0x0118BB4C File Offset: 0x01189D4C
		private void ForceTickInternal(float deltaSeconds)
		{
			float deltaSeconds2 = deltaSeconds * this.CustomTimeScale;
			this.ForceTickElevatorTick(deltaSeconds2);
			this.ForceTickAfterElevatorTick(deltaSeconds2);
		}

		// Token: 0x0603D02E RID: 249902 RVA: 0x0118BB70 File Offset: 0x01189D70
		private void ForceTickElevatorTick(float deltaSeconds)
		{
			if (this.GetLock())
			{
				return;
			}
			if (this.State == EGamePlayElevatorState.Hovering)
			{
				this.TickHovering(deltaSeconds);
				return;
			}
			if (this.State != EGamePlayElevatorState.Moving && this.State != EGamePlayElevatorState.MovingPhaseTwo)
			{
				return;
			}
			if (this.IsDescending && this.HasEntityBelow())
			{
				return;
			}
			this.MoveStrategy.TickMove(deltaSeconds);
			this.MoveStrategy.CheckAndFinishMove(delegate
			{
				this.OnMoveArrived();
			});
		}

		// Token: 0x0603D02F RID: 249903 RVA: 0x0118BBE0 File Offset: 0x01189DE0
		private unsafe void EnterState(EGamePlayElevatorState newState)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.CK;
			string message = "EnterState";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityConfigId", this.EntityConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Before", this.State);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("After", newState);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			EGamePlayElevatorState state = this.State;
			this.State = newState;
			this.MoveCtx.State = newState;
			switch (newState)
			{
			case EGamePlayElevatorState.Stop:
			case EGamePlayElevatorState.Hovering:
				this.SetIsMoving(false);
				this.UpdateIsDescending();
				break;
			case EGamePlayElevatorState.Moving:
			{
				ElevatorNormalMoveStrategy elevatorNormalMoveStrategy = this.MoveStrategy as ElevatorNormalMoveStrategy;
				if (elevatorNormalMoveStrategy != null)
				{
					elevatorNormalMoveStrategy.SetPathMoveStartTimeStamp(UGameplayStatics.GetTimeSeconds(this.ActorComp.Owner));
				}
				this.EnterMovePhase();
				break;
			}
			case EGamePlayElevatorState.MovingPhaseTwo:
				this.EnterMovePhase();
				break;
			}
			this.OnStateChange(state, newState);
		}

		// Token: 0x0603D030 RID: 249904 RVA: 0x0118BCF0 File Offset: 0x01189EF0
		private void ExecuteTeleport()
		{
			this.EnterState(EGamePlayElevatorState.Teleporting);
			global::Vector teleportEndPosition = ((ElevatorNormalMoveStrategy)this.MoveStrategy).GetTeleportEndPosition();
			if (this.HasPlayerInElevator())
			{
				TeleportController.Instance.TeleportElevatorAndPlayerSeparately(new ITeleportContextParam
				{
					ClientReason = "ElevatorTeleportPlayer",
					TargetPosition = teleportEndPosition.ToUeVector(false),
					ElevatorEntity = base.Entity
				}).Finally(delegate()
				{
					this.EnterState(EGamePlayElevatorState.MovingPhaseTwo);
				});
				return;
			}
			base.Entity.GetComponent<BaseActorComponent>().SetActorLocation(teleportEndPosition.ToUeVector(false), "unknown", true);
			this.EnterState(EGamePlayElevatorState.MovingPhaseTwo);
		}

		// Token: 0x0603D031 RID: 249905 RVA: 0x0118BD88 File Offset: 0x01189F88
		private void EnterMovePhase()
		{
			this.SetIsMoving(true);
			this.UpdateIsDescending();
			this.MoveStrategy.OnEnterMovePhase();
		}

		// Token: 0x0603D032 RID: 249906 RVA: 0x0118BDA2 File Offset: 0x01189FA2
		private void SetIsMoving(bool value)
		{
			if (this.PropComp != null)
			{
				this.PropComp.IsMoving = value;
			}
		}

		// Token: 0x0603D033 RID: 249907 RVA: 0x0118BDB8 File Offset: 0x01189FB8
		private void UpdateIsDescending()
		{
			this.IsDescending = (this.TargetFloor > 0 && this.TargetFloor < this.CurLiftFloor);
		}

		// Token: 0x0603D034 RID: 249908 RVA: 0x0118BDDC File Offset: 0x01189FDC
		private void OnStateChange(EGamePlayElevatorState oldState, EGamePlayElevatorState newState)
		{
			if (oldState == newState)
			{
				return;
			}
			bool flag = oldState == EGamePlayElevatorState.Stop || oldState == EGamePlayElevatorState.Hovering;
			bool flag2 = flag;
			if (flag2)
			{
				bool flag3 = newState - EGamePlayElevatorState.Moving <= 1;
				flag2 = flag3;
			}
			if (flag2)
			{
				this.OnMovingStateChange(true);
				return;
			}
			flag2 = (oldState - EGamePlayElevatorState.Moving <= 1);
			flag = flag2;
			if (flag)
			{
				bool flag3 = newState == EGamePlayElevatorState.Stop || newState == EGamePlayElevatorState.Hovering;
				flag = flag3;
			}
			if (flag)
			{
				this.OnMovingStateChange(false);
			}
		}

		// Token: 0x0603D035 RID: 249909 RVA: 0x0118BE43 File Offset: 0x0118A043
		private long GetActiveElevatorBuffId()
		{
			if (this.CustomLiftBuffType.GetValueOrDefault() == ELiftBuffType.AllowJumpDash)
			{
				return 640003037L;
			}
			return 640003011L;
		}

		// Token: 0x0603D036 RID: 249910 RVA: 0x0118BE60 File Offset: 0x0118A060
		[NullableContext(2)]
		public static bool IsCharacterOnMovingElevator(Entity entity)
		{
			if (entity == null || !entity.Valid)
			{
				return false;
			}
			CharacterBuffComponent component = entity.GetComponent<CharacterBuffComponent>();
			return ((component != null) ? component.GetBuffById(640003011L) : null) != null || ((component != null) ? component.GetBuffById(640003037L) : null) != null;
		}

		// Token: 0x0603D037 RID: 249911 RVA: 0x0118BEB4 File Offset: 0x0118A0B4
		private void OnMovingStateChange(bool isMoving)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			CharacterBuffComponent characterBuffComponent;
			if (baseCharacter == null)
			{
				characterBuffComponent = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
				if (characterActorComponent == null)
				{
					characterBuffComponent = null;
				}
				else
				{
					Entity entity = characterActorComponent.Entity;
					characterBuffComponent = ((entity != null) ? entity.GetComponent<CharacterBuffComponent>() : null);
				}
			}
			CharacterBuffComponent characterBuffComponent2 = characterBuffComponent;
			long activeElevatorBuffId = this.GetActiveElevatorBuffId();
			if (characterBuffComponent2 != null && this.HasPlayerInElevator())
			{
				if (isMoving)
				{
					characterBuffComponent2.AddBuff(activeElevatorBuffId, new AddBuffParam
					{
						InstigatorId = characterBuffComponent2.CreatureDataId,
						Duration = new float?(this.GetRunDuration() + this.MoveCtx.DelayMoveTime.GetValueOrDefault()),
						Reason = "电梯添加buff"
					});
					EventSystem.Instance.EmitWithTarget(characterBuffComponent2.Entity, EEventName.ElevatorMove);
				}
				else
				{
					characterBuffComponent2.RemoveBuff(activeElevatorBuffId, -1, "电梯移除buff", null, null, null);
				}
			}
			if (this.ActorHitElevator.Count > 0)
			{
				foreach (AActor aactor in this.ActorHitElevator)
				{
					if (this.ActorOnElevator.IndexOf(aactor) != -1)
					{
						if (isMoving)
						{
							this.AttachToElevator(aactor);
						}
						else
						{
							this.DetachFromElevator(aactor);
						}
					}
				}
			}
			if (isMoving)
			{
				this.DisableAFME();
				if (this.HasPlayerInElevator())
				{
					this.DisableMotionBlur();
					return;
				}
			}
			else
			{
				this.EnableAFME();
				if (this.HasPlayerInElevator())
				{
					this.EnableMotionBlur();
				}
			}
		}

		// Token: 0x0603D038 RID: 249912 RVA: 0x0118C02C File Offset: 0x0118A22C
		private void DisableAFME()
		{
			if (GameSettingsDeviceRender.Instance.IsSupportedAFME)
			{
				GameSettingsDeviceRender.Instance.TemporaryDisableAFME(this.AFMEKey);
			}
		}

		// Token: 0x0603D039 RID: 249913 RVA: 0x0118C04A File Offset: 0x0118A24A
		private void EnableAFME()
		{
			if (GameSettingsDeviceRender.Instance.IsSupportedAFME)
			{
				GameSettingsDeviceRender.Instance.CancelTemporaryDisableAFME(this.AFMEKey);
			}
		}

		// Token: 0x0603D03A RID: 249914 RVA: 0x0118C068 File Offset: 0x0118A268
		private void DisableMotionBlur()
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.MotionBlur.Amount 0", null);
		}

		// Token: 0x0603D03B RID: 249915 RVA: 0x0118C07A File Offset: 0x0118A27A
		private void EnableMotionBlur()
		{
			GameSettingsManager.Instance.ReApply(EFunction.MOTIONBLUR, EGameSettingsApplyReason.AnyTime, true);
		}

		// Token: 0x0603D03C RID: 249916 RVA: 0x0118C08C File Offset: 0x0118A28C
		private void SyncElevatorStateToServer(int floor, bool isMoving)
		{
			if (this.GetLock() || this.IsInStateChange.GetValueOrDefault())
			{
				return;
			}
			this.IsInStateChange = new bool?(true);
			ElevatorState state = ElevatorState.End;
			if (isMoving)
			{
				state = ((this.TargetFloor > this.CurLiftFloor) ? ElevatorState.Forward : ElevatorState.Reverse);
			}
			LevelGamePlayController.Instance.ElevatorStateChangeRequest(base.Entity.Id, floor, state, new Action(this.HandleStateChangeResponse));
		}

		// Token: 0x0603D03D RID: 249917 RVA: 0x0118C0F8 File Offset: 0x0118A2F8
		private void OnMoveArrived()
		{
			ElevatorNormalMoveStrategy elevatorNormalMoveStrategy = this.MoveStrategy as ElevatorNormalMoveStrategy;
			ElevatorNormalMoveStrategy elevatorNormalMoveStrategy2 = (elevatorNormalMoveStrategy != null) ? elevatorNormalMoveStrategy : null;
			bool flag = elevatorNormalMoveStrategy2 != null && elevatorNormalMoveStrategy2.GetMoveType() == ELiftMoveType.Teleport;
			if (flag && this.State == EGamePlayElevatorState.Moving)
			{
				this.ExecuteTeleport();
				return;
			}
			if (!this.IsAutoMove && this.PendingServerTargetFloor == 0)
			{
				this.SyncElevatorStateToServer(this.TargetFloor, false);
			}
			int targetFloor = this.TargetFloor;
			this.CurLiftFloor = targetFloor;
			this.MoveCtx.CurFloor = targetFloor;
			int num = 0;
			if (this.PendingServerTargetFloor > 0)
			{
				if (this.CurLiftFloor != this.PendingServerTargetFloor)
				{
					num = this.PendingServerTargetFloor;
				}
				this.PendingServerTargetFloor = 0;
			}
			this.TargetFloor = 0;
			this.MoveCtx.TargetFloor = 0;
			if (flag && this.State == EGamePlayElevatorState.MovingPhaseTwo)
			{
				this.EnterState(EGamePlayElevatorState.Stop);
				if (num > 0)
				{
					this.MoveToTargetFloor(num, "TeleportPhaseTwoComplete_PendingServerTargetFloor");
				}
				return;
			}
			if (!this.IsAutoMove)
			{
				this.EnterState(EGamePlayElevatorState.Stop);
				if (num > 0)
				{
					this.MoveToTargetFloor(num, "MoveComplete_PendingServerTargetFloor");
				}
				return;
			}
			if (num <= 0)
			{
				num = this.GetNextTargetFloor();
			}
			if (this.HoverTime > 0f)
			{
				this.PendingAutoRunNextFloor = num;
				this.EnterState(EGamePlayElevatorState.Hovering);
				return;
			}
			this.MoveToTargetFloor(num, "AutoRun");
		}

		// Token: 0x0603D03E RID: 249918 RVA: 0x0118C230 File Offset: 0x0118A430
		private unsafe bool CheckTargetFloorValid(int targetFloor)
		{
			if (this.GetLock())
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CK;
				string message = "CheckTargetFloorValid Failed, Elevator is Locked";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityConfigId", this.EntityConfigId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CurFloor", this.CurLiftFloor);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("TargetFloor", targetFloor);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("RunningTargetFloor", this.TargetFloor);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("State", this.State);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
				return false;
			}
			int floorCount = this.MoveStrategy.GetFloorCount();
			if (targetFloor < 1 || targetFloor > floorCount)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.CK;
				string message2 = "CheckTargetFloorValid Failed, Target Floor Out Of Range";
				<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray6<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityConfigId", this.EntityConfigId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("CurFloor", this.CurLiftFloor);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("TargetFloor", targetFloor);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("FloorCount", floorCount);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("RunningTargetFloor", this.TargetFloor);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 5) = new ValueTuple<string, object>("State", this.State);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 6));
				return false;
			}
			if (this.TargetFloor == targetFloor)
			{
				global::Log instance3 = global::Log.Instance;
				ELogModule module3 = ELogModule.SceneItem;
				ELogAuthor author3 = ELogAuthor.CK;
				string message3 = "CheckTargetFloorValid Failed, Target Floor Already Running";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("EntityConfigId", this.EntityConfigId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("CurFloor", this.CurLiftFloor);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("TargetFloor", targetFloor);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("FloorCount", floorCount);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 4) = new ValueTuple<string, object>("State", this.State);
				instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 5));
				this.PendingServerTargetFloor = 0;
				return false;
			}
			if (this.TargetFloor != 0)
			{
				global::Log instance4 = global::Log.Instance;
				ELogModule module4 = ELogModule.SceneItem;
				ELogAuthor author4 = ELogAuthor.CK;
				string message4 = "CheckTargetFloorValid Failed, Elevator Is Running";
				<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray6<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("EntityConfigId", this.EntityConfigId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("CurFloor", this.CurLiftFloor);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("TargetFloor", targetFloor);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 3) = new ValueTuple<string, object>("RunningTargetFloor", this.TargetFloor);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 4) = new ValueTuple<string, object>("FloorCount", floorCount);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 5) = new ValueTuple<string, object>("State", this.State);
				instance4.Warn(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 6));
				this.PendingServerTargetFloor = targetFloor;
				return false;
			}
			return true;
		}

		// Token: 0x0603D03F RID: 249919 RVA: 0x0118C5E2 File Offset: 0x0118A7E2
		public bool IsMovingOrTeleporting()
		{
			return this.State == EGamePlayElevatorState.Moving || this.State == EGamePlayElevatorState.MovingPhaseTwo || this.State == EGamePlayElevatorState.Teleporting;
		}

		// Token: 0x0603D040 RID: 249920 RVA: 0x0118C604 File Offset: 0x0118A804
		[NullableContext(2)]
		public ALevelSequenceActor GetPlayingSequenceActor()
		{
			ElevatorSequenceMoveStrategy elevatorSequenceMoveStrategy = this.MoveStrategy as ElevatorSequenceMoveStrategy;
			if (elevatorSequenceMoveStrategy != null)
			{
				return elevatorSequenceMoveStrategy.GetPlayingSequenceActor();
			}
			return null;
		}

		// Token: 0x0603D041 RID: 249921 RVA: 0x0118C628 File Offset: 0x0118A828
		private void TryStartAutoMove()
		{
			if (this.IsAutoMove)
			{
				int nextTargetFloor = this.GetNextTargetFloor();
				this.MoveToTargetFloor(nextTargetFloor, "AutoMoveStart");
			}
		}

		// Token: 0x0603D042 RID: 249922 RVA: 0x0118C650 File Offset: 0x0118A850
		public unsafe void MoveToTargetFloor(int targetFloor, string reason)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.CK;
			string message = "MoveToTargetFloor";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityConfigId", this.EntityConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TargetFloor", targetFloor);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Reason", reason);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			ElevatorSequenceMoveStrategy elevatorSequenceMoveStrategy = this.MoveStrategy as ElevatorSequenceMoveStrategy;
			if (elevatorSequenceMoveStrategy != null && elevatorSequenceMoveStrategy.IsInitializing)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.CK;
				string message2 = "MoveToTargetFloor 电梯正在初始化, 忽略移动请求";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityConfigId", this.EntityConfigId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("TargetFloor", targetFloor);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Reason", reason);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return;
			}
			if (!this.PrepareMoveToFloor(targetFloor))
			{
				return;
			}
			ElevatorNormalMoveStrategy elevatorNormalMoveStrategy = this.MoveStrategy as ElevatorNormalMoveStrategy;
			if (elevatorNormalMoveStrategy != null)
			{
				elevatorNormalMoveStrategy.StartMoveByDefault();
			}
			this.StartPreparedMove(targetFloor);
		}

		// Token: 0x0603D043 RID: 249923 RVA: 0x0118C794 File Offset: 0x0118A994
		public unsafe void MoveToTargetFloorByTeleport(int targetFloor, float startOffset, float endOffset, bool needEmitEvent = false, float startEventOffset = 0f)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.CK;
			string message = "MoveToTargetFloorByTeleport";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityConfigId", this.EntityConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TargetFloor", targetFloor);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (!this.PrepareMoveToFloor(targetFloor))
			{
				return;
			}
			((ElevatorNormalMoveStrategy)this.MoveStrategy).StartMoveByTeleport(startOffset, endOffset, needEmitEvent, startEventOffset);
			this.StartPreparedMove(targetFloor);
		}

		// Token: 0x0603D044 RID: 249924 RVA: 0x0118C82C File Offset: 0x0118AA2C
		public unsafe void MoveToTargetFloorByCurve(int targetFloor, string curveName, float duration)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.CK;
			string message = "MoveToTargetFloorByPath";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityConfigId", this.EntityConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TargetFloor", targetFloor);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (!this.PrepareMoveToFloor(targetFloor))
			{
				return;
			}
			((ElevatorNormalMoveStrategy)this.MoveStrategy).StartMoveByCurve(curveName, duration);
			this.StartPreparedMove(targetFloor);
		}

		// Token: 0x0603D045 RID: 249925 RVA: 0x0118C8BE File Offset: 0x0118AABE
		private bool PrepareMoveToFloor(int targetFloor)
		{
			if (!this.CheckTargetFloorValid(targetFloor))
			{
				return false;
			}
			this.TargetFloor = targetFloor;
			this.MoveCtx.TargetFloor = targetFloor;
			return true;
		}

		// Token: 0x0603D046 RID: 249926 RVA: 0x0118C8E0 File Offset: 0x0118AAE0
		private void StartPreparedMove(int targetFloor)
		{
			this.MoveStrategy.PrepareMoveToFloor(delegate
			{
				this.StartMoveWithDelay(targetFloor);
			});
		}

		// Token: 0x0603D047 RID: 249927 RVA: 0x0118C918 File Offset: 0x0118AB18
		private void StartMoveWithDelay(int targetFloor)
		{
			GamePlayElevatorComponent.<>c__DisplayClass64_0 CS$<>8__locals1 = new GamePlayElevatorComponent.<>c__DisplayClass64_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.targetFloor = targetFloor;
			this.ClearStartMoveDelayTimer();
			if (this.MoveCtx.DelayMoveTime != null && this.MoveCtx.DelayMoveTime.Value != 0f)
			{
				this.DelayMoveTimer = TimerSystem.Instance.Delay(delegate(float _)
				{
					CS$<>8__locals1.<>4__this.DelayMoveTimer = null;
					base.<StartMoveWithDelay>g__DoEnter|0();
				}, this.MoveCtx.DelayMoveTime.Value * 1000f, null, null, true, 1f);
				return;
			}
			CS$<>8__locals1.<StartMoveWithDelay>g__DoEnter|0();
		}

		// Token: 0x0603D048 RID: 249928 RVA: 0x0118C9A9 File Offset: 0x0118ABA9
		private void ClearStartMoveDelayTimer()
		{
			if (this.DelayMoveTimer != null)
			{
				TimerSystem.Instance.Remove(this.DelayMoveTimer);
				this.DelayMoveTimer = null;
			}
		}

		// Token: 0x0603D049 RID: 249929 RVA: 0x0118C9CC File Offset: 0x0118ABCC
		private void PostMoveToFloor(int targetFloor)
		{
			if (this.IsAutoMove)
			{
				this.SyncElevatorStateToServer(targetFloor, true);
			}
			if (!this.IsAutoMove)
			{
				TsBaseCharacter baseCharacter = Global.BaseCharacter;
				if (baseCharacter != null)
				{
					global::Vector actorLocationProxy = baseCharacter.CharacterActorComponent.ActorLocationProxy;
					ElevatorUsedRecord elevatorUsedRecord = new ElevatorUsedRecord();
					elevatorUsedRecord.i_config_id = (((this.EntityConfigId != null) ? this.EntityConfigId.GetValueOrDefault().ToString() : null) ?? "");
					elevatorUsedRecord.i_area_id = AreaModel.Instance.AreaInfo.Value.AreaId.ToString();
					elevatorUsedRecord.i_state_id = targetFloor.ToString();
					elevatorUsedRecord.f_player_pos_x = actorLocationProxy.X.ToString("F2");
					elevatorUsedRecord.f_player_pos_y = actorLocationProxy.Y.ToString("F2");
					elevatorUsedRecord.f_player_pos_z = actorLocationProxy.Z.ToString("F2");
					LogController.Instance.LogElevatorUsedPush(elevatorUsedRecord);
				}
			}
		}

		// Token: 0x0603D04A RID: 249930 RVA: 0x0118CAC4 File Offset: 0x0118ACC4
		private void TickHovering(float deltaSeconds)
		{
			this.HoveringTime += deltaSeconds * 0.001f;
			if (this.HoveringTime > this.HoverTime)
			{
				this.HoveringTime = 0f;
				int pendingAutoRunNextFloor = this.PendingAutoRunNextFloor;
				this.PendingAutoRunNextFloor = 0;
				this.EnterState(EGamePlayElevatorState.Stop);
				if (pendingAutoRunNextFloor > 0)
				{
					this.MoveToTargetFloor(pendingAutoRunNextFloor, "HoverFinished");
				}
			}
		}

		// Token: 0x0603D04B RID: 249931 RVA: 0x0118CB23 File Offset: 0x0118AD23
		private bool GetLock()
		{
			return base.Entity.GetComponent<LevelTagComponent>().HasTag(GameplayTagDefine.EGameplayTagId["关卡.Common.属性.锁定"]);
		}

		// Token: 0x0603D04C RID: 249932 RVA: 0x0118CB44 File Offset: 0x0118AD44
		private void HandleStateChangeResponse()
		{
			this.IsInStateChange = new bool?(false);
		}

		// Token: 0x0603D04D RID: 249933 RVA: 0x0118CB54 File Offset: 0x0118AD54
		private bool HasEntityBelow()
		{
			if (this.RangeComp == null)
			{
				return false;
			}
			IEnumerable<KeyValuePair<int, EntityHandle>> entitiesInRangeLocal = this.RangeComp.GetEntitiesInRangeLocal();
			Dictionary<int, EntityHandle> dictionary;
			if (entitiesInRangeLocal == null)
			{
				dictionary = null;
			}
			else
			{
				dictionary = NoLinq.ToDictionary<KeyValuePair<int, EntityHandle>, int, EntityHandle>(entitiesInRangeLocal, (KeyValuePair<int, EntityHandle> pair) => pair.Key, (KeyValuePair<int, EntityHandle> pair) => pair.Value);
			}
			Dictionary<int, EntityHandle> dictionary2 = dictionary;
			if (dictionary2 == null)
			{
				return false;
			}
			bool result = false;
			foreach (EntityHandle entityHandle in dictionary2.Values)
			{
				if (entityHandle != null && entityHandle.Valid && entityHandle.Entity != base.Entity)
				{
					BaseActorComponent component = entityHandle.Entity.GetComponent<BaseActorComponent>();
					global::Vector vector = (component != null) ? component.ActorLocationProxy : null;
					BaseActorComponent component2 = entityHandle.Entity.GetComponent<BaseActorComponent>();
					bool? flag = (component2 != null) ? new bool?(component2.HasMesh()) : null;
					CreatureDataComponent component3 = entityHandle.Entity.GetComponent<CreatureDataComponent>();
					long? num = (component3 != null) ? new long?(component3.GetSummonerId()) : null;
					bool flag2;
					if (num != null)
					{
						long? num2 = num;
						long num3 = 0L;
						flag2 = !(num2.GetValueOrDefault() == num3 & num2 != null);
					}
					else
					{
						flag2 = false;
					}
					bool flag3 = flag2;
					BaseActorComponent component4 = base.Entity.GetComponent<BaseActorComponent>();
					global::Vector vector2 = (component4 != null) ? component4.ActorLocationProxy : null;
					if (flag.GetValueOrDefault() && vector != null && vector.Z < vector2.Z - 100.0 && !flag3)
					{
						Entity entity = entityHandle.Entity;
						TsBaseCharacter baseCharacter = Global.BaseCharacter;
						if (entity == ((baseCharacter != null) ? baseCharacter.CharacterActorComponent.Entity : null))
						{
							WorldEntity entity2 = entityHandle.Entity;
							if (entity2 != null)
							{
								CharacterManipulateComponent component5 = entity2.GetComponent<CharacterManipulateComponent>();
								if (component5 != null)
								{
									component5.StopManipulate();
								}
							}
						}
						this.SetEntitySafePos(entityHandle.Entity);
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x0603D04E RID: 249934 RVA: 0x0118CD68 File Offset: 0x0118AF68
		private void SetEntitySafePos(Entity entity)
		{
			BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
			global::Vector vector = (component != null) ? component.ActorLocationProxy : null;
			global::Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
			if (vector == null || actorLocationProxy == null)
			{
				return;
			}
			if (this.SafePosition == null)
			{
				actorLocationProxy.Subtraction(vector, this.TempVector);
				this.TempVector.Z = 0.0;
				BaseActorComponent component2 = entity.GetComponent<BaseActorComponent>();
				int num = 3;
				int i = 0;
				while (i <= num)
				{
					this.TempLocation.X = vector.X + this.TempVector.X * (double)((float)i / (float)num);
					this.TempLocation.Y = vector.Y + this.TempVector.Y * (double)((float)i / (float)num);
					this.TempLocation.Z = vector.Z;
					ValueTuple<bool, UKuroHitResult> valueTuple = TraceUtils.LineTraceWithLocation(this.TempLocation, 2000f, 0f);
					bool item = valueTuple.Item1;
					UKuroHitResult item2 = valueTuple.Item2;
					if (item && !item2.bStartPenetrating)
					{
						global::Vector commonHitLocation = TraceElementModel.Instance.CommonHitLocation;
						TraceElementCommon.Instance.GetImpactPoint(item2, 0, commonHitLocation);
						float radius = component2.GetRadius();
						commonHitLocation.Z += (double)radius;
						CharacterActorComponent component3 = entity.GetComponent<CharacterActorComponent>();
						if (component3 != null)
						{
							int handle = component2.DisableCollision("[GamePlayElevatorComponent.SetEntitySafePos]");
							component3.TeleportAndFindStandLocation(commonHitLocation, true);
							component2.EnableCollision(handle);
							return;
						}
						SceneItemManipulatableComponent component4 = entity.GetComponent<SceneItemManipulatableComponent>();
						if (component4 != null)
						{
							component4.TryEnableTick(true);
						}
						component2.SetActorLocation(commonHitLocation.ToUeVector(false), base.GetType().Name, false);
						return;
					}
					else
					{
						i++;
					}
				}
				return;
			}
			BaseActorComponent component5 = entity.GetComponent<BaseActorComponent>();
			float radius2 = component5.GetRadius();
			global::Vector vector2 = global::Vector.Create(actorLocationProxy.X + this.SafePosition.X, actorLocationProxy.Y + this.SafePosition.Y, actorLocationProxy.Z + this.SafePosition.Z + (double)radius2);
			CharacterActorComponent component6 = entity.GetComponent<CharacterActorComponent>();
			if (component6 != null)
			{
				int handle2 = component5.DisableCollision("[GamePlayElevatorComponent.SetEntitySafePos]");
				component6.TeleportAndFindStandLocation(vector2, true);
				component5.EnableCollision(handle2);
				return;
			}
			component5.SetActorLocation(vector2.ToUeVector(false), base.GetType().Name, false);
		}

		// Token: 0x0603D04F RID: 249935 RVA: 0x0118CFA8 File Offset: 0x0118B1A8
		private bool HasPlayerInElevator()
		{
			if (this.RangeComp == null)
			{
				return false;
			}
			int entityId = -1;
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter != null)
			{
				entityId = baseCharacter.CharacterActorComponent.Entity.Id;
			}
			return this.RangeComp.IsEntityInRange(entityId);
		}

		// Token: 0x0603D050 RID: 249936 RVA: 0x0118CFE8 File Offset: 0x0118B1E8
		private void RecordManipulatableItem(bool isEnter, EntityHandle handle)
		{
			WorldEntity entity = handle.Entity;
			if (entity.GetComponent<SceneItemManipulatableComponent>() != null)
			{
				BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
				int num = this.ActorOnElevator.IndexOf(component.Owner);
				if (isEnter)
				{
					if (num == -1)
					{
						this.ActorOnElevator.Add(component.Owner);
					}
				}
				else if (num != -1)
				{
					this.ActorOnElevator.RemoveAt(num);
				}
				num = this.ActorHitElevator.IndexOf(component.Owner);
				if (num != -1)
				{
					this.ActorHitElevator.RemoveAt(num);
				}
			}
		}

		// Token: 0x0603D051 RID: 249937 RVA: 0x0118D06C File Offset: 0x0118B26C
		private void SetPlayerOnElevatorBuff(bool isEnter)
		{
			if (!this.IsMovingOrTeleporting())
			{
				return;
			}
			long activeElevatorBuffId = this.GetActiveElevatorBuffId();
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter != null)
			{
				CharacterBuffComponent component = baseCharacter.CharacterActorComponent.Entity.GetComponent<CharacterBuffComponent>();
				if (component != null)
				{
					if (isEnter)
					{
						double z = baseCharacter.D_K2_GetActorLocation().Z;
						double z2 = this.ActorComp.ActorLocationProxy.Z;
						if (z > z2)
						{
							component.AddBuff(activeElevatorBuffId, new AddBuffParam
							{
								InstigatorId = component.CreatureDataId,
								Duration = new float?(this.GetRunDuration()),
								Reason = "电梯添加buff"
							});
							EventSystem.Instance.EmitWithTarget(component.Entity, EEventName.ElevatorMove);
							this.DisableMotionBlur();
							return;
						}
					}
					else
					{
						component.RemoveBuff(activeElevatorBuffId, -1, "电梯移除buff", null, null, null);
						this.EnableMotionBlur();
					}
				}
			}
		}

		// Token: 0x0603D052 RID: 249938 RVA: 0x0118D155 File Offset: 0x0118B355
		private float GetRunDuration()
		{
			return this.MoveStrategy.GetMoveDuration();
		}

		// Token: 0x0603D053 RID: 249939 RVA: 0x0118D164 File Offset: 0x0118B364
		private unsafe int GetNextTargetFloor()
		{
			int floorCount = this.MoveStrategy.GetFloorCount();
			if (floorCount == 0)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CK;
				string message = "GetNextTargetFloor 楼层列表为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityConfigId", this.EntityConfigId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return this.CurLiftFloor;
			}
			int num = this.CurLiftFloor - 1;
			if (num < 0 || num >= floorCount)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.CK;
				string message2 = "GetNextTargetFloor 当前楼层索引越界";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityConfigId", this.EntityConfigId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CurFloor", this.CurLiftFloor);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return 1;
			}
			int num2 = this.IsReverseAutoRunning ? (num - 1) : (num + 1);
			if (this.IsAnnular)
			{
				if (num2 >= floorCount)
				{
					num2 = 0;
				}
				else if (num2 < 0)
				{
					num2 = floorCount - 1;
				}
			}
			else if (num2 >= floorCount)
			{
				num2 = num - 1;
				this.IsReverseAutoRunning = true;
			}
			else if (num2 < 0)
			{
				num2 = num + 1;
				this.IsReverseAutoRunning = false;
			}
			return num2 + 1;
		}

		// Token: 0x0603D054 RID: 249940 RVA: 0x0118D280 File Offset: 0x0118B480
		[NullableContext(2)]
		private void OnManipulatableSceneItemHit(AActor selfActor, AActor otherActor, FVector normalImpulse, [Nullable(1)] FHitResult hit)
		{
			EntityHandle entityByActor = ActorUtils.GetEntityByActor(otherActor, true);
			if (entityByActor == null)
			{
				return;
			}
			if (entityByActor.Entity.GetComponent<SceneItemManipulatableComponent>() == null)
			{
				return;
			}
			if (this.ActorHitElevator.IndexOf(otherActor) == -1)
			{
				if (this.IsMovingOrTeleporting() && this.ActorOnElevator.IndexOf(otherActor) != -1)
				{
					this.AttachToElevator(otherActor);
				}
				this.ActorHitElevator.Add(otherActor);
			}
		}

		// Token: 0x0603D055 RID: 249941 RVA: 0x0118D2E0 File Offset: 0x0118B4E0
		protected void OnSceneInteractionLoadCompleted()
		{
			SceneItemActorComponent component = base.Entity.GetComponent<SceneItemActorComponent>();
			AActor mainCollisionActor = SceneInteractionManager.Get().GetMainCollisionActor(component.GetSceneInteractionLevelHandleId());
			this.PrimitiveComp = (((mainCollisionActor != null) ? mainCollisionActor.GetComponentByClass(UPrimitiveComponent.StaticClass()) : null) as UPrimitiveComponent);
			if (this.PrimitiveComp != null)
			{
				mainCollisionActor.OnActorHit.Add(new Action<AActor, AActor, FVector, FHitResult>(this.OnManipulatableSceneItemHit));
				this.PrimitiveComp.SetNotifyRigidBodyCollision(true);
			}
		}

		// Token: 0x0603D056 RID: 249942 RVA: 0x0118D358 File Offset: 0x0118B558
		private void AttachToElevator(AActor actor)
		{
			EntityHandle entityByActor = ActorUtils.GetEntityByActor(actor, true);
			if (entityByActor == null)
			{
				return;
			}
			SceneItemManipulatableComponent component = entityByActor.Entity.GetComponent<SceneItemManipulatableComponent>();
			if (component == null)
			{
				return;
			}
			component.TryDisableTick("[GamePlayElevator.AttachToElevator] 上电梯关闭Tick");
			SceneItemActorComponent component2 = base.Entity.GetComponent<SceneItemActorComponent>();
			AttachToActorController.Instance.AttachToActor(actor, component2.Owner, EDetachType.DestroyExternal, "GamePlayElevatorComponent.AttachToElevator", null, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, false, true, false, false, false);
		}

		// Token: 0x0603D057 RID: 249943 RVA: 0x0118D3C4 File Offset: 0x0118B5C4
		private void DetachFromElevator(AActor actor)
		{
			AttachToActorController.Instance.DetachActor(actor, false, "GamePlayElevatorComponent.DetachFromElevator", EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
			EntityHandle entityByActor = ActorUtils.GetEntityByActor(actor, true);
			if (entityByActor == null)
			{
				return;
			}
			SceneItemManipulatableComponent component = entityByActor.Entity.GetComponent<SceneItemManipulatableComponent>();
			if (component == null)
			{
				return;
			}
			component.TryEnableTick(true);
		}

		// Token: 0x0603D058 RID: 249944 RVA: 0x0118D40C File Offset: 0x0118B60C
		public void RegisterAfterElevatorTickHandler(object key, Action<float> tickHandler)
		{
			HashSet<Action<float>> hashSet;
			if (!this.AfterElevatorTickHandlers.TryGetValue(key, out hashSet))
			{
				hashSet = new HashSet<Action<float>>();
				this.AfterElevatorTickHandlers[key] = hashSet;
			}
			hashSet.Add(tickHandler);
		}

		// Token: 0x0603D059 RID: 249945 RVA: 0x0118D444 File Offset: 0x0118B644
		public void UnRegisterAfterElevatorTickHandlers(object key)
		{
			this.AfterElevatorTickHandlers.Remove(key);
		}

		// Token: 0x0603D05A RID: 249946 RVA: 0x0118D454 File Offset: 0x0118B654
		private void ForceTickAfterElevatorTick(float deltaSeconds)
		{
			this.TempAfterElevatorTickHandlers.Clear();
			foreach (HashSet<Action<float>> collection in this.AfterElevatorTickHandlers.Values)
			{
				this.TempAfterElevatorTickHandlers.AddRange(collection);
			}
			foreach (Action<float> action in this.TempAfterElevatorTickHandlers)
			{
				if (action != null)
				{
					action(deltaSeconds);
				}
			}
			this.TempAfterElevatorTickHandlers.Clear();
		}

		// Token: 0x0603D05B RID: 249947 RVA: 0x0118D510 File Offset: 0x0118B710
		protected override void OnActivate()
		{
			if (!Info.Instance.EnableForceTick && base.Active)
			{
				ComponentForceTickController.Instance.RegisterPreMoveTick(this, new Action<float>(this.ForceTickInternal));
			}
		}

		// Token: 0x0603D05C RID: 249948 RVA: 0x0118D53D File Offset: 0x0118B73D
		protected override void OnEnable()
		{
			if (!Info.Instance.EnableForceTick)
			{
				Entity entity = base.Entity;
				if (entity != null && entity.IsInit)
				{
					ComponentForceTickController.Instance.RegisterPreMoveTick(this, new Action<float>(this.ForceTickInternal));
				}
			}
		}

		// Token: 0x0603D05D RID: 249949 RVA: 0x0118D576 File Offset: 0x0118B776
		protected override bool OnEnd()
		{
			if (!Info.Instance.EnableForceTick)
			{
				ComponentForceTickController.Instance.UnregisterPreMoveTick(this);
			}
			return true;
		}

		// Token: 0x0603D05E RID: 249950 RVA: 0x0118D590 File Offset: 0x0118B790
		protected override void OnDisable(string reason)
		{
			if (!Info.Instance.EnableForceTick)
			{
				ComponentForceTickController.Instance.UnregisterPreMoveTick(this);
			}
		}

		// Token: 0x0603D05F RID: 249951 RVA: 0x0118D5AC File Offset: 0x0118B7AC
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			GamePlayElevatorComponent gamePlayElevatorComponent = (GamePlayElevatorComponent)componentTemplate;
			if (gamePlayElevatorComponent.AfterElevatorTickHandlers != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.AfterElevatorTickHandlers), "AfterElevatorTickHandlers"))
			{
				return false;
			}
			if (gamePlayElevatorComponent.TempAfterElevatorTickHandlers != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempAfterElevatorTickHandlers), "TempAfterElevatorTickHandlers"))
			{
				return false;
			}
			if (gamePlayElevatorComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (gamePlayElevatorComponent.ActorHitElevator == null)
			{
				this.ActorHitElevator = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorHitElevator), "ActorHitElevator"))
			{
				return false;
			}
			if (gamePlayElevatorComponent.ActorOnElevator == null)
			{
				this.ActorOnElevator = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorOnElevator), "ActorOnElevator"))
			{
				return false;
			}
			this.AFMEKey = gamePlayElevatorComponent.AFMEKey;
			if (gamePlayElevatorComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			this.CustomLiftBuffType = gamePlayElevatorComponent.CustomLiftBuffType;
			this.CustomTimeScale = gamePlayElevatorComponent.CustomTimeScale;
			this.EnableCustomTimeScale = gamePlayElevatorComponent.EnableCustomTimeScale;
			this.EntityConfigId = gamePlayElevatorComponent.EntityConfigId;
			this.HoveringTime = gamePlayElevatorComponent.HoveringTime;
			this.HoverTime = gamePlayElevatorComponent.HoverTime;
			this.IsAnnular = gamePlayElevatorComponent.IsAnnular;
			this.IsAutoMove = gamePlayElevatorComponent.IsAutoMove;
			this.IsDescending = gamePlayElevatorComponent.IsDescending;
			this.IsInStateChange = gamePlayElevatorComponent.IsInStateChange;
			this.IsReverseAutoRunning = gamePlayElevatorComponent.IsReverseAutoRunning;
			this.PendingAutoRunNextFloor = gamePlayElevatorComponent.PendingAutoRunNextFloor;
			this.PendingServerTargetFloor = gamePlayElevatorComponent.PendingServerTargetFloor;
			if (gamePlayElevatorComponent.PrimitiveComp == null)
			{
				this.PrimitiveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PrimitiveComp), "PrimitiveComp"))
			{
				return false;
			}
			if (gamePlayElevatorComponent.PropComp == null)
			{
				this.PropComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PropComp), "PropComp"))
			{
				return false;
			}
			if (gamePlayElevatorComponent.RangeComp == null)
			{
				this.RangeComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RangeComp), "RangeComp"))
			{
				return false;
			}
			if (gamePlayElevatorComponent.SafePosition == null)
			{
				this.SafePosition = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SafePosition), "SafePosition"))
			{
				return false;
			}
			this.State = gamePlayElevatorComponent.State;
			this.TargetFloor = gamePlayElevatorComponent.TargetFloor;
			if (gamePlayElevatorComponent.TempLocation == null)
			{
				this.TempLocation = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempLocation), "TempLocation"))
			{
				return false;
			}
			if (gamePlayElevatorComponent.TempVector == null)
			{
				this.TempVector = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector), "TempVector"))
			{
				return false;
			}
			this.CurLiftFloor = gamePlayElevatorComponent.CurLiftFloor;
			if (gamePlayElevatorComponent.MoveCtx == null)
			{
				this.MoveCtx = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveCtx), "MoveCtx"))
			{
				return false;
			}
			if (gamePlayElevatorComponent.MoveStrategy == null)
			{
				this.MoveStrategy = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveStrategy), "MoveStrategy"))
			{
				return false;
			}
			if (gamePlayElevatorComponent.DelayMoveTimer == null)
			{
				this.DelayMoveTimer = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DelayMoveTimer), "DelayMoveTimer"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x17007378 RID: 29560
		// (get) Token: 0x0603D060 RID: 249952 RVA: 0x0118D90B File Offset: 0x0118BB0B
		public override bool NeedInitInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007379 RID: 29561
		// (get) Token: 0x0603D061 RID: 249953 RVA: 0x0118D90E File Offset: 0x0118BB0E
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700737A RID: 29562
		// (get) Token: 0x0603D062 RID: 249954 RVA: 0x0118D911 File Offset: 0x0118BB11
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700737B RID: 29563
		// (get) Token: 0x0603D063 RID: 249955 RVA: 0x0118D914 File Offset: 0x0118BB14
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700737C RID: 29564
		// (get) Token: 0x0603D064 RID: 249956 RVA: 0x0118D917 File Offset: 0x0118BB17
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700737D RID: 29565
		// (get) Token: 0x0603D065 RID: 249957 RVA: 0x0118D91A File Offset: 0x0118BB1A
		public override bool NeedEnableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700737E RID: 29566
		// (get) Token: 0x0603D066 RID: 249958 RVA: 0x0118D91D File Offset: 0x0118BB1D
		public override bool NeedDisableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700737F RID: 29567
		// (get) Token: 0x0603D067 RID: 249959 RVA: 0x0118D920 File Offset: 0x0118BB20
		public override bool NeedForceTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007380 RID: 29568
		// (get) Token: 0x0603D068 RID: 249960 RVA: 0x0118D923 File Offset: 0x0118BB23
		public override bool NeedChangeTimeDilationInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040205A6 RID: 132518
		private readonly Dictionary<object, HashSet<Action<float>>> AfterElevatorTickHandlers = new Dictionary<object, HashSet<Action<float>>>();

		// Token: 0x040205A7 RID: 132519
		private readonly List<Action<float>> TempAfterElevatorTickHandlers = new List<Action<float>>();

		// Token: 0x040205A8 RID: 132520
		[Nullable(2)]
		private BaseActorComponent ActorComp;

		// Token: 0x040205A9 RID: 132521
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<AActor> ActorHitElevator;

		// Token: 0x040205AA RID: 132522
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<AActor> ActorOnElevator;

		// Token: 0x040205AB RID: 132523
		private string AFMEKey = "";

		// Token: 0x040205AC RID: 132524
		[Nullable(2)]
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x040205AD RID: 132525
		private ELiftBuffType? CustomLiftBuffType;

		// Token: 0x040205AE RID: 132526
		private float CustomTimeScale = 1f;

		// Token: 0x040205AF RID: 132527
		private bool EnableCustomTimeScale;

		// Token: 0x040205B0 RID: 132528
		private int? EntityConfigId;

		// Token: 0x040205B1 RID: 132529
		private float HoveringTime;

		// Token: 0x040205B2 RID: 132530
		private float HoverTime;

		// Token: 0x040205B3 RID: 132531
		private bool IsAnnular;

		// Token: 0x040205B4 RID: 132532
		private bool IsAutoMove;

		// Token: 0x040205B5 RID: 132533
		private bool IsDescending;

		// Token: 0x040205B6 RID: 132534
		private bool? IsInStateChange;

		// Token: 0x040205B7 RID: 132535
		private bool IsReverseAutoRunning;

		// Token: 0x040205B8 RID: 132536
		private int PendingAutoRunNextFloor;

		// Token: 0x040205B9 RID: 132537
		private int PendingServerTargetFloor;

		// Token: 0x040205BA RID: 132538
		[Nullable(2)]
		private UPrimitiveComponent PrimitiveComp;

		// Token: 0x040205BB RID: 132539
		[Nullable(2)]
		private SceneItemPropertyComponent PropComp;

		// Token: 0x040205BC RID: 132540
		[Nullable(2)]
		private CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent RangeComp;

		// Token: 0x040205BD RID: 132541
		[Nullable(2)]
		private global::Vector SafePosition;

		// Token: 0x040205BE RID: 132542
		private EGamePlayElevatorState State;

		// Token: 0x040205BF RID: 132543
		private int TargetFloor;

		// Token: 0x040205C0 RID: 132544
		[Nullable(2)]
		private global::Vector TempLocation;

		// Token: 0x040205C1 RID: 132545
		[Nullable(2)]
		private global::Vector TempVector;

		// Token: 0x040205C3 RID: 132547
		private ElevatorContext MoveCtx;

		// Token: 0x040205C4 RID: 132548
		private IElevatorMoveStrategy MoveStrategy;

		// Token: 0x040205C5 RID: 132549
		[Nullable(2)]
		private TimerHandle DelayMoveTimer;
	}
}
