using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B4E RID: 11086
	public class ITuningStandGridBoard
	{
		// Token: 0x0600F3B6 RID: 62390 RVA: 0x00238D59 File Offset: 0x00236F59
		public static ITuningStandGridBoard Create(ITuningStandGridBoard? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITuningStandGridBoard
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049C8 RID: 18888
		// (get) Token: 0x0600F3B7 RID: 62391 RVA: 0x00238D78 File Offset: 0x00236F78
		public virtual List<ETuningStandGridType> Grids
		{
			get
			{
				if (this._GridsInited)
				{
					return this._GridsCache;
				}
				this._GridsInited = true;
				int gridsLength = this.Instance.GridsLength;
				this._GridsCache = new List<ETuningStandGridType>(gridsLength);
				for (int i = 0; i < gridsLength; i++)
				{
					this._GridsCache.Add((ETuningStandGridType)this.Instance.Grids(i));
				}
				return this._GridsCache;
			}
		}

		// Token: 0x040085AA RID: 34218
		private ITuningStandGridBoard Instance;

		// Token: 0x040085AB RID: 34219
		private List<ETuningStandGridType> _GridsCache;

		// Token: 0x040085AC RID: 34220
		private bool _GridsInited;
	}
}
