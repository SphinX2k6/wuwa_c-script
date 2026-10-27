using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000731 RID: 1841
	[NullableContext(1)]
	[Nullable(0)]
	public class ISuccessConditionSameArbitraryState : ITargetGearGroupSuccessContdion
	{
		// Token: 0x060027BB RID: 10171 RVA: 0x00069894 File Offset: 0x00067A94
		private ISuccessConditionSameArbitraryState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISuccessConditionSameArbitraryState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISuccessConditionSameArbitraryState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISuccessConditionSameArbitraryState_SetValue());
			}
			return result;
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x000698CC File Offset: 0x00067ACC
		public static ISuccessConditionSameArbitraryState Create([Nullable(2)] ISuccessConditionSameArbitraryState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISuccessConditionSameArbitraryState
			{
				FbInstance = instance
			};
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x000698DF File Offset: 0x00067ADF
		public static ISuccessConditionSameArbitraryState CreateFromSetValue([Nullable(2)] ISuccessConditionSameArbitraryState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISuccessConditionSameArbitraryState
			{
				PocoInterface = value
			};
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x000698F2 File Offset: 0x00067AF2
		public new ISuccessConditionSameArbitraryState_SetValue ToSetValue()
		{
			return new ISuccessConditionSameArbitraryState_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x060027BF RID: 10175 RVA: 0x00069905 File Offset: 0x00067B05
		// (set) Token: 0x060027C0 RID: 10176 RVA: 0x00069930 File Offset: 0x00067B30
		public override ETargetGearGroupSuccessCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetGearGroupSuccessCondition.SameSpecificState;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001AC6 RID: 6854
		[Nullable(2)]
		protected new ISuccessConditionSameArbitraryState FbInstance;

		// Token: 0x04001AC7 RID: 6855
		[Nullable(2)]
		protected new ISuccessConditionSameArbitraryState_SetValue PocoInterface;
	}
}
