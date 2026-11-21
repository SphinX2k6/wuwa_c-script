using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007D2 RID: 2002
	public class ISuccessConditionSameArbitraryState : ITargetGearGroupSuccessContdion
	{
		// Token: 0x06002ADF RID: 10975 RVA: 0x00070A3C File Offset: 0x0006EC3C
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

		// Token: 0x06002AE0 RID: 10976 RVA: 0x00070A74 File Offset: 0x0006EC74
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

		// Token: 0x06002AE1 RID: 10977 RVA: 0x00070A87 File Offset: 0x0006EC87
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

		// Token: 0x06002AE2 RID: 10978 RVA: 0x00070A9A File Offset: 0x0006EC9A
		public new ISuccessConditionSameArbitraryState_SetValue ToSetValue()
		{
			return new ISuccessConditionSameArbitraryState_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06002AE3 RID: 10979 RVA: 0x00070AAD File Offset: 0x0006ECAD
		// (set) Token: 0x06002AE4 RID: 10980 RVA: 0x00070AD8 File Offset: 0x0006ECD8
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

		// Token: 0x04001CCB RID: 7371
		[Nullable(2)]
		protected new ISuccessConditionSameArbitraryState FbInstance;

		// Token: 0x04001CCC RID: 7372
		[Nullable(2)]
		protected new ISuccessConditionSameArbitraryState_SetValue PocoInterface;
	}
}
