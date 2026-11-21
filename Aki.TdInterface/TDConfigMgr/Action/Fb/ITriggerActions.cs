using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002788 RID: 10120
	public class ITriggerActions
	{
		// Token: 0x0600E019 RID: 57369 RVA: 0x0020FB71 File Offset: 0x0020DD71
		public static ITriggerActions Create(ITriggerActions? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITriggerActions
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DB7 RID: 15799
		// (get) Token: 0x0600E01A RID: 57370 RVA: 0x0020FB90 File Offset: 0x0020DD90
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

		// Token: 0x040079EA RID: 31210
		private ITriggerActions Instance;

		// Token: 0x040079EB RID: 31211
		private List<ActionInfo> _ActionsCache;

		// Token: 0x040079EC RID: 31212
		private bool _ActionsInited;
	}
}
