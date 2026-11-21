using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003B7 RID: 951
	public class IFailureConditionSequentialState : ITargetGearGroupFailureCondition
	{
		// Token: 0x060012B3 RID: 4787 RVA: 0x0003E1F0 File Offset: 0x0003C3F0
		private IFailureConditionSequentialState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFailureConditionSequentialState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFailureConditionSequentialState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFailureConditionSequentialState_SetValue());
			}
			return result;
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x0003E228 File Offset: 0x0003C428
		public static IFailureConditionSequentialState Create([Nullable(2)] IFailureConditionSequentialState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFailureConditionSequentialState
			{
				FbInstance = instance
			};
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x0003E23B File Offset: 0x0003C43B
		public static IFailureConditionSequentialState CreateFromSetValue([Nullable(2)] IFailureConditionSequentialState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFailureConditionSequentialState
			{
				PocoInterface = value
			};
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x0003E24E File Offset: 0x0003C44E
		public new IFailureConditionSequentialState_SetValue ToSetValue()
		{
			return new IFailureConditionSequentialState_SetValue
			{
				Type = this.Type,
				Order = this.Order
			};
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x060012B7 RID: 4791 RVA: 0x0003E26D File Offset: 0x0003C46D
		// (set) Token: 0x060012B8 RID: 4792 RVA: 0x0003E298 File Offset: 0x0003C498
		public override ETargetGearGroupFailureCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetGearGroupFailureCondition.ArbitraryState;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x060012B9 RID: 4793 RVA: 0x0003E2A6 File Offset: 0x0003C4A6
		// (set) Token: 0x060012BA RID: 4794 RVA: 0x0003E2CD File Offset: 0x0003C4CD
		public virtual List<int> Order
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Order;
				}
				IFailureConditionSequentialState_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Order;
			}
			set
			{
				this.GetOrCreatePoco().Order = value;
			}
		}

		// Token: 0x04000F4C RID: 3916
		[Nullable(2)]
		protected new IFailureConditionSequentialState FbInstance;

		// Token: 0x04000F4D RID: 3917
		[Nullable(2)]
		protected new IFailureConditionSequentialState_SetValue PocoInterface;
	}
}
