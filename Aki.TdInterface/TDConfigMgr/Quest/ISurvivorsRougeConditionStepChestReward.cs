using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001156 RID: 4438
	[NullableContext(1)]
	[Nullable(0)]
	public class ISurvivorsRougeConditionStepChestReward : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x060064D2 RID: 25810 RVA: 0x000F2330 File Offset: 0x000F0530
		private ISurvivorsRougeConditionStepChestReward_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISurvivorsRougeConditionStepChestReward 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISurvivorsRougeConditionStepChestReward_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISurvivorsRougeConditionStepChestReward_SetValue());
			}
			return result;
		}

		// Token: 0x060064D3 RID: 25811 RVA: 0x000F2368 File Offset: 0x000F0568
		public static ISurvivorsRougeConditionStepChestReward Create([Nullable(2)] ISurvivorsRougeConditionStepChestReward instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepChestReward
			{
				FbInstance = instance
			};
		}

		// Token: 0x060064D4 RID: 25812 RVA: 0x000F237B File Offset: 0x000F057B
		public static ISurvivorsRougeConditionStepChestReward CreateFromSetValue([Nullable(2)] ISurvivorsRougeConditionStepChestReward_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepChestReward
			{
				PocoInterface = value
			};
		}

		// Token: 0x060064D5 RID: 25813 RVA: 0x000F238E File Offset: 0x000F058E
		public new ISurvivorsRougeConditionStepChestReward_SetValue ToSetValue()
		{
			return new ISurvivorsRougeConditionStepChestReward_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170020ED RID: 8429
		// (get) Token: 0x060064D6 RID: 25814 RVA: 0x000F23A1 File Offset: 0x000F05A1
		// (set) Token: 0x060064D7 RID: 25815 RVA: 0x000F23CC File Offset: 0x000F05CC
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

		// Token: 0x04003C88 RID: 15496
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepChestReward FbInstance;

		// Token: 0x04003C89 RID: 15497
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepChestReward_SetValue PocoInterface;
	}
}
