using System;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200592D RID: 22829
	public readonly struct SolarSchoolCostCurrency
	{
		// Token: 0x0603840C RID: 230412 RVA: 0x00FBA865 File Offset: 0x00FB8A65
		public SolarSchoolCostCurrency(ESolarSchoolCostSource source, int id, int num)
		{
			this.Source = source;
			this.Id = id;
			this.Num = num;
		}

		// Token: 0x17006BCE RID: 27598
		// (get) Token: 0x0603840D RID: 230413 RVA: 0x00FBA87C File Offset: 0x00FB8A7C
		public bool Valid
		{
			get
			{
				return this.Id > 0 && this.Num > 0;
			}
		}

		// Token: 0x0401DA0E RID: 121358
		public readonly ESolarSchoolCostSource Source;

		// Token: 0x0401DA0F RID: 121359
		public readonly int Id;

		// Token: 0x0401DA10 RID: 121360
		public readonly int Num;
	}
}
