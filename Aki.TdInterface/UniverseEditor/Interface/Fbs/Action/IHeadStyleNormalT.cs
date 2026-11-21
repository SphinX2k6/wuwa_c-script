using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F81 RID: 28545
	public class IHeadStyleNormalT
	{
		// Token: 0x1700D114 RID: 53524
		// (get) Token: 0x06031688 RID: 202376 RVA: 0x006B3108 File Offset: 0x006B1308
		// (set) Token: 0x06031689 RID: 202377 RVA: 0x006B3110 File Offset: 0x006B1310
		public EHeadStyle Type { get; set; }

		// Token: 0x1700D115 RID: 53525
		// (get) Token: 0x0603168A RID: 202378 RVA: 0x006B3119 File Offset: 0x006B1319
		// (set) Token: 0x0603168B RID: 202379 RVA: 0x006B3121 File Offset: 0x006B1321
		public int WhoId { get; set; }

		// Token: 0x0603168C RID: 202380 RVA: 0x006B312A File Offset: 0x006B132A
		public IHeadStyleNormalT()
		{
			this.Type = EHeadStyle.Normal;
			this.WhoId = 0;
		}
	}
}
