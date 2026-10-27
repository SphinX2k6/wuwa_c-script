using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049D2 RID: 18898
	public class ShowOnlyComponent : HotKeyComponent
	{
		// Token: 0x06031202 RID: 201218 RVA: 0x00B65427 File Offset: 0x00B63627
		public ShowOnlyComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031203 RID: 201219 RVA: 0x00B65430 File Offset: 0x00B63630
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x06031204 RID: 201220 RVA: 0x00B6543B File Offset: 0x00B6363B
		protected override bool OnIsOccupancyFightInput()
		{
			return false;
		}
	}
}
