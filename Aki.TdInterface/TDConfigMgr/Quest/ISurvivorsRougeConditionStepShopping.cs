using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001290 RID: 4752
	public class ISurvivorsRougeConditionStepShopping : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x06006B01 RID: 27393 RVA: 0x000FF9A0 File Offset: 0x000FDBA0
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

		// Token: 0x06006B02 RID: 27394 RVA: 0x000FF9D8 File Offset: 0x000FDBD8
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

		// Token: 0x06006B03 RID: 27395 RVA: 0x000FF9EB File Offset: 0x000FDBEB
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

		// Token: 0x06006B04 RID: 27396 RVA: 0x000FF9FE File Offset: 0x000FDBFE
		public new ISurvivorsRougeConditionStepShopping_SetValue ToSetValue()
		{
			return new ISurvivorsRougeConditionStepShopping_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170022A8 RID: 8872
		// (get) Token: 0x06006B05 RID: 27397 RVA: 0x000FFA11 File Offset: 0x000FDC11
		// (set) Token: 0x06006B06 RID: 27398 RVA: 0x000FFA3C File Offset: 0x000FDC3C
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

		// Token: 0x04003FEA RID: 16362
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepShopping FbInstance;

		// Token: 0x04003FEB RID: 16363
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepShopping_SetValue PocoInterface;
	}
}
