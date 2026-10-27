using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E8A RID: 20106
	public class IAirPassageSplineT
	{
		// Token: 0x1700901F RID: 36895
		// (get) Token: 0x0601FA04 RID: 129540 RVA: 0x00467B70 File Offset: 0x00465D70
		// (set) Token: 0x0601FA05 RID: 129541 RVA: 0x00467B78 File Offset: 0x00465D78
		public ESplineType Type { get; set; }

		// Token: 0x17009020 RID: 36896
		// (get) Token: 0x0601FA06 RID: 129542 RVA: 0x00467B81 File Offset: 0x00465D81
		// (set) Token: 0x0601FA07 RID: 129543 RVA: 0x00467B89 File Offset: 0x00465D89
		public string MiddleLineEffect { get; set; }

		// Token: 0x17009021 RID: 36897
		// (get) Token: 0x0601FA08 RID: 129544 RVA: 0x00467B92 File Offset: 0x00465D92
		// (set) Token: 0x0601FA09 RID: 129545 RVA: 0x00467B9A File Offset: 0x00465D9A
		public string TailCircleEffect { get; set; }

		// Token: 0x17009022 RID: 36898
		// (get) Token: 0x0601FA0A RID: 129546 RVA: 0x00467BA3 File Offset: 0x00465DA3
		// (set) Token: 0x0601FA0B RID: 129547 RVA: 0x00467BAB File Offset: 0x00465DAB
		public string MiddleCircleEffect { get; set; }

		// Token: 0x17009023 RID: 36899
		// (get) Token: 0x0601FA0C RID: 129548 RVA: 0x00467BB4 File Offset: 0x00465DB4
		// (set) Token: 0x0601FA0D RID: 129549 RVA: 0x00467BBC File Offset: 0x00465DBC
		public string MiddleCircleOverlyingEffect { get; set; }

		// Token: 0x17009024 RID: 36900
		// (get) Token: 0x0601FA0E RID: 129550 RVA: 0x00467BC5 File Offset: 0x00465DC5
		// (set) Token: 0x0601FA0F RID: 129551 RVA: 0x00467BCD File Offset: 0x00465DCD
		public float MiddleCircleSpace { get; set; }

		// Token: 0x17009025 RID: 36901
		// (get) Token: 0x0601FA10 RID: 129552 RVA: 0x00467BD6 File Offset: 0x00465DD6
		// (set) Token: 0x0601FA11 RID: 129553 RVA: 0x00467BDE File Offset: 0x00465DDE
		public float MiddleCircleRadius { get; set; }

		// Token: 0x17009026 RID: 36902
		// (get) Token: 0x0601FA12 RID: 129554 RVA: 0x00467BE7 File Offset: 0x00465DE7
		// (set) Token: 0x0601FA13 RID: 129555 RVA: 0x00467BEF File Offset: 0x00465DEF
		public float MovableRadius { get; set; }

		// Token: 0x17009027 RID: 36903
		// (get) Token: 0x0601FA14 RID: 129556 RVA: 0x00467BF8 File Offset: 0x00465DF8
		// (set) Token: 0x0601FA15 RID: 129557 RVA: 0x00467C00 File Offset: 0x00465E00
		public float Resistance { get; set; }

		// Token: 0x17009028 RID: 36904
		// (get) Token: 0x0601FA16 RID: 129558 RVA: 0x00467C09 File Offset: 0x00465E09
		// (set) Token: 0x0601FA17 RID: 129559 RVA: 0x00467C11 File Offset: 0x00465E11
		public float SpeedLimit { get; set; }

		// Token: 0x17009029 RID: 36905
		// (get) Token: 0x0601FA18 RID: 129560 RVA: 0x00467C1A File Offset: 0x00465E1A
		// (set) Token: 0x0601FA19 RID: 129561 RVA: 0x00467C22 File Offset: 0x00465E22
		public float SprintSpeedLimit { get; set; }

		// Token: 0x1700902A RID: 36906
		// (get) Token: 0x0601FA1A RID: 129562 RVA: 0x00467C2B File Offset: 0x00465E2B
		// (set) Token: 0x0601FA1B RID: 129563 RVA: 0x00467C33 File Offset: 0x00465E33
		public List<ICommonSplinePointT> Points { get; set; }

		// Token: 0x0601FA1C RID: 129564 RVA: 0x00467C3C File Offset: 0x00465E3C
		public IAirPassageSplineT()
		{
			this.Type = ESplineType.Common;
			this.MiddleLineEffect = null;
			this.TailCircleEffect = null;
			this.MiddleCircleEffect = null;
			this.MiddleCircleOverlyingEffect = null;
			this.MiddleCircleSpace = 0f;
			this.MiddleCircleRadius = 0f;
			this.MovableRadius = 0f;
			this.Resistance = 0f;
			this.SpeedLimit = 0f;
			this.SprintSpeedLimit = 0f;
			this.Points = null;
		}
	}
}
