using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F2E RID: 3886
	public class IStreamingWaitConfig
	{
		// Token: 0x06005751 RID: 22353 RVA: 0x000D6054 File Offset: 0x000D4254
		public static IStreamingWaitConfig Create(IStreamingWaitConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStreamingWaitConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001CF0 RID: 7408
		// (get) Token: 0x06005752 RID: 22354 RVA: 0x000D6073 File Offset: 0x000D4273
		public virtual float MinWaitStreamDuration
		{
			get
			{
				return this.Instance.MinWaitStreamDuration;
			}
		}

		// Token: 0x17001CF1 RID: 7409
		// (get) Token: 0x06005753 RID: 22355 RVA: 0x000D6080 File Offset: 0x000D4280
		public virtual float MaxWaitStreamDuration
		{
			get
			{
				return this.Instance.MaxWaitStreamDuration;
			}
		}

		// Token: 0x04003221 RID: 12833
		private IStreamingWaitConfig Instance;
	}
}
