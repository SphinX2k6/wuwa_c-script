using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A0B RID: 10763
	public class RunActions : ActionParams
	{
		// Token: 0x0600EDE8 RID: 60904 RVA: 0x0022F38D File Offset: 0x0022D58D
		public static RunActions Create(IRunActions? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RunActions
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004680 RID: 18048
		// (get) Token: 0x0600EDE9 RID: 60905 RVA: 0x0022F3AC File Offset: 0x0022D5AC
		public virtual List<ActionInfo> ActionList
		{
			get
			{
				if (this._ActionListInited)
				{
					return this._ActionListCache;
				}
				this._ActionListInited = true;
				int actionListLength = this.Instance.ActionListLength;
				this._ActionListCache = new List<ActionInfo>(actionListLength);
				for (int i = 0; i < actionListLength; i++)
				{
					this._ActionListCache.Add(ActionInfo.Create(this.Instance.ActionList(i)));
				}
				return this._ActionListCache;
			}
		}

		// Token: 0x040082E9 RID: 33513
		private IRunActions Instance;

		// Token: 0x040082EA RID: 33514
		private List<ActionInfo> _ActionListCache;

		// Token: 0x040082EB RID: 33515
		private bool _ActionListInited;
	}
}
