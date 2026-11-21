using System;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058C7 RID: 22727
	public class SolarSchoolAttrData
	{
		// Token: 0x06037F85 RID: 229253 RVA: 0x00FA57EA File Offset: 0x00FA39EA
		public SolarSchoolAttrData(ESolarSchoolSecondAttr attr)
		{
			this.Attr = attr;
		}

		// Token: 0x17006B56 RID: 27478
		// (get) Token: 0x06037F86 RID: 229254 RVA: 0x00FA57F9 File Offset: 0x00FA39F9
		public ESolarSchoolSecondAttr Attr { get; }

		// Token: 0x17006B57 RID: 27479
		// (get) Token: 0x06037F87 RID: 229255 RVA: 0x00FA5801 File Offset: 0x00FA3A01
		// (set) Token: 0x06037F88 RID: 229256 RVA: 0x00FA5809 File Offset: 0x00FA3A09
		public int BaseValue { get; set; }

		// Token: 0x17006B58 RID: 27480
		// (get) Token: 0x06037F89 RID: 229257 RVA: 0x00FA5812 File Offset: 0x00FA3A12
		// (set) Token: 0x06037F8A RID: 229258 RVA: 0x00FA581A File Offset: 0x00FA3A1A
		public int BonusValue { get; set; }

		// Token: 0x17006B59 RID: 27481
		// (get) Token: 0x06037F8B RID: 229259 RVA: 0x00FA5823 File Offset: 0x00FA3A23
		// (set) Token: 0x06037F8C RID: 229260 RVA: 0x00FA582B File Offset: 0x00FA3A2B
		public bool IsImportant { get; private set; }

		// Token: 0x06037F8D RID: 229261 RVA: 0x00FA5834 File Offset: 0x00FA3A34
		public bool SetImportant(bool isImportant)
		{
			if (this.IsImportant == isImportant)
			{
				return false;
			}
			this.IsImportant = isImportant;
			return true;
		}
	}
}
