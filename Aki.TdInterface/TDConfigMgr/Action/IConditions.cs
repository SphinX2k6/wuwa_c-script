using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AB5 RID: 6837
	public class IConditions
	{
		// Token: 0x06009155 RID: 37205 RVA: 0x00155344 File Offset: 0x00153544
		private IConditions_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IConditions 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IConditions_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IConditions_SetValue());
			}
			return result;
		}

		// Token: 0x06009156 RID: 37206 RVA: 0x0015537C File Offset: 0x0015357C
		public static IConditions Create([Nullable(2)] IConditions instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConditions
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009157 RID: 37207 RVA: 0x0015538F File Offset: 0x0015358F
		public static IConditions CreateFromSetValue([Nullable(2)] IConditions_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IConditions
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009158 RID: 37208 RVA: 0x001553A2 File Offset: 0x001535A2
		public IConditions_SetValue ToSetValue()
		{
			return new IConditions_SetValue
			{
				LogicOpType = this.LogicOpType,
				Conditions = this.Conditions
			};
		}

		// Token: 0x17002EA7 RID: 11943
		// (get) Token: 0x06009159 RID: 37209 RVA: 0x001553C1 File Offset: 0x001535C1
		// (set) Token: 0x0600915A RID: 37210 RVA: 0x001553EC File Offset: 0x001535EC
		public virtual string LogicOpType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LogicOpType;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.LogicOpType;
			}
			set
			{
				this.GetOrCreatePoco().LogicOpType = value;
			}
		}

		// Token: 0x17002EA8 RID: 11944
		// (get) Token: 0x0600915B RID: 37211 RVA: 0x001553FC File Offset: 0x001535FC
		// (set) Token: 0x0600915C RID: 37212 RVA: 0x0015548F File Offset: 0x0015368F
		public virtual List<ICondition> Conditions
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
					List<ICondition> conditions = this.FbInstance.Conditions;
					if (conditions != null)
					{
						this._ConditionsCache = new List<ICondition>(conditions.Count);
						for (int i = 0; i < conditions.Count; i++)
						{
							this._ConditionsCache.Add(ICondition.Create(conditions[i]));
						}
					}
				}
				else
				{
					IConditions_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04005ABA RID: 23226
		[Nullable(2)]
		protected IConditions FbInstance;

		// Token: 0x04005ABB RID: 23227
		[Nullable(2)]
		protected IConditions_SetValue PocoInterface;

		// Token: 0x04005ABC RID: 23228
		private List<ICondition> _ConditionsCache;

		// Token: 0x04005ABD RID: 23229
		private bool _ConditionsInited;
	}
}
