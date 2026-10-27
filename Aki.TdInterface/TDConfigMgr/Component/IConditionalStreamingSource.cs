using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000263 RID: 611
	[NullableContext(1)]
	[Nullable(0)]
	public class IConditionalStreamingSource : IStreamingSourceConfigBase
	{
		// Token: 0x06000B17 RID: 2839 RVA: 0x0002D148 File Offset: 0x0002B348
		private IConditionalStreamingSource_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IConditionalStreamingSource 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IConditionalStreamingSource_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IConditionalStreamingSource_SetValue());
			}
			return result;
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x0002D180 File Offset: 0x0002B380
		public static IConditionalStreamingSource Create([Nullable(2)] IConditionalStreamingSource instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConditionalStreamingSource
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0002D193 File Offset: 0x0002B393
		public static IConditionalStreamingSource CreateFromSetValue([Nullable(2)] IConditionalStreamingSource_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IConditionalStreamingSource
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x0002D1A6 File Offset: 0x0002B3A6
		public new IConditionalStreamingSource_SetValue ToSetValue()
		{
			return new IConditionalStreamingSource_SetValue
			{
				Type = this.Type,
				StreamingSourceConfigs = this.StreamingSourceConfigs
			};
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x0002D1C5 File Offset: 0x0002B3C5
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x0002D1F0 File Offset: 0x0002B3F0
		public override EStreamingSourceMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EStreamingSourceMode.Fixed;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x0002D200 File Offset: 0x0002B400
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x0002D293 File Offset: 0x0002B493
		public virtual List<IConditionalStreamingSourceConfig> StreamingSourceConfigs
		{
			get
			{
				if (this._StreamingSourceConfigsInited)
				{
					return this._StreamingSourceConfigsCache;
				}
				this._StreamingSourceConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<IConditionalStreamingSourceConfig> streamingSourceConfigs = this.FbInstance.StreamingSourceConfigs;
					if (streamingSourceConfigs != null)
					{
						this._StreamingSourceConfigsCache = new List<IConditionalStreamingSourceConfig>(streamingSourceConfigs.Count);
						for (int i = 0; i < streamingSourceConfigs.Count; i++)
						{
							this._StreamingSourceConfigsCache.Add(IConditionalStreamingSourceConfig.Create(streamingSourceConfigs[i]));
						}
					}
				}
				else
				{
					IConditionalStreamingSource_SetValue pocoInterface = this.PocoInterface;
					this._StreamingSourceConfigsCache = ((pocoInterface != null) ? pocoInterface.StreamingSourceConfigs : null);
				}
				return this._StreamingSourceConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().StreamingSourceConfigs = value;
				this._StreamingSourceConfigsInited = false;
			}
		}

		// Token: 0x04000AD1 RID: 2769
		[Nullable(2)]
		protected new IConditionalStreamingSource FbInstance;

		// Token: 0x04000AD2 RID: 2770
		[Nullable(2)]
		protected new IConditionalStreamingSource_SetValue PocoInterface;

		// Token: 0x04000AD3 RID: 2771
		private List<IConditionalStreamingSourceConfig> _StreamingSourceConfigsCache;

		// Token: 0x04000AD4 RID: 2772
		private bool _StreamingSourceConfigsInited;
	}
}
