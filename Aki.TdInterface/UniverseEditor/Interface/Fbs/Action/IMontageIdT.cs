using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AFE RID: 27390
	public class IMontageIdT
	{
		// Token: 0x1700CB56 RID: 52054
		// (get) Token: 0x0603008E RID: 196750 RVA: 0x00687E1A File Offset: 0x0068601A
		// (set) Token: 0x0603008F RID: 196751 RVA: 0x00687E22 File Offset: 0x00686022
		public int MontageId { get; set; }

		// Token: 0x1700CB57 RID: 52055
		// (get) Token: 0x06030090 RID: 196752 RVA: 0x00687E2B File Offset: 0x0068602B
		// (set) Token: 0x06030091 RID: 196753 RVA: 0x00687E33 File Offset: 0x00686033
		public bool IsAbp { get; set; }

		// Token: 0x1700CB58 RID: 52056
		// (get) Token: 0x06030092 RID: 196754 RVA: 0x00687E3C File Offset: 0x0068603C
		// (set) Token: 0x06030093 RID: 196755 RVA: 0x00687E44 File Offset: 0x00686044
		public byte NullMask { get; set; }

		// Token: 0x06030094 RID: 196756 RVA: 0x00687E4D File Offset: 0x0068604D
		public IMontageIdT()
		{
			this.MontageId = 0;
			this.IsAbp = false;
			this.NullMask = 0;
		}
	}
}
