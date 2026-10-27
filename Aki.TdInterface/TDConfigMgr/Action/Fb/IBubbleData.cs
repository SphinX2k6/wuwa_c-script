using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002625 RID: 9765
	[NullableContext(1)]
	[Nullable(0)]
	public class IBubbleData : ActionParams
	{
		// Token: 0x0600DB34 RID: 56116 RVA: 0x0020A42A File Offset: 0x0020862A
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

		// Token: 0x170040AC RID: 16556
		// (get) Token: 0x0600DB35 RID: 56117 RVA: 0x0020A449 File Offset: 0x00208649
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

		// Token: 0x170040AD RID: 16557
		// (get) Token: 0x0600DB36 RID: 56118 RVA: 0x0020A47D File Offset: 0x0020867D
		public virtual int WaitTime
		{
			get
			{
				return this.Instance.WaitTime;
			}
		}

		// Token: 0x040079C5 RID: 31173
		private IBubbleData Instance;

		// Token: 0x040079C6 RID: 31174
		[Nullable(2)]
		private IBubbleIndex _FlowIndexCache;

		// Token: 0x040079C7 RID: 31175
		private bool _FlowIndexInited;
	}
}
