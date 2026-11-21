using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FD2 RID: 4050
	public class IAddTimeStateCondition
	{
		// Token: 0x060058A8 RID: 22696 RVA: 0x000D8E84 File Offset: 0x000D7084
		private IAddTimeStateCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAddTimeStateCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAddTimeStateCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAddTimeStateCondition_SetValue());
			}
			return result;
		}

		// Token: 0x060058A9 RID: 22697 RVA: 0x000D8EBC File Offset: 0x000D70BC
		public static IAddTimeStateCondition Create([Nullable(2)] IAddTimeStateCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAddTimeStateCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x060058AA RID: 22698 RVA: 0x000D8ECF File Offset: 0x000D70CF
		public static IAddTimeStateCondition CreateFromSetValue([Nullable(2)] IAddTimeStateCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAddTimeStateCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x060058AB RID: 22699 RVA: 0x000D8EE2 File Offset: 0x000D70E2
		public IAddTimeStateCondition_SetValue ToSetValue()
		{
			return new IAddTimeStateCondition_SetValue
			{
				Condition = this.Condition,
				AddTime = this.AddTime
			};
		}

		// Token: 0x17001D93 RID: 7571
		// (get) Token: 0x060058AC RID: 22700 RVA: 0x000D8F04 File Offset: 0x000D7104
		// (set) Token: 0x060058AD RID: 22701 RVA: 0x000D8F65 File Offset: 0x000D7165
		public virtual IEntityStateCondition Condition
		{
			get
			{
				if (this._ConditionInited)
				{
					return this._ConditionCache;
				}
				this._ConditionInited = true;
				if (this.FbInstance != null)
				{
					this._ConditionCache = IEntityStateCondition.Create(this.FbInstance.Condition);
				}
				else
				{
					IAddTimeStateCondition_SetValue pocoInterface = this.PocoInterface;
					this._ConditionCache = ((pocoInterface != null) ? pocoInterface.Condition : null);
				}
				return this._ConditionCache;
			}
			set
			{
				this.GetOrCreatePoco().Condition = value;
				this._ConditionInited = false;
			}
		}

		// Token: 0x17001D94 RID: 7572
		// (get) Token: 0x060058AE RID: 22702 RVA: 0x000D8F7A File Offset: 0x000D717A
		// (set) Token: 0x060058AF RID: 22703 RVA: 0x000D8FA5 File Offset: 0x000D71A5
		public virtual int AddTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AddTime;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.AddTime;
			}
			set
			{
				this.GetOrCreatePoco().AddTime = value;
			}
		}

		// Token: 0x0400357A RID: 13690
		[Nullable(2)]
		protected IAddTimeStateCondition FbInstance;

		// Token: 0x0400357B RID: 13691
		[Nullable(2)]
		protected IAddTimeStateCondition_SetValue PocoInterface;

		// Token: 0x0400357C RID: 13692
		private IEntityStateCondition _ConditionCache;

		// Token: 0x0400357D RID: 13693
		private bool _ConditionInited;
	}
}
