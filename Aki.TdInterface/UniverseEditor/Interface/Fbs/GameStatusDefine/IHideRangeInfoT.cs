using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B60 RID: 19296
	public class IHideRangeInfoT
	{
		// Token: 0x17008826 RID: 34854
		// (get) Token: 0x0601D4F8 RID: 120056 RVA: 0x0041DA7D File Offset: 0x0041BC7D
		// (set) Token: 0x0601D4F9 RID: 120057 RVA: 0x0041DA85 File Offset: 0x0041BC85
		public string Path { get; set; }

		// Token: 0x17008827 RID: 34855
		// (get) Token: 0x0601D4FA RID: 120058 RVA: 0x0041DA8E File Offset: 0x0041BC8E
		// (set) Token: 0x0601D4FB RID: 120059 RVA: 0x0041DA96 File Offset: 0x0041BC96
		public List<int> HideRangeEntities { get; set; }

		// Token: 0x17008828 RID: 34856
		// (get) Token: 0x0601D4FC RID: 120060 RVA: 0x0041DA9F File Offset: 0x0041BC9F
		// (set) Token: 0x0601D4FD RID: 120061 RVA: 0x0041DAA7 File Offset: 0x0041BCA7
		public List<int> HideRangeLevelPlay { get; set; }

		// Token: 0x17008829 RID: 34857
		// (get) Token: 0x0601D4FE RID: 120062 RVA: 0x0041DAB0 File Offset: 0x0041BCB0
		// (set) Token: 0x0601D4FF RID: 120063 RVA: 0x0041DAB8 File Offset: 0x0041BCB8
		public List<int> ShowRangeEntities { get; set; }

		// Token: 0x1700882A RID: 34858
		// (get) Token: 0x0601D500 RID: 120064 RVA: 0x0041DAC1 File Offset: 0x0041BCC1
		// (set) Token: 0x0601D501 RID: 120065 RVA: 0x0041DAC9 File Offset: 0x0041BCC9
		public List<int> ShowRangeLevelPlay { get; set; }

		// Token: 0x0601D502 RID: 120066 RVA: 0x0041DAD2 File Offset: 0x0041BCD2
		public IHideRangeInfoT()
		{
			this.Path = null;
			this.HideRangeEntities = null;
			this.HideRangeLevelPlay = null;
			this.ShowRangeEntities = null;
			this.ShowRangeLevelPlay = null;
		}
	}
}
