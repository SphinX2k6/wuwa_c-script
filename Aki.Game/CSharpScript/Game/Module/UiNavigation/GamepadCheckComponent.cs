using System;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004969 RID: 18793
	public class GamepadCheckComponent : GamepadInteractComponentBase
	{
		// Token: 0x0603104B RID: 200779 RVA: 0x00B61574 File Offset: 0x00B5F774
		public GamepadCheckComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603104C RID: 200780 RVA: 0x00B61580 File Offset: 0x00B5F780
		protected override void OnPress(HotKeyMap config)
		{
			if (!UiNavigationNewController.Instance.IsNavigationMousePositionDragging() && this.IsUseDrag)
			{
				this.IsUseDrag = false;
			}
			if (this.IsUseDrag)
			{
				this.IsUseDrag = false;
				return;
			}
			this.IsUseDrag = UiNavigationNewController.Instance.IsGamepadHitListenerUseDrag();
			if (this.IsUseDrag)
			{
				UiNavigationNewController.Instance.NotifyNavigationMousePositionDragState(true);
			}
			UiNavigationNewController.Instance.SimulationPointerTrigger(true);
		}

		// Token: 0x0603104D RID: 200781 RVA: 0x00B615E6 File Offset: 0x00B5F7E6
		protected override void OnRelease(HotKeyMap config)
		{
			if (this.IsUseDrag)
			{
				return;
			}
			UiNavigationNewController.Instance.SimulationPointerTrigger(false);
			UiNavigationNewController.Instance.NotifyNavigationMousePositionDragState(false);
		}

		// Token: 0x0603104E RID: 200782 RVA: 0x00B61607 File Offset: 0x00B5F807
		protected override void OnRefreshByControllerChange()
		{
			if (this.IsUseDrag)
			{
				this.IsUseDrag = false;
				UiNavigationNewController.Instance.SimulationPointerTrigger(false);
				UiNavigationNewController.Instance.NotifyNavigationMousePositionDragState(false);
			}
		}

		// Token: 0x0401A490 RID: 107664
		private bool IsUseDrag;
	}
}
