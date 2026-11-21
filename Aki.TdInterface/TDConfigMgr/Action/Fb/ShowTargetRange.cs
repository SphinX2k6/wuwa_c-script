using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A60 RID: 10848
	public class ShowTargetRange : ActionParams
	{
		// Token: 0x0600EF8D RID: 61325 RVA: 0x00231D3E File Offset: 0x0022FF3E
		public static ShowTargetRange Create(IShowTargetRange? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ShowTargetRange
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700477B RID: 18299
		// (get) Token: 0x0600EF8E RID: 61326 RVA: 0x00231D60 File Offset: 0x0022FF60
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

		// Token: 0x1700477C RID: 18300
		// (get) Token: 0x0600EF8F RID: 61327 RVA: 0x00231DC4 File Offset: 0x0022FFC4
		public virtual bool DelayShow
		{
			get
			{
				return this.Instance.DelayShow;
			}
		}

		// Token: 0x040083AE RID: 33710
		private IShowTargetRange Instance;

		// Token: 0x040083AF RID: 33711
		private List<int> _RangeEntitiesCache;

		// Token: 0x040083B0 RID: 33712
		private bool _RangeEntitiesInited;
	}
}
