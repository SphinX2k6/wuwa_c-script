using System;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038E1 RID: 14561
	public class GamepadCheckComponent : GamepadInteractComponentBase
	{
		// Token: 0x06025B7B RID: 154491 RVA: 0x00A9C454 File Offset: 0x00A9A654
		public GamepadCheckComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B7C RID: 154492 RVA: 0x00A9C460 File Offset: 0x00A9A660
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

		// Token: 0x06025B7D RID: 154493 RVA: 0x00A9C4C6 File Offset: 0x00A9A6C6
		protected override void OnRelease(HotKeyMap config)
		{
			if (this.IsUseDrag)
			{
				return;
			}
			UiNavigationNewController.Instance.SimulationPointerTrigger(false);
			UiNavigationNewController.Instance.NotifyNavigationMousePositionDragState(false);
		}

		// Token: 0x06025B7E RID: 154494 RVA: 0x00A9C4E7 File Offset: 0x00A9A6E7
		protected override void OnRefreshByControllerChange()
		{
			if (this.IsUseDrag)
			{
				this.IsUseDrag = false;
				UiNavigationNewController.Instance.SimulationPointerTrigger(false);
				UiNavigationNewController.Instance.NotifyNavigationMousePositionDragState(false);
			}
		}

		// Token: 0x04014D03 RID: 85251
		private bool IsUseDrag;
	}
}
