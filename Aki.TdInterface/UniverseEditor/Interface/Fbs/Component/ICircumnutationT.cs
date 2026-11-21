using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054FD RID: 21757
	public class ICircumnutationT
	{
		// Token: 0x17009B68 RID: 39784
		// (get) Token: 0x060225BD RID: 140733 RVA: 0x004BC254 File Offset: 0x004BA454
		// (set) Token: 0x060225BE RID: 140734 RVA: 0x004BC25C File Offset: 0x004BA45C
		public EThrowMotion Type { get; set; }

		// Token: 0x17009B69 RID: 39785
		// (get) Token: 0x060225BF RID: 140735 RVA: 0x004BC265 File Offset: 0x004BA465
		// (set) Token: 0x060225C0 RID: 140736 RVA: 0x004BC26D File Offset: 0x004BA46D
		public float Velocity { get; set; }

		// Token: 0x17009B6A RID: 39786
		// (get) Token: 0x060225C1 RID: 140737 RVA: 0x004BC276 File Offset: 0x004BA476
		// (set) Token: 0x060225C2 RID: 140738 RVA: 0x004BC27E File Offset: 0x004BA47E
		public string VelocityCurve { get; set; }

		// Token: 0x17009B6B RID: 39787
		// (get) Token: 0x060225C3 RID: 140739 RVA: 0x004BC287 File Offset: 0x004BA487
		// (set) Token: 0x060225C4 RID: 140740 RVA: 0x004BC28F File Offset: 0x004BA48F
		public EDirection Direction { get; set; }

		// Token: 0x17009B6C RID: 39788
		// (get) Token: 0x060225C5 RID: 140741 RVA: 0x004BC298 File Offset: 0x004BA498
		// (set) Token: 0x060225C6 RID: 140742 RVA: 0x004BC2A0 File Offset: 0x004BA4A0
		public float AngularVelocity { get; set; }

		// Token: 0x17009B6D RID: 39789
		// (get) Token: 0x060225C7 RID: 140743 RVA: 0x004BC2A9 File Offset: 0x004BA4A9
		// (set) Token: 0x060225C8 RID: 140744 RVA: 0x004BC2B1 File Offset: 0x004BA4B1
		public float RotationSpeed { get; set; }

		// Token: 0x17009B6E RID: 39790
		// (get) Token: 0x060225C9 RID: 140745 RVA: 0x004BC2BA File Offset: 0x004BA4BA
		// (set) Token: 0x060225CA RID: 140746 RVA: 0x004BC2C2 File Offset: 0x004BA4C2
		public string AngularVelocityCurve { get; set; }

		// Token: 0x17009B6F RID: 39791
		// (get) Token: 0x060225CB RID: 140747 RVA: 0x004BC2CB File Offset: 0x004BA4CB
		// (set) Token: 0x060225CC RID: 140748 RVA: 0x004BC2D3 File Offset: 0x004BA4D3
		public IRenderTrajectoryConfigT RenderTrajectoryConfig { get; set; }

		// Token: 0x060225CD RID: 140749 RVA: 0x004BC2DC File Offset: 0x004BA4DC
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
