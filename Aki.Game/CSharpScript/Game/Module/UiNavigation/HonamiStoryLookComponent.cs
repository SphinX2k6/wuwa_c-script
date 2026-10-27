using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200497A RID: 18810
	public class HonamiStoryLookComponent : ClickBtnInsideReleaseComponent
	{
		// Token: 0x0603107D RID: 200829 RVA: 0x00B61D8D File Offset: 0x00B5FF8D
		public HonamiStoryLookComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603107E RID: 200830 RVA: 0x00B61D98 File Offset: 0x00B5FF98
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
