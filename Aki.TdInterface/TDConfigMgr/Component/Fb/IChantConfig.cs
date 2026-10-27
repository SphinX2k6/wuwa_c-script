using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B2B RID: 2859
	[NullableContext(1)]
	[Nullable(0)]
	public class IChantConfig
	{
		// Token: 0x06004204 RID: 16900 RVA: 0x000A9506 File Offset: 0x000A7706
		public static IChantConfig Create(IChantConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChantConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x06004205 RID: 16901 RVA: 0x000A9525 File Offset: 0x000A7725
		public virtual int ChantTime
		{
			get
			{
				return this.Instance.ChantTime;
			}
		}

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x06004206 RID: 16902 RVA: 0x000A9532 File Offset: 0x000A7732
		public virtual string ChantCameraShake
		{
			get
			{
				return this.Instance.ChantCameraShake;
			}
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x06004207 RID: 16903 RVA: 0x000A953F File Offset: 0x000A773F
		public virtual string ChantCameraStateTag
		{
			get
			{
				return this.Instance.ChantCameraStateTag;
			}
		}

		// Token: 0x04002542 RID: 9538
		private IChantConfig Instance;
	}
}
