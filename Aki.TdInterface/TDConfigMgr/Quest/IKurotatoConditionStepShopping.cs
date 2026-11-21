using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200110F RID: 4367
	public class IKurotatoConditionStepShopping : IKurotatoConditionStepBase
	{
		// Token: 0x0600606C RID: 24684 RVA: 0x000E8B1C File Offset: 0x000E6D1C
		private IKurotatoConditionStepShopping_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IKurotatoConditionStepShopping 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IKurotatoConditionStepShopping_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IKurotatoConditionStepShopping_SetValue());
			}
			return result;
		}

		// Token: 0x0600606D RID: 24685 RVA: 0x000E8B54 File Offset: 0x000E6D54
		public static IKurotatoConditionStepShopping Create([Nullable(2)] IKurotatoConditionStepShopping instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKurotatoConditionStepShopping
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600606E RID: 24686 RVA: 0x000E8B67 File Offset: 0x000E6D67
		public static IKurotatoConditionStepShopping CreateFromSetValue([Nullable(2)] IKurotatoConditionStepShopping_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IKurotatoConditionStepShopping
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600606F RID: 24687 RVA: 0x000E8B7A File Offset: 0x000E6D7A
		public new IKurotatoConditionStepShopping_SetValue ToSetValue()
		{
			return new IKurotatoConditionStepShopping_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001F9C RID: 8092
		// (get) Token: 0x06006070 RID: 24688 RVA: 0x000E8B8D File Offset: 0x000E6D8D
		// (set) Token: 0x06006071 RID: 24689 RVA: 0x000E8BB8 File Offset: 0x000E6DB8
		public override EKurotatoConditionStep Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EKurotatoConditionStep.Prepare;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040039BE RID: 14782
		[Nullable(2)]
		protected new IKurotatoConditionStepShopping FbInstance;

		// Token: 0x040039BF RID: 14783
		[Nullable(2)]
		protected new IKurotatoConditionStepShopping_SetValue PocoInterface;
	}
}
