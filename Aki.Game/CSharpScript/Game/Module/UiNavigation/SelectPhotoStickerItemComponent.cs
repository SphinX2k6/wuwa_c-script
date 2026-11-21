using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003949 RID: 14665
	public class SelectPhotoStickerItemComponent : HotKeyComponent
	{
		// Token: 0x06025D2A RID: 154922 RVA: 0x00AA00B5 File Offset: 0x00A9E2B5
		public SelectPhotoStickerItemComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D2B RID: 154923 RVA: 0x00AA00BE File Offset: 0x00A9E2BE
		protected override void OnPress(HotKeyMap config)
		{
			PhotographController.Instance.RequestSelectSticker();
		}

		// Token: 0x06025D2C RID: 154924 RVA: 0x00AA00CC File Offset: 0x00A9E2CC
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			PhotoJoystickOwnerController currentJoystickOwner = PhotographController.Instance.CurrentJoystickOwner;
			bool flag = currentJoystickOwner != null && currentJoystickOwner.Current == EPhotoJoystickOwner.Sticker;
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, !flag, false);
		}
	}
}
