using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072D2 RID: 29394
	public class ITalkItemAvgRoleConfigT
	{
		// Token: 0x1700DB8E RID: 56206
		// (get) Token: 0x060347FD RID: 215037 RVA: 0x007153DC File Offset: 0x007135DC
		// (set) Token: 0x060347FE RID: 215038 RVA: 0x007153E4 File Offset: 0x007135E4
		public EAvgVisualEffect VisualEffect { get; set; }

		// Token: 0x1700DB8F RID: 56207
		// (get) Token: 0x060347FF RID: 215039 RVA: 0x007153ED File Offset: 0x007135ED
		// (set) Token: 0x06034800 RID: 215040 RVA: 0x007153F5 File Offset: 0x007135F5
		public EAvgRoleAnimationType AnimationType { get; set; }

		// Token: 0x1700DB90 RID: 56208
		// (get) Token: 0x06034801 RID: 215041 RVA: 0x007153FE File Offset: 0x007135FE
		// (set) Token: 0x06034802 RID: 215042 RVA: 0x00715406 File Offset: 0x00713606
		public bool IsAnimationLoop { get; set; }

		// Token: 0x1700DB91 RID: 56209
		// (get) Token: 0x06034803 RID: 215043 RVA: 0x0071540F File Offset: 0x0071360F
		// (set) Token: 0x06034804 RID: 215044 RVA: 0x00715417 File Offset: 0x00713617
		public byte NullMask { get; set; }

		// Token: 0x06034805 RID: 215045 RVA: 0x00715420 File Offset: 0x00713620
		public ITalkItemAvgRoleConfigT()
		{
			this.VisualEffect = EAvgVisualEffect.Default;
			this.AnimationType = EAvgRoleAnimationType.Idle;
			this.IsAnimationLoop = false;
			this.NullMask = 0;
		}
	}
}
