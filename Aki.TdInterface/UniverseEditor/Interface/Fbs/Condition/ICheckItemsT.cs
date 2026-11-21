using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F7B RID: 20347
	public class ICheckItemsT
	{
		// Token: 0x1700917C RID: 37244
		// (get) Token: 0x0601FAF5 RID: 129781 RVA: 0x00467AED File Offset: 0x00465CED
		// (set) Token: 0x0601FAF6 RID: 129782 RVA: 0x00467AF5 File Offset: 0x00465CF5
		public ECondition Type { get; set; }

		// Token: 0x1700917D RID: 37245
		// (get) Token: 0x0601FAF7 RID: 129783 RVA: 0x00467AFE File Offset: 0x00465CFE
		// (set) Token: 0x0601FAF8 RID: 129784 RVA: 0x00467B06 File Offset: 0x00465D06
		public ECompare Compare { get; set; }

		// Token: 0x1700917E RID: 37246
		// (get) Token: 0x0601FAF9 RID: 129785 RVA: 0x00467B0F File Offset: 0x00465D0F
		// (set) Token: 0x0601FAFA RID: 129786 RVA: 0x00467B17 File Offset: 0x00465D17
		public List<IItemConfigT> Items { get; set; }

		// Token: 0x0601FAFB RID: 129787 RVA: 0x00467B20 File Offset: 0x00465D20
		public ICheckItemsT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
			this.Items = null;
		}
	}
}
