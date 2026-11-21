using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BFC RID: 3068
	public class ICastConfig
	{
		// Token: 0x06004673 RID: 18035 RVA: 0x000B3784 File Offset: 0x000B1984
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

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x06004674 RID: 18036 RVA: 0x000B37A3 File Offset: 0x000B19A3
		public virtual int CastAngularVelocity
		{
			get
			{
				return this.Instance.CastAngularVelocity;
			}
		}

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x06004675 RID: 18037 RVA: 0x000B37B0 File Offset: 0x000B19B0
		public virtual string CastCameraShake
		{
			get
			{
				return this.Instance.CastCameraShake;
			}
		}

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x06004676 RID: 18038 RVA: 0x000B37BD File Offset: 0x000B19BD
		public virtual int CastVelocity
		{
			get
			{
				return this.Instance.CastVelocity;
			}
		}

		// Token: 0x04002793 RID: 10131
		private ICastConfig Instance;
	}
}
