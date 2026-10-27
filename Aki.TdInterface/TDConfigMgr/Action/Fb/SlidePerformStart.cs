using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A1D RID: 10781
	[NullableContext(1)]
	[Nullable(0)]
	public class SlidePerformStart : ActionParams
	{
		// Token: 0x0600EDA6 RID: 60838 RVA: 0x0022A202 File Offset: 0x00228402
		public static SlidePerformStart Create(ISlidePerformStart? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SlidePerformStart
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B2E RID: 19246
		// (get) Token: 0x0600EDA7 RID: 60839 RVA: 0x0022A221 File Offset: 0x00228421
		public virtual int SlideEntityId
		{
			get
			{
				return this.Instance.SlideEntityId;
			}
		}

		// Token: 0x17004B2F RID: 19247
		// (get) Token: 0x0600EDA8 RID: 60840 RVA: 0x0022A22E File Offset: 0x0022842E
		public virtual ISlopeSlidePerformStart SlidePerformConfig
		{
			get
			{
				if (this._SlidePerformConfigInited)
				{
					return this._SlidePerformConfigCache;
				}
				this._SlidePerformConfigInited = true;
				this._SlidePerformConfigCache = ISlopeSlidePerformStart.Create(this.Instance.SlidePerformConfig);
				return this._SlidePerformConfigCache;
			}
		}

		// Token: 0x040082CD RID: 33485
		private ISlidePerformStart Instance;

		// Token: 0x040082CE RID: 33486
		[Nullable(2)]
		private ISlopeSlidePerformStart _SlidePerformConfigCache;

		// Token: 0x040082CF RID: 33487
		private bool _SlidePerformConfigInited;
	}
}
