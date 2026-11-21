using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiNavigation;

namespace Aki.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x02002F97 RID: 12183
	public class TetrisRotateComponent : HotKeyComponent
	{
		// Token: 0x0601CE4F RID: 118351 RVA: 0x008D415D File Offset: 0x008D235D
		public TetrisRotateComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0601CE50 RID: 118352 RVA: 0x008D4166 File Offset: 0x008D2366
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x0601CE51 RID: 118353 RVA: 0x008D4171 File Offset: 0x008D2371
		protected override void OnPress(HotKeyMap config)
		{
			EventSystem.Instance.Emit(EEventName.TetrisRotate);
		}
	}
}
