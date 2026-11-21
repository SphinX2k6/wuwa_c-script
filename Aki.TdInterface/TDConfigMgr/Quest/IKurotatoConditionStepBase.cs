using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001103 RID: 4355
	public class IKurotatoConditionStepBase
	{
		// Token: 0x0600603C RID: 24636 RVA: 0x000E86B4 File Offset: 0x000E68B4
		private IKurotatoConditionStepBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IKurotatoConditionStepBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IKurotatoConditionStepBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IKurotatoConditionStepBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600603D RID: 24637 RVA: 0x000E86EC File Offset: 0x000E68EC
		public static IKurotatoConditionStepBase Create([Nullable(2)] IKurotatoConditionStepBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKurotatoConditionStepBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600603E RID: 24638 RVA: 0x000E86FF File Offset: 0x000E68FF
		public static IKurotatoConditionStepBase CreateFromSetValue([Nullable(2)] IKurotatoConditionStepBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IKurotatoConditionStepBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600603F RID: 24639 RVA: 0x000E8712 File Offset: 0x000E6912
		public IKurotatoConditionStepBase_SetValue ToSetValue()
		{
			return new IKurotatoConditionStepBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001F96 RID: 8086
		// (get) Token: 0x06006040 RID: 24640 RVA: 0x000E8725 File Offset: 0x000E6925
		// (set) Token: 0x06006041 RID: 24641 RVA: 0x000E8750 File Offset: 0x000E6950
		public virtual EKurotatoConditionStep Type
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

		// Token: 0x040039AC RID: 14764
		[Nullable(2)]
		protected IKurotatoConditionStepBase FbInstance;

		// Token: 0x040039AD RID: 14765
		[Nullable(2)]
		protected IKurotatoConditionStepBase_SetValue PocoInterface;
	}
}
