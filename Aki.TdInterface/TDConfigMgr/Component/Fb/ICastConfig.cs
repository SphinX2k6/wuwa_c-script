using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B2E RID: 2862
	[NullableContext(1)]
	[Nullable(0)]
	public class ICastConfig
	{
		// Token: 0x0600421A RID: 16922 RVA: 0x000A96C0 File Offset: 0x000A78C0
		public static ICastConfig Create(ICastConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICastConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x0600421B RID: 16923 RVA: 0x000A96DF File Offset: 0x000A78DF
		public virtual int CastAngularVelocity
		{
			get
			{
				return this.Instance.CastAngularVelocity;
			}
		}

		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x0600421C RID: 16924 RVA: 0x000A96EC File Offset: 0x000A78EC
		public virtual string CastCameraShake
		{
			get
			{
				return this.Instance.CastCameraShake;
			}
		}

		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x0600421D RID: 16925 RVA: 0x000A96F9 File Offset: 0x000A78F9
		public virtual int CastVelocity
		{
			get
			{
				return this.Instance.CastVelocity;
			}
		}

		// Token: 0x0400254B RID: 9547
		private ICastConfig Instance;
	}
}
