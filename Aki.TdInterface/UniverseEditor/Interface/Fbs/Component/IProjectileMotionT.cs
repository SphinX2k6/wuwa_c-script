using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057A6 RID: 22438
	public class IProjectileMotionT
	{
		// Token: 0x1700A772 RID: 42866
		// (get) Token: 0x06025A58 RID: 154200 RVA: 0x0053177D File Offset: 0x0052F97D
		// (set) Token: 0x06025A59 RID: 154201 RVA: 0x00531785 File Offset: 0x0052F985
		public EThrowMotion Type { get; set; }

		// Token: 0x1700A773 RID: 42867
		// (get) Token: 0x06025A5A RID: 154202 RVA: 0x0053178E File Offset: 0x0052F98E
		// (set) Token: 0x06025A5B RID: 154203 RVA: 0x00531796 File Offset: 0x0052F996
		public float Velocity { get; set; }

		// Token: 0x1700A774 RID: 42868
		// (get) Token: 0x06025A5C RID: 154204 RVA: 0x0053179F File Offset: 0x0052F99F
		// (set) Token: 0x06025A5D RID: 154205 RVA: 0x005317A7 File Offset: 0x0052F9A7
		public float AngularVelocity { get; set; }

		// Token: 0x1700A775 RID: 42869
		// (get) Token: 0x06025A5E RID: 154206 RVA: 0x005317B0 File Offset: 0x0052F9B0
		// (set) Token: 0x06025A5F RID: 154207 RVA: 0x005317B8 File Offset: 0x0052F9B8
		public string CameraShake { get; set; }

		// Token: 0x1700A776 RID: 42870
		// (get) Token: 0x06025A60 RID: 154208 RVA: 0x005317C1 File Offset: 0x0052F9C1
		// (set) Token: 0x06025A61 RID: 154209 RVA: 0x005317C9 File Offset: 0x0052F9C9
		public ISpeedCurveMotionT MatchSpeedCurve { get; set; }

		// Token: 0x06025A62 RID: 154210 RVA: 0x005317D2 File Offset: 0x0052F9D2
		public IProjectileMotionT()
		{
			this.Type = EThrowMotion.Projectile;
			this.Velocity = 0f;
			this.AngularVelocity = 0f;
			this.CameraShake = null;
			this.MatchSpeedCurve = null;
		}
	}
}
