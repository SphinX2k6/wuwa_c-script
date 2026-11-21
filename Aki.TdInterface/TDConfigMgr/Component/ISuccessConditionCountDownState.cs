using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007D0 RID: 2000
	public class ISuccessConditionCountDownState : ITargetGearGroupSuccessContdion
	{
		// Token: 0x06002AD7 RID: 10967 RVA: 0x00070980 File Offset: 0x0006EB80
		private ISuccessConditionCountDownState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISuccessConditionCountDownState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISuccessConditionCountDownState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISuccessConditionCountDownState_SetValue());
			}
			return result;
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x000709B8 File Offset: 0x0006EBB8
		public static ISuccessConditionCountDownState Create([Nullable(2)] ISuccessConditionCountDownState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISuccessConditionCountDownState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x000709CB File Offset: 0x0006EBCB
		public static ISuccessConditionCountDownState CreateFromSetValue([Nullable(2)] ISuccessConditionCountDownState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISuccessConditionCountDownState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x000709DE File Offset: 0x0006EBDE
		public new ISuccessConditionCountDownState_SetValue ToSetValue()
		{
			return new ISuccessConditionCountDownState_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06002ADB RID: 10971 RVA: 0x000709F1 File Offset: 0x0006EBF1
		// (set) Token: 0x06002ADC RID: 10972 RVA: 0x00070A1C File Offset: 0x0006EC1C
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

		// Token: 0x04001CC8 RID: 7368
		[Nullable(2)]
		protected new ISuccessConditionCountDownState FbInstance;

		// Token: 0x04001CC9 RID: 7369
		[Nullable(2)]
		protected new ISuccessConditionCountDownState_SetValue PocoInterface;
	}
}
