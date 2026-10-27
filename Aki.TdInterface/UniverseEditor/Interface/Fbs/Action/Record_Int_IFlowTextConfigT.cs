using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007620 RID: 30240
	public class Record_Int_IFlowTextConfigT
	{
		// Token: 0x1700E5A3 RID: 58787
		// (get) Token: 0x0603714A RID: 225610 RVA: 0x00778723 File Offset: 0x00776923
		// (set) Token: 0x0603714B RID: 225611 RVA: 0x0077872B File Offset: 0x0077692B
		public int Key { get; set; }

		// Token: 0x1700E5A4 RID: 58788
		// (get) Token: 0x0603714C RID: 225612 RVA: 0x00778734 File Offset: 0x00776934
		// (set) Token: 0x0603714D RID: 225613 RVA: 0x0077873C File Offset: 0x0077693C
		public IFlowTextConfigT Value { get; set; }

		// Token: 0x0603714E RID: 225614 RVA: 0x00778745 File Offset: 0x00776945
		public Record_Int_IFlowTextConfigT()
		{
			this.Key = 0;
			this.Value = null;
		}
	}
}
