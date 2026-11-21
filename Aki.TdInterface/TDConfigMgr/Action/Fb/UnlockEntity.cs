using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002907 RID: 10503
	public class UnlockEntity : ActionParams
	{
		// Token: 0x0600E99F RID: 59807 RVA: 0x00227EEC File Offset: 0x002260EC
		public static UnlockEntity Create(IUnlockEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new UnlockEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700443F RID: 17471
		// (get) Token: 0x0600E9A0 RID: 59808 RVA: 0x00227F0C File Offset: 0x0022610C
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

		// Token: 0x040080C5 RID: 32965
		private IUnlockEntity Instance;

		// Token: 0x040080C6 RID: 32966
		private List<int> _EntityIdsCache;

		// Token: 0x040080C7 RID: 32967
		private bool _EntityIdsInited;
	}
}
