using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000358 RID: 856
	public class IEntityBatchType
	{
		// Token: 0x06001069 RID: 4201 RVA: 0x00038D0C File Offset: 0x00036F0C
		private IEntityBatchType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityBatchType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityBatchType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityBatchType_SetValue());
			}
			return result;
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x00038D44 File Offset: 0x00036F44
		public static IEntityBatchType Create([Nullable(2)] IEntityBatchType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityBatchType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x00038D57 File Offset: 0x00036F57
		public static IEntityBatchType CreateFromSetValue([Nullable(2)] IEntityBatchType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityBatchType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x00038D6A File Offset: 0x00036F6A
		public IEntityBatchType_SetValue ToSetValue()
		{
			return new IEntityBatchType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x00038D7D File Offset: 0x00036F7D
		// (set) Token: 0x0600106E RID: 4206 RVA: 0x00038DA8 File Offset: 0x00036FA8
		public virtual EEntityBatchType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEntityBatchType.EntityList;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000E15 RID: 3605
		[Nullable(2)]
		protected IEntityBatchType FbInstance;

		// Token: 0x04000E16 RID: 3606
		[Nullable(2)]
		protected IEntityBatchType_SetValue PocoInterface;
	}
}
