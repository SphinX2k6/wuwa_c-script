using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006078 RID: 24696
	public class IThrowMotionFreeFallT
	{
		// Token: 0x1700B768 RID: 46952
		// (get) Token: 0x06029BBF RID: 170943 RVA: 0x005B2BD5 File Offset: 0x005B0DD5
		// (set) Token: 0x06029BC0 RID: 170944 RVA: 0x005B2BDD File Offset: 0x005B0DDD
		public EThrowMotion Type { get; set; }

		// Token: 0x1700B769 RID: 46953
		// (get) Token: 0x06029BC1 RID: 170945 RVA: 0x005B2BE6 File Offset: 0x005B0DE6
		// (set) Token: 0x06029BC2 RID: 170946 RVA: 0x005B2BEE File Offset: 0x005B0DEE
		public IVectorInfoT Velocity { get; set; }

		// Token: 0x1700B76A RID: 46954
		// (get) Token: 0x06029BC3 RID: 170947 RVA: 0x005B2BF7 File Offset: 0x005B0DF7
		// (set) Token: 0x06029BC4 RID: 170948 RVA: 0x005B2BFF File Offset: 0x005B0DFF
		public IAngularVelocityConfigT AngularVelocity { get; set; }

		// Token: 0x06029BC5 RID: 170949 RVA: 0x005B2C08 File Offset: 0x005B0E08
		public IThrowMotionFreeFallT()
		{
			this.Type = EThrowMotion.Projectile;
			this.Velocity = null;
			this.AngularVelocity = null;
		}
	}
}
