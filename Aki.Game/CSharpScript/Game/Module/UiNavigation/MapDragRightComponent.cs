using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004987 RID: 18823
	[NullableContext(1)]
	[Nullable(0)]
	public class MapDragRightComponent : HotKeyComponent
	{
		// Token: 0x06031101 RID: 200961 RVA: 0x00B63289 File Offset: 0x00B61489
		public MapDragRightComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031102 RID: 200962 RVA: 0x00B63292 File Offset: 0x00B61492
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			viewHandle.GetFocusListener();
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x06031103 RID: 200963 RVA: 0x00B632A4 File Offset: 0x00B614A4
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
