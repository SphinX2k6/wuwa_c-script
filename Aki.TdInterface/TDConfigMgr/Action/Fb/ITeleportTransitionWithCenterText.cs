using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002954 RID: 10580
	public class ITeleportTransitionWithCenterText : ITeleportTransitionType
	{
		// Token: 0x0600EAE4 RID: 60132 RVA: 0x0022A2E3 File Offset: 0x002284E3
		public static ITeleportTransitionWithCenterText Create(ITeleportTransitionWithCenterText? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionWithCenterText
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044EA RID: 17642
		// (get) Token: 0x0600EAE5 RID: 60133 RVA: 0x0022A302 File Offset: 0x00228502
		public override ETeleportTransitionType Type
		{
			get
			{
				return (ETeleportTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x170044EB RID: 17643
		// (get) Token: 0x0600EAE6 RID: 60134 RVA: 0x0022A30F File Offset: 0x0022850F
		public virtual PlayFlow CenterTextFlow
		{
			get
			{
				if (this._CenterTextFlowInited)
				{
					return this._CenterTextFlowCache;
				}
				this._CenterTextFlowInited = true;
				this._CenterTextFlowCache = PlayFlow.Create(this.Instance.CenterTextFlow);
				return this._CenterTextFlowCache;
			}
		}

		// Token: 0x04008166 RID: 33126
		private ITeleportTransitionWithCenterText Instance;

		// Token: 0x04008167 RID: 33127
		[Nullable(2)]
		private PlayFlow _CenterTextFlowCache;

		// Token: 0x04008168 RID: 33128
		private bool _CenterTextFlowInited;
	}
}
