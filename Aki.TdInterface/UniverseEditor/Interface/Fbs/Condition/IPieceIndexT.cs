using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C80 RID: 19584
	public class IPieceIndexT
	{
		// Token: 0x17008E39 RID: 36409
		// (get) Token: 0x0601F0ED RID: 127213 RVA: 0x00457398 File Offset: 0x00455598
		// (set) Token: 0x0601F0EE RID: 127214 RVA: 0x004573A0 File Offset: 0x004555A0
		public int RowIndex { get; set; }

		// Token: 0x17008E3A RID: 36410
		// (get) Token: 0x0601F0EF RID: 127215 RVA: 0x004573A9 File Offset: 0x004555A9
		// (set) Token: 0x0601F0F0 RID: 127216 RVA: 0x004573B1 File Offset: 0x004555B1
		public int ColumnIndex { get; set; }

		// Token: 0x0601F0F1 RID: 127217 RVA: 0x004573BA File Offset: 0x004555BA
		public IPieceIndexT()
		{
			this.RowIndex = 0;
			this.ColumnIndex = 0;
		}
	}
}
