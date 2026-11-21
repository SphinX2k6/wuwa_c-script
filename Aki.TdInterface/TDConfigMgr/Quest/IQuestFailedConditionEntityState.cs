using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011A7 RID: 4519
	public class IQuestFailedConditionEntityState
	{
		// Token: 0x06006503 RID: 25859 RVA: 0x000F35E4 File Offset: 0x000F17E4
		private IQuestFailedConditionEntityState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestFailedConditionEntityState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestFailedConditionEntityState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestFailedConditionEntityState_SetValue());
			}
			return result;
		}

		// Token: 0x06006504 RID: 25860 RVA: 0x000F361C File Offset: 0x000F181C
		public static IQuestFailedConditionEntityState Create([Nullable(2)] IQuestFailedConditionEntityState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestFailedConditionEntityState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006505 RID: 25861 RVA: 0x000F362F File Offset: 0x000F182F
		public static IQuestFailedConditionEntityState CreateFromSetValue([Nullable(2)] IQuestFailedConditionEntityState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestFailedConditionEntityState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006506 RID: 25862 RVA: 0x000F3642 File Offset: 0x000F1842
		public IQuestFailedConditionEntityState_SetValue ToSetValue()
		{
			return new IQuestFailedConditionEntityState_SetValue
			{
				Conditions = this.Conditions
			};
		}

		// Token: 0x17002105 RID: 8453
		// (get) Token: 0x06006507 RID: 25863 RVA: 0x000F3658 File Offset: 0x000F1858
		// (set) Token: 0x06006508 RID: 25864 RVA: 0x000F36EB File Offset: 0x000F18EB
		public virtual List<IEntityStateCondition> Conditions
		{
			get
			{
				if (this._ConditionsInited)
				{
					return this._ConditionsCache;
				}
				this._ConditionsInited = true;
				if (this.FbInstance != null)
				{
					List<IEntityStateCondition> conditions = this.FbInstance.Conditions;
					if (conditions != null)
					{
						this._ConditionsCache = new List<IEntityStateCondition>(conditions.Count);
						for (int i = 0; i < conditions.Count; i++)
						{
							this._ConditionsCache.Add(IEntityStateCondition.Create(conditions[i]));
						}
					}
				}
				else
				{
					IQuestFailedConditionEntityState_SetValue pocoInterface = this.PocoInterface;
					this._ConditionsCache = ((pocoInterface != null) ? pocoInterface.Conditions : null);
				}
				return this._ConditionsCache;
			}
			set
			{
				this.GetOrCreatePoco().Conditions = value;
				this._ConditionsInited = false;
			}
		}

		// Token: 0x04003CAB RID: 15531
		[Nullable(2)]
		protected IQuestFailedConditionEntityState FbInstance;

		// Token: 0x04003CAC RID: 15532
		[Nullable(2)]
		protected IQuestFailedConditionEntityState_SetValue PocoInterface;

		// Token: 0x04003CAD RID: 15533
		private List<IEntityStateCondition> _ConditionsCache;

		// Token: 0x04003CAE RID: 15534
		private bool _ConditionsInited;
	}
}
