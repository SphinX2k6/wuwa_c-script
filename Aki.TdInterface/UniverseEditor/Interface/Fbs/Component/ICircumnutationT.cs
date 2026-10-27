using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FA1 RID: 20385
	public class ICircumnutationT
	{
		// Token: 0x17009390 RID: 37776
		// (get) Token: 0x060206C9 RID: 132809 RVA: 0x00482D70 File Offset: 0x00480F70
		// (set) Token: 0x060206CA RID: 132810 RVA: 0x00482D78 File Offset: 0x00480F78
		public EThrowMotion Type { get; set; }

		// Token: 0x17009391 RID: 37777
		// (get) Token: 0x060206CB RID: 132811 RVA: 0x00482D81 File Offset: 0x00480F81
		// (set) Token: 0x060206CC RID: 132812 RVA: 0x00482D89 File Offset: 0x00480F89
		public float Velocity { get; set; }

		// Token: 0x17009392 RID: 37778
		// (get) Token: 0x060206CD RID: 132813 RVA: 0x00482D92 File Offset: 0x00480F92
		// (set) Token: 0x060206CE RID: 132814 RVA: 0x00482D9A File Offset: 0x00480F9A
		public string VelocityCurve { get; set; }

		// Token: 0x17009393 RID: 37779
		// (get) Token: 0x060206CF RID: 132815 RVA: 0x00482DA3 File Offset: 0x00480FA3
		// (set) Token: 0x060206D0 RID: 132816 RVA: 0x00482DAB File Offset: 0x00480FAB
		public EDirection Direction { get; set; }

		// Token: 0x17009394 RID: 37780
		// (get) Token: 0x060206D1 RID: 132817 RVA: 0x00482DB4 File Offset: 0x00480FB4
		// (set) Token: 0x060206D2 RID: 132818 RVA: 0x00482DBC File Offset: 0x00480FBC
		public float AngularVelocity { get; set; }

		// Token: 0x17009395 RID: 37781
		// (get) Token: 0x060206D3 RID: 132819 RVA: 0x00482DC5 File Offset: 0x00480FC5
		// (set) Token: 0x060206D4 RID: 132820 RVA: 0x00482DCD File Offset: 0x00480FCD
		public float RotationSpeed { get; set; }

		// Token: 0x17009396 RID: 37782
		// (get) Token: 0x060206D5 RID: 132821 RVA: 0x00482DD6 File Offset: 0x00480FD6
		// (set) Token: 0x060206D6 RID: 132822 RVA: 0x00482DDE File Offset: 0x00480FDE
		public string AngularVelocityCurve { get; set; }

		// Token: 0x17009397 RID: 37783
		// (get) Token: 0x060206D7 RID: 132823 RVA: 0x00482DE7 File Offset: 0x00480FE7
		// (set) Token: 0x060206D8 RID: 132824 RVA: 0x00482DEF File Offset: 0x00480FEF
		public IRenderTrajectoryConfigT RenderTrajectoryConfig { get; set; }

		// Token: 0x060206D9 RID: 132825 RVA: 0x00482DF8 File Offset: 0x00480FF8
		public ICircumnutationT()
		{
			this.Type = EThrowMotion.Projectile;
			this.Velocity = 0f;
			this.VelocityCurve = null;
			this.Direction = EDirection.Right;
			this.AngularVelocity = 0f;
			this.RotationSpeed = 0f;
			this.AngularVelocityCurve = null;
			this.RenderTrajectoryConfig = null;
		}
	}
}
