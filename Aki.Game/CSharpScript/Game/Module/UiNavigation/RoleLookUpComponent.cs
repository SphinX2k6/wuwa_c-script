using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003936 RID: 14646
	public class RoleLookUpComponent : RoleInteractComponentBase
	{
		// Token: 0x06025CF6 RID: 154870 RVA: 0x00A9FBDD File Offset: 0x00A9DDDD
		public RoleLookUpComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025CF7 RID: 154871 RVA: 0x00A9FBE6 File Offset: 0x00A9DDE6
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			EventSystem.Instance.Emit<float>(EEventName.NavigationTriggerRoleLookUp, value);
		}
	}
}
