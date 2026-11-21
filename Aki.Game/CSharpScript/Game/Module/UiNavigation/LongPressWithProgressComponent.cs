using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038FD RID: 14589
	public class LongPressWithProgressComponent : HotKeyComponent
	{
		// Token: 0x06025C1B RID: 154651 RVA: 0x00A9DDA1 File Offset: 0x00A9BFA1
		public LongPressWithProgressComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C1C RID: 154652 RVA: 0x00A9DDAA File Offset: 0x00A9BFAA
		private void TryActivateRefreshTimer()
		{
			if (this.RefreshTimerId != null)
			{
				return;
			}
			this.RefreshTimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnRefreshCallback), 20f, 1f, null, null, true);
		}

		// Token: 0x06025C1D RID: 154653 RVA: 0x00A9DDE0 File Offset: 0x00A9BFE0
		private void OnRefreshCallback(float deltaTime)
		{
			float num = this.OnGetProgress();
			if (this.IsPress)
			{
				if (num >= 1f)
				{
					HotKeyCombineComponent curComponent = this.CurComponent;
					if (curComponent != null)
					{
						curComponent.SetLongPressState(0f);
					}
					base.ReleaseWithoutCheck();
					this.DeactivateRefreshTimer();
					return;
				}
			}
			else if (num <= 0f)
			{
				HotKeyCombineComponent curComponent2 = this.CurComponent;
				if (curComponent2 != null)
				{
					curComponent2.SetLongPressState(0f);
				}
				this.DeactivateRefreshTimer();
				return;
			}
			HotKeyCombineComponent curComponent3 = this.CurComponent;
			if (curComponent3 == null)
			{
				return;
			}
			curComponent3.SetLongPressState(num);
		}

		// Token: 0x06025C1E RID: 154654 RVA: 0x00A9DE5D File Offset: 0x00A9C05D
		protected override void OnPress(HotKeyMap config)
		{
			UiNavigationNewController.Instance.SimulationPointDown(config.BindButtonTag, config.Id, null);
			this.TryActivateRefreshTimer();
		}

		// Token: 0x06025C1F RID: 154655 RVA: 0x00A9DE7E File Offset: 0x00A9C07E
		protected override void OnRelease(HotKeyMap config)
		{
			UiNavigationNewController.Instance.SimulationPointUp(config.BindButtonTag, config.Id, null);
		}

		// Token: 0x06025C20 RID: 154656 RVA: 0x00A9DE99 File Offset: 0x00A9C099
		private void DeactivateRefreshTimer()
		{
			if (this.RefreshTimerId != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimerId);
				this.RefreshTimerId = null;
			}
		}

		// Token: 0x06025C21 RID: 154657 RVA: 0x00A9DEBB File Offset: 0x00A9C0BB
		protected override void OnClear()
		{
			this.DeactivateRefreshTimer();
		}

		// Token: 0x06025C22 RID: 154658 RVA: 0x00A9DEC3 File Offset: 0x00A9C0C3
		protected virtual float OnGetProgress()
		{
			return 0f;
		}

		// Token: 0x06025C23 RID: 154659 RVA: 0x00A9DECA File Offset: 0x00A9C0CA
		protected override bool GetIsLongPress()
		{
			return true;
		}

		// Token: 0x04014D1B RID: 85275
		[Nullable(2)]
		private TimerHandle RefreshTimerId;
	}
}
