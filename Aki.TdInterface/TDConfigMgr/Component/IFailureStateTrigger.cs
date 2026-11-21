using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003B9 RID: 953
	public class IFailureStateTrigger
	{
		// Token: 0x060012BD RID: 4797 RVA: 0x0003E2EC File Offset: 0x0003C4EC
		private IFailureStateTrigger_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFailureStateTrigger 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFailureStateTrigger_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFailureStateTrigger_SetValue());
			}
			return result;
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x0003E324 File Offset: 0x0003C524
		public static IFailureStateTrigger Create([Nullable(2)] IFailureStateTrigger instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFailureStateTrigger
			{
				FbInstance = instance
			};
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x0003E337 File Offset: 0x0003C537
		public static IFailureStateTrigger CreateFromSetValue([Nullable(2)] IFailureStateTrigger_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFailureStateTrigger
			{
				PocoInterface = value
			};
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x0003E34A File Offset: 0x0003C54A
		public IFailureStateTrigger_SetValue ToSetValue()
		{
			return new IFailureStateTrigger_SetValue
			{
				FailureConditions = this.FailureConditions,
				FailureOperations = this.FailureOperations
			};
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x060012C1 RID: 4801 RVA: 0x0003E369 File Offset: 0x0003C569
		// (set) Token: 0x060012C2 RID: 4802 RVA: 0x0003E390 File Offset: 0x0003C590
		public virtual List<IEntityGroupFailureCondition> FailureConditions
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FailureConditions;
				}
				IFailureStateTrigger_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FailureConditions;
			}
			set
			{
				this.GetOrCreatePoco().FailureConditions = value;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x060012C3 RID: 4803 RVA: 0x0003E3A0 File Offset: 0x0003C5A0
		// (set) Token: 0x060012C4 RID: 4804 RVA: 0x0003E401 File Offset: 0x0003C601
		public virtual IOperationsAfterEntityGroupFailure FailureOperations
		{
			get
			{
				if (this._FailureOperationsInited)
				{
					return this._FailureOperationsCache;
				}
				this._FailureOperationsInited = true;
				if (this.FbInstance != null)
				{
					this._FailureOperationsCache = IOperationsAfterEntityGroupFailure.Create(this.FbInstance.FailureOperations);
				}
				else
				{
					IFailureStateTrigger_SetValue pocoInterface = this.PocoInterface;
					this._FailureOperationsCache = ((pocoInterface != null) ? pocoInterface.FailureOperations : null);
				}
				return this._FailureOperationsCache;
			}
			set
			{
				this.GetOrCreatePoco().FailureOperations = value;
				this._FailureOperationsInited = false;
			}
		}

		// Token: 0x04000F50 RID: 3920
		[Nullable(2)]
		protected IFailureStateTrigger FbInstance;

		// Token: 0x04000F51 RID: 3921
		[Nullable(2)]
		protected IFailureStateTrigger_SetValue PocoInterface;

		// Token: 0x04000F52 RID: 3922
		private IOperationsAfterEntityGroupFailure _FailureOperationsCache;

		// Token: 0x04000F53 RID: 3923
		private bool _FailureOperationsInited;
	}
}
