using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024E3 RID: 9443
	[NullableContext(1)]
	[Nullable(0)]
	public class ITriggerActions
	{
		// Token: 0x0600D2C4 RID: 53956 RVA: 0x001F4315 File Offset: 0x001F2515
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

		// Token: 0x17003AC0 RID: 15040
		// (get) Token: 0x0600D2C5 RID: 53957 RVA: 0x001F4334 File Offset: 0x001F2534
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

		// Token: 0x0400739D RID: 29597
		private ITriggerActions Instance;

		// Token: 0x0400739E RID: 29598
		private List<ActionInfo> _ActionsCache;

		// Token: 0x0400739F RID: 29599
		private bool _ActionsInited;
	}
}
