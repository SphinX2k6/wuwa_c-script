using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FD7 RID: 4055
	[NullableContext(1)]
	[Nullable(0)]
	public class IKurotatoConditionStepBase
	{
		// Token: 0x06005A5C RID: 23132 RVA: 0x000DBA74 File Offset: 0x000D9C74
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

		// Token: 0x06005A5D RID: 23133 RVA: 0x000DBAAC File Offset: 0x000D9CAC
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

		// Token: 0x06005A5E RID: 23134 RVA: 0x000DBABF File Offset: 0x000D9CBF
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

		// Token: 0x06005A5F RID: 23135 RVA: 0x000DBAD2 File Offset: 0x000D9CD2
		public IKurotatoConditionStepBase_SetValue ToSetValue()
		{
			return new IKurotatoConditionStepBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001DED RID: 7661
		// (get) Token: 0x06005A60 RID: 23136 RVA: 0x000DBAE5 File Offset: 0x000D9CE5
		// (set) Token: 0x06005A61 RID: 23137 RVA: 0x000DBB10 File Offset: 0x000D9D10
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

		// Token: 0x04003674 RID: 13940
		[Nullable(2)]
		protected IKurotatoConditionStepBase FbInstance;

		// Token: 0x04003675 RID: 13941
		[Nullable(2)]
		protected IKurotatoConditionStepBase_SetValue PocoInterface;
	}
}
