using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02005B01 RID: 23297
	[NullableContext(1)]
	public interface IMachiningData : ICookItemData
	{
		// Token: 0x17008C60 RID: 35936
		// (get) Token: 0x0603AFDF RID: 241631
		// (set) Token: 0x0603AFE0 RID: 241632
		List<int> InteractiveList { get; set; }

		// Token: 0x17008C61 RID: 35937
		// (get) Token: 0x0603AFE1 RID: 241633
		// (set) Token: 0x0603AFE2 RID: 241634
		List<int> UnlockList { get; set; }

		// Token: 0x17008C62 RID: 35938
		// (get) Token: 0x0603AFE3 RID: 241635
		// (set) Token: 0x0603AFE4 RID: 241636
		int IsMachining { get; set; }
	}
}
