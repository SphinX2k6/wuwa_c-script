using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.RoleDevelopWorldDropEnoughTips
{
	// Token: 0x02003D22 RID: 15650
	public class RoleDevelopWorldDropEnoughTipsController : IStaticVariableResetter
	{
		// Token: 0x0602810D RID: 164109 RVA: 0x00B38650 File Offset: 0x00B36850
		static RoleDevelopWorldDropEnoughTipsController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoleDevelopWorldDropEnoughTipsController.CreateStaticDefaultValue), new Action(RoleDevelopWorldDropEnoughTipsController.ResetStaticDefaultValue));
		}

		// Token: 0x0602810E RID: 164110 RVA: 0x00B3866F File Offset: 0x00B3686F
		public static void CreateStaticDefaultValue()
		{
			RoleDevelopWorldDropEnoughTipsController.WaitTimerHandle = null;
		}

		// Token: 0x0602810F RID: 164111 RVA: 0x00B38677 File Offset: 0x00B36877
		public static void ResetStaticDefaultValue()
		{
			RoleDevelopWorldDropEnoughTipsController.WaitTimerHandle = null;
		}

		// Token: 0x06028110 RID: 164112 RVA: 0x00B3867F File Offset: 0x00B3687F
		public static void TryShow(int itemId, int displayItemId)
		{
			if (!RoleDevelopModel.Instance.EnqueueWorldDropTip(itemId, displayItemId))
			{
				return;
			}
			RoleDevelopWorldDropEnoughTipsController.TryOpenView();
		}

		// Token: 0x06028111 RID: 164113 RVA: 0x00B38698 File Offset: 0x00B36898
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

		// Token: 0x06028112 RID: 164114 RVA: 0x00B386E4 File Offset: 0x00B368E4
		private static bool CanOpenNow()
		{
			ItemModel instance = ItemModel.Instance;
			return instance.IsWaitItemListEmpty() && instance.IsWaitPhantomListEmpty() && instance.IsWaitVillageInfrTreeListEmpty() && !UiManager.Instance.IsViewOpen(EUiViewName.NewItemTipsView) && !UiManager.Instance.IsViewOpen(EUiViewName.PhantomTipsView) && !UiManager.Instance.IsViewOpen(EUiViewName.VillageInfrNewTipsView);
		}

		// Token: 0x06028113 RID: 164115 RVA: 0x00B38748 File Offset: 0x00B36948
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

		// Token: 0x06028114 RID: 164116 RVA: 0x00B38798 File Offset: 0x00B36998
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

		// Token: 0x06028115 RID: 164117 RVA: 0x00B387BC File Offset: 0x00B369BC
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

		// Token: 0x06028116 RID: 164118 RVA: 0x00B387F4 File Offset: 0x00B369F4
		public static int? GetCurrentDisplayItemId()
		{
			RoleDevelopWorldDropTipEntry worldDropTipCurrentEntry = RoleDevelopModel.Instance.GetWorldDropTipCurrentEntry();
			if (worldDropTipCurrentEntry == null)
			{
				return null;
			}
			return new int?(worldDropTipCurrentEntry.DisplayItemId);
		}

		// Token: 0x06028117 RID: 164119 RVA: 0x00B38824 File Offset: 0x00B36A24
		public static void TryShowNext()
		{
			RoleDevelopModel instance = RoleDevelopModel.Instance;
			if (instance != null)
			{
				instance.IsWorldDropTipShowing = false;
			}
			RoleDevelopWorldDropEnoughTipsController.TryOpenView();
		}

		// Token: 0x04015CD6 RID: 89302
		private const float WAIT_INTERVAL_MS = 500f;

		// Token: 0x04015CD7 RID: 89303
		[Nullable(2)]
		private static TimerHandle WaitTimerHandle;

		// Token: 0x02009903 RID: 39171
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402FBBA RID: 195514
			public static TTimerAction <0>__OnWaitTick;
		}
	}
}
