using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02004713 RID: 18195
	[NullableContext(1)]
	public interface IWuWaGoMovableFloorBatchResult
	{
		// Token: 0x170076E7 RID: 30439
		// (get) Token: 0x0602F8CB RID: 194763
		bool Committed { get; }

		// Token: 0x170076E8 RID: 30440
		// (get) Token: 0x0602F8CC RID: 194764
		IReadOnlyList<int> MovedRoleIds { get; }
	}
}
