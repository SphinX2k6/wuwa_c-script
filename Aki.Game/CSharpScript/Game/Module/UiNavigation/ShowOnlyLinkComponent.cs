using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049D3 RID: 18899
	public class ShowOnlyLinkComponent : HotKeyComponent
	{
		// Token: 0x06031205 RID: 201221 RVA: 0x00B6543E File Offset: 0x00B6363E
		public ShowOnlyLinkComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031206 RID: 201222 RVA: 0x00B65448 File Offset: 0x00B63648
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

		// Token: 0x06031207 RID: 201223 RVA: 0x00B6547D File Offset: 0x00B6367D
		protected override bool OnIsOccupancyFightInput()
		{
			return false;
		}
	}
}
