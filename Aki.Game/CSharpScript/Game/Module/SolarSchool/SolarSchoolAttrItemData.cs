using System;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A4E RID: 23118
	public readonly struct SolarSchoolAttrItemData
	{
		// Token: 0x06038F87 RID: 233351 RVA: 0x00FF60F7 File Offset: 0x00FF42F7
		public SolarSchoolAttrItemData(ESolarSchoolSecondAttr attr, int? delta = null)
		{
			this.Attr = attr;
			this.Delta = delta;
		}

		// Token: 0x0401DFC9 RID: 122825
		public readonly ESolarSchoolSecondAttr Attr;

		// Token: 0x0401DFCA RID: 122826
		public readonly int? Delta;
	}
}
