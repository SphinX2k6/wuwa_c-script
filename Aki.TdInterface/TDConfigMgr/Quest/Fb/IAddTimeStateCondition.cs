using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001591 RID: 5521
	public class IAddTimeStateCondition
	{
		// Token: 0x06007C76 RID: 31862 RVA: 0x00127B9A File Offset: 0x00125D9A
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

		// Token: 0x170028F6 RID: 10486
		// (get) Token: 0x06007C77 RID: 31863 RVA: 0x00127BB9 File Offset: 0x00125DB9
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

		// Token: 0x170028F7 RID: 10487
		// (get) Token: 0x06007C78 RID: 31864 RVA: 0x00127BED File Offset: 0x00125DED
		public virtual int AddTime
		{
			get
			{
				return this.Instance.AddTime;
			}
		}

		// Token: 0x040047C5 RID: 18373
		private IAddTimeStateCondition Instance;

		// Token: 0x040047C6 RID: 18374
		[Nullable(2)]
		private IEntityStateCondition _ConditionCache;

		// Token: 0x040047C7 RID: 18375
		private bool _ConditionInited;
	}
}
