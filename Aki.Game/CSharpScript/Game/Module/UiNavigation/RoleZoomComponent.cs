using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003938 RID: 14648
	public class RoleZoomComponent : RoleInteractComponentBase
	{
		// Token: 0x06025CFA RID: 154874 RVA: 0x00A9FC15 File Offset: 0x00A9DE15
		public RoleZoomComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025CFB RID: 154875 RVA: 0x00A9FC1E File Offset: 0x00A9DE1E
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			EventSystem.Instance.Emit<string, float>(EEventName.NavigationTriggerRoleZoom, axisName, value);
		}
	}
}
