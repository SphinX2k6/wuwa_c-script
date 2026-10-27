using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000335 RID: 821
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityState
	{
		// Token: 0x0600102C RID: 4140 RVA: 0x00038444 File Offset: 0x00036644
		private IEntityState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityState_SetValue());
			}
			return result;
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0003847C File Offset: 0x0003667C
		public static IEntityState Create([Nullable(2)] IEntityState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x0003848F File Offset: 0x0003668F
		public static IEntityState CreateFromSetValue([Nullable(2)] IEntityState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x000384A2 File Offset: 0x000366A2
		public IEntityState_SetValue ToSetValue()
		{
			return new IEntityState_SetValue
			{
				Type = this.Type,
				State = this.State
			};
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001030 RID: 4144 RVA: 0x000384C1 File Offset: 0x000366C1
		// (set) Token: 0x06001031 RID: 4145 RVA: 0x000384EC File Offset: 0x000366EC
		public virtual string Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001032 RID: 4146 RVA: 0x000384FA File Offset: 0x000366FA
		// (set) Token: 0x06001033 RID: 4147 RVA: 0x00038525 File Offset: 0x00036725
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x04000DA2 RID: 3490
		[Nullable(2)]
		protected IEntityState FbInstance;

		// Token: 0x04000DA3 RID: 3491
		[Nullable(2)]
		protected IEntityState_SetValue PocoInterface;
	}
}
