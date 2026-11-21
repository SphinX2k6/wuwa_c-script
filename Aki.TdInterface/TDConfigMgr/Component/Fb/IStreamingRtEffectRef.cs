using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F2B RID: 3883
	public class IStreamingRtEffectRef
	{
		// Token: 0x06005741 RID: 22337 RVA: 0x000D5E0F File Offset: 0x000D400F
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

		// Token: 0x17001CE6 RID: 7398
		// (get) Token: 0x06005742 RID: 22338 RVA: 0x000D5E2E File Offset: 0x000D402E
		public virtual string ActorRefKey
		{
			get
			{
				return this.Instance.ActorRefKey;
			}
		}

		// Token: 0x04003214 RID: 12820
		private IStreamingRtEffectRef Instance;
	}
}
