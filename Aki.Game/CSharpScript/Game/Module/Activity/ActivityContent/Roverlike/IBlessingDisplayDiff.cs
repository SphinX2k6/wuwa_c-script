using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006144 RID: 24900
	[NullableContext(1)]
	public interface IBlessingDisplayDiff
	{
		// Token: 0x17009198 RID: 37272
		// (get) Token: 0x0603EF19 RID: 257817
		// (set) Token: 0x0603EF1A RID: 257818
		List<IRoverlikeBlessingSlotItemData> DataList { get; set; }

		// Token: 0x17009199 RID: 37273
		// (get) Token: 0x0603EF1B RID: 257819
		// (set) Token: 0x0603EF1C RID: 257820
		List<int> ChangedSlots { get; set; }

		// Token: 0x1700919A RID: 37274
		// (get) Token: 0x0603EF1D RID: 257821
		// (set) Token: 0x0603EF1E RID: 257822
		int Count { get; set; }
	}
}
