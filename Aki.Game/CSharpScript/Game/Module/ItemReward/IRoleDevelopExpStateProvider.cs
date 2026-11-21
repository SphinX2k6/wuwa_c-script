using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047BF RID: 18367
	[NullableContext(2)]
	public interface IRoleDevelopExpStateProvider
	{
		// Token: 0x17005DCE RID: 24014
		// (get) Token: 0x0602E24E RID: 189006
		// (set) Token: 0x0602E24F RID: 189007
		Func<int, EItemRequirementState?> GetExpItemRequirementState { get; set; }
	}
}
