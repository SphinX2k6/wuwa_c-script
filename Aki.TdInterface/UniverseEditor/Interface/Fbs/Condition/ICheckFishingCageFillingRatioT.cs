using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EE8 RID: 20200
	public class ICheckFishingCageFillingRatioT
	{
		// Token: 0x1700903C RID: 36924
		// (get) Token: 0x0601F5C6 RID: 128454 RVA: 0x0045E8EE File Offset: 0x0045CAEE
		// (set) Token: 0x0601F5C7 RID: 128455 RVA: 0x0045E8F6 File Offset: 0x0045CAF6
		public ECondition Type { get; set; }

		// Token: 0x1700903D RID: 36925
		// (get) Token: 0x0601F5C8 RID: 128456 RVA: 0x0045E8FF File Offset: 0x0045CAFF
		// (set) Token: 0x0601F5C9 RID: 128457 RVA: 0x0045E907 File Offset: 0x0045CB07
		public ECompare Compare { get; set; }

		// Token: 0x1700903E RID: 36926
		// (get) Token: 0x0601F5CA RID: 128458 RVA: 0x0045E910 File Offset: 0x0045CB10
		// (set) Token: 0x0601F5CB RID: 128459 RVA: 0x0045E918 File Offset: 0x0045CB18
		public int Ratio { get; set; }

		// Token: 0x0601F5CC RID: 128460 RVA: 0x0045E921 File Offset: 0x0045CB21
		public ICheckFishingCageFillingRatioT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
			this.Ratio = 0;
		}
	}
}
