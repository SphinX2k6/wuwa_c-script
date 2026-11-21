using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E2E RID: 32302
	public class Record_Int_IFlowTextConfigT
	{
		// Token: 0x1700F1E1 RID: 61921
		// (get) Token: 0x0603A5EF RID: 239087 RVA: 0x007DC81F File Offset: 0x007DAA1F
		// (set) Token: 0x0603A5F0 RID: 239088 RVA: 0x007DC827 File Offset: 0x007DAA27
		public int Key { get; set; }

		// Token: 0x1700F1E2 RID: 61922
		// (get) Token: 0x0603A5F1 RID: 239089 RVA: 0x007DC830 File Offset: 0x007DAA30
		// (set) Token: 0x0603A5F2 RID: 239090 RVA: 0x007DC838 File Offset: 0x007DAA38
		public IFlowTextConfigT Value { get; set; }

		// Token: 0x0603A5F3 RID: 239091 RVA: 0x007DC841 File Offset: 0x007DAA41
		public Record_Int_IFlowTextConfigT()
		{
			this.Key = 0;
			this.Value = null;
		}
	}
}
