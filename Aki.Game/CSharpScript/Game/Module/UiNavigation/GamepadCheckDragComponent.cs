using System;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038E2 RID: 14562
	public class GamepadCheckDragComponent : GamepadInteractComponentBase
	{
		// Token: 0x06025B7F RID: 154495 RVA: 0x00A9C50E File Offset: 0x00A9A70E
		public GamepadCheckDragComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B80 RID: 154496 RVA: 0x00A9C518 File Offset: 0x00A9A718
		protected override void OnPress(HotKeyMap config)
		{
			if (this.IsUseDrag)
			{
				this.IsUseDrag = false;
				return;
			}
			this.IsUseDrag = UiNavigationNewController.Instance.IsGamepadHitListenerUseDrag();
			UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = currentViewHandle.GetGuideUiListener();
			if (tsUiNavigationBehaviorListener == null)
			{
				tsUiNavigationBehaviorListener = currentViewHandle.GetHitComponentListener();
			}
			UiNavigationNewController.Instance.GamepadInteractSimulationPointer((tsUiNavigationBehaviorListener != null) ? tsUiNavigationBehaviorListener.GetBehaviorComponent() : null, true);
			if (!UiNavigationNewController.Instance.IsNavigationMousePositionDragging() && this.IsUseDrag)
			{
				this.IsUseDrag = false;
			}
		}

		// Token: 0x06025B81 RID: 154497 RVA: 0x00A9C594 File Offset: 0x00A9A794
		protected override void OnRelease(HotKeyMap config)
		{
			if (this.IsUseDrag)
			{
				return;
			}
			UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
			if (currentViewHandle.GetGuideUiListener() == null)
			{
				currentViewHandle.GetHitComponentListener();
			}
			UiNavigationNewController.Instance.SimulationPointerTrigger(false);
		}

		// Token: 0x06025B82 RID: 154498 RVA: 0x00A9C5CF File Offset: 0x00A9A7CF
		protected override void OnRefreshByControllerChange()
		{
			if (this.IsUseDrag)
			{
				this.IsUseDrag = false;
				UiNavigationNewController.Instance.SimulationPointerTrigger(false);
				UiNavigationNewController.Instance.NotifyNavigationMousePositionDragState(false);
			}
		}

		// Token: 0x04014D04 RID: 85252
		private bool IsUseDrag;
	}
}
