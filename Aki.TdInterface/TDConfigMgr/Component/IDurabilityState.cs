using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002D5 RID: 725
	[NullableContext(1)]
	[Nullable(0)]
	public class IDurabilityState
	{
		// Token: 0x06000DD7 RID: 3543 RVA: 0x000330E4 File Offset: 0x000312E4
		private IDurabilityState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDurabilityState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDurabilityState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDurabilityState_SetValue());
			}
			return result;
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x0003311C File Offset: 0x0003131C
		public static IDurabilityState Create([Nullable(2)] IDurabilityState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDurabilityState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x0003312F File Offset: 0x0003132F
		public static IDurabilityState CreateFromSetValue([Nullable(2)] IDurabilityState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDurabilityState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00033142 File Offset: 0x00031342
		public IDurabilityState_SetValue ToSetValue()
		{
			return new IDurabilityState_SetValue
			{
				Durability = this.Durability,
				State = this.State
			};
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x00033161 File Offset: 0x00031361
		// (set) Token: 0x06000DDC RID: 3548 RVA: 0x0003318C File Offset: 0x0003138C
		public virtual int Durability
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Durability;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Durability;
			}
			set
			{
				this.GetOrCreatePoco().Durability = value;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x0003319A File Offset: 0x0003139A
		// (set) Token: 0x06000DDE RID: 3550 RVA: 0x000331C5 File Offset: 0x000313C5
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

		// Token: 0x04000C6C RID: 3180
		[Nullable(2)]
		protected IDurabilityState FbInstance;

		// Token: 0x04000C6D RID: 3181
		[Nullable(2)]
		protected IDurabilityState_SetValue PocoInterface;
	}
}
