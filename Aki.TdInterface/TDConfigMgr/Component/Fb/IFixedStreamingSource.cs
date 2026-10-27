using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E36 RID: 3638
	[NullableContext(1)]
	[Nullable(0)]
	public class IFixedStreamingSource : IStreamingSourceConfigBase
	{
		// Token: 0x06005239 RID: 21049 RVA: 0x000CA8FD File Offset: 0x000C8AFD
		public static IFixedStreamingSource Create(IFixedStreamingSource? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixedStreamingSource
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B8A RID: 7050
		// (get) Token: 0x0600523A RID: 21050 RVA: 0x000CA91C File Offset: 0x000C8B1C
		public override EStreamingSourceMode Type
		{
			get
			{
				return (EStreamingSourceMode)this.Instance.Type;
			}
		}

		// Token: 0x17001B8B RID: 7051
		// (get) Token: 0x0600523B RID: 21051 RVA: 0x000CA929 File Offset: 0x000C8B29
		public virtual IStreamingSourceConfig StreamingSourceConfig
		{
			get
			{
				if (this._StreamingSourceConfigInited)
				{
					return this._StreamingSourceConfigCache;
				}
				this._StreamingSourceConfigInited = true;
				this._StreamingSourceConfigCache = IStreamingSourceConfig.Create(this.Instance.StreamingSourceConfig);
				return this._StreamingSourceConfigCache;
			}
		}

		// Token: 0x04002F61 RID: 12129
		private IFixedStreamingSource Instance;

		// Token: 0x04002F62 RID: 12130
		[Nullable(2)]
		private IStreamingSourceConfig _StreamingSourceConfigCache;

		// Token: 0x04002F63 RID: 12131
		private bool _StreamingSourceConfigInited;
	}
}
