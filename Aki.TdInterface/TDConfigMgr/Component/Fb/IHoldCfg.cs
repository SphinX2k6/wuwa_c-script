using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B51 RID: 2897
	[NullableContext(2)]
	[Nullable(0)]
	public class IHoldCfg
	{
		// Token: 0x060042BC RID: 17084 RVA: 0x000AA56A File Offset: 0x000A876A
		[NullableContext(1)]
		public static IHoldCfg Create(IHoldCfg? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHoldCfg
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x060042BD RID: 17085 RVA: 0x000AA589 File Offset: 0x000A8789
		public virtual IHoldingTrackTarget TrackTarget
		{
			get
			{
				if (this._TrackTargetInited)
				{
					return this._TrackTargetCache;
				}
				this._TrackTargetInited = true;
				this._TrackTargetCache = IHoldingTrackTarget.Create(this.Instance.TrackTarget);
				return this._TrackTargetCache;
			}
		}

		// Token: 0x04002594 RID: 9620
		private IHoldCfg Instance;

		// Token: 0x04002595 RID: 9621
		private IHoldingTrackTarget _TrackTargetCache;

		// Token: 0x04002596 RID: 9622
		private bool _TrackTargetInited;
	}
}
