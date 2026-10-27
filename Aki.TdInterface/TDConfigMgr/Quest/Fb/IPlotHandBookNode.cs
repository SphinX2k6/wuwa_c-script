using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001463 RID: 5219
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlotHandBookNode
	{
		// Token: 0x060076C8 RID: 30408 RVA: 0x0011BF32 File Offset: 0x0011A132
		public static IPlotHandBookNode Create(IPlotHandBookNode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlotHandBookNode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027D5 RID: 10197
		// (get) Token: 0x060076C9 RID: 30409 RVA: 0x0011BF51 File Offset: 0x0011A151
		public virtual string TidTip
		{
			get
			{
				return this.Instance.TidTip;
			}
		}

		// Token: 0x170027D6 RID: 10198
		// (get) Token: 0x060076CA RID: 30410 RVA: 0x0011BF5E File Offset: 0x0011A15E
		public virtual IFlowStateIndex Flow
		{
			get
			{
				if (this._FlowInited)
				{
					return this._FlowCache;
				}
				this._FlowInited = true;
				this._FlowCache = IFlowStateIndex.Create(this.Instance.Flow);
				return this._FlowCache;
			}
		}

		// Token: 0x170027D7 RID: 10199
		// (get) Token: 0x060076CB RID: 30411 RVA: 0x0011BF92 File Offset: 0x0011A192
		public virtual bool IsHideUi
		{
			get
			{
				return this.Instance.IsHideUi;
			}
		}

		// Token: 0x0400450B RID: 17675
		private IPlotHandBookNode Instance;

		// Token: 0x0400450C RID: 17676
		[Nullable(2)]
		private IFlowStateIndex _FlowCache;

		// Token: 0x0400450D RID: 17677
		private bool _FlowInited;
	}
}
