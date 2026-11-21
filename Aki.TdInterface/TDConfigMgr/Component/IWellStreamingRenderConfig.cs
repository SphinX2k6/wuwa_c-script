using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000882 RID: 2178
	public class IWellStreamingRenderConfig
	{
		// Token: 0x06002EF5 RID: 12021 RVA: 0x000793EC File Offset: 0x000775EC
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

		// Token: 0x06002EF6 RID: 12022 RVA: 0x00079424 File Offset: 0x00077624
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

		// Token: 0x06002EF7 RID: 12023 RVA: 0x00079437 File Offset: 0x00077637
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

		// Token: 0x06002EF8 RID: 12024 RVA: 0x0007944A File Offset: 0x0007764A
		public IWellStreamingRenderConfig_SetValue ToSetValue()
		{
			return new IWellStreamingRenderConfig_SetValue
			{
				SelfConfig = this.SelfConfig,
				AsStreamPointConfig = this.AsStreamPointConfig
			};
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x06002EF9 RID: 12025 RVA: 0x0007946C File Offset: 0x0007766C
		// (set) Token: 0x06002EFA RID: 12026 RVA: 0x000794CD File Offset: 0x000776CD
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

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06002EFB RID: 12027 RVA: 0x000794E4 File Offset: 0x000776E4
		// (set) Token: 0x06002EFC RID: 12028 RVA: 0x00079545 File Offset: 0x00077745
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

		// Token: 0x04001F15 RID: 7957
		[Nullable(2)]
		protected IWellStreamingRenderConfig FbInstance;

		// Token: 0x04001F16 RID: 7958
		[Nullable(2)]
		protected IWellStreamingRenderConfig_SetValue PocoInterface;

		// Token: 0x04001F17 RID: 7959
		private IWellStreamingRenderSelfConfig _SelfConfigCache;

		// Token: 0x04001F18 RID: 7960
		private bool _SelfConfigInited;

		// Token: 0x04001F19 RID: 7961
		private IWellStreamingRenderPointConfig _AsStreamPointConfigCache;

		// Token: 0x04001F1A RID: 7962
		private bool _AsStreamPointConfigInited;
	}
}
