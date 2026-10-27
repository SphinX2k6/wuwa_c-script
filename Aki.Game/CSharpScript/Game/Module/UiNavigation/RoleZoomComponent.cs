using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049BE RID: 18878
	public class RoleZoomComponent : RoleInteractComponentBase
	{
		// Token: 0x060311C4 RID: 201156 RVA: 0x00B64CC5 File Offset: 0x00B62EC5
		public RoleZoomComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311C5 RID: 201157 RVA: 0x00B64CCE File Offset: 0x00B62ECE
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			EventSystem.Instance.Emit<string, float>(EEventName.NavigationTriggerRoleZoom, axisName, value);
		}
	}
}
