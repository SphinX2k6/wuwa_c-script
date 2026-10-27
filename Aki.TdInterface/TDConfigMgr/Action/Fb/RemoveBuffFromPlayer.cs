using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002676 RID: 9846
	[NullableContext(1)]
	[Nullable(0)]
	public class RemoveBuffFromPlayer : ActionParams
	{
		// Token: 0x0600DCAA RID: 56490 RVA: 0x0020D1C4 File Offset: 0x0020B3C4
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

		// Token: 0x17004180 RID: 16768
		// (get) Token: 0x0600DCAB RID: 56491 RVA: 0x0020D1E4 File Offset: 0x0020B3E4
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

		// Token: 0x04007AA4 RID: 31396
		private IRemoveBuffFromPlayer Instance;

		// Token: 0x04007AA5 RID: 31397
		private List<long> _BuffIdsCache;

		// Token: 0x04007AA6 RID: 31398
		private bool _BuffIdsInited;
	}
}
