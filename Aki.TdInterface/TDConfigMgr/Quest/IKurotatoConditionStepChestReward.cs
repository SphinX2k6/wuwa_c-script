using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FDB RID: 4059
	[NullableContext(1)]
	[Nullable(0)]
	public class IKurotatoConditionStepChestReward : IKurotatoConditionStepBase
	{
		// Token: 0x06005A6C RID: 23148 RVA: 0x000DBBEC File Offset: 0x000D9DEC
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

		// Token: 0x06005A6D RID: 23149 RVA: 0x000DBC24 File Offset: 0x000D9E24
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

		// Token: 0x06005A6E RID: 23150 RVA: 0x000DBC37 File Offset: 0x000D9E37
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

		// Token: 0x06005A6F RID: 23151 RVA: 0x000DBC4A File Offset: 0x000D9E4A
		public new IKurotatoConditionStepChestReward_SetValue ToSetValue()
		{
			return new IKurotatoConditionStepChestReward_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001DEF RID: 7663
		// (get) Token: 0x06005A70 RID: 23152 RVA: 0x000DBC5D File Offset: 0x000D9E5D
		// (set) Token: 0x06005A71 RID: 23153 RVA: 0x000DBC88 File Offset: 0x000D9E88
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

		// Token: 0x0400367A RID: 13946
		[Nullable(2)]
		protected new IKurotatoConditionStepChestReward FbInstance;

		// Token: 0x0400367B RID: 13947
		[Nullable(2)]
		protected new IKurotatoConditionStepChestReward_SetValue PocoInterface;
	}
}
