using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BA3 RID: 2979
	[NullableContext(1)]
	[Nullable(0)]
	public class IFailureConditionSequentialState : ITargetGearGroupFailureCondition
	{
		// Token: 0x06004465 RID: 17509 RVA: 0x000ADBC6 File Offset: 0x000ABDC6
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

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x06004466 RID: 17510 RVA: 0x000ADBE5 File Offset: 0x000ABDE5
		public override ETargetGearGroupFailureCondition Type
		{
			get
			{
				return (ETargetGearGroupFailureCondition)this.Instance.Type;
			}
		}

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x06004467 RID: 17511 RVA: 0x000ADBF4 File Offset: 0x000ABDF4
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

		// Token: 0x0400269C RID: 9884
		private IFailureConditionSequentialState Instance;

		// Token: 0x0400269D RID: 9885
		private List<int> _OrderCache;

		// Token: 0x0400269E RID: 9886
		private bool _OrderInited;
	}
}
