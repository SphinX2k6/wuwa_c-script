using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001107 RID: 4359
	public class IKurotatoConditionStepChestReward : IKurotatoConditionStepBase
	{
		// Token: 0x0600604C RID: 24652 RVA: 0x000E882C File Offset: 0x000E6A2C
		private IKurotatoConditionStepChestReward_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IKurotatoConditionStepChestReward 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IKurotatoConditionStepChestReward_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IKurotatoConditionStepChestReward_SetValue());
			}
			return result;
		}

		// Token: 0x0600604D RID: 24653 RVA: 0x000E8864 File Offset: 0x000E6A64
		public static IKurotatoConditionStepChestReward Create([Nullable(2)] IKurotatoConditionStepChestReward instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKurotatoConditionStepChestReward
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600604E RID: 24654 RVA: 0x000E8877 File Offset: 0x000E6A77
		public static IKurotatoConditionStepChestReward CreateFromSetValue([Nullable(2)] IKurotatoConditionStepChestReward_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IKurotatoConditionStepChestReward
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600604F RID: 24655 RVA: 0x000E888A File Offset: 0x000E6A8A
		public new IKurotatoConditionStepChestReward_SetValue ToSetValue()
		{
			return new IKurotatoConditionStepChestReward_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001F98 RID: 8088
		// (get) Token: 0x06006050 RID: 24656 RVA: 0x000E889D File Offset: 0x000E6A9D
		// (set) Token: 0x06006051 RID: 24657 RVA: 0x000E88C8 File Offset: 0x000E6AC8
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

		// Token: 0x040039B2 RID: 14770
		[Nullable(2)]
		protected new IKurotatoConditionStepChestReward FbInstance;

		// Token: 0x040039B3 RID: 14771
		[Nullable(2)]
		protected new IKurotatoConditionStepChestReward_SetValue PocoInterface;
	}
}
