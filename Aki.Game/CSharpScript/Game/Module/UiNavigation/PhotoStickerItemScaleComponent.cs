using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200392B RID: 14635
	public class PhotoStickerItemScaleComponent : HotKeyComponent
	{
		// Token: 0x06025CCB RID: 154827 RVA: 0x00A9F6BD File Offset: 0x00A9D8BD
		public PhotoStickerItemScaleComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025CCC RID: 154828 RVA: 0x00A9F6C6 File Offset: 0x00A9D8C6
		protected void ChangeScale(float ratio)
		{
			PhotographController.Instance.RequestChangeStickerScale(ratio);
		}

		// Token: 0x06025CCD RID: 154829 RVA: 0x00A9F6D3 File Offset: 0x00A9D8D3
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x04014D2A RID: 85290
		protected const float DEAD_AREA = 0.4f;
	}
}
