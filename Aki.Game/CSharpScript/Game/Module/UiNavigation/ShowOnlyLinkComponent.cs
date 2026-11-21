using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200394D RID: 14669
	public class ShowOnlyLinkComponent : HotKeyComponent
	{
		// Token: 0x06025D3B RID: 154939 RVA: 0x00AA038E File Offset: 0x00A9E58E
		public ShowOnlyLinkComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D3C RID: 154940 RVA: 0x00AA0398 File Offset: 0x00A9E598
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			TsUiNavigationBehaviorListener focusListener = viewHandle.GetFocusListener();
			if (focusListener == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, base.IsLinkListener(focusListener.GetOwner()), false);
		}

		// Token: 0x06025D3D RID: 154941 RVA: 0x00AA03CD File Offset: 0x00A9E5CD
		protected override bool OnIsOccupancyFightInput()
		{
			return false;
		}
	}
}
