using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FDF RID: 4063
	[NullableContext(1)]
	[Nullable(0)]
	public class IKurotatoConditionStepPrepare : IKurotatoConditionStepBase
	{
		// Token: 0x06005A7C RID: 23164 RVA: 0x000DBD64 File Offset: 0x000D9F64
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

		// Token: 0x06005A7D RID: 23165 RVA: 0x000DBD9C File Offset: 0x000D9F9C
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

		// Token: 0x06005A7E RID: 23166 RVA: 0x000DBDAF File Offset: 0x000D9FAF
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

		// Token: 0x06005A7F RID: 23167 RVA: 0x000DBDC2 File Offset: 0x000D9FC2
		public new IKurotatoConditionStepPrepare_SetValue ToSetValue()
		{
			return new IKurotatoConditionStepPrepare_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001DF1 RID: 7665
		// (get) Token: 0x06005A80 RID: 23168 RVA: 0x000DBDD5 File Offset: 0x000D9FD5
		// (set) Token: 0x06005A81 RID: 23169 RVA: 0x000DBE00 File Offset: 0x000DA000
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

		// Token: 0x04003680 RID: 13952
		[Nullable(2)]
		protected new IKurotatoConditionStepPrepare FbInstance;

		// Token: 0x04003681 RID: 13953
		[Nullable(2)]
		protected new IKurotatoConditionStepPrepare_SetValue PocoInterface;
	}
}
