using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DF6 RID: 28150
	public class IQteHourglassConfigT
	{
		// Token: 0x1700D1CE RID: 53710
		// (get) Token: 0x06031B9F RID: 203679 RVA: 0x006BBB8A File Offset: 0x006B9D8A
		// (set) Token: 0x06031BA0 RID: 203680 RVA: 0x006BBB92 File Offset: 0x006B9D92
		public int QteId { get; set; }

		// Token: 0x1700D1CF RID: 53711
		// (get) Token: 0x06031BA1 RID: 203681 RVA: 0x006BBB9B File Offset: 0x006B9D9B
		// (set) Token: 0x06031BA2 RID: 203682 RVA: 0x006BBBA3 File Offset: 0x006B9DA3
		public float TrailTime { get; set; }

		// Token: 0x1700D1D0 RID: 53712
		// (get) Token: 0x06031BA3 RID: 203683 RVA: 0x006BBBAC File Offset: 0x006B9DAC
		// (set) Token: 0x06031BA4 RID: 203684 RVA: 0x006BBBB4 File Offset: 0x006B9DB4
		public string TrailCurveX { get; set; }

		// Token: 0x1700D1D1 RID: 53713
		// (get) Token: 0x06031BA5 RID: 203685 RVA: 0x006BBBBD File Offset: 0x006B9DBD
		// (set) Token: 0x06031BA6 RID: 203686 RVA: 0x006BBBC5 File Offset: 0x006B9DC5
		public string TrailCurveY { get; set; }

		// Token: 0x06031BA7 RID: 203687 RVA: 0x006BBBCE File Offset: 0x006B9DCE
		public IQteHourglassConfigT()
		{
			this.QteId = 0;
			this.TrailTime = 0f;
			this.TrailCurveX = null;
			this.TrailCurveY = null;
		}
	}
}
