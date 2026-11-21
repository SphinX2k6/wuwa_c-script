using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F7B RID: 28539
	public class IHeadStyleT
	{
		// Token: 0x1700D10B RID: 53515
		// (get) Token: 0x0603165E RID: 202334 RVA: 0x006B2D2E File Offset: 0x006B0F2E
		// (set) Token: 0x0603165F RID: 202335 RVA: 0x006B2D36 File Offset: 0x006B0F36
		public EHeadStyle Type { get; set; }

		// Token: 0x06031660 RID: 202336 RVA: 0x006B2D3F File Offset: 0x006B0F3F
		public IHeadStyleT()
		{
			this.Type = EHeadStyle.Normal;
		}
	}
}
