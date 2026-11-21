using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200607B RID: 24699
	public class IThrowMotionLevitateT
	{
		// Token: 0x1700B773 RID: 46963
		// (get) Token: 0x06029BE3 RID: 170979 RVA: 0x005B30FD File Offset: 0x005B12FD
		// (set) Token: 0x06029BE4 RID: 170980 RVA: 0x005B3105 File Offset: 0x005B1305
		public EThrowMotion Type { get; set; }

		// Token: 0x1700B774 RID: 46964
		// (get) Token: 0x06029BE5 RID: 170981 RVA: 0x005B310E File Offset: 0x005B130E
		// (set) Token: 0x06029BE6 RID: 170982 RVA: 0x005B3116 File Offset: 0x005B1316
		public float Velocity { get; set; }

		// Token: 0x1700B775 RID: 46965
		// (get) Token: 0x06029BE7 RID: 170983 RVA: 0x005B311F File Offset: 0x005B131F
		// (set) Token: 0x06029BE8 RID: 170984 RVA: 0x005B3127 File Offset: 0x005B1327
		public string VelocityCurve { get; set; }

		// Token: 0x1700B776 RID: 46966
		// (get) Token: 0x06029BE9 RID: 170985 RVA: 0x005B3130 File Offset: 0x005B1330
		// (set) Token: 0x06029BEA RID: 170986 RVA: 0x005B3138 File Offset: 0x005B1338
		public float MoveTime { get; set; }

		// Token: 0x1700B777 RID: 46967
		// (get) Token: 0x06029BEB RID: 170987 RVA: 0x005B3141 File Offset: 0x005B1341
		// (set) Token: 0x06029BEC RID: 170988 RVA: 0x005B3149 File Offset: 0x005B1349
		public float RayRadius { get; set; }

		// Token: 0x1700B778 RID: 46968
		// (get) Token: 0x06029BED RID: 170989 RVA: 0x005B3152 File Offset: 0x005B1352
		// (set) Token: 0x06029BEE RID: 170990 RVA: 0x005B315A File Offset: 0x005B135A
		public IRenderTrajectoryConfigT RenderTrajectoryConfig { get; set; }

		// Token: 0x1700B779 RID: 46969
		// (get) Token: 0x06029BEF RID: 170991 RVA: 0x005B3163 File Offset: 0x005B1363
		// (set) Token: 0x06029BF0 RID: 170992 RVA: 0x005B316B File Offset: 0x005B136B
		public byte NullMask { get; set; }

		// Token: 0x06029BF1 RID: 170993 RVA: 0x005B3174 File Offset: 0x005B1374
		public IThrowMotionLevitateT()
		{
			this.Type = EThrowMotion.Projectile;
			this.Velocity = 0f;
			this.VelocityCurve = null;
			this.MoveTime = 0f;
			this.RayRadius = 0f;
			this.RenderTrajectoryConfig = null;
			this.NullMask = 0;
		}
	}
}
