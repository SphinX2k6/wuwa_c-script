using System;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049BF RID: 18879
	public class RoleResetComponent : RoleInteractComponentBase
	{
		// Token: 0x060311C6 RID: 201158 RVA: 0x00B64CE2 File Offset: 0x00B62EE2
		public RoleResetComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311C7 RID: 201159 RVA: 0x00B64CEB File Offset: 0x00B62EEB
		protected override void OnPress(HotKeyMap config)
		{
			EventSystem.Instance.Emit(EEventName.NavigationTriggerRoleReset);
		}
	}
}
