using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038F2 RID: 14578
	public class HonamiStoryLookComponent : ClickBtnInsideReleaseComponent
	{
		// Token: 0x06025BAD RID: 154541 RVA: 0x00A9CC6D File Offset: 0x00A9AE6D
		public HonamiStoryLookComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025BAE RID: 154542 RVA: 0x00A9CC78 File Offset: 0x00A9AE78
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			HonamiStoryGamepadLogicController gamepadLogic = HonamiStoryModel.Instance.GetGamepadLogic();
			if (gamepadLogic == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, gamepadLogic.GetSelectItem() == null, false);
		}
	}
}
