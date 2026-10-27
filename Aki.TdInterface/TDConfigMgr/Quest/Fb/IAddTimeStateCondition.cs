using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001439 RID: 5177
	[NullableContext(1)]
	[Nullable(0)]
	public class IAddTimeStateCondition
	{
		// Token: 0x060075B1 RID: 30129 RVA: 0x0011914E File Offset: 0x0011734E
		public static IAddTimeStateCondition Create(IAddTimeStateCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAddTimeStateCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002712 RID: 10002
		// (get) Token: 0x060075B2 RID: 30130 RVA: 0x0011916D File Offset: 0x0011736D
		public virtual IEntityStateCondition Condition
		{
			get
			{
				if (this._ConditionInited)
				{
					return this._ConditionCache;
				}
				this._ConditionInited = true;
				this._ConditionCache = IEntityStateCondition.Create(this.Instance.Condition);
				return this._ConditionCache;
			}
		}

		// Token: 0x17002713 RID: 10003
		// (get) Token: 0x060075B3 RID: 30131 RVA: 0x001191A1 File Offset: 0x001173A1
		public virtual int AddTime
		{
			get
			{
				return this.Instance.AddTime;
			}
		}

		// Token: 0x04004431 RID: 17457
		private IAddTimeStateCondition Instance;

		// Token: 0x04004432 RID: 17458
		[Nullable(2)]
		private IEntityStateCondition _ConditionCache;

		// Token: 0x04004433 RID: 17459
		private bool _ConditionInited;
	}
}
