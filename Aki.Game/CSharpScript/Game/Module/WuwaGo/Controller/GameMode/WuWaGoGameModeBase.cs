using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Data.Gameplay.WuWaGo;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity;
using CSharpScript.Game.Module.WuwaGo.Controller.Role;
using CSharpScript.Game.Module.WuwaGo.Model;
using CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity;
using CSharpScript.Game.Module.WuwaGo.Model.Role;
using CSharpScript.Game.Module.WuwaGo.Movement;
using CSharpScript.Game.Module.WuwaGo.Round;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameMode
{
	// Token: 0x0200477A RID: 18298
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class WuWaGoGameModeBase
	{
		// Token: 0x17007777 RID: 30583
		// (get) Token: 0x0602FD60 RID: 195936 RVA: 0x00B158C3 File Offset: 0x00B13AC3
		public WuWaGoGameData RuntimeGameData
		{
			get
			{
				return this.GameData;
			}
		}

		// Token: 0x17007778 RID: 30584
		// (get) Token: 0x0602FD61 RID: 195937 RVA: 0x00B158CB File Offset: 0x00B13ACB
		public IGameplayEntityLinkService GameplayEntityLinkService
		{
			get
			{
				return this.GameplayEntityLinkServiceInner;
			}
		}

		// Token: 0x17007779 RID: 30585
		// (get) Token: 0x0602FD62 RID: 195938 RVA: 0x00B158D3 File Offset: 0x00B13AD3
		public bool IsCinematicPlaying
		{
			get
			{
				return this.CinematicPlaying;
			}
		}

		// Token: 0x1700777A RID: 30586
		// (get) Token: 0x0602FD63 RID: 195939 RVA: 0x00B158DB File Offset: 0x00B13ADB
		public bool IsDeathSequenceActive
		{
			get
			{
				return this.DeathSequenceActiveInner;
			}
		}

		// Token: 0x0602FD64 RID: 195940 RVA: 0x00B158E4 File Offset: 0x00B13AE4
		[NullableContext(0)]
		public UniTask<bool> Start([Nullable(1)] WuWaGoGameData gameData)
		{
			WuWaGoGameModeBase.<Start>d__30 <Start>d__;
			<Start>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<Start>d__.<>4__this = this;
			<Start>d__.gameData = gameData;
			<Start>d__.<>1__state = -1;
			<Start>d__.<>t__builder.Start<WuWaGoGameModeBase.<Start>d__30>(ref <Start>d__);
			return <Start>d__.<>t__builder.Task;
		}

		// Token: 0x0602FD65 RID: 195941 RVA: 0x00B15930 File Offset: 0x00B13B30
		public bool End()
		{
			WuWaGoTimeStop.CancelAll("GameMode.End");
			bool result;
			try
			{
				UiManager.Instance.CloseView(EUiViewName.WuWaGoView, null);
				this.EnableDisabledEntity();
				this.RemoveEventListeners();
				this.CancelPendingDeathPopupWait();
				this.DeathSequenceActiveInner = false;
				this.ActiveDamageBatchReasons.Clear();
				this.PendingMainRoleDeadId = null;
				this.DestroyAllDeactivatedRoleControllers();
				foreach (KeyValuePair<int, WuWaGoRoleController> keyValuePair in this.AllRoleControllers)
				{
					int num;
					WuWaGoRoleController wuWaGoRoleController;
					keyValuePair.Deconstruct(out num, out wuWaGoRoleController);
					wuWaGoRoleController.Destroy();
				}
				this.AllRoleControllers.Clear();
				foreach (KeyValuePair<int, GameplayEntityControllerBase> keyValuePair2 in this.AllEntityControllers)
				{
					int num;
					GameplayEntityControllerBase gameplayEntityControllerBase;
					keyValuePair2.Deconstruct(out num, out gameplayEntityControllerBase);
					gameplayEntityControllerBase.Destroy();
				}
				this.AllEntityControllers.Clear();
				this.TickListeners.Clear();
				this.RollbackManager.Clear();
				this.RoundManager.Clear();
				this.AllGridControllers.Clear();
				this.DestroyAllRuntimeActors();
				this.RollbackManager = null;
				this.GridMutationService = null;
				this.GameplayEntityLinkServiceInner = null;
				result = this.OnEnd();
			}
			finally
			{
				WuWaGoTimeStop.Clear();
			}
			return result;
		}

		// Token: 0x0602FD66 RID: 195942 RVA: 0x00B15ACC File Offset: 0x00B13CCC
		public void Tick(float delta)
		{
			this.RollbackManager.TickYield();
			if (this.RollbackManager.IsRestoring)
			{
				return;
			}
			this.OnTick(delta);
			this.TickRegisteredListeners(delta);
		}

		// Token: 0x0602FD67 RID: 195943 RVA: 0x00B15AF8 File Offset: 0x00B13CF8
		private UniTask DisableCurrentEntityAsync()
		{
			WuWaGoGameModeBase.<DisableCurrentEntityAsync>d__33 <DisableCurrentEntityAsync>d__;
			<DisableCurrentEntityAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DisableCurrentEntityAsync>d__.<>4__this = this;
			<DisableCurrentEntityAsync>d__.<>1__state = -1;
			<DisableCurrentEntityAsync>d__.<>t__builder.Start<WuWaGoGameModeBase.<DisableCurrentEntityAsync>d__33>(ref <DisableCurrentEntityAsync>d__);
			return <DisableCurrentEntityAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FD68 RID: 195944 RVA: 0x00B15B3B File Offset: 0x00B13D3B
		private void EnableDisabledEntity()
		{
			if (this.DisabledEntity != null)
			{
				this.DisabledEntity.Enable(this.DisableId, "WuWaGo");
				this.DisabledEntity = null;
				this.DisableId = 0;
			}
		}

		// Token: 0x0602FD69 RID: 195945
		protected abstract bool OnStart();

		// Token: 0x0602FD6A RID: 195946 RVA: 0x00B15B6A File Offset: 0x00B13D6A
		protected virtual void OnTick(float delta)
		{
		}

		// Token: 0x0602FD6B RID: 195947
		protected abstract bool OnEnd();

		// Token: 0x0602FD6C RID: 195948 RVA: 0x00B15B6C File Offset: 0x00B13D6C
		private void AddEventListeners()
		{
			EventSystem.Instance.Add<int>(EEventName.OnWuWaGoRoleDead, new Action<int>(this.OnRoleDead));
			EventSystem.Instance.Add<bool, string>(EEventName.OnWuWaGoDamageBatchStateChanged, new Action<bool, string>(this.OnDamageBatchStateChanged));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnAnyViewClose));
			EventSystem.Instance.Add<AActor, int>(EEventName.OnAnimNotifyMaterialControllerHandleAdded, new Action<AActor, int>(this.OnAnimNotifyMaterialHandleAdded));
		}

		// Token: 0x0602FD6D RID: 195949 RVA: 0x00B15BE8 File Offset: 0x00B13DE8
		private void RemoveEventListeners()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnWuWaGoRoleDead, new Action<int>(this.OnRoleDead));
			EventSystem.Instance.Remove<bool, string>(EEventName.OnWuWaGoDamageBatchStateChanged, new Action<bool, string>(this.OnDamageBatchStateChanged));
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnAnyViewClose));
			EventSystem.Instance.Remove<AActor, int>(EEventName.OnAnimNotifyMaterialControllerHandleAdded, new Action<AActor, int>(this.OnAnimNotifyMaterialHandleAdded));
		}

		// Token: 0x0602FD6E RID: 195950 RVA: 0x00B15C64 File Offset: 0x00B13E64
		private void OnAnimNotifyMaterialHandleAdded(AActor actor, int handle)
		{
			foreach (KeyValuePair<int, WuWaGoRoleController> keyValuePair in this.AllRoleControllers)
			{
				int num;
				WuWaGoRoleController wuWaGoRoleController;
				keyValuePair.Deconstruct(out num, out wuWaGoRoleController);
				WuWaGoRoleController wuWaGoRoleController2 = wuWaGoRoleController;
				if (wuWaGoRoleController2.BaseRole.GetActorAsObject() == actor)
				{
					wuWaGoRoleController2.BaseRole.AddMaterialHandle(handle);
					break;
				}
			}
		}

		// Token: 0x0602FD6F RID: 195951 RVA: 0x00B15CDC File Offset: 0x00B13EDC
		private void OnRoleDead(int roleId)
		{
			WuWaGoRoleController wuWaGoRoleController;
			if (!this.AllRoleControllers.TryGetValue(roleId, out wuWaGoRoleController))
			{
				return;
			}
			if (this.CinematicPlaying && !wuWaGoRoleController.BaseRole.IsMonster)
			{
				return;
			}
			if (wuWaGoRoleController.BaseRole.IsMonster)
			{
				if (this.DeactivatedDeadRoleControllers.Contains(wuWaGoRoleController))
				{
					return;
				}
				this.DeactivateDeadRoleController(wuWaGoRoleController);
				this.DeactivatedDeadRoleControllers.Add(wuWaGoRoleController);
				return;
			}
			else
			{
				if (this.IsDamageBatchActive())
				{
					this.PendingMainRoleDeadId = new int?(roleId);
					return;
				}
				this.HandleMainRoleDead(wuWaGoRoleController.BaseRole as WuWaGoMainControlRole);
				return;
			}
		}

		// Token: 0x0602FD70 RID: 195952 RVA: 0x00B15D68 File Offset: 0x00B13F68
		private void OnDamageBatchStateChanged(bool isActive, string reason)
		{
			if (isActive)
			{
				int num;
				this.ActiveDamageBatchReasons[reason] = (this.ActiveDamageBatchReasons.TryGetValue(reason, out num) ? (num + 1) : 1);
				return;
			}
			int num2;
			if (!this.ActiveDamageBatchReasons.TryGetValue(reason, out num2))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.WuWaGo;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "收到未开始的批处理伤害机关结束事件";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reason", reason);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (num2 <= 1)
			{
				this.ActiveDamageBatchReasons.Remove(reason);
			}
			else
			{
				this.ActiveDamageBatchReasons[reason] = num2 - 1;
			}
			if (!this.IsDamageBatchActive())
			{
				this.FlushPendingMainRoleDead();
			}
		}

		// Token: 0x0602FD71 RID: 195953 RVA: 0x00B15E06 File Offset: 0x00B14006
		public bool IsDamageBatchActive()
		{
			return this.ActiveDamageBatchReasons.Count > 0;
		}

		// Token: 0x0602FD72 RID: 195954 RVA: 0x00B15E18 File Offset: 0x00B14018
		private void FlushPendingMainRoleDead()
		{
			int? pendingMainRoleDeadId = this.PendingMainRoleDeadId;
			if (pendingMainRoleDeadId == null)
			{
				return;
			}
			this.PendingMainRoleDeadId = null;
			WuWaGoRoleController wuWaGoRoleController;
			if (!this.AllRoleControllers.TryGetValue(pendingMainRoleDeadId.Value, out wuWaGoRoleController) || wuWaGoRoleController.BaseRole.IsMonster || !wuWaGoRoleController.BaseRole.IsDead)
			{
				return;
			}
			this.HandleMainRoleDead(wuWaGoRoleController.BaseRole as WuWaGoMainControlRole);
		}

		// Token: 0x0602FD73 RID: 195955 RVA: 0x00B15E84 File Offset: 0x00B14084
		private void HandleMainRoleDead(WuWaGoMainControlRole mainRole)
		{
			if (this.DeathSequenceActiveInner)
			{
				return;
			}
			mainRole.DeathCount++;
			this.RefreshPlayTipAvailable();
			this.RollbackManager.FlushPendingPlayerActionTracking();
			this.DeathSequenceActiveInner = true;
			this.RunDeathSequenceWithResetAsync().Forget();
		}

		// Token: 0x0602FD74 RID: 195956 RVA: 0x00B15EC0 File Offset: 0x00B140C0
		private UniTask RunDeathSequenceWithResetAsync()
		{
			WuWaGoGameModeBase.<RunDeathSequenceWithResetAsync>d__46 <RunDeathSequenceWithResetAsync>d__;
			<RunDeathSequenceWithResetAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunDeathSequenceWithResetAsync>d__.<>4__this = this;
			<RunDeathSequenceWithResetAsync>d__.<>1__state = -1;
			<RunDeathSequenceWithResetAsync>d__.<>t__builder.Start<WuWaGoGameModeBase.<RunDeathSequenceWithResetAsync>d__46>(ref <RunDeathSequenceWithResetAsync>d__);
			return <RunDeathSequenceWithResetAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FD75 RID: 195957 RVA: 0x00B15F04 File Offset: 0x00B14104
		private UniTask RunDeathSequenceAsync()
		{
			WuWaGoGameModeBase.<RunDeathSequenceAsync>d__47 <RunDeathSequenceAsync>d__;
			<RunDeathSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunDeathSequenceAsync>d__.<>4__this = this;
			<RunDeathSequenceAsync>d__.<>1__state = -1;
			<RunDeathSequenceAsync>d__.<>t__builder.Start<WuWaGoGameModeBase.<RunDeathSequenceAsync>d__47>(ref <RunDeathSequenceAsync>d__);
			return <RunDeathSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FD76 RID: 195958 RVA: 0x00B15F47 File Offset: 0x00B14147
		private void OnAnyViewClose(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.WuWaGoPopupView)
			{
				return;
			}
			this.CancelPendingDeathPopupWait();
		}

		// Token: 0x0602FD77 RID: 195959 RVA: 0x00B15F60 File Offset: 0x00B14160
		private void CancelPendingDeathPopupWait()
		{
			if (this.DeathPopupClosedPromise != null)
			{
				this.DeathPopupClosedPromise.SetResult(default(UniTaskVoid));
				this.DeathPopupClosedPromise = null;
			}
		}

		// Token: 0x0602FD78 RID: 195960 RVA: 0x00B15F90 File Offset: 0x00B14190
		private void DeactivateDeadRoleController(WuWaGoRoleController controller)
		{
			this.RoundManager.RemoveController(controller);
			this.TickListeners.Remove(controller);
			controller.BaseRole.SetStandGrid(null, null);
			controller.BaseRole.SetHiddenInGame(true);
		}

		// Token: 0x0602FD79 RID: 195961 RVA: 0x00B15FC4 File Offset: 0x00B141C4
		private void DestroyAllDeactivatedRoleControllers()
		{
			foreach (WuWaGoRoleController controller in this.DeactivatedDeadRoleControllers)
			{
				this.DestroyDeactivatedRoleController(controller);
			}
			this.DeactivatedDeadRoleControllers.Clear();
		}

		// Token: 0x0602FD7A RID: 195962 RVA: 0x00B16024 File Offset: 0x00B14224
		private void DestroyDeactivatedRoleController(WuWaGoRoleController controller)
		{
			WuWaGoRole baseRole = controller.BaseRole;
			this.AllRoleControllers.Remove(baseRole.Id);
			this.TickListeners.Remove(controller);
			this.GameData.RemoveRole(baseRole);
			controller.Destroy();
		}

		// Token: 0x0602FD7B RID: 195963 RVA: 0x00B1606C File Offset: 0x00B1426C
		public void RestoreDeactivatedRoleControllersFromRollback()
		{
			foreach (WuWaGoRoleController wuWaGoRoleController in this.DeactivatedDeadRoleControllers)
			{
				if (!wuWaGoRoleController.BaseRole.IsDead)
				{
					ERoundStep roleStep = this.GetRoleStep(wuWaGoRoleController.BaseRole.Type);
					this.RoundManager.RegisterUnit(roleStep, wuWaGoRoleController);
					this.TryRegisterTick(wuWaGoRoleController);
					wuWaGoRoleController.BaseRole.SetHiddenInGame(false);
					this.DeactivatedDeadRoleControllers.Remove(wuWaGoRoleController);
				}
			}
			foreach (KeyValuePair<int, WuWaGoRoleController> keyValuePair in this.AllRoleControllers)
			{
				int num;
				WuWaGoRoleController wuWaGoRoleController2;
				keyValuePair.Deconstruct(out num, out wuWaGoRoleController2);
				WuWaGoRoleController wuWaGoRoleController3 = wuWaGoRoleController2;
				if (wuWaGoRoleController3.BaseRole.IsMonster && !this.DeactivatedDeadRoleControllers.Contains(wuWaGoRoleController3) && wuWaGoRoleController3.BaseRole.IsDead)
				{
					this.DeactivateDeadRoleController(wuWaGoRoleController3);
					this.DeactivatedDeadRoleControllers.Add(wuWaGoRoleController3);
				}
			}
		}

		// Token: 0x0602FD7C RID: 195964 RVA: 0x00B16190 File Offset: 0x00B14390
		public void NotifyAllControllersRollbackRestore()
		{
			foreach (KeyValuePair<int, WuWaGoRoleController> keyValuePair in this.AllRoleControllers)
			{
				int num;
				WuWaGoRoleController wuWaGoRoleController;
				keyValuePair.Deconstruct(out num, out wuWaGoRoleController);
				wuWaGoRoleController.OnRollbackRestore();
			}
			foreach (KeyValuePair<int, GameplayEntityControllerBase> keyValuePair2 in this.AllEntityControllers)
			{
				int num;
				GameplayEntityControllerBase gameplayEntityControllerBase;
				keyValuePair2.Deconstruct(out num, out gameplayEntityControllerBase);
				gameplayEntityControllerBase.OnRollbackRestore();
			}
		}

		// Token: 0x0602FD7D RID: 195965 RVA: 0x00B1623C File Offset: 0x00B1443C
		public void NotifyGameplayEntityLinkServiceRollbackRestore()
		{
			this.GameplayEntityLinkServiceInner.OnRollbackRestore();
		}

		// Token: 0x0602FD7E RID: 195966 RVA: 0x00B1624C File Offset: 0x00B1444C
		public UniTask PlayPlayTipCinematicAsync()
		{
			WuWaGoGameModeBase.<PlayPlayTipCinematicAsync>d__56 <PlayPlayTipCinematicAsync>d__;
			<PlayPlayTipCinematicAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayPlayTipCinematicAsync>d__.<>4__this = this;
			<PlayPlayTipCinematicAsync>d__.<>1__state = -1;
			<PlayPlayTipCinematicAsync>d__.<>t__builder.Start<WuWaGoGameModeBase.<PlayPlayTipCinematicAsync>d__56>(ref <PlayPlayTipCinematicAsync>d__);
			return <PlayPlayTipCinematicAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FD7F RID: 195967 RVA: 0x00B1628F File Offset: 0x00B1448F
		public void RequestInterruptPlayTipCinematic()
		{
			if (!this.CinematicPlaying)
			{
				return;
			}
			this.InterruptCinematicRequested = true;
		}

		// Token: 0x0602FD80 RID: 195968 RVA: 0x00B162A4 File Offset: 0x00B144A4
		public UniTask RollbackToLastStepAsync()
		{
			WuWaGoGameModeBase.<RollbackToLastStepAsync>d__58 <RollbackToLastStepAsync>d__;
			<RollbackToLastStepAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RollbackToLastStepAsync>d__.<>4__this = this;
			<RollbackToLastStepAsync>d__.<>1__state = -1;
			<RollbackToLastStepAsync>d__.<>t__builder.Start<WuWaGoGameModeBase.<RollbackToLastStepAsync>d__58>(ref <RollbackToLastStepAsync>d__);
			return <RollbackToLastStepAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FD81 RID: 195969 RVA: 0x00B162E8 File Offset: 0x00B144E8
		public UniTask RollbackToSavePointAsync()
		{
			WuWaGoGameModeBase.<RollbackToSavePointAsync>d__59 <RollbackToSavePointAsync>d__;
			<RollbackToSavePointAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RollbackToSavePointAsync>d__.<>4__this = this;
			<RollbackToSavePointAsync>d__.<>1__state = -1;
			<RollbackToSavePointAsync>d__.<>t__builder.Start<WuWaGoGameModeBase.<RollbackToSavePointAsync>d__59>(ref <RollbackToSavePointAsync>d__);
			return <RollbackToSavePointAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FD82 RID: 195970 RVA: 0x00B1632C File Offset: 0x00B1452C
		public void NotifyArrivedSavePoint(WuWaGoGrid grid)
		{
			if (this.CinematicPlaying)
			{
				return;
			}
			WuWaGoGameplayEntityBase gameplayEntityByPbDataId = this.GameData.GetGameplayEntityByPbDataId(grid.EntityPbDataId);
			this.CurrentHintSource = (gameplayEntityByPbDataId as WuWaGoTraversalGridEntity);
			if (grid.EntityType.GetValueOrDefault() == EWuWaGoEntityType.SaveGrid)
			{
				this.RollbackManager.ResetForSavePoint();
				this.DestroyAllDeactivatedRoleControllers();
			}
			this.RefreshPlayTipAvailable();
		}

		// Token: 0x0602FD83 RID: 195971 RVA: 0x00B16388 File Offset: 0x00B14588
		public bool IsRollbackAvailable()
		{
			return !this.IsDamageBatchActive() && this.RollbackManager.IsAvailable;
		}

		// Token: 0x0602FD84 RID: 195972 RVA: 0x00B1639F File Offset: 0x00B1459F
		public bool CanUsePlayTip()
		{
			if (!this.IsCinematicPlaying && !this.IsDamageBatchActive() && !this.IsDeathSequenceActive && !this.IsRollbackRestoring)
			{
				WuWaGoMainControlRole mainControlRole = this.GameData.MainControlRole;
				return mainControlRole != null && mainControlRole.IsAcceptingInput;
			}
			return false;
		}

		// Token: 0x1700777B RID: 30587
		// (get) Token: 0x0602FD85 RID: 195973 RVA: 0x00B163D9 File Offset: 0x00B145D9
		public bool IsRollbackRestoring
		{
			get
			{
				return this.RollbackManager.IsRestoring;
			}
		}

		// Token: 0x0602FD86 RID: 195974 RVA: 0x00B163E6 File Offset: 0x00B145E6
		public bool CanExecuteGameplayEntityAction()
		{
			return !this.IsDeathSequenceActive && !this.IsRollbackRestoring && !this.RoundManager.ShouldAbortCurrentRound();
		}

		// Token: 0x0602FD87 RID: 195975 RVA: 0x00B16408 File Offset: 0x00B14608
		public void OnRollbackTriggered()
		{
			WuWaGoTimeStop.CancelAll("WuWaGo.Rollback");
			this.RoundManager.ResetForRollback();
		}

		// Token: 0x0602FD88 RID: 195976 RVA: 0x00B1641F File Offset: 0x00B1461F
		public void ResetPlayerActionCaptures()
		{
			this.RollbackManager.ResetPlayerActionCaptures();
		}

		// Token: 0x0602FD89 RID: 195977 RVA: 0x00B1642C File Offset: 0x00B1462C
		public void FlushPendingPlayerActionTracking()
		{
			this.RollbackManager.FlushPendingPlayerActionTracking();
		}

		// Token: 0x0602FD8A RID: 195978 RVA: 0x00B16439 File Offset: 0x00B14639
		public void BeginPlayerActionTracking()
		{
			this.RollbackManager.BeginPlayerActionTracking();
		}

		// Token: 0x0602FD8B RID: 195979 RVA: 0x00B16446 File Offset: 0x00B14646
		public void NotifyMainControlInputAcceptingChanged(bool accept)
		{
			this.RollbackManager.SetAcceptingInput(accept);
			EventSystem.Instance.Emit<bool>(EEventName.OnWuWaGoMainControlInputAcceptingChanged, accept);
		}

		// Token: 0x0602FD8C RID: 195980 RVA: 0x00B16465 File Offset: 0x00B14665
		public void SetMainControlInputAccepting(bool accept)
		{
			MainControlRoleController mainControlRoleController = this.GetMainControlRoleController();
			if (mainControlRoleController == null)
			{
				return;
			}
			mainControlRoleController.SetInputAcceptingFromExternal(accept);
		}

		// Token: 0x0602FD8D RID: 195981 RVA: 0x00B16478 File Offset: 0x00B14678
		private void RefreshPlayTipAvailable()
		{
			bool flag = this.ComputePlayTipAvailable();
			if (flag == this.LastEmittedPlayTipAvailable)
			{
				return;
			}
			this.LastEmittedPlayTipAvailable = flag;
			EventSystem.Instance.Emit<bool>(EEventName.OnWuWaGoPlayTipAvailable, flag);
		}

		// Token: 0x0602FD8E RID: 195982 RVA: 0x00B164B0 File Offset: 0x00B146B0
		private bool ComputePlayTipAvailable()
		{
			if (this.CinematicPlaying)
			{
				return false;
			}
			WuWaGoMainControlRole mainControlRole = this.GameData.MainControlRole;
			int num = (mainControlRole != null) ? mainControlRole.DeathCount : 0;
			BP_WuWaGo_C setting = WuWaGoGlobal.Setting;
			int num2 = (setting != null) ? setting.TipButtonShowDeadCount : 0;
			if (num < num2)
			{
				return false;
			}
			WuWaGoTraversalGridEntity currentHintSource = this.CurrentHintSource;
			IReadOnlyList<IWuWaGoHintStepBase> readOnlyList = (currentHintSource != null) ? currentHintSource.HintSteps : null;
			return readOnlyList != null && readOnlyList.Count > 0;
		}

		// Token: 0x0602FD8F RID: 195983 RVA: 0x00B16516 File Offset: 0x00B14716
		private void SetCinematicPlaying(bool playing)
		{
			if (this.CinematicPlaying == playing)
			{
				return;
			}
			this.CinematicPlaying = playing;
			if (playing)
			{
				this.InterruptCinematicRequested = false;
			}
			EventSystem.Instance.Emit<bool>(EEventName.OnWuWaGoCinematicPlayingChanged, playing);
			this.RefreshPlayTipAvailable();
		}

		// Token: 0x0602FD90 RID: 195984 RVA: 0x00B1654C File Offset: 0x00B1474C
		private void InitCurrentHintSource()
		{
			foreach (WuWaGoGameplayEntityBase wuWaGoGameplayEntityBase in this.GameData.GetGameplayEntitiesByType(EWuWaGoEntityType.StartGrid))
			{
				WuWaGoTraversalGridEntity wuWaGoTraversalGridEntity = wuWaGoGameplayEntityBase as WuWaGoTraversalGridEntity;
				if (wuWaGoTraversalGridEntity != null)
				{
					this.CurrentHintSource = wuWaGoTraversalGridEntity;
					this.RollbackManager.CaptureSavePointSnapshot();
					break;
				}
			}
		}

		// Token: 0x0602FD91 RID: 195985 RVA: 0x00B165B8 File Offset: 0x00B147B8
		[NullableContext(2)]
		private MainControlRoleController GetMainControlRoleController()
		{
			foreach (KeyValuePair<int, WuWaGoRoleController> keyValuePair in this.AllRoleControllers)
			{
				int num;
				WuWaGoRoleController wuWaGoRoleController;
				keyValuePair.Deconstruct(out num, out wuWaGoRoleController);
				MainControlRoleController mainControlRoleController = wuWaGoRoleController as MainControlRoleController;
				if (mainControlRoleController != null)
				{
					return mainControlRoleController;
				}
			}
			return null;
		}

		// Token: 0x0602FD92 RID: 195986 RVA: 0x00B16628 File Offset: 0x00B14828
		[NullableContext(2)]
		public GameplayEntityControllerBase GetEntityControllerByPbDataId(int pbDataId)
		{
			WuWaGoGameplayEntityBase gameplayEntityByPbDataId = this.GameData.GetGameplayEntityByPbDataId(pbDataId);
			if (gameplayEntityByPbDataId == null)
			{
				return null;
			}
			return this.AllEntityControllers.GetValueOrDefault(gameplayEntityByPbDataId.Id);
		}

		// Token: 0x0602FD93 RID: 195987 RVA: 0x00B16658 File Offset: 0x00B14858
		[NullableContext(2)]
		public WuWaGoRoleController GetRoleController(int roleId)
		{
			return this.AllRoleControllers.GetValueOrDefault(roleId);
		}

		// Token: 0x0602FD94 RID: 195988 RVA: 0x00B16666 File Offset: 0x00B14866
		[NullableContext(2)]
		public WuWaGoGridController GetGridControllerById(int gridId)
		{
			return this.AllGridControllers.GetValueOrDefault(gridId);
		}

		// Token: 0x0602FD95 RID: 195989 RVA: 0x00B16674 File Offset: 0x00B14874
		public void NotifyMoveMonsterActed()
		{
			this.RoundManager.NotifyMoveMonsterActed();
		}

		// Token: 0x0602FD96 RID: 195990 RVA: 0x00B16684 File Offset: 0x00B14884
		public UniTask ExecuteImmediateMovableFloorBatch(IReadOnlyList<int> pbDataIds, string batchSource)
		{
			WuWaGoGameModeBase.<ExecuteImmediateMovableFloorBatch>d__81 <ExecuteImmediateMovableFloorBatch>d__;
			<ExecuteImmediateMovableFloorBatch>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteImmediateMovableFloorBatch>d__.<>4__this = this;
			<ExecuteImmediateMovableFloorBatch>d__.pbDataIds = pbDataIds;
			<ExecuteImmediateMovableFloorBatch>d__.batchSource = batchSource;
			<ExecuteImmediateMovableFloorBatch>d__.<>1__state = -1;
			<ExecuteImmediateMovableFloorBatch>d__.<>t__builder.Start<WuWaGoGameModeBase.<ExecuteImmediateMovableFloorBatch>d__81>(ref <ExecuteImmediateMovableFloorBatch>d__);
			return <ExecuteImmediateMovableFloorBatch>d__.<>t__builder.Task;
		}

		// Token: 0x0602FD97 RID: 195991 RVA: 0x00B166D8 File Offset: 0x00B148D8
		public UniTask ExecutePostMovableFloorEnemyAttackJudgement(IWuWaGoMovableFloorBatchResult result)
		{
			WuWaGoGameModeBase.<ExecutePostMovableFloorEnemyAttackJudgement>d__82 <ExecutePostMovableFloorEnemyAttackJudgement>d__;
			<ExecutePostMovableFloorEnemyAttackJudgement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecutePostMovableFloorEnemyAttackJudgement>d__.<>4__this = this;
			<ExecutePostMovableFloorEnemyAttackJudgement>d__.result = result;
			<ExecutePostMovableFloorEnemyAttackJudgement>d__.<>1__state = -1;
			<ExecutePostMovableFloorEnemyAttackJudgement>d__.<>t__builder.Start<WuWaGoGameModeBase.<ExecutePostMovableFloorEnemyAttackJudgement>d__82>(ref <ExecutePostMovableFloorEnemyAttackJudgement>d__);
			return <ExecutePostMovableFloorEnemyAttackJudgement>d__.<>t__builder.Task;
		}

		// Token: 0x0602FD98 RID: 195992 RVA: 0x00B16724 File Offset: 0x00B14924
		private bool ShouldStopPostMovableFloorEnemyAttackJudgement()
		{
			WuWaGoMainControlRole mainControlRole = this.GameData.MainControlRole;
			if (mainControlRole == null || mainControlRole.IsDead)
			{
				return true;
			}
			WuWaGoGrid gridById = this.GameData.GetGridById(mainControlRole.StandGridId);
			return gridById != null && gridById.IsEndPoint;
		}

		// Token: 0x0602FD99 RID: 195993 RVA: 0x00B16768 File Offset: 0x00B14968
		private void CreateAllRoleControllers(WuWaGoGameData gameData)
		{
			foreach (WuWaGoRole wuWaGoRole in gameData.AllRoles)
			{
				WuWaGoRoleController wuWaGoRoleController = this.CreateRoleController(wuWaGoRole);
				if (wuWaGoRoleController != null)
				{
					wuWaGoRoleController.Create();
					this.AllRoleControllers.Add(wuWaGoRole.Id, wuWaGoRoleController);
					ERoundStep roleStep = this.GetRoleStep(wuWaGoRole.Type);
					this.RoundManager.RegisterUnit(roleStep, wuWaGoRoleController);
					this.TryRegisterTick(wuWaGoRoleController);
				}
			}
		}

		// Token: 0x0602FD9A RID: 195994 RVA: 0x00B167FC File Offset: 0x00B149FC
		[return: Nullable(2)]
		private WuWaGoRoleController CreateRoleController(WuWaGoRole role)
		{
			switch (role.Type)
			{
			case EWuWaGoRoleType.AircraftSoldiers:
				return new MainControlRoleController(role, this.GameData, this);
			case EWuWaGoRoleType.HeatFusionEnemy:
			{
				WuWaGoStaticMonster wuWaGoStaticMonster = role as WuWaGoStaticMonster;
				if (wuWaGoStaticMonster != null)
				{
					return new StaticMonsterController(wuWaGoStaticMonster, this.GameData, this);
				}
				return null;
			}
			case EWuWaGoRoleType.DiffractionEnemy:
			{
				WuWaGoMoveMonster wuWaGoMoveMonster = role as WuWaGoMoveMonster;
				if (wuWaGoMoveMonster != null)
				{
					return new MoveMonsterController(wuWaGoMoveMonster, this.GameData, this);
				}
				return null;
			}
			default:
				return null;
			}
		}

		// Token: 0x0602FD9B RID: 195995 RVA: 0x00B16868 File Offset: 0x00B14A68
		private void CreateAllEntityControllers(WuWaGoGameData gameData)
		{
			foreach (KeyValuePair<int, WuWaGoGameplayEntityBase> keyValuePair in gameData.AllGameplayEntities)
			{
				int num;
				WuWaGoGameplayEntityBase wuWaGoGameplayEntityBase;
				keyValuePair.Deconstruct(out num, out wuWaGoGameplayEntityBase);
				WuWaGoGameplayEntityBase wuWaGoGameplayEntityBase2 = wuWaGoGameplayEntityBase;
				GameplayEntityControllerBase gameplayEntityControllerBase = this.CreateEntityController(wuWaGoGameplayEntityBase2);
				if (gameplayEntityControllerBase != null && gameplayEntityControllerBase.Create())
				{
					this.AllEntityControllers.Add(wuWaGoGameplayEntityBase2.Id, gameplayEntityControllerBase);
					ERoundStep? entityStep = this.GetEntityStep(wuWaGoGameplayEntityBase2.EntityType);
					if (entityStep != null)
					{
						this.RoundManager.RegisterUnit(entityStep.Value, gameplayEntityControllerBase);
					}
					this.TryRegisterTick(gameplayEntityControllerBase);
				}
			}
		}

		// Token: 0x0602FD9C RID: 195996 RVA: 0x00B16920 File Offset: 0x00B14B20
		[return: Nullable(2)]
		private GameplayEntityControllerBase CreateEntityController(WuWaGoGameplayEntityBase entity)
		{
			switch (entity.EntityType)
			{
			case EWuWaGoEntityType.MovableFloor:
				return new MovableFloorController(entity, this.GameData, this);
			case EWuWaGoEntityType.PullRod:
				return new PullRodController(entity, this.GameData, this);
			case EWuWaGoEntityType.PressureTrigger:
				return new PressureTriggerController(entity, this.GameData, this);
			case EWuWaGoEntityType.Gear:
				return new GearTrapController(entity, this.GameData, this);
			case EWuWaGoEntityType.SpikeTrap:
				return new SpikeTrapController(entity, this.GameData, this);
			case EWuWaGoEntityType.BowTrap:
				return new BowTrapController(entity, this.GameData, this);
			case EWuWaGoEntityType.SaveGrid:
			case EWuWaGoEntityType.EndGrid:
			case EWuWaGoEntityType.StartGrid:
				return new TraversalGridController(entity, this.GameData, this);
			default:
				return null;
			}
		}

		// Token: 0x0602FD9D RID: 195997 RVA: 0x00B169C8 File Offset: 0x00B14BC8
		private void CreateAllGridControllers(WuWaGoGameData gameData)
		{
			this.AllGridControllers.Clear();
			foreach (KeyValuePair<string, WuWaGoGrid> keyValuePair in gameData.Girds)
			{
				string text;
				WuWaGoGrid wuWaGoGrid;
				keyValuePair.Deconstruct(out text, out wuWaGoGrid);
				WuWaGoGrid wuWaGoGrid2 = wuWaGoGrid;
				this.AllGridControllers.Add(wuWaGoGrid2.Id, new WuWaGoGridController(wuWaGoGrid2));
			}
		}

		// Token: 0x0602FD9E RID: 195998 RVA: 0x00B16A44 File Offset: 0x00B14C44
		private void TryRegisterTick(IExecutableUnit controller)
		{
			FieldInfo field = controller.GetType().GetField("EnableTick", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			if ((((field != null) ? field.GetValue(null) : null) as bool?).GetValueOrDefault())
			{
				this.TickListeners.Add(controller);
			}
		}

		// Token: 0x0602FD9F RID: 195999 RVA: 0x00B16A94 File Offset: 0x00B14C94
		private void TickRegisteredListeners(float delta)
		{
			foreach (IExecutableUnit executableUnit in this.TickListeners)
			{
				executableUnit.OnTick(delta);
			}
		}

		// Token: 0x0602FDA0 RID: 196000 RVA: 0x00B16AE8 File Offset: 0x00B14CE8
		private ERoundStep GetRoleStep(EWuWaGoRoleType roleType)
		{
			if (roleType == EWuWaGoRoleType.AircraftSoldiers)
			{
				return ERoundStep.PlayerAction;
			}
			if (roleType - EWuWaGoRoleType.HeatFusionEnemy > 1)
			{
				return ERoundStep.MonsterAction;
			}
			return ERoundStep.MonsterAction;
		}

		// Token: 0x0602FDA1 RID: 196001 RVA: 0x00B16AFC File Offset: 0x00B14CFC
		private ERoundStep? GetEntityStep(EWuWaGoEntityType entityType)
		{
			switch (entityType)
			{
			case EWuWaGoEntityType.MovableFloor:
				return new ERoundStep?(ERoundStep.MovableFloor);
			case EWuWaGoEntityType.PressureTrigger:
				return new ERoundStep?(ERoundStep.PressureTrigger);
			case EWuWaGoEntityType.Gear:
				return new ERoundStep?(ERoundStep.GearTrap);
			case EWuWaGoEntityType.SpikeTrap:
				return new ERoundStep?(ERoundStep.SpikeTrap);
			case EWuWaGoEntityType.BowTrap:
				return new ERoundStep?(ERoundStep.BowTrap);
			}
			return null;
		}

		// Token: 0x0602FDA2 RID: 196002 RVA: 0x00B16B58 File Offset: 0x00B14D58
		private UniTask CreateAllAppliques(WuWaGoGameData gameData)
		{
			WuWaGoGameModeBase.<CreateAllAppliques>d__93 <CreateAllAppliques>d__;
			<CreateAllAppliques>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateAllAppliques>d__.gameData = gameData;
			<CreateAllAppliques>d__.<>1__state = -1;
			<CreateAllAppliques>d__.<>t__builder.Start<WuWaGoGameModeBase.<CreateAllAppliques>d__93>(ref <CreateAllAppliques>d__);
			return <CreateAllAppliques>d__.<>t__builder.Task;
		}

		// Token: 0x0602FDA3 RID: 196003 RVA: 0x00B16B9C File Offset: 0x00B14D9C
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private static UniTask<UStaticMesh> LoadPlaneMesh()
		{
			WuWaGoGameModeBase.<LoadPlaneMesh>d__94 <LoadPlaneMesh>d__;
			<LoadPlaneMesh>d__.<>t__builder = AsyncUniTaskMethodBuilder<UStaticMesh>.Create();
			<LoadPlaneMesh>d__.<>1__state = -1;
			<LoadPlaneMesh>d__.<>t__builder.Start<WuWaGoGameModeBase.<LoadPlaneMesh>d__94>(ref <LoadPlaneMesh>d__);
			return <LoadPlaneMesh>d__.<>t__builder.Task;
		}

		// Token: 0x0602FDA4 RID: 196004 RVA: 0x00B16BD8 File Offset: 0x00B14DD8
		private UniTask CreateAllRoles(WuWaGoGameData gameData)
		{
			WuWaGoGameModeBase.<CreateAllRoles>d__95 <CreateAllRoles>d__;
			<CreateAllRoles>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateAllRoles>d__.gameData = gameData;
			<CreateAllRoles>d__.<>1__state = -1;
			<CreateAllRoles>d__.<>t__builder.Start<WuWaGoGameModeBase.<CreateAllRoles>d__95>(ref <CreateAllRoles>d__);
			return <CreateAllRoles>d__.<>t__builder.Task;
		}

		// Token: 0x0602FDA5 RID: 196005 RVA: 0x00B16C1C File Offset: 0x00B14E1C
		private UniTask PreloadBpClass()
		{
			WuWaGoGameModeBase.<PreloadBpClass>d__96 <PreloadBpClass>d__;
			<PreloadBpClass>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadBpClass>d__.<>1__state = -1;
			<PreloadBpClass>d__.<>t__builder.Start<WuWaGoGameModeBase.<PreloadBpClass>d__96>(ref <PreloadBpClass>d__);
			return <PreloadBpClass>d__.<>t__builder.Task;
		}

		// Token: 0x0602FDA6 RID: 196006 RVA: 0x00B16C58 File Offset: 0x00B14E58
		private void DestroyAllRuntimeActors()
		{
			foreach (WuWaGoRole wuWaGoRole in this.GameData.AllRoles)
			{
				wuWaGoRole.Destroy();
			}
			foreach (KeyValuePair<string, WuWaGoGrid> keyValuePair in this.GameData.Girds)
			{
				string text;
				WuWaGoGrid wuWaGoGrid;
				keyValuePair.Deconstruct(out text, out wuWaGoGrid);
				wuWaGoGrid.Destroy();
			}
			foreach (KeyValuePair<int, WuWaGoGameplayEntityBase> keyValuePair2 in this.GameData.AllGameplayEntities)
			{
				int num;
				WuWaGoGameplayEntityBase wuWaGoGameplayEntityBase;
				keyValuePair2.Deconstruct(out num, out wuWaGoGameplayEntityBase);
				WuWaGoGameplayEntityBase wuWaGoGameplayEntityBase2 = wuWaGoGameplayEntityBase;
				wuWaGoGameplayEntityBase2.RestoreInitialStateForGameOver();
				wuWaGoGameplayEntityBase2.Destroy();
			}
		}

		// Token: 0x0602FDA7 RID: 196007 RVA: 0x00B16D5C File Offset: 0x00B14F5C
		private List<MovableFloorController> GetMovableFloorControllersByPbDataIds(IReadOnlyList<int> pbDataIds)
		{
			HashSet<int> hashSet = new HashSet<int>(pbDataIds);
			List<MovableFloorController> list = new List<MovableFloorController>();
			foreach (KeyValuePair<int, GameplayEntityControllerBase> keyValuePair in this.AllEntityControllers)
			{
				int num;
				GameplayEntityControllerBase gameplayEntityControllerBase;
				keyValuePair.Deconstruct(out num, out gameplayEntityControllerBase);
				MovableFloorController movableFloorController = gameplayEntityControllerBase as MovableFloorController;
				if (movableFloorController != null && hashSet.Contains(movableFloorController.Entity.EntityPbDataId))
				{
					list.Add(movableFloorController);
				}
			}
			using (HashSet<int>.Enumerator enumerator2 = hashSet.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					int pbDataId = enumerator2.Current;
					if (list.Find((MovableFloorController controller) => controller.Entity.EntityPbDataId == pbDataId) == null)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.WuWaGo;
						ELogAuthor author = ELogAuthor.YSQ;
						string message = "移动板批量执行找不到目标Controller";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("pbDataId", pbDataId);
						instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
				}
			}
			return list;
		}

		// Token: 0x0602FDA8 RID: 196008 RVA: 0x00B16E78 File Offset: 0x00B15078
		private UniTask AddRolePetrifyEffect()
		{
			WuWaGoGameModeBase.<AddRolePetrifyEffect>d__99 <AddRolePetrifyEffect>d__;
			<AddRolePetrifyEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AddRolePetrifyEffect>d__.<>4__this = this;
			<AddRolePetrifyEffect>d__.<>1__state = -1;
			<AddRolePetrifyEffect>d__.<>t__builder.Start<WuWaGoGameModeBase.<AddRolePetrifyEffect>d__99>(ref <AddRolePetrifyEffect>d__);
			return <AddRolePetrifyEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602FDA9 RID: 196009 RVA: 0x00B16EBC File Offset: 0x00B150BC
		public UniTask WaitPlayIntroAsync()
		{
			WuWaGoGameModeBase.<WaitPlayIntroAsync>d__100 <WaitPlayIntroAsync>d__;
			<WaitPlayIntroAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitPlayIntroAsync>d__.<>4__this = this;
			<WaitPlayIntroAsync>d__.<>1__state = -1;
			<WaitPlayIntroAsync>d__.<>t__builder.Start<WuWaGoGameModeBase.<WaitPlayIntroAsync>d__100>(ref <WaitPlayIntroAsync>d__);
			return <WaitPlayIntroAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FDAA RID: 196010 RVA: 0x00B16F00 File Offset: 0x00B15100
		public void OnEnterIntro()
		{
			foreach (KeyValuePair<int, WuWaGoRoleController> keyValuePair in this.AllRoleControllers)
			{
				int num;
				WuWaGoRoleController wuWaGoRoleController;
				keyValuePair.Deconstruct(out num, out wuWaGoRoleController);
				wuWaGoRoleController.OnPlayIntroBegin();
			}
		}

		// Token: 0x0602FDAB RID: 196011 RVA: 0x00B16F60 File Offset: 0x00B15160
		public void OnEnterRunning()
		{
			foreach (KeyValuePair<int, WuWaGoRoleController> keyValuePair in this.AllRoleControllers)
			{
				int num;
				WuWaGoRoleController wuWaGoRoleController;
				keyValuePair.Deconstruct(out num, out wuWaGoRoleController);
				wuWaGoRoleController.OnEnterRunning();
			}
		}

		// Token: 0x04019CD9 RID: 105689
		private const string WUWAGO = "WuWaGo";

		// Token: 0x04019CDA RID: 105690
		private const int DISABLE_ENTITY_WAIT_TIMEOUT_MS = 5000;

		// Token: 0x04019CDB RID: 105691
		protected readonly RoundManager RoundManager = new RoundManager();

		// Token: 0x04019CDC RID: 105692
		private RollbackManager RollbackManager;

		// Token: 0x04019CDD RID: 105693
		protected WuWaGoGameData GameData;

		// Token: 0x04019CDE RID: 105694
		private WuWaGoGridMutationService GridMutationService;

		// Token: 0x04019CDF RID: 105695
		private IGameplayEntityLinkService GameplayEntityLinkServiceInner;

		// Token: 0x04019CE0 RID: 105696
		private readonly Dictionary<int, WuWaGoRoleController> AllRoleControllers = new Dictionary<int, WuWaGoRoleController>();

		// Token: 0x04019CE1 RID: 105697
		private readonly HashSet<WuWaGoRoleController> DeactivatedDeadRoleControllers = new HashSet<WuWaGoRoleController>();

		// Token: 0x04019CE2 RID: 105698
		private readonly Dictionary<int, GameplayEntityControllerBase> AllEntityControllers = new Dictionary<int, GameplayEntityControllerBase>();

		// Token: 0x04019CE3 RID: 105699
		private readonly Dictionary<int, WuWaGoGridController> AllGridControllers = new Dictionary<int, WuWaGoGridController>();

		// Token: 0x04019CE4 RID: 105700
		private readonly HashSet<IExecutableUnit> TickListeners = new HashSet<IExecutableUnit>();

		// Token: 0x04019CE5 RID: 105701
		private bool LastEmittedPlayTipAvailable;

		// Token: 0x04019CE6 RID: 105702
		[Nullable(2)]
		private WuWaGoTraversalGridEntity CurrentHintSource;

		// Token: 0x04019CE7 RID: 105703
		private bool CinematicPlaying;

		// Token: 0x04019CE8 RID: 105704
		private bool InterruptCinematicRequested;

		// Token: 0x04019CE9 RID: 105705
		[Nullable(2)]
		private WorldEntity DisabledEntity;

		// Token: 0x04019CEA RID: 105706
		private int DisableId;

		// Token: 0x04019CEB RID: 105707
		[Nullable(2)]
		private CustomPromise<UniTaskVoid> DeathPopupClosedPromise;

		// Token: 0x04019CEC RID: 105708
		private bool DeathSequenceActiveInner;

		// Token: 0x04019CED RID: 105709
		private readonly Dictionary<string, int> ActiveDamageBatchReasons = new Dictionary<string, int>();

		// Token: 0x04019CEE RID: 105710
		private int? PendingMainRoleDeadId;
	}
}
