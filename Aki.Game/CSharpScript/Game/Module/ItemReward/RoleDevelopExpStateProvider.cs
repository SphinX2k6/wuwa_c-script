using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047C0 RID: 18368
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleDevelopExpStateProvider : IRoleDevelopExpStateProvider
	{
		// Token: 0x17005DCF RID: 24015
		// (get) Token: 0x0602E250 RID: 189008 RVA: 0x00CDFD54 File Offset: 0x00CDDF54
		// (set) Token: 0x0602E251 RID: 189009 RVA: 0x00CDFD5C File Offset: 0x00CDDF5C
		public Func<int, EItemRequirementState?> GetExpItemRequirementState { get; set; }
	}
}
