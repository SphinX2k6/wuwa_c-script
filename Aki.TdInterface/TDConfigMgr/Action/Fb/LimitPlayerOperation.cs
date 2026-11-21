using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A9B RID: 10907
	public class LimitPlayerOperation : ActionParams
	{
		// Token: 0x0600F09A RID: 61594 RVA: 0x00233FCE File Offset: 0x002321CE
		public static LimitPlayerOperation Create(ILimitPlayerOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LimitPlayerOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004812 RID: 18450
		// (get) Token: 0x0600F09B RID: 61595 RVA: 0x00233FED File Offset: 0x002321ED
		public virtual ILimitPlayerOption Type
		{
			get
			{
				if (this._TypeInited)
				{
					return this._TypeCache;
				}
				this._TypeInited = true;
				this._TypeCache = ActionReadHelper.ReadLimitPlayerOperation_Type(this.Instance);
				return this._TypeCache;
			}
		}

		// Token: 0x0400844F RID: 33871
		private ILimitPlayerOperation Instance;

		// Token: 0x04008450 RID: 33872
		private ILimitPlayerOption _TypeCache;

		// Token: 0x04008451 RID: 33873
		private bool _TypeInited;
	}
}
