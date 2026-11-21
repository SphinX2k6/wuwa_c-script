using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001105 RID: 4357
	public class IKurotatoConditionStepBattle : IKurotatoConditionStepBase
	{
		// Token: 0x06006044 RID: 24644 RVA: 0x000E8770 File Offset: 0x000E6970
		private IKurotatoConditionStepBattle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IKurotatoConditionStepBattle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IKurotatoConditionStepBattle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IKurotatoConditionStepBattle_SetValue());
			}
			return result;
		}

		// Token: 0x06006045 RID: 24645 RVA: 0x000E87A8 File Offset: 0x000E69A8
		public static IKurotatoConditionStepBattle Create([Nullable(2)] IKurotatoConditionStepBattle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKurotatoConditionStepBattle
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006046 RID: 24646 RVA: 0x000E87BB File Offset: 0x000E69BB
		public static IKurotatoConditionStepBattle CreateFromSetValue([Nullable(2)] IKurotatoConditionStepBattle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IKurotatoConditionStepBattle
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006047 RID: 24647 RVA: 0x000E87CE File Offset: 0x000E69CE
		public new IKurotatoConditionStepBattle_SetValue ToSetValue()
		{
			return new IKurotatoConditionStepBattle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001F97 RID: 8087
		// (get) Token: 0x06006048 RID: 24648 RVA: 0x000E87E1 File Offset: 0x000E69E1
		// (set) Token: 0x06006049 RID: 24649 RVA: 0x000E880C File Offset: 0x000E6A0C
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

		// Token: 0x040039AF RID: 14767
		[Nullable(2)]
		protected new IKurotatoConditionStepBattle FbInstance;

		// Token: 0x040039B0 RID: 14768
		[Nullable(2)]
		protected new IKurotatoConditionStepBattle_SetValue PocoInterface;
	}
}
