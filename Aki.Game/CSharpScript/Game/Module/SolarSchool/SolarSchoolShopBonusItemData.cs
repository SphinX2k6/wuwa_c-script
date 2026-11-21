using System;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A06 RID: 23046
	public readonly struct SolarSchoolShopBonusItemData
	{
		// Token: 0x06038C00 RID: 232448 RVA: 0x00FE25C2 File Offset: 0x00FE07C2
		public SolarSchoolShopBonusItemData(ESolarSchoolSecondAttr attr, int value)
		{
			this.Attr = attr;
			this.Value = value;
		}

		// Token: 0x0401DE04 RID: 122372
		public readonly ESolarSchoolSecondAttr Attr;

		// Token: 0x0401DE05 RID: 122373
		public readonly int Value;
	}
}
