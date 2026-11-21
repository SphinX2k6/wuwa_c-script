using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038FE RID: 14590
	public class LongTimeToTriggerComponent : HotKeyComponent
	{
		// Token: 0x06025C24 RID: 154660 RVA: 0x00A9DECD File Offset: 0x00A9C0CD
		public LongTimeToTriggerComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C25 RID: 154661 RVA: 0x00A9DED6 File Offset: 0x00A9C0D6
		protected override void OnPress(HotKeyMap config)
		{
			this.DeactivateLongPress();
			this.TryActivateLongPress();
			this.OnPressAction();
		}

		// Token: 0x06025C26 RID: 154662 RVA: 0x00A9DEEC File Offset: 0x00A9C0EC
		protected override void OnRelease(HotKeyMap config)
		{
			if (this.CurPressTime >= (float)(config.LongPressTime + config.ReleaseFailureTime))
			{
				this.ClickButton(config.BindButtonTag);
			}
			this.SetLongPressState(0f);
			this.SetCurComponentAlpha(0f);
			this.DeactivateLongPress();
			this.OnReleaseAction();
			this.IsLockActionName = false;
		}

		// Token: 0x06025C27 RID: 154663 RVA: 0x00A9DF4C File Offset: 0x00A9C14C
		[NullableContext(1)]
		protected virtual void ClickButton(string tag)
		{
			if (tag == "tag1")
			{
				UiNavigationNewController.Instance.HotKeyCloseView();
				return;
			}
			UiNavigationNewController.Instance.ClickButton(tag);
		}

		// Token: 0x06025C28 RID: 154664 RVA: 0x00A9DF71 File Offset: 0x00A9C171
		protected override void OnUnRegisterMe()
		{
			this.DeactivateLongPress();
		}

		// Token: 0x06025C29 RID: 154665 RVA: 0x00A9DF79 File Offset: 0x00A9C179
		private void DeactivateLongPress()
		{
			if (this.LongPressRefreshTimerId != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.LongPressRefreshTimerId);
				this.LongPressRefreshTimerId = null;
			}
			this.CurPressTime = 0f;
		}

		// Token: 0x06025C2A RID: 154666 RVA: 0x00A9DFA6 File Offset: 0x00A9C1A6
		private void TryActivateLongPress()
		{
			this.LongPressRefreshTimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnLongPressRefreshCallback), 20f, 1f, null, null, true);
		}

		// Token: 0x06025C2B RID: 154667 RVA: 0x00A9DFD4 File Offset: 0x00A9C1D4
		private void OnLongPressRefreshCallback(float _)
		{
			this.CurPressTime += 20f;
			HotKeyMap? hotKeyConfig = base.GetHotKeyConfig();
			if (hotKeyConfig == null)
			{
				return;
			}
			float num = 0f;
			if (this.CurPressTime > (float)hotKeyConfig.Value.ReleaseFailureTime)
			{
				this.HandleLockActionName();
				int longPressTime = hotKeyConfig.Value.LongPressTime;
				num = (this.CurPressTime - (float)hotKeyConfig.Value.ReleaseFailureTime) / (float)longPressTime;
			}
			if (num >= 1f)
			{
				this.OnHandleLongPressRefresh(num);
				base.ReleaseWithoutCheck();
				return;
			}
			this.SetLongPressState(num);
			this.SetCurComponentAlpha(num > 0f);
		}

		// Token: 0x06025C2C RID: 154668 RVA: 0x00A9E07F File Offset: 0x00A9C27F
		private void SetLongPressState(float percent)
		{
			this.CurComponent.SetLongPressState(percent);
			this.OnHandleLongPressRefresh(percent);
		}

		// Token: 0x06025C2D RID: 154669 RVA: 0x00A9E094 File Offset: 0x00A9C294
		private void SetCurComponentAlpha(float alpha)
		{
			HotKeyMap? hotKeyConfig = base.GetHotKeyConfig();
			if (hotKeyConfig == null)
			{
				return;
			}
			if (hotKeyConfig.Value.ApplicableType == 6)
			{
				this.CurComponent.SetLongPressItemAlpha(alpha);
			}
		}

		// Token: 0x06025C2E RID: 154670 RVA: 0x00A9E0D0 File Offset: 0x00A9C2D0
		private void HandleLockActionName()
		{
			if (this.IsLockActionName)
			{
				return;
			}
			this.IsLockActionName = true;
			UiNavigationModel instance = UiNavigationModel.Instance;
			if (instance == null)
			{
				return;
			}
			foreach (HotKeyComponent hotKeyComponent in instance.GetActionHotKeyComponentSet(base.GetActionName()))
			{
				hotKeyComponent.ResetPressState();
			}
		}

		// Token: 0x06025C2F RID: 154671 RVA: 0x00A9E140 File Offset: 0x00A9C340
		protected virtual void OnPressAction()
		{
		}

		// Token: 0x06025C30 RID: 154672 RVA: 0x00A9E142 File Offset: 0x00A9C342
		protected virtual void OnReleaseAction()
		{
		}

		// Token: 0x06025C31 RID: 154673 RVA: 0x00A9E144 File Offset: 0x00A9C344
		protected virtual void OnHandleLongPressRefresh(float percent)
		{
		}

		// Token: 0x04014D1C RID: 85276
		private float CurPressTime;

		// Token: 0x04014D1D RID: 85277
		[Nullable(2)]
		private TimerHandle LongPressRefreshTimerId;

		// Token: 0x04014D1E RID: 85278
		private bool IsLockActionName;
	}
}
