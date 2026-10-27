using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007DF RID: 2015
	[NullableContext(1)]
	[Nullable(0)]
	public class IWellStreamingRenderConfig
	{
		// Token: 0x06002BC5 RID: 11205 RVA: 0x00072088 File Offset: 0x00070288
		private IWellStreamingRenderConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWellStreamingRenderConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWellStreamingRenderConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWellStreamingRenderConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x000720C0 File Offset: 0x000702C0
		public static IWellStreamingRenderConfig Create([Nullable(2)] IWellStreamingRenderConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWellStreamingRenderConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002BC7 RID: 11207 RVA: 0x000720D3 File Offset: 0x000702D3
		public static IWellStreamingRenderConfig CreateFromSetValue([Nullable(2)] IWellStreamingRenderConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWellStreamingRenderConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002BC8 RID: 11208 RVA: 0x000720E6 File Offset: 0x000702E6
		public IWellStreamingRenderConfig_SetValue ToSetValue()
		{
			return new IWellStreamingRenderConfig_SetValue
			{
				SelfConfig = this.SelfConfig,
				AsStreamPointConfig = this.AsStreamPointConfig
			};
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06002BC9 RID: 11209 RVA: 0x00072108 File Offset: 0x00070308
		// (set) Token: 0x06002BCA RID: 11210 RVA: 0x00072169 File Offset: 0x00070369
		public virtual IWellStreamingRenderSelfConfig SelfConfig
		{
			get
			{
				if (this._SelfConfigInited)
				{
					return this._SelfConfigCache;
				}
				this._SelfConfigInited = true;
				if (this.FbInstance != null)
				{
					this._SelfConfigCache = IWellStreamingRenderSelfConfig.Create(this.FbInstance.SelfConfig);
				}
				else
				{
					IWellStreamingRenderConfig_SetValue pocoInterface = this.PocoInterface;
					this._SelfConfigCache = ((pocoInterface != null) ? pocoInterface.SelfConfig : null);
				}
				return this._SelfConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().SelfConfig = value;
				this._SelfConfigInited = false;
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06002BCB RID: 11211 RVA: 0x00072180 File Offset: 0x00070380
		// (set) Token: 0x06002BCC RID: 11212 RVA: 0x000721E1 File Offset: 0x000703E1
		public virtual IWellStreamingRenderPointConfig AsStreamPointConfig
		{
			get
			{
				if (this._AsStreamPointConfigInited)
				{
					return this._AsStreamPointConfigCache;
				}
				this._AsStreamPointConfigInited = true;
				if (this.FbInstance != null)
				{
					this._AsStreamPointConfigCache = IWellStreamingRenderPointConfig.Create(this.FbInstance.AsStreamPointConfig);
				}
				else
				{
					IWellStreamingRenderConfig_SetValue pocoInterface = this.PocoInterface;
					this._AsStreamPointConfigCache = ((pocoInterface != null) ? pocoInterface.AsStreamPointConfig : null);
				}
				return this._AsStreamPointConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().AsStreamPointConfig = value;
				this._AsStreamPointConfigInited = false;
			}
		}

		// Token: 0x04001D09 RID: 7433
		[Nullable(2)]
		protected IWellStreamingRenderConfig FbInstance;

		// Token: 0x04001D0A RID: 7434
		[Nullable(2)]
		protected IWellStreamingRenderConfig_SetValue PocoInterface;

		// Token: 0x04001D0B RID: 7435
		private IWellStreamingRenderSelfConfig _SelfConfigCache;

		// Token: 0x04001D0C RID: 7436
		private bool _SelfConfigInited;

		// Token: 0x04001D0D RID: 7437
		private IWellStreamingRenderPointConfig _AsStreamPointConfigCache;

		// Token: 0x04001D0E RID: 7438
		private bool _AsStreamPointConfigInited;
	}
}
