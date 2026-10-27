using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C4A RID: 19530
	public class IItemConfigT
	{
		// Token: 0x17008DE4 RID: 36324
		// (get) Token: 0x0601EF63 RID: 126819 RVA: 0x00454C5C File Offset: 0x00452E5C
		// (set) Token: 0x0601EF64 RID: 126820 RVA: 0x00454C64 File Offset: 0x00452E64
		public int ItemId { get; set; }

		// Token: 0x17008DE5 RID: 36325
		// (get) Token: 0x0601EF65 RID: 126821 RVA: 0x00454C6D File Offset: 0x00452E6D
		// (set) Token: 0x0601EF66 RID: 126822 RVA: 0x00454C75 File Offset: 0x00452E75
		public int Count { get; set; }

		// Token: 0x0601EF67 RID: 126823 RVA: 0x00454C7E File Offset: 0x00452E7E
		public IItemConfigT()
		{
			this.ItemId = 0;
			this.Count = 0;
		}
	}
}
