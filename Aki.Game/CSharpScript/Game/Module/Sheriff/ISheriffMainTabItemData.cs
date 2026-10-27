using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C3C RID: 19516
	[NullableContext(1)]
	public interface ISheriffMainTabItemData
	{
		// Token: 0x17007CA8 RID: 31912
		// (get) Token: 0x060327BF RID: 206783
		// (set) Token: 0x060327C0 RID: 206784
		ESheriffMainTabType TabType { get; set; }

		// Token: 0x17007CA9 RID: 31913
		// (get) Token: 0x060327C1 RID: 206785
		// (set) Token: 0x060327C2 RID: 206786
		string TabIcon { get; set; }

		// Token: 0x17007CAA RID: 31914
		// (get) Token: 0x060327C3 RID: 206787
		// (set) Token: 0x060327C4 RID: 206788
		string TabTxt { get; set; }

		// Token: 0x17007CAB RID: 31915
		// (get) Token: 0x060327C5 RID: 206789
		// (set) Token: 0x060327C6 RID: 206790
		bool? IsLock { get; set; }

		// Token: 0x17007CAC RID: 31916
		// (get) Token: 0x060327C7 RID: 206791
		// (set) Token: 0x060327C8 RID: 206792
		EFunctionType FunctionType { get; set; }
	}
}
