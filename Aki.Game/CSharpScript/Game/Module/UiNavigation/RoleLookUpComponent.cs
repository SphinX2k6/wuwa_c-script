using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049BC RID: 18876
	public class RoleLookUpComponent : RoleInteractComponentBase
	{
		// Token: 0x060311C0 RID: 201152 RVA: 0x00B64C8D File Offset: 0x00B62E8D
		public RoleLookUpComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311C1 RID: 201153 RVA: 0x00B64C96 File Offset: 0x00B62E96
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			EventSystem.Instance.Emit<float>(EEventName.NavigationTriggerRoleLookUp, value);
		}
	}
}
