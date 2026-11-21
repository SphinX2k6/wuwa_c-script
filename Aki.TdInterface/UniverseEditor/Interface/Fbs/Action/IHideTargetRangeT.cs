using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FBD RID: 28605
	public class IHideTargetRangeT
	{
		// Token: 0x1700D182 RID: 53634
		// (get) Token: 0x0603189A RID: 202906 RVA: 0x006B6B1D File Offset: 0x006B4D1D
		// (set) Token: 0x0603189B RID: 202907 RVA: 0x006B6B25 File Offset: 0x006B4D25
		public int RangeEntity { get; set; }

		// Token: 0x1700D183 RID: 53635
		// (get) Token: 0x0603189C RID: 202908 RVA: 0x006B6B2E File Offset: 0x006B4D2E
		// (set) Token: 0x0603189D RID: 202909 RVA: 0x006B6B36 File Offset: 0x006B4D36
		public THideRangeConfigUnion HideConfig { get; set; }

		// Token: 0x1700D184 RID: 53636
		// (get) Token: 0x0603189E RID: 202910 RVA: 0x006B6B3F File Offset: 0x006B4D3F
		// (set) Token: 0x0603189F RID: 202911 RVA: 0x006B6B47 File Offset: 0x006B4D47
		public bool IsHideSimpleNpc { get; set; }

		// Token: 0x1700D185 RID: 53637
		// (get) Token: 0x060318A0 RID: 202912 RVA: 0x006B6B50 File Offset: 0x006B4D50
		// (set) Token: 0x060318A1 RID: 202913 RVA: 0x006B6B58 File Offset: 0x006B4D58
		public bool IsHidePasserByNpc { get; set; }

		// Token: 0x1700D186 RID: 53638
		// (get) Token: 0x060318A2 RID: 202914 RVA: 0x006B6B61 File Offset: 0x006B4D61
		// (set) Token: 0x060318A3 RID: 202915 RVA: 0x006B6B69 File Offset: 0x006B4D69
		public byte NullMask { get; set; }

		// Token: 0x060318A4 RID: 202916 RVA: 0x006B6B72 File Offset: 0x006B4D72
		public IHideTargetRangeT()
		{
			this.RangeEntity = 0;
			this.HideConfig = null;
			this.IsHideSimpleNpc = false;
			this.IsHidePasserByNpc = false;
			this.NullMask = 0;
		}
	}
}
