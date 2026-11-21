using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002A6 RID: 678
	public class IConditionalStreamingSource : IStreamingSourceConfigBase
	{
		// Token: 0x06000C31 RID: 3121 RVA: 0x0002FE38 File Offset: 0x0002E038
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

		// Token: 0x06000C32 RID: 3122 RVA: 0x0002FE70 File Offset: 0x0002E070
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

		// Token: 0x06000C33 RID: 3123 RVA: 0x0002FE83 File Offset: 0x0002E083
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

		// Token: 0x06000C34 RID: 3124 RVA: 0x0002FE96 File Offset: 0x0002E096
		public new IConditionalStreamingSource_SetValue ToSetValue()
		{
			return new IConditionalStreamingSource_SetValue
			{
				Type = this.Type,
				StreamingSourceConfigs = this.StreamingSourceConfigs
			};
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x0002FEB5 File Offset: 0x0002E0B5
		// (set) Token: 0x06000C36 RID: 3126 RVA: 0x0002FEE0 File Offset: 0x0002E0E0
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

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x0002FEF0 File Offset: 0x0002E0F0
		// (set) Token: 0x06000C38 RID: 3128 RVA: 0x0002FF83 File Offset: 0x0002E183
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

		// Token: 0x04000BB2 RID: 2994
		[Nullable(2)]
		protected new IConditionalStreamingSource FbInstance;

		// Token: 0x04000BB3 RID: 2995
		[Nullable(2)]
		protected new IConditionalStreamingSource_SetValue PocoInterface;

		// Token: 0x04000BB4 RID: 2996
		private List<IConditionalStreamingSourceConfig> _StreamingSourceConfigsCache;

		// Token: 0x04000BB5 RID: 2997
		private bool _StreamingSourceConfigsInited;
	}
}
