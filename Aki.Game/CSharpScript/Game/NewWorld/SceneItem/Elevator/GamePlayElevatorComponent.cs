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
	// Token: 0x02007202 RID: 29186
	[NullableContext(1)]
	[Nullable(0)]
	public class GamePlayElevatorComponent : EntityComponent
	{
		// Token: 0x17009E1A RID: 40474
		// (get) Token: 0x0604771D RID: 292637 RVA: 0x01231AA6 File Offset: 0x0122FCA6
		// (set) Token: 0x0604771E RID: 292638 RVA: 0x01231AAE File Offset: 0x0122FCAE
		public int CurLiftFloor { get; private set; } = 1;

		// Token: 0x0604771F RID: 292639 RVA: 0x01231AB8 File Offset: 0x0122FCB8
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

		// Token: 0x06047720 RID: 292640 RVA: 0x01231E06 File Offset: 0x01230006
		protected override bool OnInit()
		{
			this.MoveStrategy.OnInit();
			return true;
		}

		// Token: 0x06047721 RID: 292641 RVA: 0x01231E14 File Offset: 0x01230014
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

		// Token: 0x06047722 RID: 292642 RVA: 0x01231EB4 File Offset: 0x012300B4
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

		// Token: 0x06047723 RID: 292643 RVA: 0x01231F54 File Offset: 0x01230154
		protected override void OnChangeTimeDilation(float timeDilation)
		{
			if (this.EnableCustomTimeScale)
			{
				PawnTimeScaleComponent component = base.Entity.GetComponent<PawnTimeScaleComponent>();
				this.CustomTimeScale = ((component != null) ? component.CurrentTimeScale : 1f);
			}
		}

		// Token: 0x06047724 RID: 292644 RVA: 0x01231F7F File Offset: 0x0123017F
		protected override void OnForceTick(float deltaSeconds)
		{
			this.ForceTickInternal(deltaSeconds);
		}

		// Token: 0x06047725 RID: 292645 RVA: 0x01231F88 File Offset: 0x01230188
		private void ForceTickInternal(float deltaSeconds)
		{
			float deltaSeconds2 = deltaSeconds * this.CustomTimeScale;
			this.ForceTickElevatorTick(deltaSeconds2);
			this.ForceTickAfterElevatorTick(deltaSeconds2);
		}

		// Token: 0x06047726 RID: 292646 RVA: 0x01231FAC File Offset: 0x012301AC
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

		// Token: 0x06047727 RID: 292647 RVA: 0x0123201C File Offset: 0x0123021C
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

		// Token: 0x06047728 RID: 292648 RVA: 0x0123212C File Offset: 0x0123032C
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

		// Token: 0x06047729 RID: 292649 RVA: 0x012321C4 File Offset: 0x012303C4
		private void EnterMovePhase()
		{
			this.SetIsMoving(true);
			this.UpdateIsDescending();
			this.MoveStrategy.OnEnterMovePhase();
		}

		// Token: 0x0604772A RID: 292650 RVA: 0x012321DE File Offset: 0x012303DE
		private void SetIsMoving(bool value)
		{
			if (this.PropComp != null)
			{
				this.PropComp.IsMoving = value;
			}
		}

		// Token: 0x0604772B RID: 292651 RVA: 0x012321F4 File Offset: 0x012303F4
		private void UpdateIsDescending()
		{
			this.IsDescending = (this.TargetFloor > 0 && this.TargetFloor < this.CurLiftFloor);
		}

		// Token: 0x0604772C RID: 292652 RVA: 0x01232218 File Offset: 0x01230418
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

		// Token: 0x0604772D RID: 292653 RVA: 0x0123227F File Offset: 0x0123047F
		private long GetActiveElevatorBuffId()
		{
			if (this.CustomLiftBuffType.GetValueOrDefault() == ELiftBuffType.AllowJumpDash)
			{
				return 640003037L;
			}
			return 640003011L;
		}

		// Token: 0x0604772E RID: 292654 RVA: 0x0123229C File Offset: 0x0123049C
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

		// Token: 0x0604772F RID: 292655 RVA: 0x012322F0 File Offset: 0x012304F0
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

		// Token: 0x06047730 RID: 292656 RVA: 0x01232468 File Offset: 0x01230668
		private void DisableAFME()
		{
			if (GameSettingsDeviceRender.Instance.IsSupportedAFME)
			{
				GameSettingsDeviceRender.Instance.TemporaryDisableAFME(this.AFMEKey);
			}
		}

		// Token: 0x06047731 RID: 292657 RVA: 0x01232486 File Offset: 0x01230686
		private void EnableAFME()
		{
			if (GameSettingsDeviceRender.Instance.IsSupportedAFME)
			{
				GameSettingsDeviceRender.Instance.CancelTemporaryDisableAFME(this.AFMEKey);
			}
		}

		// Token: 0x06047732 RID: 292658 RVA: 0x012324A4 File Offset: 0x012306A4
		private void DisableMotionBlur()
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.MotionBlur.Amount 0", null);
		}

		// Token: 0x06047733 RID: 292659 RVA: 0x012324B6 File Offset: 0x012306B6
		private void EnableMotionBlur()
		{
			GameSettingsManager.Instance.ReApply(EFunction.MOTIONBLUR, EGameSettingsApplyReason.AnyTime, true);
		}

		// Token: 0x06047734 RID: 292660 RVA: 0x012324C8 File Offset: 0x012306C8
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

		// Token: 0x06047735 RID: 292661 RVA: 0x01232534 File Offset: 0x01230734
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

		// Token: 0x06047736 RID: 292662 RVA: 0x0123266C File Offset: 0x0123086C
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

		// Token: 0x06047737 RID: 292663 RVA: 0x01232A1E File Offset: 0x01230C1E
		public bool IsMovingOrTeleporting()
		{
			return this.State == EGamePlayElevatorState.Moving || this.State == EGamePlayElevatorState.MovingPhaseTwo || this.State == EGamePlayElevatorState.Teleporting;
		}

		// Token: 0x06047738 RID: 292664 RVA: 0x01232A40 File Offset: 0x01230C40
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

		// Token: 0x06047739 RID: 292665 RVA: 0x01232A64 File Offset: 0x01230C64
		private void TryStartAutoMove()
		{
			if (this.IsAutoMove)
			{
				int nextTargetFloor = this.GetNextTargetFloor();
				this.MoveToTargetFloor(nextTargetFloor, "AutoMoveStart");
			}
		}

		// Token: 0x0604773A RID: 292666 RVA: 0x01232A8C File Offset: 0x01230C8C
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

		// Token: 0x0604773B RID: 292667 RVA: 0x01232BD0 File Offset: 0x01230DD0
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

		// Token: 0x0604773C RID: 292668 RVA: 0x01232C68 File Offset: 0x01230E68
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

		// Token: 0x0604773D RID: 292669 RVA: 0x01232CFA File Offset: 0x01230EFA
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

		// Token: 0x0604773E RID: 292670 RVA: 0x01232D1C File Offset: 0x01230F1C
		private void StartPreparedMove(int targetFloor)
		{
			this.MoveStrategy.PrepareMoveToFloor(delegate
			{
				this.StartMoveWithDelay(targetFloor);
			});
		}

		// Token: 0x0604773F RID: 292671 RVA: 0x01232D54 File Offset: 0x01230F54
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

		// Token: 0x06047740 RID: 292672 RVA: 0x01232DE5 File Offset: 0x01230FE5
		private void ClearStartMoveDelayTimer()
		{
			if (this.DelayMoveTimer != null)
			{
				TimerSystem.Instance.Remove(this.DelayMoveTimer);
				this.DelayMoveTimer = null;
			}
		}

		// Token: 0x06047741 RID: 292673 RVA: 0x01232E08 File Offset: 0x01231008
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

		// Token: 0x06047742 RID: 292674 RVA: 0x01232F00 File Offset: 0x01231100
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

		// Token: 0x06047743 RID: 292675 RVA: 0x01232F5F File Offset: 0x0123115F
		private bool GetLock()
		{
			return base.Entity.GetComponent<LevelTagComponent>().HasTag(GameplayTagDefine.EGameplayTagId["关卡.Common.属性.锁定"]);
		}

		// Token: 0x06047744 RID: 292676 RVA: 0x01232F80 File Offset: 0x01231180
		private void HandleStateChangeResponse()
		{
			this.IsInStateChange = new bool?(false);
		}

		// Token: 0x06047745 RID: 292677 RVA: 0x01232F90 File Offset: 0x01231190
		private bool HasEntityBelow()
		{
			if (this.RangeComp == null)
			{
				return false;
			}
			IReadOnlyDictionary<int, EntityHandle> entitiesInRangeLocal = this.RangeComp.GetEntitiesInRangeLocal();
			if (entitiesInRangeLocal == null)
			{
				return false;
			}
			bool result = false;
			foreach (EntityHandle entityHandle in entitiesInRangeLocal.Values)
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

		// Token: 0x06047746 RID: 292678 RVA: 0x01233148 File Offset: 0x01231348
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

		// Token: 0x06047747 RID: 292679 RVA: 0x01233388 File Offset: 0x01231588
		private bool HasPlayerInElevator()
		{
			if (this.RangeComp == null)
			{
				return false;
			}
			IReadOnlyDictionary<int, EntityHandle> entitiesInRangeLocal = this.RangeComp.GetEntitiesInRangeLocal();
			if (entitiesInRangeLocal == null)
			{
				return false;
			}
			int key = -1;
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter != null)
			{
				key = baseCharacter.CharacterActorComponent.Entity.Id;
			}
			return entitiesInRangeLocal.ContainsKey(key);
		}

		// Token: 0x06047748 RID: 292680 RVA: 0x012333D4 File Offset: 0x012315D4
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

		// Token: 0x06047749 RID: 292681 RVA: 0x01233458 File Offset: 0x01231658
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

		// Token: 0x0604774A RID: 292682 RVA: 0x01233541 File Offset: 0x01231741
		private float GetRunDuration()
		{
			return this.MoveStrategy.GetMoveDuration();
		}

		// Token: 0x0604774B RID: 292683 RVA: 0x01233550 File Offset: 0x01231750
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

		// Token: 0x0604774C RID: 292684 RVA: 0x0123366C File Offset: 0x0123186C
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

		// Token: 0x0604774D RID: 292685 RVA: 0x012336CC File Offset: 0x012318CC
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

		// Token: 0x0604774E RID: 292686 RVA: 0x01233744 File Offset: 0x01231944
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

		// Token: 0x0604774F RID: 292687 RVA: 0x012337B0 File Offset: 0x012319B0
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

		// Token: 0x06047750 RID: 292688 RVA: 0x012337F8 File Offset: 0x012319F8
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

		// Token: 0x06047751 RID: 292689 RVA: 0x01233830 File Offset: 0x01231A30
		public void UnRegisterAfterElevatorTickHandlers(object key)
		{
			this.AfterElevatorTickHandlers.Remove(key);
		}

		// Token: 0x06047752 RID: 292690 RVA: 0x01233840 File Offset: 0x01231A40
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

		// Token: 0x06047753 RID: 292691 RVA: 0x012338FC File Offset: 0x01231AFC
		protected override void OnActivate()
		{
			if (!Info.Instance.EnableForceTick && base.Active)
			{
				ComponentForceTickController.Instance.RegisterPreMoveTick(this, new Action<float>(this.ForceTickInternal));
			}
		}

		// Token: 0x06047754 RID: 292692 RVA: 0x01233929 File Offset: 0x01231B29
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

		// Token: 0x06047755 RID: 292693 RVA: 0x01233962 File Offset: 0x01231B62
		protected override bool OnEnd()
		{
			if (!Info.Instance.EnableForceTick)
			{
				ComponentForceTickController.Instance.UnregisterPreMoveTick(this);
			}
			return true;
		}

		// Token: 0x06047756 RID: 292694 RVA: 0x0123397C File Offset: 0x01231B7C
		protected override void OnDisable(string reason)
		{
			if (!Info.Instance.EnableForceTick)
			{
				ComponentForceTickController.Instance.UnregisterPreMoveTick(this);
			}
		}

		// Token: 0x06047757 RID: 292695 RVA: 0x01233998 File Offset: 0x01231B98
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			GamePlayElevatorComponent gamePlayElevatorComponent = (GamePlayElevatorComponent)componentTemplate;
			if (base.CanResetComponentProperty("AfterElevatorTickHandlers") && gamePlayElevatorComponent.AfterElevatorTickHandlers != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<object, HashSet<Action<float>>>>(this.AfterElevatorTickHandlers), "AfterElevatorTickHandlers"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TempAfterElevatorTickHandlers") && gamePlayElevatorComponent.TempAfterElevatorTickHandlers != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<Action<float>>>(this.TempAfterElevatorTickHandlers), "TempAfterElevatorTickHandlers"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (gamePlayElevatorComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ActorHitElevator"))
			{
				if (gamePlayElevatorComponent.ActorHitElevator == null)
				{
					this.ActorHitElevator = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<AActor>>(this.ActorHitElevator), "ActorHitElevator"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ActorOnElevator"))
			{
				if (gamePlayElevatorComponent.ActorOnElevator == null)
				{
					this.ActorOnElevator = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<AActor>>(this.ActorOnElevator), "ActorOnElevator"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("AFMEKey"))
			{
				this.AFMEKey = gamePlayElevatorComponent.AFMEKey;
			}
			if (base.CanResetComponentProperty("CreatureDataComp"))
			{
				if (gamePlayElevatorComponent.CreatureDataComp == null)
				{
					this.CreatureDataComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComp), "CreatureDataComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CustomLiftBuffType"))
			{
				this.CustomLiftBuffType = gamePlayElevatorComponent.CustomLiftBuffType;
			}
			if (base.CanResetComponentProperty("CustomTimeScale"))
			{
				this.CustomTimeScale = gamePlayElevatorComponent.CustomTimeScale;
			}
			if (base.CanResetComponentProperty("EnableCustomTimeScale"))
			{
				this.EnableCustomTimeScale = gamePlayElevatorComponent.EnableCustomTimeScale;
			}
			if (base.CanResetComponentProperty("EntityConfigId"))
			{
				this.EntityConfigId = gamePlayElevatorComponent.EntityConfigId;
			}
			if (base.CanResetComponentProperty("HoveringTime"))
			{
				this.HoveringTime = gamePlayElevatorComponent.HoveringTime;
			}
			if (base.CanResetComponentProperty("HoverTime"))
			{
				this.HoverTime = gamePlayElevatorComponent.HoverTime;
			}
			if (base.CanResetComponentProperty("IsAnnular"))
			{
				this.IsAnnular = gamePlayElevatorComponent.IsAnnular;
			}
			if (base.CanResetComponentProperty("IsAutoMove"))
			{
				this.IsAutoMove = gamePlayElevatorComponent.IsAutoMove;
			}
			if (base.CanResetComponentProperty("IsDescending"))
			{
				this.IsDescending = gamePlayElevatorComponent.IsDescending;
			}
			if (base.CanResetComponentProperty("IsInStateChange"))
			{
				this.IsInStateChange = gamePlayElevatorComponent.IsInStateChange;
			}
			if (base.CanResetComponentProperty("IsReverseAutoRunning"))
			{
				this.IsReverseAutoRunning = gamePlayElevatorComponent.IsReverseAutoRunning;
			}
			if (base.CanResetComponentProperty("PendingAutoRunNextFloor"))
			{
				this.PendingAutoRunNextFloor = gamePlayElevatorComponent.PendingAutoRunNextFloor;
			}
			if (base.CanResetComponentProperty("PendingServerTargetFloor"))
			{
				this.PendingServerTargetFloor = gamePlayElevatorComponent.PendingServerTargetFloor;
			}
			if (base.CanResetComponentProperty("PrimitiveComp"))
			{
				if (gamePlayElevatorComponent.PrimitiveComp == null)
				{
					this.PrimitiveComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UPrimitiveComponent>(this.PrimitiveComp), "PrimitiveComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("PropComp"))
			{
				if (gamePlayElevatorComponent.PropComp == null)
				{
					this.PropComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemPropertyComponent>(this.PropComp), "PropComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("RangeComp"))
			{
				if (gamePlayElevatorComponent.RangeComp == null)
				{
					this.RangeComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent>(this.RangeComp), "RangeComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SafePosition"))
			{
				if (gamePlayElevatorComponent.SafePosition == null)
				{
					this.SafePosition = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.SafePosition), "SafePosition"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("State"))
			{
				this.State = gamePlayElevatorComponent.State;
			}
			if (base.CanResetComponentProperty("TargetFloor"))
			{
				this.TargetFloor = gamePlayElevatorComponent.TargetFloor;
			}
			if (base.CanResetComponentProperty("TempLocation"))
			{
				if (gamePlayElevatorComponent.TempLocation == null)
				{
					this.TempLocation = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TempLocation), "TempLocation"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TempVector"))
			{
				if (gamePlayElevatorComponent.TempVector == null)
				{
					this.TempVector = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TempVector), "TempVector"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("<CurLiftFloor>k__BackingField"))
			{
				this.CurLiftFloor = gamePlayElevatorComponent.CurLiftFloor;
			}
			if (base.CanResetComponentProperty("MoveCtx"))
			{
				if (gamePlayElevatorComponent.MoveCtx == null)
				{
					this.MoveCtx = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ElevatorContext>(this.MoveCtx), "MoveCtx"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("MoveStrategy"))
			{
				if (gamePlayElevatorComponent.MoveStrategy == null)
				{
					this.MoveStrategy = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<IElevatorMoveStrategy>(this.MoveStrategy), "MoveStrategy"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("DelayMoveTimer"))
			{
				if (gamePlayElevatorComponent.DelayMoveTimer == null)
				{
					this.DelayMoveTimer = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.DelayMoveTimer), "DelayMoveTimer"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04025937 RID: 153911
		private readonly Dictionary<object, HashSet<Action<float>>> AfterElevatorTickHandlers = new Dictionary<object, HashSet<Action<float>>>();

		// Token: 0x04025938 RID: 153912
		private readonly List<Action<float>> TempAfterElevatorTickHandlers = new List<Action<float>>();

		// Token: 0x04025939 RID: 153913
		[Nullable(2)]
		private BaseActorComponent ActorComp;

		// Token: 0x0402593A RID: 153914
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<AActor> ActorHitElevator;

		// Token: 0x0402593B RID: 153915
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<AActor> ActorOnElevator;

		// Token: 0x0402593C RID: 153916
		private string AFMEKey = "";

		// Token: 0x0402593D RID: 153917
		[Nullable(2)]
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x0402593E RID: 153918
		private ELiftBuffType? CustomLiftBuffType;

		// Token: 0x0402593F RID: 153919
		private float CustomTimeScale = 1f;

		// Token: 0x04025940 RID: 153920
		private bool EnableCustomTimeScale;

		// Token: 0x04025941 RID: 153921
		private int? EntityConfigId;

		// Token: 0x04025942 RID: 153922
		private float HoveringTime;

		// Token: 0x04025943 RID: 153923
		private float HoverTime;

		// Token: 0x04025944 RID: 153924
		private bool IsAnnular;

		// Token: 0x04025945 RID: 153925
		private bool IsAutoMove;

		// Token: 0x04025946 RID: 153926
		private bool IsDescending;

		// Token: 0x04025947 RID: 153927
		private bool? IsInStateChange;

		// Token: 0x04025948 RID: 153928
		private bool IsReverseAutoRunning;

		// Token: 0x04025949 RID: 153929
		private int PendingAutoRunNextFloor;

		// Token: 0x0402594A RID: 153930
		private int PendingServerTargetFloor;

		// Token: 0x0402594B RID: 153931
		[Nullable(2)]
		private UPrimitiveComponent PrimitiveComp;

		// Token: 0x0402594C RID: 153932
		[Nullable(2)]
		private SceneItemPropertyComponent PropComp;

		// Token: 0x0402594D RID: 153933
		[Nullable(2)]
		private CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent RangeComp;

		// Token: 0x0402594E RID: 153934
		[Nullable(2)]
		private global::Vector SafePosition;

		// Token: 0x0402594F RID: 153935
		private EGamePlayElevatorState State;

		// Token: 0x04025950 RID: 153936
		private int TargetFloor;

		// Token: 0x04025951 RID: 153937
		[Nullable(2)]
		private global::Vector TempLocation;

		// Token: 0x04025952 RID: 153938
		[Nullable(2)]
		private global::Vector TempVector;

		// Token: 0x04025954 RID: 153940
		private ElevatorContext MoveCtx;

		// Token: 0x04025955 RID: 153941
		private IElevatorMoveStrategy MoveStrategy;

		// Token: 0x04025956 RID: 153942
		[Nullable(2)]
		private TimerHandle DelayMoveTimer;
	}
}
