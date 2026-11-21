using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003901 RID: 14593
	[NullableContext(1)]
	[Nullable(0)]
	public class MapDragRightComponent : HotKeyComponent
	{
		// Token: 0x06025C37 RID: 154679 RVA: 0x00A9E1D9 File Offset: 0x00A9C3D9
		public MapDragRightComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C38 RID: 154680 RVA: 0x00A9E1E2 File Offset: 0x00A9C3E2
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			viewHandle.GetFocusListener();
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x06025C39 RID: 154681 RVA: 0x00A9E1F4 File Offset: 0x00A9C3F4
		protected override void OnInputAxis(string axisName, float value)
		{
			if (value == 0f)
			{
				return;
			}
			EventSystem.Instance.Emit<float>(EEventName.MapDragMoveRight, value);
		}
	}
}
