using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200115C RID: 4444
	[NullableContext(1)]
	[Nullable(0)]
	public class ISurvivorsRougeConditionStepEnd : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x060064EA RID: 25834 RVA: 0x000F2564 File Offset: 0x000F0764
		private ISurvivorsRougeConditionStepEnd_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISurvivorsRougeConditionStepEnd 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISurvivorsRougeConditionStepEnd_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISurvivorsRougeConditionStepEnd_SetValue());
			}
			return result;
		}

		// Token: 0x060064EB RID: 25835 RVA: 0x000F259C File Offset: 0x000F079C
		public static ISurvivorsRougeConditionStepEnd Create([Nullable(2)] ISurvivorsRougeConditionStepEnd instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepEnd
			{
				FbInstance = instance
			};
		}

		// Token: 0x060064EC RID: 25836 RVA: 0x000F25AF File Offset: 0x000F07AF
		public static ISurvivorsRougeConditionStepEnd CreateFromSetValue([Nullable(2)] ISurvivorsRougeConditionStepEnd_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepEnd
			{
				PocoInterface = value
			};
		}

		// Token: 0x060064ED RID: 25837 RVA: 0x000F25C2 File Offset: 0x000F07C2
		public new ISurvivorsRougeConditionStepEnd_SetValue ToSetValue()
		{
			return new ISurvivorsRougeConditionStepEnd_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170020F0 RID: 8432
		// (get) Token: 0x060064EE RID: 25838 RVA: 0x000F25D5 File Offset: 0x000F07D5
		// (set) Token: 0x060064EF RID: 25839 RVA: 0x000F2600 File Offset: 0x000F0800
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

		// Token: 0x04003C91 RID: 15505
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepEnd FbInstance;

		// Token: 0x04003C92 RID: 15506
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepEnd_SetValue PocoInterface;
	}
}
