using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001312 RID: 4882
	public class ITrapDefenseConditionStepReward : ITrapDefenseConditionStepBase
	{
		// Token: 0x06006DFF RID: 28159 RVA: 0x00105C18 File Offset: 0x00103E18
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

		// Token: 0x06006E00 RID: 28160 RVA: 0x00105C50 File Offset: 0x00103E50
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

		// Token: 0x06006E01 RID: 28161 RVA: 0x00105C63 File Offset: 0x00103E63
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

		// Token: 0x06006E02 RID: 28162 RVA: 0x00105C76 File Offset: 0x00103E76
		public new ITrapDefenseConditionStepReward_SetValue ToSetValue()
		{
			return new ITrapDefenseConditionStepReward_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002364 RID: 9060
		// (get) Token: 0x06006E03 RID: 28163 RVA: 0x00105C89 File Offset: 0x00103E89
		// (set) Token: 0x06006E04 RID: 28164 RVA: 0x00105CB4 File Offset: 0x00103EB4
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

		// Token: 0x040041A8 RID: 16808
		[Nullable(2)]
		protected new ITrapDefenseConditionStepReward FbInstance;

		// Token: 0x040041A9 RID: 16809
		[Nullable(2)]
		protected new ITrapDefenseConditionStepReward_SetValue PocoInterface;
	}
}
