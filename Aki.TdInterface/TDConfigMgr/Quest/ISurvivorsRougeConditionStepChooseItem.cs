using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001158 RID: 4440
	[NullableContext(1)]
	[Nullable(0)]
	public class ISurvivorsRougeConditionStepChooseItem : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x060064DA RID: 25818 RVA: 0x000F23EC File Offset: 0x000F05EC
		private ISurvivorsRougeConditionStepChooseItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISurvivorsRougeConditionStepChooseItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISurvivorsRougeConditionStepChooseItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISurvivorsRougeConditionStepChooseItem_SetValue());
			}
			return result;
		}

		// Token: 0x060064DB RID: 25819 RVA: 0x000F2424 File Offset: 0x000F0624
		public static ISurvivorsRougeConditionStepChooseItem Create([Nullable(2)] ISurvivorsRougeConditionStepChooseItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepChooseItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x060064DC RID: 25820 RVA: 0x000F2437 File Offset: 0x000F0637
		public static ISurvivorsRougeConditionStepChooseItem CreateFromSetValue([Nullable(2)] ISurvivorsRougeConditionStepChooseItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepChooseItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x060064DD RID: 25821 RVA: 0x000F244A File Offset: 0x000F064A
		public new ISurvivorsRougeConditionStepChooseItem_SetValue ToSetValue()
		{
			return new ISurvivorsRougeConditionStepChooseItem_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170020EE RID: 8430
		// (get) Token: 0x060064DE RID: 25822 RVA: 0x000F245D File Offset: 0x000F065D
		// (set) Token: 0x060064DF RID: 25823 RVA: 0x000F2488 File Offset: 0x000F0688
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

		// Token: 0x04003C8B RID: 15499
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepChooseItem FbInstance;

		// Token: 0x04003C8C RID: 15500
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepChooseItem_SetValue PocoInterface;
	}
}
