using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002997 RID: 10647
	public class RemoveBuffToTriggeredEntity : ActionParams
	{
		// Token: 0x0600EC08 RID: 60424 RVA: 0x0022C15C File Offset: 0x0022A35C
		public static RemoveBuffToTriggeredEntity Create(IRemoveBuffToTriggeredEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RemoveBuffToTriggeredEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004588 RID: 17800
		// (get) Token: 0x0600EC09 RID: 60425 RVA: 0x0022C17C File Offset: 0x0022A37C
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

		// Token: 0x040081F9 RID: 33273
		private IRemoveBuffToTriggeredEntity Instance;

		// Token: 0x040081FA RID: 33274
		private List<long> _BuffIdsCache;

		// Token: 0x040081FB RID: 33275
		private bool _BuffIdsInited;
	}
}
