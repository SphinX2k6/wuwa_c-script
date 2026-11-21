using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003900 RID: 14592
	[NullableContext(1)]
	[Nullable(0)]
	public class MapDragForwardComponent : HotKeyComponent
	{
		// Token: 0x06025C34 RID: 154676 RVA: 0x00A9E1A2 File Offset: 0x00A9C3A2
		public MapDragForwardComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C35 RID: 154677 RVA: 0x00A9E1AB File Offset: 0x00A9C3AB
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			viewHandle.GetFocusListener();
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x06025C36 RID: 154678 RVA: 0x00A9E1BD File Offset: 0x00A9C3BD
		protected override void OnInputAxis(string axisName, float value)
		{
			if (value == 0f)
			{
				return;
			}
			EventSystem.Instance.Emit<float>(EEventName.MapDragMoveForward, value);
		}
	}
}
