using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029EC RID: 10732
	public class IPerformerRangeBoundaryActionTrigger
	{
		// Token: 0x0600ED61 RID: 60769 RVA: 0x0022E59A File Offset: 0x0022C79A
		public static IPerformerRangeBoundaryActionTrigger Create(IPerformerRangeBoundaryActionTrigger? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPerformerRangeBoundaryActionTrigger
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004637 RID: 17975
		// (get) Token: 0x0600ED62 RID: 60770 RVA: 0x0022E5B9 File Offset: 0x0022C7B9
		public virtual int Range
		{
			get
			{
				return this.Instance.Range;
			}
		}

		// Token: 0x17004638 RID: 17976
		// (get) Token: 0x0600ED63 RID: 60771 RVA: 0x0022E5C8 File Offset: 0x0022C7C8
		public virtual List<ActionInfo> Actions
		{
			get
			{
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				int actionsLength = this.Instance.ActionsLength;
				this._ActionsCache = new List<ActionInfo>(actionsLength);
				for (int i = 0; i < actionsLength; i++)
				{
					this._ActionsCache.Add(ActionInfo.Create(this.Instance.Actions(i)));
				}
				return this._ActionsCache;
			}
		}

		// Token: 0x040082A4 RID: 33444
		private IPerformerRangeBoundaryActionTrigger Instance;

		// Token: 0x040082A5 RID: 33445
		private List<ActionInfo> _ActionsCache;

		// Token: 0x040082A6 RID: 33446
		private bool _ActionsInited;
	}
}
