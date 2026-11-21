using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C71 RID: 3185
	public class IFailureConditionSequentialState : ITargetGearGroupFailureCondition
	{
		// Token: 0x060048BE RID: 18622 RVA: 0x000B7C8A File Offset: 0x000B5E8A
		public static IFailureConditionSequentialState Create(IFailureConditionSequentialState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFailureConditionSequentialState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x060048BF RID: 18623 RVA: 0x000B7CA9 File Offset: 0x000B5EA9
		public override ETargetGearGroupFailureCondition Type
		{
			get
			{
				return (ETargetGearGroupFailureCondition)this.Instance.Type;
			}
		}

		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x060048C0 RID: 18624 RVA: 0x000B7CB8 File Offset: 0x000B5EB8
		public virtual List<int> Order
		{
			get
			{
				if (this._OrderInited)
				{
					return this._OrderCache;
				}
				this._OrderInited = true;
				int orderLength = this.Instance.OrderLength;
				this._OrderCache = new List<int>(orderLength);
				for (int i = 0; i < orderLength; i++)
				{
					this._OrderCache.Add(this.Instance.Order(i));
				}
				return this._OrderCache;
			}
		}

		// Token: 0x040028E4 RID: 10468
		private IFailureConditionSequentialState Instance;

		// Token: 0x040028E5 RID: 10469
		private List<int> _OrderCache;

		// Token: 0x040028E6 RID: 10470
		private bool _OrderInited;
	}
}
