using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057E9 RID: 22505
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleDevelopExpStateProvider : IRoleDevelopExpStateProvider
	{
		// Token: 0x17008A05 RID: 35333
		// (get) Token: 0x0603933C RID: 234300 RVA: 0x00D90F0C File Offset: 0x00D8F10C
		// (set) Token: 0x0603933D RID: 234301 RVA: 0x00D90F14 File Offset: 0x00D8F114
		public Func<int, EItemRequirementState?> GetExpItemRequirementState { get; set; }
	}
}
