using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.RoleDevelopWorldDropEnoughTips
{
	// Token: 0x02004D59 RID: 19801
	public class RoleDevelopWorldDropEnoughTipsController : IStaticVariableResetter
	{
		// Token: 0x060332A3 RID: 209571 RVA: 0x00BEF51C File Offset: 0x00BED71C
		static RoleDevelopWorldDropEnoughTipsController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoleDevelopWorldDropEnoughTipsController.CreateStaticDefaultValue), new Action(RoleDevelopWorldDropEnoughTipsController.ResetStaticDefaultValue));
		}

		// Token: 0x060332A4 RID: 209572 RVA: 0x00BEF53B File Offset: 0x00BED73B
		public static void CreateStaticDefaultValue()
		{
			RoleDevelopWorldDropEnoughTipsController.WaitTimerHandle = null;
		}

		// Token: 0x060332A5 RID: 209573 RVA: 0x00BEF543 File Offset: 0x00BED743
		public static void ResetStaticDefaultValue()
		{
			RoleDevelopWorldDropEnoughTipsController.WaitTimerHandle = null;
		}

		// Token: 0x060332A6 RID: 209574 RVA: 0x00BEF54B File Offset: 0x00BED74B
		public static void TryShow(int itemId, int displayItemId)
		{
			if (!RoleDevelopModel.Instance.EnqueueWorldDropTip(itemId, displayItemId))
			{
				return;
			}
			RoleDevelopWorldDropEnoughTipsController.TryOpenView();
		}

		// Token: 0x060332A7 RID: 209575 RVA: 0x00BEF564 File Offset: 0x00BED764
		private static void TryOpenView()
		{
			RoleDevelopModel instance = RoleDevelopModel.Instance;
			if (instance.IsWorldDropTipShowing || !instance.HasPendingWorldDropTip())
			{
				return;
			}
			if (!RoleDevelopWorldDropEnoughTipsController.CanOpenNow())
			{
				RoleDevelopWorldDropEnoughTipsController.StartWaitTimer();
				return;
			}
			if (!instance.AdvanceWorldDropTipToNext())
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.RoleDevelopWorldDropEnoughTips, null, null);
		}

		// Token: 0x060332A8 RID: 209576 RVA: 0x00BEF5B0 File Offset: 0x00BED7B0
		private static bool CanOpenNow()
		{
			ItemModel instance = ItemModel.Instance;
			return instance.IsWaitItemListEmpty() && instance.IsWaitPhantomListEmpty() && instance.IsWaitVillageInfrTreeListEmpty() && !UiManager.Instance.IsViewOpen(EUiViewName.NewItemTipsView) && !UiManager.Instance.IsViewOpen(EUiViewName.PhantomTipsView) && !UiManager.Instance.IsViewOpen(EUiViewName.VillageInfrNewTipsView);
		}

		// Token: 0x060332A9 RID: 209577 RVA: 0x00BEF614 File Offset: 0x00BED814
		private static void StartWaitTimer()
		{
			if (RoleDevelopWorldDropEnoughTipsController.WaitTimerHandle != null)
			{
				return;
			}
			TimerSystemInstance instance = TimerSystem.Instance;
			TTimerAction action;
			if ((action = RoleDevelopWorldDropEnoughTipsController.<>O.<0>__OnWaitTick) == null)
			{
				action = (RoleDevelopWorldDropEnoughTipsController.<>O.<0>__OnWaitTick = new TTimerAction(RoleDevelopWorldDropEnoughTipsController.OnWaitTick));
			}
			RoleDevelopWorldDropEnoughTipsController.WaitTimerHandle = instance.Forever(action, 500f, 1f, null, "RoleDevelopWorldDropEnoughTips.WaitNewItemTips", true);
		}

		// Token: 0x060332AA RID: 209578 RVA: 0x00BEF664 File Offset: 0x00BED864
		private static void StopWaitTimer()
		{
			TimerHandle waitTimerHandle = RoleDevelopWorldDropEnoughTipsController.WaitTimerHandle;
			if (waitTimerHandle == null)
			{
				return;
			}
			RoleDevelopWorldDropEnoughTipsController.WaitTimerHandle = null;
			waitTimerHandle.Remove();
		}

		// Token: 0x060332AB RID: 209579 RVA: 0x00BEF688 File Offset: 0x00BED888
		private static void OnWaitTick(float delta)
		{
			RoleDevelopModel instance = RoleDevelopModel.Instance;
			if (instance == null || !instance.HasPendingWorldDropTip())
			{
				RoleDevelopWorldDropEnoughTipsController.StopWaitTimer();
				return;
			}
			if (!RoleDevelopWorldDropEnoughTipsController.CanOpenNow())
			{
				return;
			}
			RoleDevelopWorldDropEnoughTipsController.StopWaitTimer();
			RoleDevelopWorldDropEnoughTipsController.TryOpenView();
		}

		// Token: 0x060332AC RID: 209580 RVA: 0x00BEF6C0 File Offset: 0x00BED8C0
		public static int? GetCurrentDisplayItemId()
		{
			RoleDevelopWorldDropTipEntry worldDropTipCurrentEntry = RoleDevelopModel.Instance.GetWorldDropTipCurrentEntry();
			if (worldDropTipCurrentEntry == null)
			{
				return null;
			}
			return new int?(worldDropTipCurrentEntry.DisplayItemId);
		}

		// Token: 0x060332AD RID: 209581 RVA: 0x00BEF6F0 File Offset: 0x00BED8F0
		public static void TryShowNext()
		{
			RoleDevelopModel instance = RoleDevelopModel.Instance;
			if (instance != null)
			{
				instance.IsWorldDropTipShowing = false;
			}
			RoleDevelopWorldDropEnoughTipsController.TryOpenView();
		}

		// Token: 0x0401B305 RID: 111365
		private const float WAIT_INTERVAL_MS = 500f;

		// Token: 0x0401B306 RID: 111366
		[Nullable(2)]
		private static TimerHandle WaitTimerHandle;

		// Token: 0x0200AED0 RID: 44752
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403518A RID: 217482
			public static TTimerAction <0>__OnWaitTick;
		}
	}
}
