using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200036E RID: 878
	[NullableContext(1)]
	[Nullable(0)]
	public class IFailureConditionSequentialState : ITargetGearGroupFailureCondition
	{
		// Token: 0x0600116F RID: 4463 RVA: 0x0003AF0C File Offset: 0x0003910C
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

		// Token: 0x06001170 RID: 4464 RVA: 0x0003AF44 File Offset: 0x00039144
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

		// Token: 0x06001171 RID: 4465 RVA: 0x0003AF57 File Offset: 0x00039157
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

		// Token: 0x06001172 RID: 4466 RVA: 0x0003AF6A File Offset: 0x0003916A
		public new IFailureConditionSequentialState_SetValue ToSetValue()
		{
			return new IFailureConditionSequentialState_SetValue
			{
				Type = this.Type,
				Order = this.Order
			};
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001173 RID: 4467 RVA: 0x0003AF89 File Offset: 0x00039189
		// (set) Token: 0x06001174 RID: 4468 RVA: 0x0003AFB4 File Offset: 0x000391B4
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

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001175 RID: 4469 RVA: 0x0003AFC2 File Offset: 0x000391C2
		// (set) Token: 0x06001176 RID: 4470 RVA: 0x0003AFE9 File Offset: 0x000391E9
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

		// Token: 0x04000E55 RID: 3669
		[Nullable(2)]
		protected new IFailureConditionSequentialState FbInstance;

		// Token: 0x04000E56 RID: 3670
		[Nullable(2)]
		protected new IFailureConditionSequentialState_SetValue PocoInterface;
	}
}
