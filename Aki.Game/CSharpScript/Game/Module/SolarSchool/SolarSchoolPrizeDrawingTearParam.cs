using System;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005934 RID: 22836
	public sealed class SolarSchoolPrizeDrawingTearParam
	{
		// Token: 0x0603843C RID: 230460 RVA: 0x00FBB2DC File Offset: 0x00FB94DC
		public SolarSchoolPrizeDrawingTearParam(SolarSchoolCostCurrency firstCost)
		{
			this.FirstCost = firstCost;
		}

		// Token: 0x0401DA22 RID: 121378
		public readonly SolarSchoolCostCurrency FirstCost;
	}
}
