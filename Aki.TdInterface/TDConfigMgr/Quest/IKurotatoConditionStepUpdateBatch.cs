using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FE5 RID: 4069
	[NullableContext(1)]
	[Nullable(0)]
	public class IKurotatoConditionStepUpdateBatch : IKurotatoConditionStepBase
	{
		// Token: 0x06005A94 RID: 23188 RVA: 0x000DBF98 File Offset: 0x000DA198
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

		// Token: 0x06005A95 RID: 23189 RVA: 0x000DBFD0 File Offset: 0x000DA1D0
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

		// Token: 0x06005A96 RID: 23190 RVA: 0x000DBFE3 File Offset: 0x000DA1E3
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

		// Token: 0x06005A97 RID: 23191 RVA: 0x000DBFF6 File Offset: 0x000DA1F6
		public new IKurotatoConditionStepUpdateBatch_SetValue ToSetValue()
		{
			return new IKurotatoConditionStepUpdateBatch_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001DF4 RID: 7668
		// (get) Token: 0x06005A98 RID: 23192 RVA: 0x000DC009 File Offset: 0x000DA209
		// (set) Token: 0x06005A99 RID: 23193 RVA: 0x000DC034 File Offset: 0x000DA234
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

		// Token: 0x04003689 RID: 13961
		[Nullable(2)]
		protected new IKurotatoConditionStepUpdateBatch FbInstance;

		// Token: 0x0400368A RID: 13962
		[Nullable(2)]
		protected new IKurotatoConditionStepUpdateBatch_SetValue PocoInterface;
	}
}
