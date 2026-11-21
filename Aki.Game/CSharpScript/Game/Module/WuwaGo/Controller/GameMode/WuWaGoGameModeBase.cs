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
	// Token: 0x020036AB RID: 13995
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class WuWaGoGameModeBase
	{
		// Token: 0x17004A33 RID: 18995
		// (get) Token: 0x0602452A RID: 148778 RVA: 0x00A45923 File Offset: 0x00A43B23
		public WuWaGoGameData RuntimeGameData
		{
			get
			{
				return this.GameData;
			}
		}

		// Token: 0x17004A34 RID: 18996
		// (get) Token: 0x0602452B RID: 148779 RVA: 0x00A4592B File Offset: 0x00A43B2B
		public IGameplayEntityLinkService GameplayEntityLinkService
		{
			get
			{
				return this.GameplayEntityLinkServiceInner;
			}
		}

		// Token: 0x17004A35 RID: 18997
		// (get) Token: 0x0602452C RID: 148780 RVA: 0x00A45933 File Offset: 0x00A43B33
		public bool IsCinematicPlaying
		{
			get
			{
				return this.CinematicPlaying;
			}
		}

		// Token: 0x17004A36 RID: 18998
		// (get) Token: 0x0602452D RID: 148781 RVA: 0x00A4593B File Offset: 0x00A43B3B
		public bool IsDeathSequenceActive
		{
			get
			{
				return this.DeathSequenceActiveInner;
			}
		}

		// Token: 0x0602452E RID: 148782 RVA: 0x00A45944 File Offset: 0x00A43B44
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

		// Token: 0x0602452F RID: 148783 RVA: 0x00A45990 File Offset: 0x00A43B90
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

		// Token: 0x06024530 RID: 148784 RVA: 0x00A45B2C File Offset: 0x00A43D2C
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

		// Token: 0x06024531 RID: 148785 RVA: 0x00A45B58 File Offset: 0x00A43D58
		private UniTask DisableCurrentEntityAsync()
		{
			WuWaGoGameModeBase.<DisableCurrentEntityAsync>d__33 <DisableCurrentEntityAsync>d__;
			<DisableCurrentEntityAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DisableCurrentEntityAsync>d__.<>4__this = this;
			<DisableCurrentEntityAsync>d__.<>1__state = -1;
			<DisableCurrentEntityAsync>d__.<>t__builder.Start<WuWaGoGameModeBase.<DisableCurrentEntityAsync>d__33>(ref <DisableCurrentEntityAsync>d__);
			return <DisableCurrentEntityAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024532 RID: 148786 RVA: 0x00A45B9B File Offset: 0x00A43D9B
		private void EnableDisabledEntity()
		{
			if (this.DisabledEntity != null)
			{
				this.DisabledEntity.Enable(this.DisableId, "WuWaGo");
				this.DisabledEntity = null;
				this.DisableId = 0;
			}
		}

		// Token: 0x06024533 RID: 148787
		protected abstract bool OnStart();

		// Token: 0x06024534 RID: 148788 RVA: 0x00A45BCA File Offset: 0x00A43DCA
		protected virtual void OnTick(float delta)
		{
		}

		// Token: 0x06024535 RID: 148789
		protected abstract bool OnEnd();

		// Token: 0x06024536 RID: 148790 RVA: 0x00A45BCC File Offset: 0x00A43DCC
		private void AddEventListeners()
		{
			EventSystem.Instance.Add<int>(EEventName.OnWuWaGoRoleDead, new Action<int>(this.OnRoleDead));
			EventSystem.Instance.Add<bool, string>(EEventName.OnWuWaGoDamageBatchStateChanged, new Action<bool, string>(this.OnDamageBatchStateChanged));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnAnyViewClose));
			EventSystem.Instance.Add<AActor, int>(EEventName.OnAnimNotifyMaterialControllerHandleAdded, new Action<AActor, int>(this.OnAnimNotifyMaterialHandleAdded));
		}

		// Token: 0x06024537 RID: 148791 RVA: 0x00A45C48 File Offset: 0x00A43E48
		private void RemoveEventListeners()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnWuWaGoRoleDead, new Action<int>(this.OnRoleDead));
			EventSystem.Instance.Remove<bool, string>(EEventName.OnWuWaGoDamageBatchStateChanged, new Action<bool, string>(this.OnDamageBatchStateChanged));
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnAnyViewClose));
			EventSystem.Instance.Remove<AActor, int>(EEventName.OnAnimNotifyMaterialControllerHandleAdded, new Action<AActor, int>(this.OnAnimNotifyMaterialHandleAdded));
		}

		// Token: 0x06024538 RID: 148792 RVA: 0x00A45CC4 File Offset: 0x00A43EC4
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

		// Token: 0x06024539 RID: 148793 RVA: 0x00A45D3C File Offset: 0x00A43F3C
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

		// Token: 0x0602453A RID: 148794 RVA: 0x00A45DC8 File Offset: 0x00A43FC8
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

		// Token: 0x0602453B RID: 148795 RVA: 0x00A45E66 File Offset: 0x00A44066
		public bool IsDamageBatchActive()
		{
			return this.ActiveDamageBatchReasons.Count > 0;
		}

		// Token: 0x0602453C RID: 148796 RVA: 0x00A45E78 File Offset: 0x00A44078
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

		// Token: 0x0602453D RID: 148797 RVA: 0x00A45EE4 File Offset: 0x00A440E4
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

		// Token: 0x0602453E RID: 148798 RVA: 0x00A45F20 File Offset: 0x00A44120
		private UniTask RunDeathSequenceWithResetAsync()
		{
			WuWaGoGameModeBase.<RunDeathSequenceWithResetAsync>d__46 <RunDeathSequenceWithResetAsync>d__;
			<RunDeathSequenceWithResetAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunDeathSequenceWithResetAsync>d__.<>4__this = this;
			<RunDeathSequenceWithResetAsync>d__.<>1__state = -1;
			<RunDeathSequenceWithResetAsync>d__.<>t__builder.Start<WuWaGoGameModeBase.<RunDeathSequenceWithResetAsync>d__46>(ref <RunDeathSequenceWithResetAsync>d__);
			return <RunDeathSequenceWithResetAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602453F RID: 148799 RVA: 0x00A45F64 File Offset: 0x00A44164
		private UniTask RunDeathSequenceAsync()
		{
			WuWaGoGameModeBase.<RunDeathSequenceAsync>d__47 <RunDeathSequenceAsync>d__;
			<RunDeathSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunDeathSequenceAsync>d__.<>4__this = this;
			<RunDeathSequenceAsync>d__.<>1__state = -1;
			<RunDeathSequenceAsync>d__.<>t__builder.Start<WuWaGoGameModeBase.<RunDeathSequenceAsync>d__47>(ref <RunDeathSequenceAsync>d__);
			return <RunDeathSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024540 RID: 148800 RVA: 0x00A45FA7 File Offset: 0x00A441A7
		private void OnAnyViewClose(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.WuWaGoPopupView)
			{
				return;
			}
			this.CancelPendingDeathPopupWait();
		}

		// Token: 0x06024541 RID: 148801 RVA: 0x00A45FC0 File Offset: 0x00A441C0
		private void CancelPendingDeathPopupWait()
		{
			if (this.DeathPopupClosedPromise != null)
			{
				this.DeathPopupClosedPromise.SetResult(default(UniTaskVoid));
				this.DeathPopupClosedPromise = null;
			}
		}

		// Token: 0x06024542 RID: 148802 RVA: 0x00A45FF0 File Offset: 0x00A441F0
		private void DeactivateDeadRoleController(WuWaGoRoleController controller)
		{
			this.RoundManager.RemoveController(controller);
			this.TickListeners.Remove(controller);
			controller.BaseRole.SetStandGrid(null, null);
			controller.BaseRole.SetHiddenInGame(true);
		}

		// Token: 0x06024543 RID: 148803 RVA: 0x00A46024 File Offset: 0x00A44224
		private void DestroyAllDeactivatedRoleControllers()
		{
			foreach (WuWaGoRoleController controller in this.DeactivatedDeadRoleControllers)
			{
				this.DestroyDeactivatedRoleController(controller);
			}
			this.DeactivatedDeadRoleControllers.Clear();
		}

		// Token: 0x06024544 RID: 148804 RVA: 0x00A46084 File Offset: 0x00A44284
		private void DestroyDeactivatedRoleController(WuWaGoRoleController controller)
		{
			WuWaGoRole baseRole = controller.BaseRole;
			this.AllRoleControllers.Remove(baseRole.Id);
			this.TickListeners.Remove(controller);
			this.GameData.RemoveRole(baseRole);
			controller.Destroy();
		}

		// Token: 0x06024545 RID: 148805 RVA: 0x00A460CC File Offset: 0x00A442CC
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

		// Token: 0x06024546 RID: 148806 RVA: 0x00A461F0 File Offset: 0x00A443F0
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

		// Token: 0x06024547 RID: 148807 RVA: 0x00A4629C File Offset: 0x00A4449C
		public void NotifyGameplayEntityLinkServiceRollbackRestore()
		{
			this.GameplayEntityLinkServiceInner.OnRollbackRestore();
		}

		// Token: 0x06024548 RID: 148808 RVA: 0x00A462AC File Offset: 0x00A444AC
		public UniTask PlayPlayTipCinematicAsync()
		{
			WuWaGoGameModeBase.<PlayPlayTipCinematicAsync>d__56 <PlayPlayTipCinematicAsync>d__;
			<PlayPlayTipCinematicAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayPlayTipCinematicAsync>d__.<>4__this = this;
			<PlayPlayTipCinematicAsync>d__.<>1__state = -1;
			<PlayPlayTipCinematicAsync>d__.<>t__builder.Start<WuWaGoGameModeBase.<PlayPlayTipCinematicAsync>d__56>(ref <PlayPlayTipCinematicAsync>d__);
			return <PlayPlayTipCinematicAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024549 RID: 148809 RVA: 0x00A462EF File Offset: 0x00A444EF
		public void RequestInterruptPlayTipCinematic()
		{
			if (!this.CinematicPlaying)
			{
				return;
			}
			this.InterruptCinematicRequested = true;
		}

		// Token: 0x0602454A RID: 148810 RVA: 0x00A46304 File Offset: 0x00A44504
		public UniTask RollbackToLastStepAsync()
		{
			WuWaGoGameModeBase.<RollbackToLastStepAsync>d__58 <RollbackToLastStepAsync>d__;
			<RollbackToLastStepAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RollbackToLastStepAsync>d__.<>4__this = this;
			<RollbackToLastStepAsync>d__.<>1__state = -1;
			<RollbackToLastStepAsync>d__.<>t__builder.Start<WuWaGoGameModeBase.<RollbackToLastStepAsync>d__58>(ref <RollbackToLastStepAsync>d__);
			return <RollbackToLastStepAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602454B RID: 148811 RVA: 0x00A46348 File Offset: 0x00A44548
		public UniTask RollbackToSavePointAsync()
		{
			WuWaGoGameModeBase.<RollbackToSavePointAsync>d__59 <RollbackToSavePointAsync>d__;
			<RollbackToSavePointAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RollbackToSavePointAsync>d__.<>4__this = this;
			<RollbackToSavePointAsync>d__.<>1__state = -1;
			<RollbackToSavePointAsync>d__.<>t__builder.Start<WuWaGoGameModeBase.<RollbackToSavePointAsync>d__59>(ref <RollbackToSavePointAsync>d__);
			return <RollbackToSavePointAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602454C RID: 148812 RVA: 0x00A4638C File Offset: 0x00A4458C
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

		// Token: 0x0602454D RID: 148813 RVA: 0x00A463E8 File Offset: 0x00A445E8
		public bool IsRollbackAvailable()
		{
			return !this.IsDamageBatchActive() && this.RollbackManager.IsAvailable;
		}

		// Token: 0x0602454E RID: 148814 RVA: 0x00A463FF File Offset: 0x00A445FF
		public bool CanUsePlayTip()
		{
			if (!this.IsCinematicPlaying && !this.IsDamageBatchActive() && !this.IsDeathSequenceActive && !this.IsRollbackRestoring)
			{
				WuWaGoMainControlRole mainControlRole = this.GameData.MainControlRole;
				return mainControlRole != null && mainControlRole.IsAcceptingInput;
			}
			return false;
		}

		// Token: 0x17004A37 RID: 18999
		// (get) Token: 0x0602454F RID: 148815 RVA: 0x00A46439 File Offset: 0x00A44639
		public bool IsRollbackRestoring
		{
			get
			{
				return this.RollbackManager.IsRestoring;
			}
		}

		// Token: 0x06024550 RID: 148816 RVA: 0x00A46446 File Offset: 0x00A44646
		public bool CanExecuteGameplayEntityAction()
		{
			return !this.IsDeathSequenceActive && !this.IsRollbackRestoring && !this.RoundManager.ShouldAbortCurrentRound();
		}

		// Token: 0x06024551 RID: 148817 RVA: 0x00A46468 File Offset: 0x00A44668
		public void OnRollbackTriggered()
		{
			WuWaGoTimeStop.CancelAll("WuWaGo.Rollback");
			this.RoundManager.ResetForRollback();
		}

		// Token: 0x06024552 RID: 148818 RVA: 0x00A4647F File Offset: 0x00A4467F
		public void ResetPlayerActionCaptures()
		{
			this.RollbackManager.ResetPlayerActionCaptures();
		}

		// Token: 0x06024553 RID: 148819 RVA: 0x00A4648C File Offset: 0x00A4468C
		public void FlushPendingPlayerActionTracking()
		{
			this.RollbackManager.FlushPendingPlayerActionTracking();
		}

		// Token: 0x06024554 RID: 148820 RVA: 0x00A46499 File Offset: 0x00A44699
		public void BeginPlayerActionTracking()
		{
			this.RollbackManager.BeginPlayerActionTracking();
		}

		// Token: 0x06024555 RID: 148821 RVA: 0x00A464A6 File Offset: 0x00A446A6
		public void NotifyMainControlInputAcceptingChanged(bool accept)
		{
			this.RollbackManager.SetAcceptingInput(accept);
			EventSystem.Instance.Emit<bool>(EEventName.OnWuWaGoMainControlInputAcceptingChanged, accept);
		}

		// Token: 0x06024556 RID: 148822 RVA: 0x00A464C5 File Offset: 0x00A446C5
		public void SetMainControlInputAccepting(bool accept)
		{
			MainControlRoleController mainControlRoleController = this.GetMainControlRoleController();
			if (mainControlRoleController == null)
			{
				return;
			}
			mainControlRoleController.SetInputAcceptingFromExternal(accept);
		}

		// Token: 0x06024557 RID: 148823 RVA: 0x00A464D8 File Offset: 0x00A446D8
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

		// Token: 0x06024558 RID: 148824 RVA: 0x00A46510 File Offset: 0x00A44710
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

		// Token: 0x06024559 RID: 148825 RVA: 0x00A46576 File Offset: 0x00A44776
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

		// Token: 0x0602455A RID: 148826 RVA: 0x00A465AC File Offset: 0x00A447AC
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

		// Token: 0x0602455B RID: 148827 RVA: 0x00A46618 File Offset: 0x00A44818
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

		// Token: 0x0602455C RID: 148828 RVA: 0x00A46688 File Offset: 0x00A44888
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

		// Token: 0x0602455D RID: 148829 RVA: 0x00A466B8 File Offset: 0x00A448B8
		[NullableContext(2)]
		public WuWaGoRoleController GetRoleController(int roleId)
		{
			return this.AllRoleControllers.GetValueOrDefault(roleId);
		}

		// Token: 0x0602455E RID: 148830 RVA: 0x00A466C6 File Offset: 0x00A448C6
		[NullableContext(2)]
		public WuWaGoGridController GetGridControllerById(int gridId)
		{
			return this.AllGridControllers.GetValueOrDefault(gridId);
		}

		// Token: 0x0602455F RID: 148831 RVA: 0x00A466D4 File Offset: 0x00A448D4
		public void NotifyMoveMonsterActed()
		{
			this.RoundManager.NotifyMoveMonsterActed();
		}

		// Token: 0x06024560 RID: 148832 RVA: 0x00A466E4 File Offset: 0x00A448E4
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

		// Token: 0x06024561 RID: 148833 RVA: 0x00A46738 File Offset: 0x00A44938
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

		// Token: 0x06024562 RID: 148834 RVA: 0x00A46784 File Offset: 0x00A44984
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

		// Token: 0x06024563 RID: 148835 RVA: 0x00A467C8 File Offset: 0x00A449C8
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

		// Token: 0x06024564 RID: 148836 RVA: 0x00A4685C File Offset: 0x00A44A5C
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

		// Token: 0x06024565 RID: 148837 RVA: 0x00A468C8 File Offset: 0x00A44AC8
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

		// Token: 0x06024566 RID: 148838 RVA: 0x00A46980 File Offset: 0x00A44B80
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

		// Token: 0x06024567 RID: 148839 RVA: 0x00A46A28 File Offset: 0x00A44C28
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

		// Token: 0x06024568 RID: 148840 RVA: 0x00A46AA4 File Offset: 0x00A44CA4
		private void TryRegisterTick(IExecutableUnit controller)
		{
			FieldInfo field = controller.GetType().GetField("EnableTick", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			if ((((field != null) ? field.GetValue(null) : null) as bool?).GetValueOrDefault())
			{
				this.TickListeners.Add(controller);
			}
		}

		// Token: 0x06024569 RID: 148841 RVA: 0x00A46AF4 File Offset: 0x00A44CF4
		private void TickRegisteredListeners(float delta)
		{
			foreach (IExecutableUnit executableUnit in this.TickListeners)
			{
				executableUnit.OnTick(delta);
			}
		}

		// Token: 0x0602456A RID: 148842 RVA: 0x00A46B48 File Offset: 0x00A44D48
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

		// Token: 0x0602456B RID: 148843 RVA: 0x00A46B5C File Offset: 0x00A44D5C
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

		// Token: 0x0602456C RID: 148844 RVA: 0x00A46BB8 File Offset: 0x00A44DB8
		private UniTask CreateAllAppliques(WuWaGoGameData gameData)
		{
			WuWaGoGameModeBase.<CreateAllAppliques>d__93 <CreateAllAppliques>d__;
			<CreateAllAppliques>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateAllAppliques>d__.gameData = gameData;
			<CreateAllAppliques>d__.<>1__state = -1;
			<CreateAllAppliques>d__.<>t__builder.Start<WuWaGoGameModeBase.<CreateAllAppliques>d__93>(ref <CreateAllAppliques>d__);
			return <CreateAllAppliques>d__.<>t__builder.Task;
		}

		// Token: 0x0602456D RID: 148845 RVA: 0x00A46BFC File Offset: 0x00A44DFC
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

		// Token: 0x0602456E RID: 148846 RVA: 0x00A46C38 File Offset: 0x00A44E38
		private UniTask CreateAllRoles(WuWaGoGameData gameData)
		{
			WuWaGoGameModeBase.<CreateAllRoles>d__95 <CreateAllRoles>d__;
			<CreateAllRoles>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateAllRoles>d__.gameData = gameData;
			<CreateAllRoles>d__.<>1__state = -1;
			<CreateAllRoles>d__.<>t__builder.Start<WuWaGoGameModeBase.<CreateAllRoles>d__95>(ref <CreateAllRoles>d__);
			return <CreateAllRoles>d__.<>t__builder.Task;
		}

		// Token: 0x0602456F RID: 148847 RVA: 0x00A46C7C File Offset: 0x00A44E7C
		private UniTask PreloadBpClass()
		{
			WuWaGoGameModeBase.<PreloadBpClass>d__96 <PreloadBpClass>d__;
			<PreloadBpClass>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadBpClass>d__.<>1__state = -1;
			<PreloadBpClass>d__.<>t__builder.Start<WuWaGoGameModeBase.<PreloadBpClass>d__96>(ref <PreloadBpClass>d__);
			return <PreloadBpClass>d__.<>t__builder.Task;
		}

		// Token: 0x06024570 RID: 148848 RVA: 0x00A46CB8 File Offset: 0x00A44EB8
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

		// Token: 0x06024571 RID: 148849 RVA: 0x00A46DBC File Offset: 0x00A44FBC
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

		// Token: 0x06024572 RID: 148850 RVA: 0x00A46ED8 File Offset: 0x00A450D8
		private UniTask AddRolePetrifyEffect()
		{
			WuWaGoGameModeBase.<AddRolePetrifyEffect>d__99 <AddRolePetrifyEffect>d__;
			<AddRolePetrifyEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AddRolePetrifyEffect>d__.<>4__this = this;
			<AddRolePetrifyEffect>d__.<>1__state = -1;
			<AddRolePetrifyEffect>d__.<>t__builder.Start<WuWaGoGameModeBase.<AddRolePetrifyEffect>d__99>(ref <AddRolePetrifyEffect>d__);
			return <AddRolePetrifyEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06024573 RID: 148851 RVA: 0x00A46F1C File Offset: 0x00A4511C
		public UniTask WaitPlayIntroAsync()
		{
			WuWaGoGameModeBase.<WaitPlayIntroAsync>d__100 <WaitPlayIntroAsync>d__;
			<WaitPlayIntroAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitPlayIntroAsync>d__.<>4__this = this;
			<WaitPlayIntroAsync>d__.<>1__state = -1;
			<WaitPlayIntroAsync>d__.<>t__builder.Start<WuWaGoGameModeBase.<WaitPlayIntroAsync>d__100>(ref <WaitPlayIntroAsync>d__);
			return <WaitPlayIntroAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024574 RID: 148852 RVA: 0x00A46F60 File Offset: 0x00A45160
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

		// Token: 0x06024575 RID: 148853 RVA: 0x00A46FC0 File Offset: 0x00A451C0
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

		// Token: 0x04014389 RID: 82825
		private const string WUWAGO = "WuWaGo";

		// Token: 0x0401438A RID: 82826
		private const int DISABLE_ENTITY_WAIT_TIMEOUT_MS = 5000;

		// Token: 0x0401438B RID: 82827
		protected readonly RoundManager RoundManager = new RoundManager();

		// Token: 0x0401438C RID: 82828
		private RollbackManager RollbackManager;

		// Token: 0x0401438D RID: 82829
		protected WuWaGoGameData GameData;

		// Token: 0x0401438E RID: 82830
		private WuWaGoGridMutationService GridMutationService;

		// Token: 0x0401438F RID: 82831
		private IGameplayEntityLinkService GameplayEntityLinkServiceInner;

		// Token: 0x04014390 RID: 82832
		private readonly Dictionary<int, WuWaGoRoleController> AllRoleControllers = new Dictionary<int, WuWaGoRoleController>();

		// Token: 0x04014391 RID: 82833
		private readonly HashSet<WuWaGoRoleController> DeactivatedDeadRoleControllers = new HashSet<WuWaGoRoleController>();

		// Token: 0x04014392 RID: 82834
		private readonly Dictionary<int, GameplayEntityControllerBase> AllEntityControllers = new Dictionary<int, GameplayEntityControllerBase>();

		// Token: 0x04014393 RID: 82835
		private readonly Dictionary<int, WuWaGoGridController> AllGridControllers = new Dictionary<int, WuWaGoGridController>();

		// Token: 0x04014394 RID: 82836
		private readonly HashSet<IExecutableUnit> TickListeners = new HashSet<IExecutableUnit>();

		// Token: 0x04014395 RID: 82837
		private bool LastEmittedPlayTipAvailable;

		// Token: 0x04014396 RID: 82838
		[Nullable(2)]
		private WuWaGoTraversalGridEntity CurrentHintSource;

		// Token: 0x04014397 RID: 82839
		private bool CinematicPlaying;

		// Token: 0x04014398 RID: 82840
		private bool InterruptCinematicRequested;

		// Token: 0x04014399 RID: 82841
		[Nullable(2)]
		private WorldEntity DisabledEntity;

		// Token: 0x0401439A RID: 82842
		private int DisableId;

		// Token: 0x0401439B RID: 82843
		[Nullable(2)]
		private CustomPromise<UniTaskVoid> DeathPopupClosedPromise;

		// Token: 0x0401439C RID: 82844
		private bool DeathSequenceActiveInner;

		// Token: 0x0401439D RID: 82845
		private readonly Dictionary<string, int> ActiveDamageBatchReasons = new Dictionary<string, int>();

		// Token: 0x0401439E RID: 82846
		private int? PendingMainRoleDeadId;
	}
}
