using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005179 RID: 20857
	public class IPieceIndexT
	{
		// Token: 0x17009567 RID: 38247
		// (get) Token: 0x06020D0F RID: 134415 RVA: 0x0048AEE8 File Offset: 0x004890E8
		// (set) Token: 0x06020D10 RID: 134416 RVA: 0x0048AEF0 File Offset: 0x004890F0
		public int RowIndex { get; set; }

		// Token: 0x17009568 RID: 38248
		// (get) Token: 0x06020D11 RID: 134417 RVA: 0x0048AEF9 File Offset: 0x004890F9
		// (set) Token: 0x06020D12 RID: 134418 RVA: 0x0048AF01 File Offset: 0x00489101
		public int ColumnIndex { get; set; }

		// Token: 0x06020D13 RID: 134419 RVA: 0x0048AF0A File Offset: 0x0048910A
		public IPieceIndexT()
		{
			this.RowIndex = 0;
			this.ColumnIndex = 0;
		}
	}
}
