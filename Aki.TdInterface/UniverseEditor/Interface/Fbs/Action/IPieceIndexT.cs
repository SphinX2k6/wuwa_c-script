using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007446 RID: 29766
	public class IPieceIndexT
	{
		// Token: 0x1700DAA2 RID: 55970
		// (get) Token: 0x06034168 RID: 213352 RVA: 0x00704BAC File Offset: 0x00702DAC
		// (set) Token: 0x06034169 RID: 213353 RVA: 0x00704BB4 File Offset: 0x00702DB4
		public int RowIndex { get; set; }

		// Token: 0x1700DAA3 RID: 55971
		// (get) Token: 0x0603416A RID: 213354 RVA: 0x00704BBD File Offset: 0x00702DBD
		// (set) Token: 0x0603416B RID: 213355 RVA: 0x00704BC5 File Offset: 0x00702DC5
		public int ColumnIndex { get; set; }

		// Token: 0x0603416C RID: 213356 RVA: 0x00704BCE File Offset: 0x00702DCE
		public IPieceIndexT()
		{
			this.RowIndex = 0;
			this.ColumnIndex = 0;
		}
	}
}
