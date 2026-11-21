using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200277E RID: 10110
	public class ClearEntityVisibleTag : ActionParams
	{
		// Token: 0x0600DFFB RID: 57339 RVA: 0x0020F7E6 File Offset: 0x0020D9E6
		public static ClearEntityVisibleTag Create(IClearEntityVisibleTag? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClearEntityVisibleTag
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DAD RID: 15789
		// (get) Token: 0x0600DFFC RID: 57340 RVA: 0x0020F808 File Offset: 0x0020DA08
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

		// Token: 0x040079D4 RID: 31188
		private IClearEntityVisibleTag Instance;

		// Token: 0x040079D5 RID: 31189
		private List<int> _EntityIdsCache;

		// Token: 0x040079D6 RID: 31190
		private bool _EntityIdsInited;
	}
}
