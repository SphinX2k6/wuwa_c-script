using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000EBC RID: 3772
	[NullableContext(1)]
	[Nullable(0)]
	public class IAddTimeStateCondition
	{
		// Token: 0x0600532C RID: 21292 RVA: 0x000CCCDC File Offset: 0x000CAEDC
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

		// Token: 0x0600532D RID: 21293 RVA: 0x000CCD14 File Offset: 0x000CAF14
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

		// Token: 0x0600532E RID: 21294 RVA: 0x000CCD27 File Offset: 0x000CAF27
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

		// Token: 0x0600532F RID: 21295 RVA: 0x000CCD3A File Offset: 0x000CAF3A
		public IAddTimeStateCondition_SetValue ToSetValue()
		{
			return new IAddTimeStateCondition_SetValue
			{
				Condition = this.Condition,
				AddTime = this.AddTime
			};
		}

		// Token: 0x17001BFB RID: 7163
		// (get) Token: 0x06005330 RID: 21296 RVA: 0x000CCD5C File Offset: 0x000CAF5C
		// (set) Token: 0x06005331 RID: 21297 RVA: 0x000CCDBD File Offset: 0x000CAFBD
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

		// Token: 0x17001BFC RID: 7164
		// (get) Token: 0x06005332 RID: 21298 RVA: 0x000CCDD2 File Offset: 0x000CAFD2
		// (set) Token: 0x06005333 RID: 21299 RVA: 0x000CCDFD File Offset: 0x000CAFFD
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

		// Token: 0x0400326D RID: 12909
		[Nullable(2)]
		protected IAddTimeStateCondition FbInstance;

		// Token: 0x0400326E RID: 12910
		[Nullable(2)]
		protected IAddTimeStateCondition_SetValue PocoInterface;

		// Token: 0x0400326F RID: 12911
		private IEntityStateCondition _ConditionCache;

		// Token: 0x04003270 RID: 12912
		private bool _ConditionInited;
	}
}
