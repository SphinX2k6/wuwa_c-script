using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004974 RID: 18804
	public class HonamiStoryMoveLeftComponent : HonamiStoryComponentBase
	{
		// Token: 0x0603106B RID: 200811 RVA: 0x00B61AD4 File Offset: 0x00B5FCD4
		public HonamiStoryMoveLeftComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603106C RID: 200812 RVA: 0x00B61ADD File Offset: 0x00B5FCDD
		protected override void OnPress(HotKeyMap config)
		{
			if (base.Logic == null)
			{
				return;
			}
			base.Logic.JumpToPrevPanelNew();
		}

		// Token: 0x0603106D RID: 200813 RVA: 0x00B61AF3 File Offset: 0x00B5FCF3
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			if (base.Logic == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
