using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002647 RID: 9799
	[NullableContext(1)]
	[Nullable(0)]
	public class UnlockEntity : ActionParams
	{
		// Token: 0x0600DBD1 RID: 56273 RVA: 0x0020B720 File Offset: 0x00209920
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

		// Token: 0x17004105 RID: 16645
		// (get) Token: 0x0600DBD2 RID: 56274 RVA: 0x0020B740 File Offset: 0x00209940
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

		// Token: 0x04007A29 RID: 31273
		private IUnlockEntity Instance;

		// Token: 0x04007A2A RID: 31274
		private List<int> _EntityIdsCache;

		// Token: 0x04007A2B RID: 31275
		private bool _EntityIdsInited;
	}
}
