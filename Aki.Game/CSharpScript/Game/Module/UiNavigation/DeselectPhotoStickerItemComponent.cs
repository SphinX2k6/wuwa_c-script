using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004956 RID: 18774
	public class DeselectPhotoStickerItemComponent : HotKeyComponent
	{
		// Token: 0x06030FFB RID: 200699 RVA: 0x00B60DEA File Offset: 0x00B5EFEA
		public DeselectPhotoStickerItemComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06030FFC RID: 200700 RVA: 0x00B60DF3 File Offset: 0x00B5EFF3
		protected override void OnPress(HotKeyMap config)
		{
			PhotographController.Instance.RequestDeselectSticker();
		}

		// Token: 0x06030FFD RID: 200701 RVA: 0x00B60DFF File Offset: 0x00B5EFFF
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
