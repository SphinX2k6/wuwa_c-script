using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007359 RID: 29529
	public class ITalkSequenceTransitionT
	{
		// Token: 0x1700E042 RID: 57410
		// (get) Token: 0x06035992 RID: 219538 RVA: 0x0074CCF0 File Offset: 0x0074AEF0
		// (set) Token: 0x06035993 RID: 219539 RVA: 0x0074CCF8 File Offset: 0x0074AEF8
		public string OptionText { get; set; }

		// Token: 0x1700E043 RID: 57411
		// (get) Token: 0x06035994 RID: 219540 RVA: 0x0074CD01 File Offset: 0x0074AF01
		// (set) Token: 0x06035995 RID: 219541 RVA: 0x0074CD09 File Offset: 0x0074AF09
		public string OptionTextKey { get; set; }

		// Token: 0x1700E044 RID: 57412
		// (get) Token: 0x06035996 RID: 219542 RVA: 0x0074CD12 File Offset: 0x0074AF12
		// (set) Token: 0x06035997 RID: 219543 RVA: 0x0074CD1A File Offset: 0x0074AF1A
		public int NextSequenceIndex { get; set; }

		// Token: 0x06035998 RID: 219544 RVA: 0x0074CD23 File Offset: 0x0074AF23
		public ITalkSequenceTransitionT()
		{
			this.OptionText = null;
			this.OptionTextKey = null;
			this.NextSequenceIndex = 0;
		}
	}
}
