using System;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003939 RID: 14649
	public class RoleResetComponent : RoleInteractComponentBase
	{
		// Token: 0x06025CFC RID: 154876 RVA: 0x00A9FC32 File Offset: 0x00A9DE32
		public RoleResetComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025CFD RID: 154877 RVA: 0x00A9FC3B File Offset: 0x00A9DE3B
		protected override void OnPress(HotKeyMap config)
		{
			EventSystem.Instance.Emit(EEventName.NavigationTriggerRoleReset);
		}
	}
}
