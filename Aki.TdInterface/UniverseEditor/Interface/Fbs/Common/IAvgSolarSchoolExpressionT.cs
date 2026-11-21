using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006351 RID: 25425
	public class IAvgSolarSchoolExpressionT
	{
		// Token: 0x1700BC00 RID: 48128
		// (get) Token: 0x0602B207 RID: 176647 RVA: 0x005E09F3 File Offset: 0x005DEBF3
		// (set) Token: 0x0602B208 RID: 176648 RVA: 0x005E09FB File Offset: 0x005DEBFB
		public int Id { get; set; }

		// Token: 0x1700BC01 RID: 48129
		// (get) Token: 0x0602B209 RID: 176649 RVA: 0x005E0A04 File Offset: 0x005DEC04
		// (set) Token: 0x0602B20A RID: 176650 RVA: 0x005E0A0C File Offset: 0x005DEC0C
		public string Name { get; set; }

		// Token: 0x1700BC02 RID: 48130
		// (get) Token: 0x0602B20B RID: 176651 RVA: 0x005E0A15 File Offset: 0x005DEC15
		// (set) Token: 0x0602B20C RID: 176652 RVA: 0x005E0A1D File Offset: 0x005DEC1D
		public string BodyAnimation { get; set; }

		// Token: 0x1700BC03 RID: 48131
		// (get) Token: 0x0602B20D RID: 176653 RVA: 0x005E0A26 File Offset: 0x005DEC26
		// (set) Token: 0x0602B20E RID: 176654 RVA: 0x005E0A2E File Offset: 0x005DEC2E
		public string MouthAnimation { get; set; }

		// Token: 0x1700BC04 RID: 48132
		// (get) Token: 0x0602B20F RID: 176655 RVA: 0x005E0A37 File Offset: 0x005DEC37
		// (set) Token: 0x0602B210 RID: 176656 RVA: 0x005E0A3F File Offset: 0x005DEC3F
		public string MouthOpenSmallAnimation { get; set; }

		// Token: 0x1700BC05 RID: 48133
		// (get) Token: 0x0602B211 RID: 176657 RVA: 0x005E0A48 File Offset: 0x005DEC48
		// (set) Token: 0x0602B212 RID: 176658 RVA: 0x005E0A50 File Offset: 0x005DEC50
		public string MouthOpenLargeAnimation { get; set; }

		// Token: 0x1700BC06 RID: 48134
		// (get) Token: 0x0602B213 RID: 176659 RVA: 0x005E0A59 File Offset: 0x005DEC59
		// (set) Token: 0x0602B214 RID: 176660 RVA: 0x005E0A61 File Offset: 0x005DEC61
		public string EyeAnimation { get; set; }

		// Token: 0x1700BC07 RID: 48135
		// (get) Token: 0x0602B215 RID: 176661 RVA: 0x005E0A6A File Offset: 0x005DEC6A
		// (set) Token: 0x0602B216 RID: 176662 RVA: 0x005E0A72 File Offset: 0x005DEC72
		public string BlinkAnimation { get; set; }

		// Token: 0x0602B217 RID: 176663 RVA: 0x005E0A7B File Offset: 0x005DEC7B
		public IAvgSolarSchoolExpressionT()
		{
			this.Id = 0;
			this.Name = null;
			this.BodyAnimation = null;
			this.MouthAnimation = null;
			this.MouthOpenSmallAnimation = null;
			this.MouthOpenLargeAnimation = null;
			this.EyeAnimation = null;
			this.BlinkAnimation = null;
		}
	}
}
