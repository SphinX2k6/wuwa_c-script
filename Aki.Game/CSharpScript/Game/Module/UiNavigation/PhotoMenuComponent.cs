using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049B0 RID: 18864
	public class PhotoMenuComponent : HotKeyComponent
	{
		// Token: 0x06031192 RID: 201106 RVA: 0x00B6474D File Offset: 0x00B6294D
		public PhotoMenuComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031193 RID: 201107 RVA: 0x00B64756 File Offset: 0x00B62956
		protected override void OnPress(HotKeyMap config)
		{
			PhotographController.Instance.RequestOpenLastDetailPanel();
		}

		// Token: 0x06031194 RID: 201108 RVA: 0x00B64762 File Offset: 0x00B62962
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
