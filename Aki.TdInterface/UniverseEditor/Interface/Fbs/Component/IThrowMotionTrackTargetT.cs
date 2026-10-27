using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A71 RID: 23153
	public class IThrowMotionTrackTargetT
	{
		// Token: 0x1700AE49 RID: 44617
		// (get) Token: 0x06027697 RID: 161431 RVA: 0x0056C674 File Offset: 0x0056A874
		// (set) Token: 0x06027698 RID: 161432 RVA: 0x0056C67C File Offset: 0x0056A87C
		public EThrowMotion Type { get; set; }

		// Token: 0x1700AE4A RID: 44618
		// (get) Token: 0x06027699 RID: 161433 RVA: 0x0056C685 File Offset: 0x0056A885
		// (set) Token: 0x0602769A RID: 161434 RVA: 0x0056C68D File Offset: 0x0056A88D
		public float Velocity { get; set; }

		// Token: 0x1700AE4B RID: 44619
		// (get) Token: 0x0602769B RID: 161435 RVA: 0x0056C696 File Offset: 0x0056A896
		// (set) Token: 0x0602769C RID: 161436 RVA: 0x0056C69E File Offset: 0x0056A89E
		public string VelocityCurve { get; set; }

		// Token: 0x1700AE4C RID: 44620
		// (get) Token: 0x0602769D RID: 161437 RVA: 0x0056C6A7 File Offset: 0x0056A8A7
		// (set) Token: 0x0602769E RID: 161438 RVA: 0x0056C6AF File Offset: 0x0056A8AF
		public IVectorInfoT VelocityOffset { get; set; }

		// Token: 0x1700AE4D RID: 44621
		// (get) Token: 0x0602769F RID: 161439 RVA: 0x0056C6B8 File Offset: 0x0056A8B8
		// (set) Token: 0x060276A0 RID: 161440 RVA: 0x0056C6C0 File Offset: 0x0056A8C0
		public float AngularVelocity { get; set; }

		// Token: 0x1700AE4E RID: 44622
		// (get) Token: 0x060276A1 RID: 161441 RVA: 0x0056C6C9 File Offset: 0x0056A8C9
		// (set) Token: 0x060276A2 RID: 161442 RVA: 0x0056C6D1 File Offset: 0x0056A8D1
		public string AngularVelocityCurve { get; set; }

		// Token: 0x060276A3 RID: 161443 RVA: 0x0056C6DA File Offset: 0x0056A8DA
		public IThrowMotionTrackTargetT()
		{
			this.Type = EThrowMotion.Projectile;
			this.Velocity = 0f;
			this.VelocityCurve = null;
			this.VelocityOffset = null;
			this.AngularVelocity = 0f;
			this.AngularVelocityCurve = null;
		}
	}
}
