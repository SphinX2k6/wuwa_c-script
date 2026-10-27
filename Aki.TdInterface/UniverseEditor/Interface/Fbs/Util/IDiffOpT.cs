using System;

namespace Aki.UniverseEditor.Interface.Fbs.Util
{
	// Token: 0x02003B6D RID: 15213
	public class IDiffOpT
	{
		// Token: 0x17006836 RID: 26678
		// (get) Token: 0x06014D03 RID: 85251 RVA: 0x00305D71 File Offset: 0x00303F71
		// (set) Token: 0x06014D04 RID: 85252 RVA: 0x00305D79 File Offset: 0x00303F79
		public EDiffOp Type { get; set; }

		// Token: 0x17006837 RID: 26679
		// (get) Token: 0x06014D05 RID: 85253 RVA: 0x00305D82 File Offset: 0x00303F82
		// (set) Token: 0x06014D06 RID: 85254 RVA: 0x00305D8A File Offset: 0x00303F8A
		public int Length { get; set; }

		// Token: 0x17006838 RID: 26680
		// (get) Token: 0x06014D07 RID: 85255 RVA: 0x00305D93 File Offset: 0x00303F93
		// (set) Token: 0x06014D08 RID: 85256 RVA: 0x00305D9B File Offset: 0x00303F9B
		public IDiffOpT PreOp { get; set; }

		// Token: 0x06014D09 RID: 85257 RVA: 0x00305DA4 File Offset: 0x00303FA4
		public IDiffOpT()
		{
			this.Type = EDiffOp.Same;
			this.Length = 0;
			this.PreOp = null;
		}
	}
}
