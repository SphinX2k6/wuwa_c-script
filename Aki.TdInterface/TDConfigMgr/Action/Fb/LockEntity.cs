using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002646 RID: 9798
	[NullableContext(1)]
	[Nullable(0)]
	public class LockEntity : ActionParams
	{
		// Token: 0x0600DBCE RID: 56270 RVA: 0x0020B695 File Offset: 0x00209895
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

		// Token: 0x17004104 RID: 16644
		// (get) Token: 0x0600DBCF RID: 56271 RVA: 0x0020B6B4 File Offset: 0x002098B4
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

		// Token: 0x04007A26 RID: 31270
		private ILockEntity Instance;

		// Token: 0x04007A27 RID: 31271
		private List<int> _EntityIdsCache;

		// Token: 0x04007A28 RID: 31272
		private bool _EntityIdsInited;
	}
}
