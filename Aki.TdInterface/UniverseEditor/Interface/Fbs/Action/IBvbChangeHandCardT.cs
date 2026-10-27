using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200623D RID: 25149
	public class IBvbChangeHandCardT
	{
		// Token: 0x1700BB69 RID: 47977
		// (get) Token: 0x0602B5BE RID: 177598 RVA: 0x005F830A File Offset: 0x005F650A
		// (set) Token: 0x0602B5BF RID: 177599 RVA: 0x005F8312 File Offset: 0x005F6512
		public EBvbPlayerOperationType Type { get; set; }

		// Token: 0x1700BB6A RID: 47978
		// (get) Token: 0x0602B5C0 RID: 177600 RVA: 0x005F831B File Offset: 0x005F651B
		// (set) Token: 0x0602B5C1 RID: 177601 RVA: 0x005F8323 File Offset: 0x005F6523
		public int HandCardIndex { get; set; }

		// Token: 0x1700BB6B RID: 47979
		// (get) Token: 0x0602B5C2 RID: 177602 RVA: 0x005F832C File Offset: 0x005F652C
		// (set) Token: 0x0602B5C3 RID: 177603 RVA: 0x005F8334 File Offset: 0x005F6534
		public byte NullMask { get; set; }

		// Token: 0x0602B5C4 RID: 177604 RVA: 0x005F833D File Offset: 0x005F653D
		public IBvbChangeHandCardT()
		{
			this.Type = EBvbPlayerOperationType.BvbDeploy;
			this.HandCardIndex = 0;
			this.NullMask = 0;
		}
	}
}
