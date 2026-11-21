using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E82 RID: 20098
	public class ICheckDataLayerConditionT
	{
		// Token: 0x17008F54 RID: 36692
		// (get) Token: 0x0601F21D RID: 127517 RVA: 0x00457C2A File Offset: 0x00455E2A
		// (set) Token: 0x0601F21E RID: 127518 RVA: 0x00457C32 File Offset: 0x00455E32
		public int DataLayerId { get; set; }

		// Token: 0x17008F55 RID: 36693
		// (get) Token: 0x0601F21F RID: 127519 RVA: 0x00457C3B File Offset: 0x00455E3B
		// (set) Token: 0x0601F220 RID: 127520 RVA: 0x00457C43 File Offset: 0x00455E43
		public bool IsLoad { get; set; }

		// Token: 0x17008F56 RID: 36694
		// (get) Token: 0x0601F221 RID: 127521 RVA: 0x00457C4C File Offset: 0x00455E4C
		// (set) Token: 0x0601F222 RID: 127522 RVA: 0x00457C54 File Offset: 0x00455E54
		public ECondition Type { get; set; }

		// Token: 0x0601F223 RID: 127523 RVA: 0x00457C5D File Offset: 0x00455E5D
		public ICheckDataLayerConditionT()
		{
			this.DataLayerId = 0;
			this.IsLoad = false;
			this.Type = ECondition.CompareVar;
		}
	}
}
