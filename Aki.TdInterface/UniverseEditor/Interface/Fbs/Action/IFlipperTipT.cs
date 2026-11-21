using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E64 RID: 28260
	public class IFlipperTipT
	{
		// Token: 0x1700CF1A RID: 53018
		// (get) Token: 0x06030D1B RID: 199963 RVA: 0x0069FCB8 File Offset: 0x0069DEB8
		// (set) Token: 0x06030D1C RID: 199964 RVA: 0x0069FCC0 File Offset: 0x0069DEC0
		public ECommonTipType Type { get; set; }

		// Token: 0x1700CF1B RID: 53019
		// (get) Token: 0x06030D1D RID: 199965 RVA: 0x0069FCC9 File Offset: 0x0069DEC9
		// (set) Token: 0x06030D1E RID: 199966 RVA: 0x0069FCD1 File Offset: 0x0069DED1
		public string TidMainText { get; set; }

		// Token: 0x1700CF1C RID: 53020
		// (get) Token: 0x06030D1F RID: 199967 RVA: 0x0069FCDA File Offset: 0x0069DEDA
		// (set) Token: 0x06030D20 RID: 199968 RVA: 0x0069FCE2 File Offset: 0x0069DEE2
		public string TidSubText { get; set; }

		// Token: 0x06030D21 RID: 199969 RVA: 0x0069FCEB File Offset: 0x0069DEEB
		public IFlipperTipT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
			this.TidSubText = null;
		}
	}
}
