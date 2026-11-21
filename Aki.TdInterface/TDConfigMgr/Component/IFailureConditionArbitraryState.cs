using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003B3 RID: 947
	public class IFailureConditionArbitraryState : ITargetGearGroupFailureCondition
	{
		// Token: 0x0600129F RID: 4767 RVA: 0x0003DFF4 File Offset: 0x0003C1F4
		private IFailureConditionArbitraryState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFailureConditionArbitraryState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFailureConditionArbitraryState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFailureConditionArbitraryState_SetValue());
			}
			return result;
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x0003E02C File Offset: 0x0003C22C
		public static IFailureConditionArbitraryState Create([Nullable(2)] IFailureConditionArbitraryState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFailureConditionArbitraryState
			{
				FbInstance = instance
			};
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x0003E03F File Offset: 0x0003C23F
		public static IFailureConditionArbitraryState CreateFromSetValue([Nullable(2)] IFailureConditionArbitraryState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFailureConditionArbitraryState
			{
				PocoInterface = value
			};
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x0003E052 File Offset: 0x0003C252
		public new IFailureConditionArbitraryState_SetValue ToSetValue()
		{
			return new IFailureConditionArbitraryState_SetValue
			{
				Type = this.Type,
				State = this.State
			};
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060012A3 RID: 4771 RVA: 0x0003E071 File Offset: 0x0003C271
		// (set) Token: 0x060012A4 RID: 4772 RVA: 0x0003E09C File Offset: 0x0003C29C
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

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x060012A5 RID: 4773 RVA: 0x0003E0AA File Offset: 0x0003C2AA
		// (set) Token: 0x060012A6 RID: 4774 RVA: 0x0003E0D5 File Offset: 0x0003C2D5
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x04000F44 RID: 3908
		[Nullable(2)]
		protected new IFailureConditionArbitraryState FbInstance;

		// Token: 0x04000F45 RID: 3909
		[Nullable(2)]
		protected new IFailureConditionArbitraryState_SetValue PocoInterface;
	}
}
