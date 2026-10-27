using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E3A RID: 3642
	[NullableContext(1)]
	[Nullable(0)]
	public class IWellStreamingRenderConfig
	{
		// Token: 0x0600524C RID: 21068 RVA: 0x000CAB28 File Offset: 0x000C8D28
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

		// Token: 0x17001B95 RID: 7061
		// (get) Token: 0x0600524D RID: 21069 RVA: 0x000CAB47 File Offset: 0x000C8D47
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

		// Token: 0x17001B96 RID: 7062
		// (get) Token: 0x0600524E RID: 21070 RVA: 0x000CAB7B File Offset: 0x000C8D7B
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

		// Token: 0x04002F6D RID: 12141
		private IWellStreamingRenderConfig Instance;

		// Token: 0x04002F6E RID: 12142
		[Nullable(2)]
		private IWellStreamingRenderSelfConfig _SelfConfigCache;

		// Token: 0x04002F6F RID: 12143
		private bool _SelfConfigInited;

		// Token: 0x04002F70 RID: 12144
		[Nullable(2)]
		private IWellStreamingRenderPointConfig _AsStreamPointConfigCache;

		// Token: 0x04002F71 RID: 12145
		private bool _AsStreamPointConfigInited;
	}
}
