using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200192C RID: 6444
	[NullableContext(1)]
	[Nullable(0)]
	public class IConditions
	{
		// Token: 0x06008A29 RID: 35369 RVA: 0x00145A04 File Offset: 0x00143C04
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

		// Token: 0x06008A2A RID: 35370 RVA: 0x00145A3C File Offset: 0x00143C3C
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

		// Token: 0x06008A2B RID: 35371 RVA: 0x00145A4F File Offset: 0x00143C4F
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

		// Token: 0x06008A2C RID: 35372 RVA: 0x00145A62 File Offset: 0x00143C62
		public IConditions_SetValue ToSetValue()
		{
			return new IConditions_SetValue
			{
				LogicOpType = this.LogicOpType,
				Conditions = this.Conditions
			};
		}

		// Token: 0x17002CA7 RID: 11431
		// (get) Token: 0x06008A2D RID: 35373 RVA: 0x00145A81 File Offset: 0x00143C81
		// (set) Token: 0x06008A2E RID: 35374 RVA: 0x00145AAC File Offset: 0x00143CAC
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

		// Token: 0x17002CA8 RID: 11432
		// (get) Token: 0x06008A2F RID: 35375 RVA: 0x00145ABC File Offset: 0x00143CBC
		// (set) Token: 0x06008A30 RID: 35376 RVA: 0x00145B4F File Offset: 0x00143D4F
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

		// Token: 0x0400566A RID: 22122
		[Nullable(2)]
		protected IConditions FbInstance;

		// Token: 0x0400566B RID: 22123
		[Nullable(2)]
		protected IConditions_SetValue PocoInterface;

		// Token: 0x0400566C RID: 22124
		private List<ICondition> _ConditionsCache;

		// Token: 0x0400566D RID: 22125
		private bool _ConditionsInited;
	}
}
