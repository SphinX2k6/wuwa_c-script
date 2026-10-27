using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FDD RID: 4061
	[NullableContext(1)]
	[Nullable(0)]
	public class IKurotatoConditionStepEnd : IKurotatoConditionStepBase
	{
		// Token: 0x06005A74 RID: 23156 RVA: 0x000DBCA8 File Offset: 0x000D9EA8
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

		// Token: 0x06005A75 RID: 23157 RVA: 0x000DBCE0 File Offset: 0x000D9EE0
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

		// Token: 0x06005A76 RID: 23158 RVA: 0x000DBCF3 File Offset: 0x000D9EF3
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

		// Token: 0x06005A77 RID: 23159 RVA: 0x000DBD06 File Offset: 0x000D9F06
		public new IKurotatoConditionStepEnd_SetValue ToSetValue()
		{
			return new IKurotatoConditionStepEnd_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001DF0 RID: 7664
		// (get) Token: 0x06005A78 RID: 23160 RVA: 0x000DBD19 File Offset: 0x000D9F19
		// (set) Token: 0x06005A79 RID: 23161 RVA: 0x000DBD44 File Offset: 0x000D9F44
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

		// Token: 0x0400367D RID: 13949
		[Nullable(2)]
		protected new IKurotatoConditionStepEnd FbInstance;

		// Token: 0x0400367E RID: 13950
		[Nullable(2)]
		protected new IKurotatoConditionStepEnd_SetValue PocoInterface;
	}
}
