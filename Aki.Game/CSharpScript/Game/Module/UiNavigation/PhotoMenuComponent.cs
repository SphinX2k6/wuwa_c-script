using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200392A RID: 14634
	public class PhotoMenuComponent : HotKeyComponent
	{
		// Token: 0x06025CC8 RID: 154824 RVA: 0x00A9F69D File Offset: 0x00A9D89D
		public PhotoMenuComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025CC9 RID: 154825 RVA: 0x00A9F6A6 File Offset: 0x00A9D8A6
		protected override void OnPress(HotKeyMap config)
		{
			PhotographController.Instance.RequestOpenLastDetailPanel();
		}

		// Token: 0x06025CCA RID: 154826 RVA: 0x00A9F6B2 File Offset: 0x00A9D8B2
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
