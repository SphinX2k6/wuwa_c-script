using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002722 RID: 10018
	[NullableContext(1)]
	[Nullable(0)]
	public class IPerformerRangeBoundaryActionTrigger
	{
		// Token: 0x0600DF69 RID: 57193 RVA: 0x00211B0A File Offset: 0x0020FD0A
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

		// Token: 0x170042E7 RID: 17127
		// (get) Token: 0x0600DF6A RID: 57194 RVA: 0x00211B29 File Offset: 0x0020FD29
		public virtual int Range
		{
			get
			{
				return this.Instance.Range;
			}
		}

		// Token: 0x170042E8 RID: 17128
		// (get) Token: 0x0600DF6B RID: 57195 RVA: 0x00211B38 File Offset: 0x0020FD38
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

		// Token: 0x04007BFA RID: 31738
		private IPerformerRangeBoundaryActionTrigger Instance;

		// Token: 0x04007BFB RID: 31739
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007BFC RID: 31740
		private bool _ActionsInited;
	}
}
