using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B37 RID: 2871
	[NullableContext(1)]
	[Nullable(0)]
	public class ISearchTargetCfg
	{
		// Token: 0x06004244 RID: 16964 RVA: 0x000A9AD7 File Offset: 0x000A7CD7
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

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x06004245 RID: 16965 RVA: 0x000A9AF8 File Offset: 0x000A7CF8
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

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x06004246 RID: 16966 RVA: 0x000A9B64 File Offset: 0x000A7D64
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

		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x06004247 RID: 16967 RVA: 0x000A9BD0 File Offset: 0x000A7DD0
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

		// Token: 0x0400255C RID: 9564
		private ISearchTargetCfg Instance;

		// Token: 0x0400255D RID: 9565
		private List<IEntityAngleWeight> _AngleWeightCache;

		// Token: 0x0400255E RID: 9566
		private bool _AngleWeightInited;

		// Token: 0x0400255F RID: 9567
		private List<IEntityCategoryWeight> _LockConditionsCache;

		// Token: 0x04002560 RID: 9568
		private bool _LockConditionsInited;
	}
}
