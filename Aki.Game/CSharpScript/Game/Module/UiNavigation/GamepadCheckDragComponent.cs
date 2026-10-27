using System;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200496A RID: 18794
	public class GamepadCheckDragComponent : GamepadInteractComponentBase
	{
		// Token: 0x0603104F RID: 200783 RVA: 0x00B6162E File Offset: 0x00B5F82E
		public GamepadCheckDragComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031050 RID: 200784 RVA: 0x00B61638 File Offset: 0x00B5F838
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

		// Token: 0x06031051 RID: 200785 RVA: 0x00B616B4 File Offset: 0x00B5F8B4
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

		// Token: 0x06031052 RID: 200786 RVA: 0x00B616EF File Offset: 0x00B5F8EF
		protected override void OnRefreshByControllerChange()
		{
			if (this.IsUseDrag)
			{
				this.IsUseDrag = false;
				UiNavigationNewController.Instance.SimulationPointerTrigger(false);
				UiNavigationNewController.Instance.NotifyNavigationMousePositionDragState(false);
			}
		}

		// Token: 0x0401A491 RID: 107665
		private bool IsUseDrag;
	}
}
