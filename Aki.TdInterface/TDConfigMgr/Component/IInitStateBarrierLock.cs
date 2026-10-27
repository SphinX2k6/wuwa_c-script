using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000466 RID: 1126
	[NullableContext(1)]
	[Nullable(0)]
	public class IInitStateBarrierLock : IInitState
	{
		// Token: 0x060016B7 RID: 5815 RVA: 0x00045B54 File Offset: 0x00043D54
		private IInitStateBarrierLock_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInitStateBarrierLock 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInitStateBarrierLock_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInitStateBarrierLock_SetValue());
			}
			return result;
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x00045B8C File Offset: 0x00043D8C
		public static IInitStateBarrierLock Create([Nullable(2)] IInitStateBarrierLock instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInitStateBarrierLock
			{
				FbInstance = instance
			};
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x00045B9F File Offset: 0x00043D9F
		public static IInitStateBarrierLock CreateFromSetValue([Nullable(2)] IInitStateBarrierLock_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInitStateBarrierLock
			{
				PocoInterface = value
			};
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x00045BB2 File Offset: 0x00043DB2
		public new IInitStateBarrierLock_SetValue ToSetValue()
		{
			return new IInitStateBarrierLock_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x060016BB RID: 5819 RVA: 0x00045BC5 File Offset: 0x00043DC5
		// (set) Token: 0x060016BC RID: 5820 RVA: 0x00045BF0 File Offset: 0x00043DF0
		public override EInitStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInitStateType.Birth;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400113D RID: 4413
		[Nullable(2)]
		protected new IInitStateBarrierLock FbInstance;

		// Token: 0x0400113E RID: 4414
		[Nullable(2)]
		protected new IInitStateBarrierLock_SetValue PocoInterface;
	}
}
