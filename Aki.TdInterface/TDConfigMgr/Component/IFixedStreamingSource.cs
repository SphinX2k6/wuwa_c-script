using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200039A RID: 922
	[NullableContext(1)]
	[Nullable(0)]
	public class IFixedStreamingSource : IStreamingSourceConfigBase
	{
		// Token: 0x0600125D RID: 4701 RVA: 0x0003CBBC File Offset: 0x0003ADBC
		private IFixedStreamingSource_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFixedStreamingSource 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFixedStreamingSource_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFixedStreamingSource_SetValue());
			}
			return result;
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x0003CBF4 File Offset: 0x0003ADF4
		public static IFixedStreamingSource Create([Nullable(2)] IFixedStreamingSource instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixedStreamingSource
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x0003CC07 File Offset: 0x0003AE07
		public static IFixedStreamingSource CreateFromSetValue([Nullable(2)] IFixedStreamingSource_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFixedStreamingSource
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x0003CC1A File Offset: 0x0003AE1A
		public new IFixedStreamingSource_SetValue ToSetValue()
		{
			return new IFixedStreamingSource_SetValue
			{
				Type = this.Type,
				StreamingSourceConfig = this.StreamingSourceConfig
			};
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001261 RID: 4705 RVA: 0x0003CC39 File Offset: 0x0003AE39
		// (set) Token: 0x06001262 RID: 4706 RVA: 0x0003CC64 File Offset: 0x0003AE64
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

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001263 RID: 4707 RVA: 0x0003CC74 File Offset: 0x0003AE74
		// (set) Token: 0x06001264 RID: 4708 RVA: 0x0003CCD5 File Offset: 0x0003AED5
		public virtual IStreamingSourceConfig StreamingSourceConfig
		{
			get
			{
				if (this._StreamingSourceConfigInited)
				{
					return this._StreamingSourceConfigCache;
				}
				this._StreamingSourceConfigInited = true;
				if (this.FbInstance != null)
				{
					this._StreamingSourceConfigCache = IStreamingSourceConfig.Create(this.FbInstance.StreamingSourceConfig);
				}
				else
				{
					IFixedStreamingSource_SetValue pocoInterface = this.PocoInterface;
					this._StreamingSourceConfigCache = ((pocoInterface != null) ? pocoInterface.StreamingSourceConfig : null);
				}
				return this._StreamingSourceConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().StreamingSourceConfig = value;
				this._StreamingSourceConfigInited = false;
			}
		}

		// Token: 0x04000ED0 RID: 3792
		[Nullable(2)]
		protected new IFixedStreamingSource FbInstance;

		// Token: 0x04000ED1 RID: 3793
		[Nullable(2)]
		protected new IFixedStreamingSource_SetValue PocoInterface;

		// Token: 0x04000ED2 RID: 3794
		private IStreamingSourceConfig _StreamingSourceConfigCache;

		// Token: 0x04000ED3 RID: 3795
		private bool _StreamingSourceConfigInited;
	}
}
