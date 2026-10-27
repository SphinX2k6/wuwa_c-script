using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001079 RID: 4217
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestFailedConditionEntityState
	{
		// Token: 0x06005F0A RID: 24330 RVA: 0x000E64C4 File Offset: 0x000E46C4
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

		// Token: 0x06005F0B RID: 24331 RVA: 0x000E64FC File Offset: 0x000E46FC
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

		// Token: 0x06005F0C RID: 24332 RVA: 0x000E650F File Offset: 0x000E470F
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

		// Token: 0x06005F0D RID: 24333 RVA: 0x000E6522 File Offset: 0x000E4722
		public IQuestFailedConditionEntityState_SetValue ToSetValue()
		{
			return new IQuestFailedConditionEntityState_SetValue
			{
				Conditions = this.Conditions
			};
		}

		// Token: 0x17001F53 RID: 8019
		// (get) Token: 0x06005F0E RID: 24334 RVA: 0x000E6538 File Offset: 0x000E4738
		// (set) Token: 0x06005F0F RID: 24335 RVA: 0x000E65CB File Offset: 0x000E47CB
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

		// Token: 0x0400395E RID: 14686
		[Nullable(2)]
		protected IQuestFailedConditionEntityState FbInstance;

		// Token: 0x0400395F RID: 14687
		[Nullable(2)]
		protected IQuestFailedConditionEntityState_SetValue PocoInterface;

		// Token: 0x04003960 RID: 14688
		private List<IEntityStateCondition> _ConditionsCache;

		// Token: 0x04003961 RID: 14689
		private bool _ConditionsInited;
	}
}
