using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001286 RID: 4742
	public class ISurvivorsRougeConditionStepChestReward : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x06006AD9 RID: 27353 RVA: 0x000FF5F4 File Offset: 0x000FD7F4
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

		// Token: 0x06006ADA RID: 27354 RVA: 0x000FF62C File Offset: 0x000FD82C
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

		// Token: 0x06006ADB RID: 27355 RVA: 0x000FF63F File Offset: 0x000FD83F
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

		// Token: 0x06006ADC RID: 27356 RVA: 0x000FF652 File Offset: 0x000FD852
		public new ISurvivorsRougeConditionStepChestReward_SetValue ToSetValue()
		{
			return new ISurvivorsRougeConditionStepChestReward_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170022A3 RID: 8867
		// (get) Token: 0x06006ADD RID: 27357 RVA: 0x000FF665 File Offset: 0x000FD865
		// (set) Token: 0x06006ADE RID: 27358 RVA: 0x000FF690 File Offset: 0x000FD890
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

		// Token: 0x04003FDB RID: 16347
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepChestReward FbInstance;

		// Token: 0x04003FDC RID: 16348
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepChestReward_SetValue PocoInterface;
	}
}
