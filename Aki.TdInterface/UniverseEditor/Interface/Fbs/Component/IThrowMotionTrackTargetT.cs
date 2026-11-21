using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200607E RID: 24702
	public class IThrowMotionTrackTargetT
	{
		// Token: 0x1700B781 RID: 46977
		// (get) Token: 0x06029C0F RID: 171023 RVA: 0x005B3680 File Offset: 0x005B1880
		// (set) Token: 0x06029C10 RID: 171024 RVA: 0x005B3688 File Offset: 0x005B1888
		public EThrowMotion Type { get; set; }

		// Token: 0x1700B782 RID: 46978
		// (get) Token: 0x06029C11 RID: 171025 RVA: 0x005B3691 File Offset: 0x005B1891
		// (set) Token: 0x06029C12 RID: 171026 RVA: 0x005B3699 File Offset: 0x005B1899
		public float Velocity { get; set; }

		// Token: 0x1700B783 RID: 46979
		// (get) Token: 0x06029C13 RID: 171027 RVA: 0x005B36A2 File Offset: 0x005B18A2
		// (set) Token: 0x06029C14 RID: 171028 RVA: 0x005B36AA File Offset: 0x005B18AA
		public string VelocityCurve { get; set; }

		// Token: 0x1700B784 RID: 46980
		// (get) Token: 0x06029C15 RID: 171029 RVA: 0x005B36B3 File Offset: 0x005B18B3
		// (set) Token: 0x06029C16 RID: 171030 RVA: 0x005B36BB File Offset: 0x005B18BB
		public IVectorInfoT VelocityOffset { get; set; }

		// Token: 0x1700B785 RID: 46981
		// (get) Token: 0x06029C17 RID: 171031 RVA: 0x005B36C4 File Offset: 0x005B18C4
		// (set) Token: 0x06029C18 RID: 171032 RVA: 0x005B36CC File Offset: 0x005B18CC
		public float AngularVelocity { get; set; }

		// Token: 0x1700B786 RID: 46982
		// (get) Token: 0x06029C19 RID: 171033 RVA: 0x005B36D5 File Offset: 0x005B18D5
		// (set) Token: 0x06029C1A RID: 171034 RVA: 0x005B36DD File Offset: 0x005B18DD
		public string AngularVelocityCurve { get; set; }

		// Token: 0x06029C1B RID: 171035 RVA: 0x005B36E6 File Offset: 0x005B18E6
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
