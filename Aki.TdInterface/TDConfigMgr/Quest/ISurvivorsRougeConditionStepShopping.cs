using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001160 RID: 4448
	[NullableContext(1)]
	[Nullable(0)]
	public class ISurvivorsRougeConditionStepShopping : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x060064FA RID: 25850 RVA: 0x000F26DC File Offset: 0x000F08DC
		private ISurvivorsRougeConditionStepShopping_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISurvivorsRougeConditionStepShopping 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISurvivorsRougeConditionStepShopping_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISurvivorsRougeConditionStepShopping_SetValue());
			}
			return result;
		}

		// Token: 0x060064FB RID: 25851 RVA: 0x000F2714 File Offset: 0x000F0914
		public static ISurvivorsRougeConditionStepShopping Create([Nullable(2)] ISurvivorsRougeConditionStepShopping instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepShopping
			{
				FbInstance = instance
			};
		}

		// Token: 0x060064FC RID: 25852 RVA: 0x000F2727 File Offset: 0x000F0927
		public static ISurvivorsRougeConditionStepShopping CreateFromSetValue([Nullable(2)] ISurvivorsRougeConditionStepShopping_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepShopping
			{
				PocoInterface = value
			};
		}

		// Token: 0x060064FD RID: 25853 RVA: 0x000F273A File Offset: 0x000F093A
		public new ISurvivorsRougeConditionStepShopping_SetValue ToSetValue()
		{
			return new ISurvivorsRougeConditionStepShopping_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170020F2 RID: 8434
		// (get) Token: 0x060064FE RID: 25854 RVA: 0x000F274D File Offset: 0x000F094D
		// (set) Token: 0x060064FF RID: 25855 RVA: 0x000F2778 File Offset: 0x000F0978
		public override ESurvivorsRougeConditionStep Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESurvivorsRougeConditionStep.Prepare;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003C97 RID: 15511
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepShopping FbInstance;

		// Token: 0x04003C98 RID: 15512
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepShopping_SetValue PocoInterface;
	}
}
