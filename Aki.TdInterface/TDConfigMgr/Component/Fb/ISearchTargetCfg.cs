using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C05 RID: 3077
	public class ISearchTargetCfg
	{
		// Token: 0x0600469D RID: 18077 RVA: 0x000B3B9B File Offset: 0x000B1D9B
		public static ISearchTargetCfg Create(ISearchTargetCfg? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISearchTargetCfg
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x0600469E RID: 18078 RVA: 0x000B3BBC File Offset: 0x000B1DBC
		public virtual List<IEntityAngleWeight> AngleWeight
		{
			get
			{
				if (this._AngleWeightInited)
				{
					return this._AngleWeightCache;
				}
				this._AngleWeightInited = true;
				int angleWeightLength = this.Instance.AngleWeightLength;
				this._AngleWeightCache = new List<IEntityAngleWeight>(angleWeightLength);
				for (int i = 0; i < angleWeightLength; i++)
				{
					this._AngleWeightCache.Add(IEntityAngleWeight.Create(this.Instance.AngleWeight(i)));
				}
				return this._AngleWeightCache;
			}
		}

		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x0600469F RID: 18079 RVA: 0x000B3C28 File Offset: 0x000B1E28
		public virtual List<IEntityCategoryWeight> LockConditions
		{
			get
			{
				if (this._LockConditionsInited)
				{
					return this._LockConditionsCache;
				}
				this._LockConditionsInited = true;
				int lockConditionsLength = this.Instance.LockConditionsLength;
				this._LockConditionsCache = new List<IEntityCategoryWeight>(lockConditionsLength);
				for (int i = 0; i < lockConditionsLength; i++)
				{
					this._LockConditionsCache.Add(IEntityCategoryWeight.Create(this.Instance.LockConditions(i)));
				}
				return this._LockConditionsCache;
			}
		}

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x060046A0 RID: 18080 RVA: 0x000B3C94 File Offset: 0x000B1E94
		public virtual bool? IgnoreDistanceWeight
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IgnoreDistanceWeight);
			}
		}

		// Token: 0x040027A4 RID: 10148
		private ISearchTargetCfg Instance;

		// Token: 0x040027A5 RID: 10149
		private List<IEntityAngleWeight> _AngleWeightCache;

		// Token: 0x040027A6 RID: 10150
		private bool _AngleWeightInited;

		// Token: 0x040027A7 RID: 10151
		private List<IEntityCategoryWeight> _LockConditionsCache;

		// Token: 0x040027A8 RID: 10152
		private bool _LockConditionsInited;
	}
}
