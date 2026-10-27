using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Character.Item;
using AkiClient.Game.Aki.Data.Gameplay.WuWaGo;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.LevelGameplay.SplineConstrainedDrag.Capability;
using CSharpScript.Game.Module.WuwaGo.Controller.GameMode;
using CSharpScript.Game.Module.WuwaGo.Controller.Role.Capability;
using CSharpScript.Game.Module.WuwaGo.Model;
using CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity;
using CSharpScript.Game.Module.WuwaGo.Model.Role;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Controller.Role
{
	// Token: 0x02004758 RID: 18264
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	[Controller(0)]
	public class MainControlRoleController : WuWaGoRoleController<WuWaGoRole>
	{
		// Token: 0x0602FBCC RID: 195532 RVA: 0x00B0ECA4 File Offset: 0x00B0CEA4
		public MainControlRoleController(WuWaGoRole role, WuWaGoGameData gameData, WuWaGoGameModeBase gameMode) : base(role, gameData, gameMode)
		{
			this.MoveCapability = new MoveCapability(role);
			this.ClimbCapability = new ClimbCapability(role);
			this.ScreenTrace = new ScreenPositionTraceCapability(null);
			this.ScreenTrace.GetLineTrace(false, KuroTraceTypeQuery.AcrossBlock);
			this.ScreenTrace.Activate();
		}

		// Token: 0x0602FBCD RID: 195533 RVA: 0x00B0ED5E File Offset: 0x00B0CF5E
		protected override bool OnCreate()
		{
			if (!base.OnCreate())
			{
				return false;
			}
			this.Role.AddStandGridChangedListener(new WuWaGoRoleStandGridChangedListener(this.HandleStandGridChanged));
			return true;
		}

		// Token: 0x0602FBCE RID: 195534 RVA: 0x00B0ED84 File Offset: 0x00B0CF84
		protected override void OnDestroy()
		{
			this.Role.RemoveStandGridChangedListener(new WuWaGoRoleStandGridChangedListener(this.HandleStandGridChanged));
			this.SetInputAccepting(false);
			ScreenPositionTraceCapability screenTrace = this.ScreenTrace;
			if (screenTrace != null)
			{
				screenTrace.Deactivate();
			}
			this.ScreenTrace = null;
			this.ClearAllHoverEffects(true);
			this.StopPullRodInteractMontage("Destroy");
			this.ClimbCapability.ExitClimbIdle();
			CustomPromise<UniTaskVoid> waitActionFinishPromise = this.WaitActionFinishPromise;
			if (waitActionFinishPromise != null)
			{
				waitActionFinishPromise.SetResult(default(UniTaskVoid));
			}
			this.WaitActionFinishPromise = null;
			this.LinkGrids = null;
			foreach (AActor aactor in this.CanMoveTipsApplique)
			{
				if (aactor.IsValid())
				{
					WuWaGoFactory.DestroyApplique(aactor);
				}
			}
			this.CanMoveTipsApplique.Clear();
			base.OnDestroy();
		}

		// Token: 0x0602FBCF RID: 195535 RVA: 0x00B0EE6C File Offset: 0x00B0D06C
		protected override UniTask OnExecuteAction()
		{
			MainControlRoleController.<OnExecuteAction>d__29 <OnExecuteAction>d__;
			<OnExecuteAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnExecuteAction>d__.<>4__this = this;
			<OnExecuteAction>d__.<>1__state = -1;
			<OnExecuteAction>d__.<>t__builder.Start<MainControlRoleController.<OnExecuteAction>d__29>(ref <OnExecuteAction>d__);
			return <OnExecuteAction>d__.<>t__builder.Task;
		}

		// Token: 0x0602FBD0 RID: 195536 RVA: 0x00B0EEB0 File Offset: 0x00B0D0B0
		protected override UniTask OnBeforeAttack(WuWaGoGrid targetGrid)
		{
			MainControlRoleController.<OnBeforeAttack>d__30 <OnBeforeAttack>d__;
			<OnBeforeAttack>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeAttack>d__.<>4__this = this;
			<OnBeforeAttack>d__.targetGrid = targetGrid;
			<OnBeforeAttack>d__.<>1__state = -1;
			<OnBeforeAttack>d__.<>t__builder.Start<MainControlRoleController.<OnBeforeAttack>d__30>(ref <OnBeforeAttack>d__);
			return <OnBeforeAttack>d__.<>t__builder.Task;
		}

		// Token: 0x0602FBD1 RID: 195537 RVA: 0x00B0EEFC File Offset: 0x00B0D0FC
		private void FinishExecuteAction()
		{
			CustomPromise<UniTaskVoid> waitActionFinishPromise = this.WaitActionFinishPromise;
			if (waitActionFinishPromise == null)
			{
				return;
			}
			waitActionFinishPromise.SetResult(default(UniTaskVoid));
		}

		// Token: 0x0602FBD2 RID: 195538 RVA: 0x00B0EF22 File Offset: 0x00B0D122
		[NullableContext(2)]
		private void HandleStandGridChanged([Nullable(1)] WuWaGoRole role, WuWaGoGrid prevGrid, WuWaGoGrid currentGrid)
		{
			this.RefreshProgress(currentGrid);
			this.CheckArriveEndPoint(currentGrid);
		}

		// Token: 0x0602FBD3 RID: 195539 RVA: 0x00B0EF34 File Offset: 0x00B0D134
		[NullableContext(2)]
		private void RefreshProgress(WuWaGoGrid currentGrid)
		{
			if (this.GameMode.IsCinematicPlaying)
			{
				return;
			}
			WuWaGoGameData gameData = WuWaGoModel.Instance.GameData;
			int progressTotalGridCount = gameData.ProgressTotalGridCount;
			EWuWaGoEntityType? ewuWaGoEntityType = (currentGrid != null) ? currentGrid.EntityType : null;
			if (currentGrid != null && (ewuWaGoEntityType.GetValueOrDefault() == EWuWaGoEntityType.SaveGrid || ewuWaGoEntityType.GetValueOrDefault() == EWuWaGoEntityType.EndGrid))
			{
				bool flag = !gameData.VisitedProgressGridIds.Contains(currentGrid.Id);
				gameData.VisitedProgressGridIds.Add(currentGrid.Id);
				if (flag)
				{
					WuWaGoController.Instance.NotifyArrivedSavePoint(currentGrid);
				}
			}
			EventSystem.Instance.Emit<int, int>(EEventName.OnWuWaGoProgressUpdate, gameData.VisitedProgressGridIds.Count, progressTotalGridCount);
		}

		// Token: 0x0602FBD4 RID: 195540 RVA: 0x00B0EFDC File Offset: 0x00B0D1DC
		[NullableContext(2)]
		private void CheckArriveEndPoint(WuWaGoGrid currentGrid)
		{
			if (currentGrid == null || currentGrid.EntityType.GetValueOrDefault() != EWuWaGoEntityType.EndGrid)
			{
				return;
			}
			WuWaGoController.Instance.EndGameplay(true);
		}

		// Token: 0x0602FBD5 RID: 195541 RVA: 0x00B0F014 File Offset: 0x00B0D214
		private void SetInputAccepting(bool accept)
		{
			if (this.IsAcceptingInput == accept)
			{
				return;
			}
			this.IsAcceptingInput = accept;
			(this.Role as WuWaGoMainControlRole).IsAcceptingInput = accept;
			this.GameMode.NotifyMainControlInputAcceptingChanged(accept);
			if (accept)
			{
				EventSystem.Instance.Add<int, int>(EEventName.OnWuWaGoUserPickScreen, new Action<int, int>(this.OnUserPickScreen));
				EventSystem.Instance.Add<int, int>(EEventName.OnWuWaGoUserPreviewScreen, new Action<int, int>(this.OnUserPreviewScreen));
				EventSystem.Instance.Add<double, double>(EEventName.OnWuWaGoUserPickDirection, new Action<double, double>(this.OnUserPickDirection));
				EventSystem.Instance.Add(EEventName.OnWuWaGoUserUseInteraction, new Action(this.OnUserUseInteraction));
			}
			else
			{
				EventSystem.Instance.Remove<int, int>(EEventName.OnWuWaGoUserPickScreen, new Action<int, int>(this.OnUserPickScreen));
				EventSystem.Instance.Remove<int, int>(EEventName.OnWuWaGoUserPreviewScreen, new Action<int, int>(this.OnUserPreviewScreen));
				EventSystem.Instance.Remove<double, double>(EEventName.OnWuWaGoUserPickDirection, new Action<double, double>(this.OnUserPickDirection));
				EventSystem.Instance.Remove(EEventName.OnWuWaGoUserUseInteraction, new Action(this.OnUserUseInteraction));
			}
			this.RefreshInteractionAvailable();
		}

		// Token: 0x0602FBD6 RID: 195542 RVA: 0x00B0F13A File Offset: 0x00B0D33A
		public void SetInputAcceptingFromExternal(bool accept)
		{
			this.SetInputAccepting(accept);
		}

		// Token: 0x0602FBD7 RID: 195543 RVA: 0x00B0F144 File Offset: 0x00B0D344
		private void OnUserPickScreen(int screenX, int screenY)
		{
			if (this.GameMode.IsRollbackRestoring)
			{
				return;
			}
			WuWaGoGrid wuWaGoGrid = this.RaycastToLinkGrid(screenX, screenY);
			if (wuWaGoGrid == null)
			{
				return;
			}
			this.ExecuteOnGrid(wuWaGoGrid);
		}

		// Token: 0x0602FBD8 RID: 195544 RVA: 0x00B0F174 File Offset: 0x00B0D374
		private void OnUserPreviewScreen(int screenX, int screenY)
		{
			if (this.GameMode.IsRollbackRestoring)
			{
				return;
			}
			WuWaGoGrid wuWaGoGrid = this.RaycastToLinkGrid(screenX, screenY);
			WuWaGoGrid grid = (wuWaGoGrid != null && wuWaGoGrid.Id == 0) ? null : wuWaGoGrid;
			this.UpdateGridHoverEffect(grid);
			this.UpdateRedArrowHoverEffect(grid);
		}

		// Token: 0x0602FBD9 RID: 195545 RVA: 0x00B0F1B8 File Offset: 0x00B0D3B8
		private void OnUserPickDirection(double dx, double dy)
		{
			if (this.GameMode.IsRollbackRestoring)
			{
				return;
			}
			WuWaGoGrid gridById = WuWaGoModel.Instance.GetGridById(this.Role.StandGridId);
			bool flag = gridById == null;
			if (!flag)
			{
				List<WuWaGoGrid> linkGrids = this.LinkGrids;
				bool flag2 = (((linkGrids != null) ? new int?(linkGrids.Count) : null) ?? 0) == 0;
				flag = flag2;
			}
			if (flag)
			{
				return;
			}
			WuWaGoGrid wuWaGoGrid = this.FindLinkGridByDirection(dx, dy, gridById);
			if (wuWaGoGrid == null)
			{
				return;
			}
			this.ExecuteOnGrid(wuWaGoGrid);
		}

		// Token: 0x0602FBDA RID: 195546 RVA: 0x00B0F24C File Offset: 0x00B0D44C
		private void OnUserUseInteraction()
		{
			if (this.GameMode.IsRollbackRestoring)
			{
				return;
			}
			WuWaGoGrid gridById = WuWaGoModel.Instance.GetGridById(this.Role.StandGridId);
			if (gridById == null || !this.IsPullRodGrid(gridById))
			{
				return;
			}
			this.RunInteraction(gridById);
		}

		// Token: 0x0602FBDB RID: 195547 RVA: 0x00B0F294 File Offset: 0x00B0D494
		private UniTask ExecuteOnGrid(WuWaGoGrid grid)
		{
			MainControlRoleController.<ExecuteOnGrid>d__41 <ExecuteOnGrid>d__;
			<ExecuteOnGrid>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteOnGrid>d__.<>4__this = this;
			<ExecuteOnGrid>d__.grid = grid;
			<ExecuteOnGrid>d__.<>1__state = -1;
			<ExecuteOnGrid>d__.<>t__builder.Start<MainControlRoleController.<ExecuteOnGrid>d__41>(ref <ExecuteOnGrid>d__);
			return <ExecuteOnGrid>d__.<>t__builder.Task;
		}

		// Token: 0x0602FBDC RID: 195548 RVA: 0x00B0F2E0 File Offset: 0x00B0D4E0
		private UniTask RunPlayerInputAction([Nullable(new byte[]
		{
			1,
			0
		})] Func<UniTask<EPlayerInputActionResult>> action)
		{
			MainControlRoleController.<RunPlayerInputAction>d__42 <RunPlayerInputAction>d__;
			<RunPlayerInputAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunPlayerInputAction>d__.<>4__this = this;
			<RunPlayerInputAction>d__.action = action;
			<RunPlayerInputAction>d__.<>1__state = -1;
			<RunPlayerInputAction>d__.<>t__builder.Start<MainControlRoleController.<RunPlayerInputAction>d__42>(ref <RunPlayerInputAction>d__);
			return <RunPlayerInputAction>d__.<>t__builder.Task;
		}

		// Token: 0x0602FBDD RID: 195549 RVA: 0x00B0F32C File Offset: 0x00B0D52C
		[NullableContext(0)]
		private UniTask<EPlayerInputActionResult> ExecuteActionImp([Nullable(1)] WuWaGoGrid hitGrid)
		{
			MainControlRoleController.<ExecuteActionImp>d__43 <ExecuteActionImp>d__;
			<ExecuteActionImp>d__.<>t__builder = AsyncUniTaskMethodBuilder<EPlayerInputActionResult>.Create();
			<ExecuteActionImp>d__.<>4__this = this;
			<ExecuteActionImp>d__.hitGrid = hitGrid;
			<ExecuteActionImp>d__.<>1__state = -1;
			<ExecuteActionImp>d__.<>t__builder.Start<MainControlRoleController.<ExecuteActionImp>d__43>(ref <ExecuteActionImp>d__);
			return <ExecuteActionImp>d__.<>t__builder.Task;
		}

		// Token: 0x0602FBDE RID: 195550 RVA: 0x00B0F378 File Offset: 0x00B0D578
		[NullableContext(0)]
		private UniTask<bool> TryHandleClimb([Nullable(1)] WuWaGoGrid hitGrid)
		{
			MainControlRoleController.<TryHandleClimb>d__44 <TryHandleClimb>d__;
			<TryHandleClimb>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TryHandleClimb>d__.<>4__this = this;
			<TryHandleClimb>d__.hitGrid = hitGrid;
			<TryHandleClimb>d__.<>1__state = -1;
			<TryHandleClimb>d__.<>t__builder.Start<MainControlRoleController.<TryHandleClimb>d__44>(ref <TryHandleClimb>d__);
			return <TryHandleClimb>d__.<>t__builder.Task;
		}

		// Token: 0x0602FBDF RID: 195551 RVA: 0x00B0F3C4 File Offset: 0x00B0D5C4
		private UniTask RunInteraction(WuWaGoGrid grid)
		{
			MainControlRoleController.<RunInteraction>d__45 <RunInteraction>d__;
			<RunInteraction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunInteraction>d__.<>4__this = this;
			<RunInteraction>d__.grid = grid;
			<RunInteraction>d__.<>1__state = -1;
			<RunInteraction>d__.<>t__builder.Start<MainControlRoleController.<RunInteraction>d__45>(ref <RunInteraction>d__);
			return <RunInteraction>d__.<>t__builder.Task;
		}

		// Token: 0x0602FBE0 RID: 195552 RVA: 0x00B0F410 File Offset: 0x00B0D610
		public UniTask PlayHintMoveAsync(Vector targetCoordinate)
		{
			MainControlRoleController.<PlayHintMoveAsync>d__46 <PlayHintMoveAsync>d__;
			<PlayHintMoveAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayHintMoveAsync>d__.<>4__this = this;
			<PlayHintMoveAsync>d__.targetCoordinate = targetCoordinate;
			<PlayHintMoveAsync>d__.<>1__state = -1;
			<PlayHintMoveAsync>d__.<>t__builder.Start<MainControlRoleController.<PlayHintMoveAsync>d__46>(ref <PlayHintMoveAsync>d__);
			return <PlayHintMoveAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FBE1 RID: 195553 RVA: 0x00B0F45C File Offset: 0x00B0D65C
		public UniTask PlayHintInteractAsync()
		{
			MainControlRoleController.<PlayHintInteractAsync>d__47 <PlayHintInteractAsync>d__;
			<PlayHintInteractAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayHintInteractAsync>d__.<>4__this = this;
			<PlayHintInteractAsync>d__.<>1__state = -1;
			<PlayHintInteractAsync>d__.<>t__builder.Start<MainControlRoleController.<PlayHintInteractAsync>d__47>(ref <PlayHintInteractAsync>d__);
			return <PlayHintInteractAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FBE2 RID: 195554 RVA: 0x00B0F4A0 File Offset: 0x00B0D6A0
		private UniTask PlayPullRodInteractMontage(WuWaGoPullRodEntity pullRodEntity)
		{
			MainControlRoleController.<PlayPullRodInteractMontage>d__48 <PlayPullRodInteractMontage>d__;
			<PlayPullRodInteractMontage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayPullRodInteractMontage>d__.<>4__this = this;
			<PlayPullRodInteractMontage>d__.pullRodEntity = pullRodEntity;
			<PlayPullRodInteractMontage>d__.<>1__state = -1;
			<PlayPullRodInteractMontage>d__.<>t__builder.Start<MainControlRoleController.<PlayPullRodInteractMontage>d__48>(ref <PlayPullRodInteractMontage>d__);
			return <PlayPullRodInteractMontage>d__.<>t__builder.Task;
		}

		// Token: 0x0602FBE3 RID: 195555 RVA: 0x00B0F4EC File Offset: 0x00B0D6EC
		private void StopPullRodInteractMontage(string reason)
		{
			UAnimMontage playingPullRodMontage = this.PlayingPullRodMontage;
			if (playingPullRodMontage == null)
			{
				return;
			}
			UAnimInstance actorAnimInstance = WuWaGoUtil.GetActorAnimInstance(this.Role, "StopPullRodInteractMontage");
			this.PlayingPullRodMontage = null;
			if (actorAnimInstance == null)
			{
				return;
			}
			if (actorAnimInstance.GetCurrentActiveMontage() != playingPullRodMontage && !actorAnimInstance.Montage_IsPlaying(playingPullRodMontage))
			{
				return;
			}
			actorAnimInstance.Montage_Stop(MainControlRoleController.PullRodMontageBlendOutTime, playingPullRodMontage);
		}

		// Token: 0x0602FBE4 RID: 195556 RVA: 0x00B0F540 File Offset: 0x00B0D740
		private void RefreshInteractionAvailable()
		{
			bool flag = this.ComputeInteractionAvailable();
			if (flag == this.LastEmittedInteractionAvailable)
			{
				return;
			}
			this.LastEmittedInteractionAvailable = flag;
			EventSystem.Instance.Emit<bool>(EEventName.OnWuWaGoInteractionAvailable, flag);
		}

		// Token: 0x0602FBE5 RID: 195557 RVA: 0x00B0F578 File Offset: 0x00B0D778
		private bool ComputeInteractionAvailable()
		{
			if (!this.IsAcceptingInput)
			{
				return false;
			}
			WuWaGoGrid gridById = WuWaGoModel.Instance.GetGridById(this.Role.StandGridId);
			return gridById != null && this.IsPullRodGrid(gridById);
		}

		// Token: 0x0602FBE6 RID: 195558 RVA: 0x00B0F5B4 File Offset: 0x00B0D7B4
		[NullableContext(2)]
		private WuWaGoGrid RaycastToLinkGrid(int screenX, int screenY)
		{
			bool flag = this.ScreenTrace == null;
			if (!flag)
			{
				List<WuWaGoGrid> linkGrids = this.LinkGrids;
				bool flag2 = (((linkGrids != null) ? new int?(linkGrids.Count) : null) ?? 0) == 0;
				flag = flag2;
			}
			if (flag)
			{
				return null;
			}
			Transform originTransform = WuWaGoModel.Instance.GameData.OriginTransform;
			if (originTransform == null)
			{
				return null;
			}
			this.ScratchScreenPos.Set((double)screenX, (double)screenY, 0.0);
			if (!this.ScreenTrace.GetHitResultAtScreenPosition(this.ScratchScreenPos, ref this.KuroHitResult, "WuWaGo.Raycast"))
			{
				return null;
			}
			UKuroHitResult kuroHitResult = this.KuroHitResult;
			int num = kuroHitResult.Actors.Num();
			for (int i = 0; i < num; i++)
			{
				AActor aactor = kuroHitResult.Actors.Get(i).Get();
				if (aactor != null && aactor.IsValid() && (aactor is BP_WuWaGo_LandBox_C || aactor is BP_WuWaGo_WallBox_C || this.IsGameplayEntityActor(aactor)))
				{
					WuWaGoUtil.ConvertWorldPositionToCoordinate(originTransform, Vector.Create(aactor.D_K2_GetActorLocation()), this.HitActorCoordinate);
					WuWaGoUtil.SnapVectorToHalf(this.HitActorCoordinate);
					WuWaGoGrid wuWaGoGrid = this.LinkGrids.Find((WuWaGoGrid grid) => grid.Coordinate.Equals(this.HitActorCoordinate, 9.999999747378752E-05));
					if (wuWaGoGrid != null)
					{
						return wuWaGoGrid;
					}
				}
			}
			return null;
		}

		// Token: 0x0602FBE7 RID: 195559 RVA: 0x00B0F71C File Offset: 0x00B0D91C
		[return: Nullable(2)]
		private WuWaGoGrid FindLinkGridByDirection(double dx, double dy, WuWaGoGrid standGrid)
		{
			List<WuWaGoGrid> linkGrids = this.LinkGrids;
			bool flag = (((linkGrids != null) ? new int?(linkGrids.Count) : null) ?? 0) == 0;
			if (flag)
			{
				return null;
			}
			double num = Math.Sqrt(dx * dx + dy * dy);
			if (num < 0.001)
			{
				return null;
			}
			Transform originTransform = WuWaGoModel.Instance.GameData.OriginTransform;
			if (originTransform == null)
			{
				return null;
			}
			double num2 = dx / num;
			double num3 = dy / num;
			ValueTuple<float, float>? valueTuple = this.ProjectGridToScreen(standGrid, originTransform);
			if (valueTuple == null)
			{
				return null;
			}
			WuWaGoGrid result = null;
			double num4 = 0.0;
			foreach (WuWaGoGrid wuWaGoGrid in this.LinkGrids)
			{
				if (wuWaGoGrid.Id != standGrid.Id)
				{
					ValueTuple<float, float>? valueTuple2 = this.ProjectGridToScreen(wuWaGoGrid, originTransform);
					if (valueTuple2 != null)
					{
						float num5 = valueTuple2.Value.Item1 - valueTuple.Value.Item1;
						float num6 = valueTuple2.Value.Item2 - valueTuple.Value.Item2;
						double num7 = Math.Sqrt((double)(num5 * num5 + num6 * num6));
						if (num7 >= 1.0)
						{
							double num8 = ((double)num5 * num2 + (double)num6 * num3) / num7;
							if (num8 > num4)
							{
								num4 = num8;
								result = wuWaGoGrid;
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0602FBE8 RID: 195560 RVA: 0x00B0F8AC File Offset: 0x00B0DAAC
		[return: TupleElementNames(new string[]
		{
			"X",
			"Y"
		})]
		[return: Nullable(0)]
		private ValueTuple<float, float>? ProjectGridToScreen(WuWaGoGrid grid, Transform originTransform)
		{
			APlayerController playerController = Global.PlayerController;
			if (playerController == null)
			{
				return null;
			}
			FVectorDouble fvectorDouble = WuWaGoUtil.GetWorldPositionByCoordinate(originTransform, grid.Coordinate, null).ToUeVector(false);
			FVector2D fvector2D = new FVector2D();
			if (!UGameplayStatics.D_ProjectWorldToScreen(playerController, fvectorDouble, ref fvector2D, false))
			{
				return null;
			}
			return new ValueTuple<float, float>?(new ValueTuple<float, float>(fvector2D.X, fvector2D.Y));
		}

		// Token: 0x0602FBE9 RID: 195561 RVA: 0x00B0F914 File Offset: 0x00B0DB14
		[NullableContext(2)]
		private AActor GetGameplayEntityRootActor(AActor actor)
		{
			if (actor == null || !actor.IsValid())
			{
				return null;
			}
			AActor attachParentActor = actor.GetAttachParentActor();
			if (attachParentActor == null)
			{
				return null;
			}
			attachParentActor = attachParentActor.GetAttachParentActor();
			if (!(attachParentActor is BP_BaseItem_C))
			{
				return null;
			}
			return attachParentActor;
		}

		// Token: 0x0602FBEA RID: 195562 RVA: 0x00B0F952 File Offset: 0x00B0DB52
		private bool IsGameplayEntityActor(AActor actor)
		{
			return this.GetGameplayEntityRootActor(actor) != null;
		}

		// Token: 0x0602FBEB RID: 195563 RVA: 0x00B0F95E File Offset: 0x00B0DB5E
		[NullableContext(2)]
		private void UpdateGridHoverEffect(WuWaGoGrid grid)
		{
			if (grid == this.HoverGrid)
			{
				return;
			}
			this.ClearGridHoverEffect(true);
			if (grid == null)
			{
				return;
			}
			this.HoverGrid = grid;
			this.PlayGridHoverEffect(grid);
		}

		// Token: 0x0602FBEC RID: 195564 RVA: 0x00B0F984 File Offset: 0x00B0DB84
		private UniTask PlayGridHoverEffect(WuWaGoGrid grid)
		{
			MainControlRoleController.<PlayGridHoverEffect>d__58 <PlayGridHoverEffect>d__;
			<PlayGridHoverEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayGridHoverEffect>d__.<>4__this = this;
			<PlayGridHoverEffect>d__.grid = grid;
			<PlayGridHoverEffect>d__.<>1__state = -1;
			<PlayGridHoverEffect>d__.<>t__builder.Start<MainControlRoleController.<PlayGridHoverEffect>d__58>(ref <PlayGridHoverEffect>d__);
			return <PlayGridHoverEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602FBED RID: 195565 RVA: 0x00B0F9D0 File Offset: 0x00B0DBD0
		private void ClearGridHoverEffect(bool immediately)
		{
			this.HoverEffectRequestSeq++;
			if (EffectSystem.Instance.IsValid(this.HoverEffectHandle))
			{
				EffectSystem.Instance.StopEffectById(this.HoverEffectHandle, "WuWaGo.Hover.Clear", immediately, null);
			}
			this.HoverEffectHandle = 0;
			this.HoverGrid = null;
		}

		// Token: 0x0602FBEE RID: 195566 RVA: 0x00B0FA2C File Offset: 0x00B0DC2C
		[NullableContext(2)]
		private void UpdateRedArrowHoverEffect(WuWaGoGrid grid)
		{
			WuWaGoRole canAttackMonsterOnGrid = this.GetCanAttackMonsterOnGrid(grid);
			if (canAttackMonsterOnGrid == this.RedArrowHoverMonster)
			{
				return;
			}
			this.ClearRedArrowEffect(true);
			if (canAttackMonsterOnGrid == null)
			{
				return;
			}
			this.RedArrowHoverMonster = canAttackMonsterOnGrid;
			this.PlayRedArrowEffect(canAttackMonsterOnGrid);
		}

		// Token: 0x0602FBEF RID: 195567 RVA: 0x00B0FA68 File Offset: 0x00B0DC68
		private UniTask PlayRedArrowEffect(WuWaGoRole monster)
		{
			MainControlRoleController.<PlayRedArrowEffect>d__61 <PlayRedArrowEffect>d__;
			<PlayRedArrowEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayRedArrowEffect>d__.<>4__this = this;
			<PlayRedArrowEffect>d__.monster = monster;
			<PlayRedArrowEffect>d__.<>1__state = -1;
			<PlayRedArrowEffect>d__.<>t__builder.Start<MainControlRoleController.<PlayRedArrowEffect>d__61>(ref <PlayRedArrowEffect>d__);
			return <PlayRedArrowEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602FBF0 RID: 195568 RVA: 0x00B0FAB4 File Offset: 0x00B0DCB4
		private void ClearRedArrowEffect(bool immediately)
		{
			this.RedArrowEffectRequestSeq++;
			if (EffectSystem.Instance.IsValid(this.RedArrowEffectHandle))
			{
				EffectSystem.Instance.StopEffectById(this.RedArrowEffectHandle, "WuWaGo.RedArrow.Clear", immediately, null);
			}
			this.RedArrowEffectHandle = 0;
			this.RedArrowHoverMonster = null;
		}

		// Token: 0x0602FBF1 RID: 195569 RVA: 0x00B0FB0F File Offset: 0x00B0DD0F
		private void ClearAllHoverEffects(bool immediately)
		{
			this.ClearGridHoverEffect(immediately);
			this.ClearRedArrowEffect(immediately);
		}

		// Token: 0x0602FBF2 RID: 195570 RVA: 0x00B0FB20 File Offset: 0x00B0DD20
		[NullableContext(2)]
		private WuWaGoRole GetCanAttackMonsterOnGrid(WuWaGoGrid grid)
		{
			if (grid == null)
			{
				return null;
			}
			WuWaGoRole hostileRoleOnGrid = base.GetHostileRoleOnGrid(grid);
			if (hostileRoleOnGrid == null || !hostileRoleOnGrid.IsMonster)
			{
				return null;
			}
			if (!base.CanAttackTarget(hostileRoleOnGrid))
			{
				return null;
			}
			return hostileRoleOnGrid;
		}

		// Token: 0x0602FBF3 RID: 195571 RVA: 0x00B0FB54 File Offset: 0x00B0DD54
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private List<WuWaGoGrid> FindLinkGrid()
		{
			WuWaGoModel instance = WuWaGoModel.Instance;
			WuWaGoGrid gridById = instance.GetGridById(this.Role.StandGridId);
			if (gridById == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.WuWaGo;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "FindLinkGrid：当前所在的Grid不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("StandGridId", this.Role.StandGridId);
				instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			List<WuWaGoGrid> list = new List<WuWaGoGrid>();
			Vector vector = Vector.Create();
			foreach (Vector inB in gridById.LinkedDirections)
			{
				gridById.Coordinate.Addition(inB, vector);
				WuWaGoGrid grid = instance.GetGrid(vector);
				if (grid != null && grid.IsBidirectionalLinkedTo(gridById))
				{
					list.Add(grid);
				}
			}
			return list;
		}

		// Token: 0x0602FBF4 RID: 195572 RVA: 0x00B0FC34 File Offset: 0x00B0DE34
		private UniTask ShowLinkGrids()
		{
			MainControlRoleController.<ShowLinkGrids>d__66 <ShowLinkGrids>d__;
			<ShowLinkGrids>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowLinkGrids>d__.<>4__this = this;
			<ShowLinkGrids>d__.<>1__state = -1;
			<ShowLinkGrids>d__.<>t__builder.Start<MainControlRoleController.<ShowLinkGrids>d__66>(ref <ShowLinkGrids>d__);
			return <ShowLinkGrids>d__.<>t__builder.Task;
		}

		// Token: 0x0602FBF5 RID: 195573 RVA: 0x00B0FC78 File Offset: 0x00B0DE78
		private void HideAllLinkGrid()
		{
			foreach (AActor aactor in this.CanMoveTipsApplique)
			{
				if (aactor.IsValid())
				{
					aactor.SetActorHiddenInGame(true);
				}
			}
		}

		// Token: 0x0602FBF6 RID: 195574 RVA: 0x00B0FCD4 File Offset: 0x00B0DED4
		private Rotator CalcCanMoveTipsAppliqueWorldRotator(WuWaGoGrid grid, WuWaGoGrid curStandGrid, Transform originTransform, Rotator @out)
		{
			WuWaGoUtil.GetWorldPositionByCoordinate(originTransform, grid.Coordinate, this.TipsTargetWorldTemp);
			WuWaGoUtil.GetWorldPositionByCoordinate(originTransform, curStandGrid.Coordinate, this.TipsSelfWorldTemp);
			this.TipsSelfWorldTemp.Subtraction(this.TipsTargetWorldTemp, this.TipsForwardTemp);
			if (grid.GridShape == EGridShape.Horizontal)
			{
				Vector tipsNormalLocalTemp = this.TipsNormalLocalTemp;
				FVectorDouble fvectorDouble = Vector.UpVector;
				tipsNormalLocalTemp.DeepCopy(fvectorDouble);
			}
			else
			{
				IWallFrame wallFrame = grid.WallFrame;
				if (wallFrame == null)
				{
					return WuWaGoUtil.GetWorldRotator(originTransform, grid.GetLinkRotator(), @out);
				}
				this.TipsNormalLocalTemp.Set((double)(-(double)wallFrame.WallNormalX * wallFrame.OwnerSign), (double)(-(double)wallFrame.WallNormalY * wallFrame.OwnerSign), 0.0);
			}
			originTransform.GetRotation().RotateVector(this.TipsNormalLocalTemp, this.TipsNormalWorldTemp);
			double num = this.TipsForwardTemp.DotProduct(this.TipsNormalWorldTemp);
			this.TipsForwardTemp.X -= this.TipsNormalWorldTemp.X * num;
			this.TipsForwardTemp.Y -= this.TipsNormalWorldTemp.Y * num;
			this.TipsForwardTemp.Z -= this.TipsNormalWorldTemp.Z * num;
			if (this.TipsForwardTemp.IsNearlyZero(9.999999747378752E-05))
			{
				return WuWaGoUtil.GetWorldRotator(originTransform, grid.GetLinkRotator(), @out);
			}
			this.TipsForwardTemp.Normalize(9.99999993922529E-09);
			FVector fvector = this.TipsForwardTemp.ToUeVectorOld();
			FVector fvector2 = this.TipsNormalWorldTemp.ToUeVectorOld();
			FRotator frotator = UKismetMathLibrary.MakeRotFromXZ(fvector, fvector2);
			@out.Set(frotator.Pitch, frotator.Yaw, frotator.Roll);
			return @out;
		}

		// Token: 0x0602FBF7 RID: 195575 RVA: 0x00B0FE8C File Offset: 0x00B0E08C
		public override void OnRollbackRestore()
		{
			base.OnRollbackRestore();
			this.SetInputAccepting(false);
			this.ClearAllHoverEffects(true);
			this.HideAllLinkGrid();
			if (this.Role.IsClimbing)
			{
				this.ClimbCapability.EnterClimbIdle();
			}
			else
			{
				this.ClimbCapability.ExitClimbIdle();
			}
			this.LinkGrids = null;
			CustomPromise<UniTaskVoid> waitActionFinishPromise = this.WaitActionFinishPromise;
			if (waitActionFinishPromise != null)
			{
				waitActionFinishPromise.SetResult(default(UniTaskVoid));
			}
			this.WaitActionFinishPromise = null;
		}

		// Token: 0x0602FBF8 RID: 195576 RVA: 0x00B0FF00 File Offset: 0x00B0E100
		[return: Nullable(2)]
		private WuWaGoPullRodEntity FindPullRodEntity(WuWaGoGrid grid)
		{
			WuWaGoPullRodEntity wuWaGoPullRodEntity = WuWaGoModel.Instance.GameData.GetGameplayEntityByGrid(grid, EWuWaGoEntityType.PullRod) as WuWaGoPullRodEntity;
			if (wuWaGoPullRodEntity == null)
			{
				return null;
			}
			return wuWaGoPullRodEntity;
		}

		// Token: 0x0602FBF9 RID: 195577 RVA: 0x00B0FF2A File Offset: 0x00B0E12A
		private bool IsPullRodGrid(WuWaGoGrid grid)
		{
			return WuWaGoModel.Instance.GameData.GetGameplayEntityByGrid(grid, EWuWaGoEntityType.PullRod) is WuWaGoPullRodEntity;
		}

		// Token: 0x04019C28 RID: 105512
		private readonly MoveCapability MoveCapability;

		// Token: 0x04019C29 RID: 105513
		private readonly ClimbCapability ClimbCapability;

		// Token: 0x04019C2A RID: 105514
		[Nullable(2)]
		private CustomPromise<UniTaskVoid> WaitActionFinishPromise;

		// Token: 0x04019C2B RID: 105515
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<WuWaGoGrid> LinkGrids;

		// Token: 0x04019C2C RID: 105516
		private bool IsAcceptingInput;

		// Token: 0x04019C2D RID: 105517
		private bool LastEmittedInteractionAvailable;

		// Token: 0x04019C2E RID: 105518
		[Nullable(2)]
		private ScreenPositionTraceCapability ScreenTrace;

		// Token: 0x04019C2F RID: 105519
		private UKuroHitResult KuroHitResult = new UKuroHitResult();

		// Token: 0x04019C30 RID: 105520
		private readonly Vector ScratchScreenPos = Vector.Create();

		// Token: 0x04019C31 RID: 105521
		private readonly Vector HitActorCoordinate = Vector.Create();

		// Token: 0x04019C32 RID: 105522
		[StaticVariableRuleIgnore]
		private static readonly Rotator WorldRotationTemp = Rotator.Create();

		// Token: 0x04019C33 RID: 105523
		[StaticVariableRuleIgnore]
		private static readonly Rotator LocalRotationTemp = Rotator.Create();

		// Token: 0x04019C34 RID: 105524
		[Nullable(2)]
		private WuWaGoGrid HoverGrid;

		// Token: 0x04019C35 RID: 105525
		private int HoverEffectHandle;

		// Token: 0x04019C36 RID: 105526
		private int HoverEffectRequestSeq;

		// Token: 0x04019C37 RID: 105527
		[Nullable(2)]
		private WuWaGoRole RedArrowHoverMonster;

		// Token: 0x04019C38 RID: 105528
		private int RedArrowEffectHandle;

		// Token: 0x04019C39 RID: 105529
		private int RedArrowEffectRequestSeq;

		// Token: 0x04019C3A RID: 105530
		private readonly List<AActor> CanMoveTipsApplique = new List<AActor>();

		// Token: 0x04019C3B RID: 105531
		private readonly Vector TipsForwardTemp = Vector.Create();

		// Token: 0x04019C3C RID: 105532
		private readonly Vector TipsNormalLocalTemp = Vector.Create();

		// Token: 0x04019C3D RID: 105533
		private readonly Vector TipsNormalWorldTemp = Vector.Create();

		// Token: 0x04019C3E RID: 105534
		private readonly Vector TipsTargetWorldTemp = Vector.Create();

		// Token: 0x04019C3F RID: 105535
		private readonly Vector TipsSelfWorldTemp = Vector.Create();

		// Token: 0x04019C40 RID: 105536
		private static readonly float PullRodMontageBlendOutTime = 0.1f;

		// Token: 0x04019C41 RID: 105537
		[Nullable(2)]
		private UAnimMontage PlayingPullRodMontage;
	}
}
