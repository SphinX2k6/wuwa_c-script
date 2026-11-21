using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003905 RID: 14597
	public class MapZoomComponent : MapInteractComponentBase
	{
		// Token: 0x06025C44 RID: 154692 RVA: 0x00A9E41C File Offset: 0x00A9C61C
		public MapZoomComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C45 RID: 154693 RVA: 0x00A9E425 File Offset: 0x00A9C625
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			EventSystem.Instance.Emit<string, float>(EEventName.NavigationTriggerMapZoom, axisName, value);
		}
	}
}
