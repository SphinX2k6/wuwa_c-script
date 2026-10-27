using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002878 RID: 10360
	[NullableContext(1)]
	[Nullable(0)]
	public class ITuningStandGridBoard
	{
		// Token: 0x0600E585 RID: 58757 RVA: 0x0021BE05 File Offset: 0x0021A005
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

		// Token: 0x17004657 RID: 18007
		// (get) Token: 0x0600E586 RID: 58758 RVA: 0x0021BE24 File Offset: 0x0021A024
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

		// Token: 0x04007EEA RID: 32490
		private ITuningStandGridBoard Instance;

		// Token: 0x04007EEB RID: 32491
		private List<ETuningStandGridType> _GridsCache;

		// Token: 0x04007EEC RID: 32492
		private bool _GridsInited;
	}
}
