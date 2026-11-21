using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002996 RID: 10646
	public class AddBuffToTriggeredEntity : ActionParams
	{
		// Token: 0x0600EC05 RID: 60421 RVA: 0x0022C0CF File Offset: 0x0022A2CF
		public static AddBuffToTriggeredEntity Create(IAddBuffToTriggeredEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AddBuffToTriggeredEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004587 RID: 17799
		// (get) Token: 0x0600EC06 RID: 60422 RVA: 0x0022C0F0 File Offset: 0x0022A2F0
		public virtual List<long> BuffIds
		{
			get
			{
				if (this._BuffIdsInited)
				{
					return this._BuffIdsCache;
				}
				this._BuffIdsInited = true;
				int buffIdsLength = this.Instance.BuffIdsLength;
				this._BuffIdsCache = new List<long>(buffIdsLength);
				for (int i = 0; i < buffIdsLength; i++)
				{
					this._BuffIdsCache.Add(this.Instance.BuffIds(i));
				}
				return this._BuffIdsCache;
			}
		}

		// Token: 0x040081F6 RID: 33270
		private IAddBuffToTriggeredEntity Instance;

		// Token: 0x040081F7 RID: 33271
		private List<long> _BuffIdsCache;

		// Token: 0x040081F8 RID: 33272
		private bool _BuffIdsInited;
	}
}
