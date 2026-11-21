using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002935 RID: 10549
	public class RemoveBuffFromPlayer : ActionParams
	{
		// Token: 0x0600EA76 RID: 60022 RVA: 0x002298D4 File Offset: 0x00227AD4
		public static RemoveBuffFromPlayer Create(IRemoveBuffFromPlayer? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RemoveBuffFromPlayer
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044BA RID: 17594
		// (get) Token: 0x0600EA77 RID: 60023 RVA: 0x002298F4 File Offset: 0x00227AF4
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

		// Token: 0x0400813B RID: 33083
		private IRemoveBuffFromPlayer Instance;

		// Token: 0x0400813C RID: 33084
		private List<long> _BuffIdsCache;

		// Token: 0x0400813D RID: 33085
		private bool _BuffIdsInited;
	}
}
