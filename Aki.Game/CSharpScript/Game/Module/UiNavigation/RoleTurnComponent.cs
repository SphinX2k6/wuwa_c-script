using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003937 RID: 14647
	public class RoleTurnComponent : RoleInteractComponentBase
	{
		// Token: 0x06025CF8 RID: 154872 RVA: 0x00A9FBF9 File Offset: 0x00A9DDF9
		public RoleTurnComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025CF9 RID: 154873 RVA: 0x00A9FC02 File Offset: 0x00A9DE02
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			EventSystem.Instance.Emit<float>(EEventName.NavigationTriggerRoleTurn, value);
		}
	}
}
