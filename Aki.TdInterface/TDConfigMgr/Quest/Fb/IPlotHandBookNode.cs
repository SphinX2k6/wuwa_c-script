using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015BC RID: 5564
	public class IPlotHandBookNode
	{
		// Token: 0x06007D96 RID: 32150 RVA: 0x0012AB4A File Offset: 0x00128D4A
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

		// Token: 0x170029C0 RID: 10688
		// (get) Token: 0x06007D97 RID: 32151 RVA: 0x0012AB69 File Offset: 0x00128D69
		public virtual string TidTip
		{
			get
			{
				return this.Instance.TidTip;
			}
		}

		// Token: 0x170029C1 RID: 10689
		// (get) Token: 0x06007D98 RID: 32152 RVA: 0x0012AB76 File Offset: 0x00128D76
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

		// Token: 0x170029C2 RID: 10690
		// (get) Token: 0x06007D99 RID: 32153 RVA: 0x0012ABAA File Offset: 0x00128DAA
		public virtual bool IsHideUi
		{
			get
			{
				return this.Instance.IsHideUi;
			}
		}

		// Token: 0x040048A6 RID: 18598
		private IPlotHandBookNode Instance;

		// Token: 0x040048A7 RID: 18599
		[Nullable(2)]
		private IFlowStateIndex _FlowCache;

		// Token: 0x040048A8 RID: 18600
		private bool _FlowInited;
	}
}
