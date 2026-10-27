using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004985 RID: 18821
	public class LongTimeToTriggerComponent : HotKeyComponent
	{
		// Token: 0x060310F0 RID: 200944 RVA: 0x00B62FD9 File Offset: 0x00B611D9
		public LongTimeToTriggerComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060310F1 RID: 200945 RVA: 0x00B62FE2 File Offset: 0x00B611E2
		protected override void OnPress(HotKeyMap config)
		{
			this.DeactivateLongPress();
			this.TryActivateLongPress();
			this.OnPressAction();
		}

		// Token: 0x060310F2 RID: 200946 RVA: 0x00B62FF8 File Offset: 0x00B611F8
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

		// Token: 0x060310F3 RID: 200947 RVA: 0x00B63058 File Offset: 0x00B61258
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

		// Token: 0x060310F4 RID: 200948 RVA: 0x00B6307D File Offset: 0x00B6127D
		protected override void OnUnRegisterMe()
		{
			this.DeactivateLongPress();
		}

		// Token: 0x060310F5 RID: 200949 RVA: 0x00B63085 File Offset: 0x00B61285
		private void DeactivateLongPress()
		{
			if (this.LongPressRefreshTimerId != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.LongPressRefreshTimerId);
				this.LongPressRefreshTimerId = null;
			}
			this.CurPressTime = 0f;
		}

		// Token: 0x060310F6 RID: 200950 RVA: 0x00B630B2 File Offset: 0x00B612B2
		private void TryActivateLongPress()
		{
			this.LongPressRefreshTimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnLongPressRefreshCallback), 20f, 1f, null, null, true);
		}

		// Token: 0x060310F7 RID: 200951 RVA: 0x00B630E0 File Offset: 0x00B612E0
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

		// Token: 0x060310F8 RID: 200952 RVA: 0x00B6318B File Offset: 0x00B6138B
		private void SetLongPressState(float percent)
		{
			this.CurComponent.SetLongPressState(percent);
			this.OnHandleLongPressRefresh(percent);
		}

		// Token: 0x060310F9 RID: 200953 RVA: 0x00B631A0 File Offset: 0x00B613A0
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

		// Token: 0x060310FA RID: 200954 RVA: 0x00B631DC File Offset: 0x00B613DC
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

		// Token: 0x060310FB RID: 200955 RVA: 0x00B6324C File Offset: 0x00B6144C
		protected virtual void OnPressAction()
		{
		}

		// Token: 0x060310FC RID: 200956 RVA: 0x00B6324E File Offset: 0x00B6144E
		protected virtual void OnReleaseAction()
		{
		}

		// Token: 0x060310FD RID: 200957 RVA: 0x00B63250 File Offset: 0x00B61450
		protected virtual void OnHandleLongPressRefresh(float percent)
		{
		}

		// Token: 0x0401A4AA RID: 107690
		private float CurPressTime;

		// Token: 0x0401A4AB RID: 107691
		[Nullable(2)]
		private TimerHandle LongPressRefreshTimerId;

		// Token: 0x0401A4AC RID: 107692
		private bool IsLockActionName;
	}
}
