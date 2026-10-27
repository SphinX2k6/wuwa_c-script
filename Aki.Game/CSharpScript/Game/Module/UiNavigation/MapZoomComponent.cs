using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200498B RID: 18827
	public class MapZoomComponent : MapInteractComponentBase
	{
		// Token: 0x0603110E RID: 200974 RVA: 0x00B634CC File Offset: 0x00B616CC
		public MapZoomComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603110F RID: 200975 RVA: 0x00B634D5 File Offset: 0x00B616D5
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			EventSystem.Instance.Emit<string, float>(EEventName.NavigationTriggerMapZoom, axisName, value);
		}
	}
}
