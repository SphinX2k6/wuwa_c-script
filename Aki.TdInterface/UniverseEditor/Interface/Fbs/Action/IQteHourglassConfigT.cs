using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007571 RID: 30065
	public class IQteHourglassConfigT
	{
		// Token: 0x1700DD16 RID: 56598
		// (get) Token: 0x06034B9B RID: 215963 RVA: 0x00717272 File Offset: 0x00715472
		// (set) Token: 0x06034B9C RID: 215964 RVA: 0x0071727A File Offset: 0x0071547A
		public int QteId { get; set; }

		// Token: 0x1700DD17 RID: 56599
		// (get) Token: 0x06034B9D RID: 215965 RVA: 0x00717283 File Offset: 0x00715483
		// (set) Token: 0x06034B9E RID: 215966 RVA: 0x0071728B File Offset: 0x0071548B
		public float TrailTime { get; set; }

		// Token: 0x1700DD18 RID: 56600
		// (get) Token: 0x06034B9F RID: 215967 RVA: 0x00717294 File Offset: 0x00715494
		// (set) Token: 0x06034BA0 RID: 215968 RVA: 0x0071729C File Offset: 0x0071549C
		public string TrailCurveX { get; set; }

		// Token: 0x1700DD19 RID: 56601
		// (get) Token: 0x06034BA1 RID: 215969 RVA: 0x007172A5 File Offset: 0x007154A5
		// (set) Token: 0x06034BA2 RID: 215970 RVA: 0x007172AD File Offset: 0x007154AD
		public string TrailCurveY { get; set; }

		// Token: 0x06034BA3 RID: 215971 RVA: 0x007172B6 File Offset: 0x007154B6
		public IQteHourglassConfigT()
		{
			this.QteId = 0;
			this.TrailTime = 0f;
			this.TrailCurveX = null;
			this.TrailCurveY = null;
		}
	}
}
