using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029DD RID: 10717
	public class IBubbleRangeCylinderConfig
	{
		// Token: 0x0600ED1B RID: 60699 RVA: 0x0022DC8A File Offset: 0x0022BE8A
		public static IBubbleRangeCylinderConfig Create(IBubbleRangeCylinderConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBubbleRangeCylinderConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700460F RID: 17935
		// (get) Token: 0x0600ED1C RID: 60700 RVA: 0x0022DCA9 File Offset: 0x0022BEA9
		public virtual IBubbleCylinderConfig InnerConfig
		{
			get
			{
				if (this._InnerConfigInited)
				{
					return this._InnerConfigCache;
				}
				this._InnerConfigInited = true;
				this._InnerConfigCache = IBubbleCylinderConfig.Create(this.Instance.InnerConfig);
				return this._InnerConfigCache;
			}
		}

		// Token: 0x17004610 RID: 17936
		// (get) Token: 0x0600ED1D RID: 60701 RVA: 0x0022DCDD File Offset: 0x0022BEDD
		public virtual IBubbleCylinderConfig OuterConfig
		{
			get
			{
				if (this._OuterConfigInited)
				{
					return this._OuterConfigCache;
				}
				this._OuterConfigInited = true;
				this._OuterConfigCache = IBubbleCylinderConfig.Create(this.Instance.OuterConfig);
				return this._OuterConfigCache;
			}
		}

		// Token: 0x0400827D RID: 33405
		private IBubbleRangeCylinderConfig Instance;

		// Token: 0x0400827E RID: 33406
		[Nullable(2)]
		private IBubbleCylinderConfig _InnerConfigCache;

		// Token: 0x0400827F RID: 33407
		private bool _InnerConfigInited;

		// Token: 0x04008280 RID: 33408
		[Nullable(2)]
		private IBubbleCylinderConfig _OuterConfigCache;

		// Token: 0x04008281 RID: 33409
		private bool _OuterConfigInited;
	}
}
