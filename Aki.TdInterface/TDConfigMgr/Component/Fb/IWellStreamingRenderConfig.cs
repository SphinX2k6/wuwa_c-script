using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F36 RID: 3894
	public class IWellStreamingRenderConfig
	{
		// Token: 0x06005773 RID: 22387 RVA: 0x000D63F0 File Offset: 0x000D45F0
		public static IWellStreamingRenderConfig Create(IWellStreamingRenderConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWellStreamingRenderConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D02 RID: 7426
		// (get) Token: 0x06005774 RID: 22388 RVA: 0x000D640F File Offset: 0x000D460F
		public virtual IWellStreamingRenderSelfConfig SelfConfig
		{
			get
			{
				if (this._SelfConfigInited)
				{
					return this._SelfConfigCache;
				}
				this._SelfConfigInited = true;
				this._SelfConfigCache = IWellStreamingRenderSelfConfig.Create(this.Instance.SelfConfig);
				return this._SelfConfigCache;
			}
		}

		// Token: 0x17001D03 RID: 7427
		// (get) Token: 0x06005775 RID: 22389 RVA: 0x000D6443 File Offset: 0x000D4643
		public virtual IWellStreamingRenderPointConfig AsStreamPointConfig
		{
			get
			{
				if (this._AsStreamPointConfigInited)
				{
					return this._AsStreamPointConfigCache;
				}
				this._AsStreamPointConfigInited = true;
				this._AsStreamPointConfigCache = IWellStreamingRenderPointConfig.Create(this.Instance.AsStreamPointConfig);
				return this._AsStreamPointConfigCache;
			}
		}

		// Token: 0x04003235 RID: 12853
		private IWellStreamingRenderConfig Instance;

		// Token: 0x04003236 RID: 12854
		[Nullable(2)]
		private IWellStreamingRenderSelfConfig _SelfConfigCache;

		// Token: 0x04003237 RID: 12855
		private bool _SelfConfigInited;

		// Token: 0x04003238 RID: 12856
		[Nullable(2)]
		private IWellStreamingRenderPointConfig _AsStreamPointConfigCache;

		// Token: 0x04003239 RID: 12857
		private bool _AsStreamPointConfigInited;
	}
}
