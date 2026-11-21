using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001111 RID: 4369
	public class IKurotatoConditionStepUpdateBatch : IKurotatoConditionStepBase
	{
		// Token: 0x06006074 RID: 24692 RVA: 0x000E8BD8 File Offset: 0x000E6DD8
		private IKurotatoConditionStepUpdateBatch_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IKurotatoConditionStepUpdateBatch 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IKurotatoConditionStepUpdateBatch_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IKurotatoConditionStepUpdateBatch_SetValue());
			}
			return result;
		}

		// Token: 0x06006075 RID: 24693 RVA: 0x000E8C10 File Offset: 0x000E6E10
		public static IKurotatoConditionStepUpdateBatch Create([Nullable(2)] IKurotatoConditionStepUpdateBatch instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKurotatoConditionStepUpdateBatch
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006076 RID: 24694 RVA: 0x000E8C23 File Offset: 0x000E6E23
		public static IKurotatoConditionStepUpdateBatch CreateFromSetValue([Nullable(2)] IKurotatoConditionStepUpdateBatch_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IKurotatoConditionStepUpdateBatch
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006077 RID: 24695 RVA: 0x000E8C36 File Offset: 0x000E6E36
		public new IKurotatoConditionStepUpdateBatch_SetValue ToSetValue()
		{
			return new IKurotatoConditionStepUpdateBatch_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001F9D RID: 8093
		// (get) Token: 0x06006078 RID: 24696 RVA: 0x000E8C49 File Offset: 0x000E6E49
		// (set) Token: 0x06006079 RID: 24697 RVA: 0x000E8C74 File Offset: 0x000E6E74
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

		// Token: 0x040039C1 RID: 14785
		[Nullable(2)]
		protected new IKurotatoConditionStepUpdateBatch FbInstance;

		// Token: 0x040039C2 RID: 14786
		[Nullable(2)]
		protected new IKurotatoConditionStepUpdateBatch_SetValue PocoInterface;
	}
}
