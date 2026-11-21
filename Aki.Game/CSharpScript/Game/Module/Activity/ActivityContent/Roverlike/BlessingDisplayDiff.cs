using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050C3 RID: 20675
	[NullableContext(1)]
	[Nullable(0)]
	public class BlessingDisplayDiff : IBlessingDisplayDiff
	{
		// Token: 0x170064FD RID: 25853
		// (get) Token: 0x06033BDF RID: 211935 RVA: 0x00E7B6A2 File Offset: 0x00E798A2
		// (set) Token: 0x06033BE0 RID: 211936 RVA: 0x00E7B6AA File Offset: 0x00E798AA
		public List<IRoverlikeBlessingSlotItemData> DataList { get; set; }

		// Token: 0x170064FE RID: 25854
		// (get) Token: 0x06033BE1 RID: 211937 RVA: 0x00E7B6B3 File Offset: 0x00E798B3
		// (set) Token: 0x06033BE2 RID: 211938 RVA: 0x00E7B6BB File Offset: 0x00E798BB
		public List<int> ChangedSlots { get; set; }

		// Token: 0x170064FF RID: 25855
		// (get) Token: 0x06033BE3 RID: 211939 RVA: 0x00E7B6C4 File Offset: 0x00E798C4
		// (set) Token: 0x06033BE4 RID: 211940 RVA: 0x00E7B6CC File Offset: 0x00E798CC
		public int Count { get; set; }
	}
}
