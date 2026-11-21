using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002786 RID: 10118
	public class FixShowTargetRange : ActionParams
	{
		// Token: 0x0600E012 RID: 57362 RVA: 0x0020FA48 File Offset: 0x0020DC48
		public static FixShowTargetRange Create(IFixShowTargetRange? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FixShowTargetRange
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DB4 RID: 15796
		// (get) Token: 0x0600E013 RID: 57363 RVA: 0x0020FA68 File Offset: 0x0020DC68
		public virtual List<int> RangeEntities
		{
			get
			{
				if (this._RangeEntitiesInited)
				{
					return this._RangeEntitiesCache;
				}
				this._RangeEntitiesInited = true;
				int rangeEntitiesLength = this.Instance.RangeEntitiesLength;
				this._RangeEntitiesCache = new List<int>(rangeEntitiesLength);
				for (int i = 0; i < rangeEntitiesLength; i++)
				{
					this._RangeEntitiesCache.Add(this.Instance.RangeEntities(i));
				}
				return this._RangeEntitiesCache;
			}
		}

		// Token: 0x17003DB5 RID: 15797
		// (get) Token: 0x0600E014 RID: 57364 RVA: 0x0020FACC File Offset: 0x0020DCCC
		public virtual bool DelayShow
		{
			get
			{
				return this.Instance.DelayShow;
			}
		}

		// Token: 0x040079E4 RID: 31204
		private IFixShowTargetRange Instance;

		// Token: 0x040079E5 RID: 31205
		private List<int> _RangeEntitiesCache;

		// Token: 0x040079E6 RID: 31206
		private bool _RangeEntitiesInited;
	}
}
