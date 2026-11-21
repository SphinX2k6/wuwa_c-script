using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002906 RID: 10502
	public class LockEntity : ActionParams
	{
		// Token: 0x0600E99C RID: 59804 RVA: 0x00227E61 File Offset: 0x00226061
		public static LockEntity Create(ILockEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LockEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700443E RID: 17470
		// (get) Token: 0x0600E99D RID: 59805 RVA: 0x00227E80 File Offset: 0x00226080
		public virtual List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x040080C2 RID: 32962
		private ILockEntity Instance;

		// Token: 0x040080C3 RID: 32963
		private List<int> _EntityIdsCache;

		// Token: 0x040080C4 RID: 32964
		private bool _EntityIdsInited;
	}
}
