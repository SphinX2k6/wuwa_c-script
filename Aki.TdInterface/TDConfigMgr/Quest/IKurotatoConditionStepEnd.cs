using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001109 RID: 4361
	public class IKurotatoConditionStepEnd : IKurotatoConditionStepBase
	{
		// Token: 0x06006054 RID: 24660 RVA: 0x000E88E8 File Offset: 0x000E6AE8
		private IKurotatoConditionStepEnd_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IKurotatoConditionStepEnd 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IKurotatoConditionStepEnd_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IKurotatoConditionStepEnd_SetValue());
			}
			return result;
		}

		// Token: 0x06006055 RID: 24661 RVA: 0x000E8920 File Offset: 0x000E6B20
		public static IKurotatoConditionStepEnd Create([Nullable(2)] IKurotatoConditionStepEnd instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKurotatoConditionStepEnd
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006056 RID: 24662 RVA: 0x000E8933 File Offset: 0x000E6B33
		public static IKurotatoConditionStepEnd CreateFromSetValue([Nullable(2)] IKurotatoConditionStepEnd_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IKurotatoConditionStepEnd
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006057 RID: 24663 RVA: 0x000E8946 File Offset: 0x000E6B46
		public new IKurotatoConditionStepEnd_SetValue ToSetValue()
		{
			return new IKurotatoConditionStepEnd_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001F99 RID: 8089
		// (get) Token: 0x06006058 RID: 24664 RVA: 0x000E8959 File Offset: 0x000E6B59
		// (set) Token: 0x06006059 RID: 24665 RVA: 0x000E8984 File Offset: 0x000E6B84
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

		// Token: 0x040039B5 RID: 14773
		[Nullable(2)]
		protected new IKurotatoConditionStepEnd FbInstance;

		// Token: 0x040039B6 RID: 14774
		[Nullable(2)]
		protected new IKurotatoConditionStepEnd_SetValue PocoInterface;
	}
}
