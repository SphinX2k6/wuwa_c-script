using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F80 RID: 20352
	[NullableContext(1)]
	public interface IQuickHackOnScreenTargetInfo
	{
		// Token: 0x17007F59 RID: 32601
		// (get) Token: 0x060341DF RID: 213471
		// (set) Token: 0x060341E0 RID: 213472
		Dictionary<int, int> TargetIdToIndexMap { get; set; }

		// Token: 0x17007F5A RID: 32602
		// (get) Token: 0x060341E1 RID: 213473
		// (set) Token: 0x060341E2 RID: 213474
		List<EntityHandle> Targets { get; set; }

		// Token: 0x17007F5B RID: 32603
		// (get) Token: 0x060341E3 RID: 213475
		// (set) Token: 0x060341E4 RID: 213476
		List<double> SignedScreenDistSquaredList { get; set; }

		// Token: 0x17007F5C RID: 32604
		// (get) Token: 0x060341E5 RID: 213477
		// (set) Token: 0x060341E6 RID: 213478
		List<double> DistSquaredList { get; set; }
	}
}
