using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004986 RID: 18822
	[NullableContext(1)]
	[Nullable(0)]
	public class MapDragForwardComponent : HotKeyComponent
	{
		// Token: 0x060310FE RID: 200958 RVA: 0x00B63252 File Offset: 0x00B61452
		public MapDragForwardComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060310FF RID: 200959 RVA: 0x00B6325B File Offset: 0x00B6145B
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			viewHandle.GetFocusListener();
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x06031100 RID: 200960 RVA: 0x00B6326D File Offset: 0x00B6146D
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
