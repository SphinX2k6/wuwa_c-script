using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200278E RID: 10126
	[NullableContext(1)]
	[Nullable(0)]
	public class ShowTargetRange : ActionParams
	{
		// Token: 0x0600E16F RID: 57711 RVA: 0x00214FAA File Offset: 0x002131AA
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

		// Token: 0x17004415 RID: 17429
		// (get) Token: 0x0600E170 RID: 57712 RVA: 0x00214FCC File Offset: 0x002131CC
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

		// Token: 0x17004416 RID: 17430
		// (get) Token: 0x0600E171 RID: 57713 RVA: 0x00215030 File Offset: 0x00213230
		public virtual bool DelayShow
		{
			get
			{
				return this.Instance.DelayShow;
			}
		}

		// Token: 0x04007CF8 RID: 31992
		private IShowTargetRange Instance;

		// Token: 0x04007CF9 RID: 31993
		private List<int> _RangeEntitiesCache;

		// Token: 0x04007CFA RID: 31994
		private bool _RangeEntitiesInited;
	}
}
