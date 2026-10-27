using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FD9 RID: 4057
	[NullableContext(1)]
	[Nullable(0)]
	public class IKurotatoConditionStepBattle : IKurotatoConditionStepBase
	{
		// Token: 0x06005A64 RID: 23140 RVA: 0x000DBB30 File Offset: 0x000D9D30
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

		// Token: 0x06005A65 RID: 23141 RVA: 0x000DBB68 File Offset: 0x000D9D68
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

		// Token: 0x06005A66 RID: 23142 RVA: 0x000DBB7B File Offset: 0x000D9D7B
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

		// Token: 0x06005A67 RID: 23143 RVA: 0x000DBB8E File Offset: 0x000D9D8E
		public new IKurotatoConditionStepBattle_SetValue ToSetValue()
		{
			return new IKurotatoConditionStepBattle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001DEE RID: 7662
		// (get) Token: 0x06005A68 RID: 23144 RVA: 0x000DBBA1 File Offset: 0x000D9DA1
		// (set) Token: 0x06005A69 RID: 23145 RVA: 0x000DBBCC File Offset: 0x000D9DCC
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

		// Token: 0x04003677 RID: 13943
		[Nullable(2)]
		protected new IKurotatoConditionStepBattle FbInstance;

		// Token: 0x04003678 RID: 13944
		[Nullable(2)]
		protected new IKurotatoConditionStepBattle_SetValue PocoInterface;
	}
}
