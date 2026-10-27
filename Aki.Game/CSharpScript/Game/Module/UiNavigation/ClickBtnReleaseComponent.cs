using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004951 RID: 18769
	public class ClickBtnReleaseComponent : HotKeyComponent
	{
		// Token: 0x06030FE9 RID: 200681 RVA: 0x00B60B39 File Offset: 0x00B5ED39
		public ClickBtnReleaseComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06030FEA RID: 200682 RVA: 0x00B60B42 File Offset: 0x00B5ED42
		protected override void OnRelease(HotKeyMap config)
		{
			this.ClickButton(config.BindButtonTag);
		}

		// Token: 0x06030FEB RID: 200683 RVA: 0x00B60B51 File Offset: 0x00B5ED51
		[NullableContext(1)]
		private void ClickButton(string tag)
		{
			if (tag == "tag1")
			{
				UiNavigationNewController.Instance.HotKeyCloseView();
				return;
			}
			UiNavigationNewController.Instance.ClickButton(tag);
		}
	}
}
