using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E37 RID: 3639
	[NullableContext(1)]
	[Nullable(0)]
	public class IConditionalStreamingSource : IStreamingSourceConfigBase
	{
		// Token: 0x0600523D RID: 21053 RVA: 0x000CA965 File Offset: 0x000C8B65
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

		// Token: 0x17001B8C RID: 7052
		// (get) Token: 0x0600523E RID: 21054 RVA: 0x000CA984 File Offset: 0x000C8B84
		public override EStreamingSourceMode Type
		{
			get
			{
				return (EStreamingSourceMode)this.Instance.Type;
			}
		}

		// Token: 0x17001B8D RID: 7053
		// (get) Token: 0x0600523F RID: 21055 RVA: 0x000CA994 File Offset: 0x000C8B94
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

		// Token: 0x04002F64 RID: 12132
		private IConditionalStreamingSource Instance;

		// Token: 0x04002F65 RID: 12133
		private List<IConditionalStreamingSourceConfig> _StreamingSourceConfigsCache;

		// Token: 0x04002F66 RID: 12134
		private bool _StreamingSourceConfigsInited;
	}
}
