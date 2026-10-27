using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049CF RID: 18895
	public class SelectPhotoStickerItemComponent : HotKeyComponent
	{
		// Token: 0x060311F4 RID: 201204 RVA: 0x00B65165 File Offset: 0x00B63365
		public SelectPhotoStickerItemComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311F5 RID: 201205 RVA: 0x00B6516E File Offset: 0x00B6336E
		protected override void OnPress(HotKeyMap config)
		{
			PhotographController.Instance.RequestSelectSticker();
		}

		// Token: 0x060311F6 RID: 201206 RVA: 0x00B6517C File Offset: 0x00B6337C
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			PhotoJoystickOwnerController currentJoystickOwner = PhotographController.Instance.CurrentJoystickOwner;
			bool flag = currentJoystickOwner != null && currentJoystickOwner.Current == EPhotoJoystickOwner.Sticker;
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, !flag, false);
		}
	}
}
