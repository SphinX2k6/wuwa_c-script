using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011D6 RID: 4566
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrapDefenseConditionStepReward : ITrapDefenseConditionStepBase
	{
		// Token: 0x060067BE RID: 26558 RVA: 0x000F830C File Offset: 0x000F650C
		private ITrapDefenseConditionStepReward_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrapDefenseConditionStepReward 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrapDefenseConditionStepReward_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrapDefenseConditionStepReward_SetValue());
			}
			return result;
		}

		// Token: 0x060067BF RID: 26559 RVA: 0x000F8344 File Offset: 0x000F6544
		public static ITrapDefenseConditionStepReward Create([Nullable(2)] ITrapDefenseConditionStepReward instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefenseConditionStepReward
			{
				FbInstance = instance
			};
		}

		// Token: 0x060067C0 RID: 26560 RVA: 0x000F8357 File Offset: 0x000F6557
		public static ITrapDefenseConditionStepReward CreateFromSetValue([Nullable(2)] ITrapDefenseConditionStepReward_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrapDefenseConditionStepReward
			{
				PocoInterface = value
			};
		}

		// Token: 0x060067C1 RID: 26561 RVA: 0x000F836A File Offset: 0x000F656A
		public new ITrapDefenseConditionStepReward_SetValue ToSetValue()
		{
			return new ITrapDefenseConditionStepReward_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021A3 RID: 8611
		// (get) Token: 0x060067C2 RID: 26562 RVA: 0x000F837D File Offset: 0x000F657D
		// (set) Token: 0x060067C3 RID: 26563 RVA: 0x000F83A8 File Offset: 0x000F65A8
		public override ETrapDefenseConditionStep Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETrapDefenseConditionStep.Reward;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003E3A RID: 15930
		[Nullable(2)]
		protected new ITrapDefenseConditionStepReward FbInstance;

		// Token: 0x04003E3B RID: 15931
		[Nullable(2)]
		protected new ITrapDefenseConditionStepReward_SetValue PocoInterface;
	}
}
