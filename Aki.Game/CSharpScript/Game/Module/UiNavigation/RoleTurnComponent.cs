using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049BD RID: 18877
	public class RoleTurnComponent : RoleInteractComponentBase
	{
		// Token: 0x060311C2 RID: 201154 RVA: 0x00B64CA9 File Offset: 0x00B62EA9
		public RoleTurnComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311C3 RID: 201155 RVA: 0x00B64CB2 File Offset: 0x00B62EB2
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			EventSystem.Instance.Emit<float>(EEventName.NavigationTriggerRoleTurn, value);
		}
	}
}
