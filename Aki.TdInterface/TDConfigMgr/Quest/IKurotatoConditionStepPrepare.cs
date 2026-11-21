using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200110B RID: 4363
	public class IKurotatoConditionStepPrepare : IKurotatoConditionStepBase
	{
		// Token: 0x0600605C RID: 24668 RVA: 0x000E89A4 File Offset: 0x000E6BA4
		private IKurotatoConditionStepPrepare_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IKurotatoConditionStepPrepare 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IKurotatoConditionStepPrepare_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IKurotatoConditionStepPrepare_SetValue());
			}
			return result;
		}

		// Token: 0x0600605D RID: 24669 RVA: 0x000E89DC File Offset: 0x000E6BDC
		public static IKurotatoConditionStepPrepare Create([Nullable(2)] IKurotatoConditionStepPrepare instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKurotatoConditionStepPrepare
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600605E RID: 24670 RVA: 0x000E89EF File Offset: 0x000E6BEF
		public static IKurotatoConditionStepPrepare CreateFromSetValue([Nullable(2)] IKurotatoConditionStepPrepare_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IKurotatoConditionStepPrepare
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600605F RID: 24671 RVA: 0x000E8A02 File Offset: 0x000E6C02
		public new IKurotatoConditionStepPrepare_SetValue ToSetValue()
		{
			return new IKurotatoConditionStepPrepare_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001F9A RID: 8090
		// (get) Token: 0x06006060 RID: 24672 RVA: 0x000E8A15 File Offset: 0x000E6C15
		// (set) Token: 0x06006061 RID: 24673 RVA: 0x000E8A40 File Offset: 0x000E6C40
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

		// Token: 0x040039B8 RID: 14776
		[Nullable(2)]
		protected new IKurotatoConditionStepPrepare FbInstance;

		// Token: 0x040039B9 RID: 14777
		[Nullable(2)]
		protected new IKurotatoConditionStepPrepare_SetValue PocoInterface;
	}
}
