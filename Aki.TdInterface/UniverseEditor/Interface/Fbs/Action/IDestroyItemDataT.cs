using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BFA RID: 27642
	public class IDestroyItemDataT
	{
		// Token: 0x1700CAAA RID: 51882
		// (get) Token: 0x0602F92C RID: 194860 RVA: 0x0067BEA2 File Offset: 0x0067A0A2
		// (set) Token: 0x0602F92D RID: 194861 RVA: 0x0067BEAA File Offset: 0x0067A0AA
		public int ItemId { get; set; }

		// Token: 0x1700CAAB RID: 51883
		// (get) Token: 0x0602F92E RID: 194862 RVA: 0x0067BEB3 File Offset: 0x0067A0B3
		// (set) Token: 0x0602F92F RID: 194863 RVA: 0x0067BEBB File Offset: 0x0067A0BB
		public int Count { get; set; }

		// Token: 0x1700CAAC RID: 51884
		// (get) Token: 0x0602F930 RID: 194864 RVA: 0x0067BEC4 File Offset: 0x0067A0C4
		// (set) Token: 0x0602F931 RID: 194865 RVA: 0x0067BECC File Offset: 0x0067A0CC
		public bool IsAll { get; set; }

		// Token: 0x0602F932 RID: 194866 RVA: 0x0067BED5 File Offset: 0x0067A0D5
		public IDestroyItemDataT()
		{
			this.ItemId = 0;
			this.Count = 0;
			this.IsAll = false;
		}
	}
}
