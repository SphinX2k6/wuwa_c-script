using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038C4 RID: 14532
	[NullableContext(1)]
	[Nullable(0)]
	public class ClickBtnComponent : HotKeyComponent
	{
		// Token: 0x06025B02 RID: 154370 RVA: 0x00A9B5F0 File Offset: 0x00A997F0
		public ClickBtnComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B03 RID: 154371 RVA: 0x00A9B5F9 File Offset: 0x00A997F9
		protected override void OnPress(HotKeyMap config)
		{
			this.ClickButton(config.BindButtonTag);
		}

		// Token: 0x06025B04 RID: 154372 RVA: 0x00A9B608 File Offset: 0x00A99808
		private void ClickButton(string tag)
		{
			if (tag == "tag1")
			{
				UiNavigationNewController.Instance.HotKeyCloseView();
				return;
			}
			UiNavigationNewController.Instance.ClickButton(tag);
		}

		// Token: 0x06025B05 RID: 154373 RVA: 0x00A9B630 File Offset: 0x00A99830
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			string bindButtonTag = base.GetBindButtonTag();
			if (string.IsNullOrEmpty(bindButtonTag))
			{
				return;
			}
			TsUiNavigationBehaviorListener activeListenerByTag = viewHandle.GetActiveListenerByTag(bindButtonTag);
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, activeListenerByTag != null && activeListenerByTag.IsListenerActive(), false);
		}
	}
}
