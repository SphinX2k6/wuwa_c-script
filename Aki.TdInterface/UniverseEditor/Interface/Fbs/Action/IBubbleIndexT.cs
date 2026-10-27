using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006231 RID: 25137
	public class IBubbleIndexT
	{
		// Token: 0x1700BB4E RID: 47950
		// (get) Token: 0x0602B550 RID: 177488 RVA: 0x005F7703 File Offset: 0x005F5903
		// (set) Token: 0x0602B551 RID: 177489 RVA: 0x005F770B File Offset: 0x005F590B
		public string FlowListName { get; set; }

		// Token: 0x1700BB4F RID: 47951
		// (get) Token: 0x0602B552 RID: 177490 RVA: 0x005F7714 File Offset: 0x005F5914
		// (set) Token: 0x0602B553 RID: 177491 RVA: 0x005F771C File Offset: 0x005F591C
		public int FlowId { get; set; }

		// Token: 0x1700BB50 RID: 47952
		// (get) Token: 0x0602B554 RID: 177492 RVA: 0x005F7725 File Offset: 0x005F5925
		// (set) Token: 0x0602B555 RID: 177493 RVA: 0x005F772D File Offset: 0x005F592D
		public int StateId { get; set; }

		// Token: 0x1700BB51 RID: 47953
		// (get) Token: 0x0602B556 RID: 177494 RVA: 0x005F7736 File Offset: 0x005F5936
		// (set) Token: 0x0602B557 RID: 177495 RVA: 0x005F773E File Offset: 0x005F593E
		public byte NullMask { get; set; }

		// Token: 0x0602B558 RID: 177496 RVA: 0x005F7747 File Offset: 0x005F5947
		public IBubbleIndexT()
		{
			this.FlowListName = null;
			this.FlowId = 0;
			this.StateId = 0;
			this.NullMask = 0;
		}
	}
}
