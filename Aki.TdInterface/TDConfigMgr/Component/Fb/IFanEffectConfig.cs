using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DAF RID: 3503
	public class IFanEffectConfig
	{
		// Token: 0x06004F9F RID: 20383 RVA: 0x000C62BD File Offset: 0x000C44BD
		public static IFanEffectConfig Create(IFanEffectConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFanEffectConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x06004FA0 RID: 20384 RVA: 0x000C62DC File Offset: 0x000C44DC
		public virtual string EffectPath
		{
			get
			{
				return this.Instance.EffectPath;
			}
		}

		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x06004FA1 RID: 20385 RVA: 0x000C62E9 File Offset: 0x000C44E9
		public virtual float DefaultEffectLength
		{
			get
			{
				return this.Instance.DefaultEffectLength;
			}
		}

		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x06004FA2 RID: 20386 RVA: 0x000C62F6 File Offset: 0x000C44F6
		[Nullable(2)]
		public virtual string HitEffectPath
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.HitEffectPath;
			}
		}

		// Token: 0x04002D66 RID: 11622
		private IFanEffectConfig Instance;
	}
}
