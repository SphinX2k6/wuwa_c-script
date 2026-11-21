using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028E5 RID: 10469
	public class IBubbleData : ActionParams
	{
		// Token: 0x0600E902 RID: 59650 RVA: 0x00226BF6 File Offset: 0x00224DF6
		public static IBubbleData Create(IBubbleData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBubbleData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043E6 RID: 17382
		// (get) Token: 0x0600E903 RID: 59651 RVA: 0x00226C15 File Offset: 0x00224E15
		public virtual IBubbleIndex FlowIndex
		{
			get
			{
				if (this._FlowIndexInited)
				{
					return this._FlowIndexCache;
				}
				this._FlowIndexInited = true;
				this._FlowIndexCache = IBubbleIndex.Create(this.Instance.FlowIndex);
				return this._FlowIndexCache;
			}
		}

		// Token: 0x170043E7 RID: 17383
		// (get) Token: 0x0600E904 RID: 59652 RVA: 0x00226C49 File Offset: 0x00224E49
		public virtual int WaitTime
		{
			get
			{
				return this.Instance.WaitTime;
			}
		}

		// Token: 0x04008061 RID: 32865
		private IBubbleData Instance;

		// Token: 0x04008062 RID: 32866
		[Nullable(2)]
		private IBubbleIndex _FlowIndexCache;

		// Token: 0x04008063 RID: 32867
		private bool _FlowIndexInited;
	}
}
