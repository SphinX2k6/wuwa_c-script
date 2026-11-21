using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02004AE2 RID: 19170
	[NullableContext(1)]
	public interface IMachiningData : ICookItemData
	{
		// Token: 0x1700603A RID: 24634
		// (get) Token: 0x0602FF51 RID: 196433
		// (set) Token: 0x0602FF52 RID: 196434
		List<int> InteractiveList { get; set; }

		// Token: 0x1700603B RID: 24635
		// (get) Token: 0x0602FF53 RID: 196435
		// (set) Token: 0x0602FF54 RID: 196436
		List<int> UnlockList { get; set; }

		// Token: 0x1700603C RID: 24636
		// (get) Token: 0x0602FF55 RID: 196437
		// (set) Token: 0x0602FF56 RID: 196438
		int IsMachining { get; set; }
	}
}
