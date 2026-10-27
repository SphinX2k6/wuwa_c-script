using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057E8 RID: 22504
	[NullableContext(2)]
	public interface IRoleDevelopExpStateProvider
	{
		// Token: 0x17008A04 RID: 35332
		// (get) Token: 0x0603933A RID: 234298
		// (set) Token: 0x0603933B RID: 234299
		Func<int, EItemRequirementState?> GetExpItemRequirementState { get; set; }
	}
}
