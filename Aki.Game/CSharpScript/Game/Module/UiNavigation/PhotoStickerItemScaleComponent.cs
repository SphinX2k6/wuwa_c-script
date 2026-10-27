using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049B1 RID: 18865
	public class PhotoStickerItemScaleComponent : HotKeyComponent
	{
		// Token: 0x06031195 RID: 201109 RVA: 0x00B6476D File Offset: 0x00B6296D
		public PhotoStickerItemScaleComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031196 RID: 201110 RVA: 0x00B64776 File Offset: 0x00B62976
		protected void ChangeScale(float ratio)
		{
			PhotographController.Instance.RequestChangeStickerScale(ratio);
		}

		// Token: 0x06031197 RID: 201111 RVA: 0x00B64783 File Offset: 0x00B62983
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x0401A4B8 RID: 107704
		protected const float DEAD_AREA = 0.4f;
	}
}
