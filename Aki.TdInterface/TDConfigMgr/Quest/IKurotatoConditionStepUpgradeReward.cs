using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001113 RID: 4371
	public class IKurotatoConditionStepUpgradeReward : IKurotatoConditionStepBase
	{
		// Token: 0x0600607C RID: 24700 RVA: 0x000E8C94 File Offset: 0x000E6E94
		private IKurotatoConditionStepUpgradeReward_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IKurotatoConditionStepUpgradeReward 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IKurotatoConditionStepUpgradeReward_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IKurotatoConditionStepUpgradeReward_SetValue());
			}
			return result;
		}

		// Token: 0x0600607D RID: 24701 RVA: 0x000E8CCC File Offset: 0x000E6ECC
		public static IKurotatoConditionStepUpgradeReward Create([Nullable(2)] IKurotatoConditionStepUpgradeReward instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKurotatoConditionStepUpgradeReward
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600607E RID: 24702 RVA: 0x000E8CDF File Offset: 0x000E6EDF
		public static IKurotatoConditionStepUpgradeReward CreateFromSetValue([Nullable(2)] IKurotatoConditionStepUpgradeReward_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IKurotatoConditionStepUpgradeReward
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600607F RID: 24703 RVA: 0x000E8CF2 File Offset: 0x000E6EF2
		public new IKurotatoConditionStepUpgradeReward_SetValue ToSetValue()
		{
			return new IKurotatoConditionStepUpgradeReward_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001F9E RID: 8094
		// (get) Token: 0x06006080 RID: 24704 RVA: 0x000E8D05 File Offset: 0x000E6F05
		// (set) Token: 0x06006081 RID: 24705 RVA: 0x000E8D30 File Offset: 0x000E6F30
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

		// Token: 0x040039C4 RID: 14788
		[Nullable(2)]
		protected new IKurotatoConditionStepUpgradeReward FbInstance;

		// Token: 0x040039C5 RID: 14789
		[Nullable(2)]
		protected new IKurotatoConditionStepUpgradeReward_SetValue PocoInterface;
	}
}
