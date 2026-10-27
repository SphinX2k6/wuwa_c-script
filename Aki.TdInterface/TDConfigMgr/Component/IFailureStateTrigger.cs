using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000370 RID: 880
	[NullableContext(1)]
	[Nullable(0)]
	public class IFailureStateTrigger
	{
		// Token: 0x06001179 RID: 4473 RVA: 0x0003B008 File Offset: 0x00039208
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

		// Token: 0x0600117A RID: 4474 RVA: 0x0003B040 File Offset: 0x00039240
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

		// Token: 0x0600117B RID: 4475 RVA: 0x0003B053 File Offset: 0x00039253
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

		// Token: 0x0600117C RID: 4476 RVA: 0x0003B066 File Offset: 0x00039266
		public IFailureStateTrigger_SetValue ToSetValue()
		{
			return new IFailureStateTrigger_SetValue
			{
				FailureConditions = this.FailureConditions,
				FailureOperations = this.FailureOperations
			};
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x0003B085 File Offset: 0x00039285
		// (set) Token: 0x0600117E RID: 4478 RVA: 0x0003B0AC File Offset: 0x000392AC
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

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x0003B0BC File Offset: 0x000392BC
		// (set) Token: 0x06001180 RID: 4480 RVA: 0x0003B11D File Offset: 0x0003931D
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

		// Token: 0x04000E59 RID: 3673
		[Nullable(2)]
		protected IFailureStateTrigger FbInstance;

		// Token: 0x04000E5A RID: 3674
		[Nullable(2)]
		protected IFailureStateTrigger_SetValue PocoInterface;

		// Token: 0x04000E5B RID: 3675
		private IOperationsAfterEntityGroupFailure _FailureOperationsCache;

		// Token: 0x04000E5C RID: 3676
		private bool _FailureOperationsInited;
	}
}
