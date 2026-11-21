using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F2F RID: 3887
	public class IStreamingSourceConfig
	{
		// Token: 0x06005755 RID: 22357 RVA: 0x000D6095 File Offset: 0x000D4295
		public static IStreamingSourceConfig Create(IStreamingSourceConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStreamingSourceConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001CF2 RID: 7410
		// (get) Token: 0x06005756 RID: 22358 RVA: 0x000D60B4 File Offset: 0x000D42B4
		public virtual int StreamingSourceTargetEntityId
		{
			get
			{
				return this.Instance.StreamingSourceTargetEntityId;
			}
		}

		// Token: 0x17001CF3 RID: 7411
		// (get) Token: 0x06005757 RID: 22359 RVA: 0x000D60C4 File Offset: 0x000D42C4
		public virtual bool? IsNoRenderStreaming
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsNoRenderStreaming);
			}
		}

		// Token: 0x04003222 RID: 12834
		private IStreamingSourceConfig Instance;
	}
}
