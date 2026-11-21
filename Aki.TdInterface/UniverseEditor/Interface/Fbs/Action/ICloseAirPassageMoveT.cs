using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A90 RID: 27280
	public class ICloseAirPassageMoveT
	{
		// Token: 0x1700C85A RID: 51290
		// (get) Token: 0x0602ED09 RID: 191753 RVA: 0x0066153A File Offset: 0x0065F73A
		// (set) Token: 0x0602ED0A RID: 191754 RVA: 0x00661542 File Offset: 0x0065F742
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700C85B RID: 51291
		// (get) Token: 0x0602ED0B RID: 191755 RVA: 0x0066154B File Offset: 0x0065F74B
		// (set) Token: 0x0602ED0C RID: 191756 RVA: 0x00661553 File Offset: 0x0065F753
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700C85C RID: 51292
		// (get) Token: 0x0602ED0D RID: 191757 RVA: 0x0066155C File Offset: 0x0065F75C
		// (set) Token: 0x0602ED0E RID: 191758 RVA: 0x00661564 File Offset: 0x0065F764
		public byte NullMask { get; set; }

		// Token: 0x0602ED0F RID: 191759 RVA: 0x0066156D File Offset: 0x0065F76D
		public ICloseAirPassageMoveT()
		{
			this.Type = ESplineMovePattern.PathLine;
			this.GravitySwitchAngularVelocity = 0f;
			this.NullMask = 0;
		}
	}
}
