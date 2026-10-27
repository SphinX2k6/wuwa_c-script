using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FE7 RID: 4071
	[NullableContext(1)]
	[Nullable(0)]
	public class IKurotatoConditionStepUpgradeReward : IKurotatoConditionStepBase
	{
		// Token: 0x06005A9C RID: 23196 RVA: 0x000DC054 File Offset: 0x000DA254
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

		// Token: 0x06005A9D RID: 23197 RVA: 0x000DC08C File Offset: 0x000DA28C
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

		// Token: 0x06005A9E RID: 23198 RVA: 0x000DC09F File Offset: 0x000DA29F
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

		// Token: 0x06005A9F RID: 23199 RVA: 0x000DC0B2 File Offset: 0x000DA2B2
		public new IKurotatoConditionStepUpgradeReward_SetValue ToSetValue()
		{
			return new IKurotatoConditionStepUpgradeReward_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001DF5 RID: 7669
		// (get) Token: 0x06005AA0 RID: 23200 RVA: 0x000DC0C5 File Offset: 0x000DA2C5
		// (set) Token: 0x06005AA1 RID: 23201 RVA: 0x000DC0F0 File Offset: 0x000DA2F0
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

		// Token: 0x0400368C RID: 13964
		[Nullable(2)]
		protected new IKurotatoConditionStepUpgradeReward FbInstance;

		// Token: 0x0400368D RID: 13965
		[Nullable(2)]
		protected new IKurotatoConditionStepUpgradeReward_SetValue PocoInterface;
	}
}
