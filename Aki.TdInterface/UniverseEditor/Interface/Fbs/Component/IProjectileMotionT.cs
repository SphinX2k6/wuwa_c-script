using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DAD RID: 23981
	public class IProjectileMotionT
	{
		// Token: 0x1700B096 RID: 45206
		// (get) Token: 0x06027F78 RID: 163704 RVA: 0x00577909 File Offset: 0x00575B09
		// (set) Token: 0x06027F79 RID: 163705 RVA: 0x00577911 File Offset: 0x00575B11
		public EThrowMotion Type { get; set; }

		// Token: 0x1700B097 RID: 45207
		// (get) Token: 0x06027F7A RID: 163706 RVA: 0x0057791A File Offset: 0x00575B1A
		// (set) Token: 0x06027F7B RID: 163707 RVA: 0x00577922 File Offset: 0x00575B22
		public float Velocity { get; set; }

		// Token: 0x1700B098 RID: 45208
		// (get) Token: 0x06027F7C RID: 163708 RVA: 0x0057792B File Offset: 0x00575B2B
		// (set) Token: 0x06027F7D RID: 163709 RVA: 0x00577933 File Offset: 0x00575B33
		public float AngularVelocity { get; set; }

		// Token: 0x1700B099 RID: 45209
		// (get) Token: 0x06027F7E RID: 163710 RVA: 0x0057793C File Offset: 0x00575B3C
		// (set) Token: 0x06027F7F RID: 163711 RVA: 0x00577944 File Offset: 0x00575B44
		public string CameraShake { get; set; }

		// Token: 0x1700B09A RID: 45210
		// (get) Token: 0x06027F80 RID: 163712 RVA: 0x0057794D File Offset: 0x00575B4D
		// (set) Token: 0x06027F81 RID: 163713 RVA: 0x00577955 File Offset: 0x00575B55
		public ISpeedCurveMotionT MatchSpeedCurve { get; set; }

		// Token: 0x06027F82 RID: 163714 RVA: 0x0057795E File Offset: 0x00575B5E
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
