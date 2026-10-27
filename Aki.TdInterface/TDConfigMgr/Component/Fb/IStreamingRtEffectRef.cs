using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E2F RID: 3631
	[NullableContext(1)]
	[Nullable(0)]
	public class IStreamingRtEffectRef
	{
		// Token: 0x0600521A RID: 21018 RVA: 0x000CA547 File Offset: 0x000C8747
		public static IStreamingRtEffectRef Create(IStreamingRtEffectRef? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStreamingRtEffectRef
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B79 RID: 7033
		// (get) Token: 0x0600521B RID: 21019 RVA: 0x000CA566 File Offset: 0x000C8766
		public virtual string ActorRefKey
		{
			get
			{
				return this.Instance.ActorRefKey;
			}
		}

		// Token: 0x04002F4C RID: 12108
		private IStreamingRtEffectRef Instance;
	}
}
