using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038CE RID: 14542
	public class DeselectPhotoStickerItemComponent : HotKeyComponent
	{
		// Token: 0x06025B2B RID: 154411 RVA: 0x00A9BCCB File Offset: 0x00A99ECB
		public DeselectPhotoStickerItemComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B2C RID: 154412 RVA: 0x00A9BCD4 File Offset: 0x00A99ED4
		protected override void OnPress(HotKeyMap config)
		{
			PhotographController.Instance.RequestDeselectSticker();
		}

		// Token: 0x06025B2D RID: 154413 RVA: 0x00A9BCE0 File Offset: 0x00A99EE0
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
