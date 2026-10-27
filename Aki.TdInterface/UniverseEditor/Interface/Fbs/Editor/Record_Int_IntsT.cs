using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048D8 RID: 18648
	public class Record_Int_IntsT
	{
		// Token: 0x17008762 RID: 34658
		// (get) Token: 0x0601D2AA RID: 119466 RVA: 0x0041DF43 File Offset: 0x0041C143
		// (set) Token: 0x0601D2AB RID: 119467 RVA: 0x0041DF4B File Offset: 0x0041C14B
		public int Key { get; set; }

		// Token: 0x17008763 RID: 34659
		// (get) Token: 0x0601D2AC RID: 119468 RVA: 0x0041DF54 File Offset: 0x0041C154
		// (set) Token: 0x0601D2AD RID: 119469 RVA: 0x0041DF5C File Offset: 0x0041C15C
		public List<int> Values { get; set; }

		// Token: 0x0601D2AE RID: 119470 RVA: 0x0041DF65 File Offset: 0x0041C165
		public Record_Int_IntsT()
		{
			this.Key = 0;
			this.Values = null;
		}
	}
}
