using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038C9 RID: 14537
	public class ClickBtnReleaseComponent : HotKeyComponent
	{
		// Token: 0x06025B19 RID: 154393 RVA: 0x00A9BA19 File Offset: 0x00A99C19
		public ClickBtnReleaseComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B1A RID: 154394 RVA: 0x00A9BA22 File Offset: 0x00A99C22
		protected override void OnRelease(HotKeyMap config)
		{
			this.ClickButton(config.BindButtonTag);
		}

		// Token: 0x06025B1B RID: 154395 RVA: 0x00A9BA31 File Offset: 0x00A99C31
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
