using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004984 RID: 18820
	public class LongPressWithProgressComponent : HotKeyComponent
	{
		// Token: 0x060310E7 RID: 200935 RVA: 0x00B62EAD File Offset: 0x00B610AD
		public LongPressWithProgressComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060310E8 RID: 200936 RVA: 0x00B62EB6 File Offset: 0x00B610B6
		private void TryActivateRefreshTimer()
		{
			if (this.RefreshTimerId != null)
			{
				return;
			}
			this.RefreshTimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnRefreshCallback), 20f, 1f, null, null, true);
		}

		// Token: 0x060310E9 RID: 200937 RVA: 0x00B62EEC File Offset: 0x00B610EC
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

		// Token: 0x060310EA RID: 200938 RVA: 0x00B62F69 File Offset: 0x00B61169
		protected override void OnPress(HotKeyMap config)
		{
			UiNavigationNewController.Instance.SimulationPointDown(config.BindButtonTag, config.Id, null);
			this.TryActivateRefreshTimer();
		}

		// Token: 0x060310EB RID: 200939 RVA: 0x00B62F8A File Offset: 0x00B6118A
		protected override void OnRelease(HotKeyMap config)
		{
			UiNavigationNewController.Instance.SimulationPointUp(config.BindButtonTag, config.Id, null);
		}

		// Token: 0x060310EC RID: 200940 RVA: 0x00B62FA5 File Offset: 0x00B611A5
		private void DeactivateRefreshTimer()
		{
			if (this.RefreshTimerId != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimerId);
				this.RefreshTimerId = null;
			}
		}

		// Token: 0x060310ED RID: 200941 RVA: 0x00B62FC7 File Offset: 0x00B611C7
		protected override void OnClear()
		{
			this.DeactivateRefreshTimer();
		}

		// Token: 0x060310EE RID: 200942 RVA: 0x00B62FCF File Offset: 0x00B611CF
		protected virtual float OnGetProgress()
		{
			return 0f;
		}

		// Token: 0x060310EF RID: 200943 RVA: 0x00B62FD6 File Offset: 0x00B611D6
		protected override bool GetIsLongPress()
		{
			return true;
		}

		// Token: 0x0401A4A9 RID: 107689
		[Nullable(2)]
		private TimerHandle RefreshTimerId;
	}
}
