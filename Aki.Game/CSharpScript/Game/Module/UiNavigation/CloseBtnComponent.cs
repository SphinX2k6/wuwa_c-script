using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038CA RID: 14538
	public class CloseBtnComponent : HotKeyComponent
	{
		// Token: 0x06025B1C RID: 154396 RVA: 0x00A9BA56 File Offset: 0x00A99C56
		public CloseBtnComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B1D RID: 154397 RVA: 0x00A9BA5F File Offset: 0x00A99C5F
		protected override void OnPress(HotKeyMap config)
		{
			this.HomeBtnListenerActive = this.CheckHomeBtnListenerActive();
			if (this.HomeBtnListenerActive)
			{
				return;
			}
			UiNavigationNewController.Instance.HotKeyCloseView();
		}

		// Token: 0x06025B1E RID: 154398 RVA: 0x00A9BA80 File Offset: 0x00A99C80
		protected override void OnRelease(HotKeyMap config)
		{
			if (!this.HomeBtnListenerActive)
			{
				return;
			}
			UiNavigationNewController.Instance.HotKeyCloseView();
		}

		// Token: 0x06025B1F RID: 154399 RVA: 0x00A9BA98 File Offset: 0x00A99C98
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			string bindButtonTag = base.GetBindButtonTag();
			if (StringUtils.IsEmpty(bindButtonTag))
			{
				return;
			}
			TsUiNavigationBehaviorListener activeListenerByTag = viewHandle.GetActiveListenerByTag(bindButtonTag);
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, activeListenerByTag != null && activeListenerByTag.IsListenerActive(), false);
		}

		// Token: 0x06025B20 RID: 154400 RVA: 0x00A9BAD1 File Offset: 0x00A99CD1
		private bool CheckHomeBtnListenerActive()
		{
			TsUiNavigationBehaviorListener activeListenerByTag = UiNavigationViewManager.Instance.GetCurrentViewHandle().GetActiveListenerByTag("tag_home");
			return activeListenerByTag != null && activeListenerByTag.IsListenerActive();
		}

		// Token: 0x04014CF4 RID: 85236
		private bool HomeBtnListenerActive;
	}
}
