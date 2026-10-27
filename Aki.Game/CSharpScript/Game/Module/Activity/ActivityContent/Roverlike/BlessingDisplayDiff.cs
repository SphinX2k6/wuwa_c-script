using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006145 RID: 24901
	[NullableContext(1)]
	[Nullable(0)]
	public class BlessingDisplayDiff : IBlessingDisplayDiff
	{
		// Token: 0x1700919B RID: 37275
		// (get) Token: 0x0603EF1F RID: 257823 RVA: 0x00F347C2 File Offset: 0x00F329C2
		// (set) Token: 0x0603EF20 RID: 257824 RVA: 0x00F347CA File Offset: 0x00F329CA
		public List<IRoverlikeBlessingSlotItemData> DataList { get; set; }

		// Token: 0x1700919C RID: 37276
		// (get) Token: 0x0603EF21 RID: 257825 RVA: 0x00F347D3 File Offset: 0x00F329D3
		// (set) Token: 0x0603EF22 RID: 257826 RVA: 0x00F347DB File Offset: 0x00F329DB
		public List<int> ChangedSlots { get; set; }

		// Token: 0x1700919D RID: 37277
		// (get) Token: 0x0603EF23 RID: 257827 RVA: 0x00F347E4 File Offset: 0x00F329E4
		// (set) Token: 0x0603EF24 RID: 257828 RVA: 0x00F347EC File Offset: 0x00F329EC
		public int Count { get; set; }
	}
}
