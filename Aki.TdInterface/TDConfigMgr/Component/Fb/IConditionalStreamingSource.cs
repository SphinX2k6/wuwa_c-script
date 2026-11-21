using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F33 RID: 3891
	public class IConditionalStreamingSource : IStreamingSourceConfigBase
	{
		// Token: 0x06005764 RID: 22372 RVA: 0x000D622D File Offset: 0x000D442D
		public static IConditionalStreamingSource Create(IConditionalStreamingSource? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConditionalStreamingSource
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001CF9 RID: 7417
		// (get) Token: 0x06005765 RID: 22373 RVA: 0x000D624C File Offset: 0x000D444C
		public override EStreamingSourceMode Type
		{
			get
			{
				return (EStreamingSourceMode)this.Instance.Type;
			}
		}

		// Token: 0x17001CFA RID: 7418
		// (get) Token: 0x06005766 RID: 22374 RVA: 0x000D625C File Offset: 0x000D445C
		public virtual List<IConditionalStreamingSourceConfig> StreamingSourceConfigs
		{
			get
			{
				if (this._StreamingSourceConfigsInited)
				{
					return this._StreamingSourceConfigsCache;
				}
				this._StreamingSourceConfigsInited = true;
				int streamingSourceConfigsLength = this.Instance.StreamingSourceConfigsLength;
				this._StreamingSourceConfigsCache = new List<IConditionalStreamingSourceConfig>(streamingSourceConfigsLength);
				for (int i = 0; i < streamingSourceConfigsLength; i++)
				{
					this._StreamingSourceConfigsCache.Add(IConditionalStreamingSourceConfig.Create(this.Instance.StreamingSourceConfigs(i)));
				}
				return this._StreamingSourceConfigsCache;
			}
		}

		// Token: 0x0400322C RID: 12844
		private IConditionalStreamingSource Instance;

		// Token: 0x0400322D RID: 12845
		private List<IConditionalStreamingSourceConfig> _StreamingSourceConfigsCache;

		// Token: 0x0400322E RID: 12846
		private bool _StreamingSourceConfigsInited;
	}
}
