using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B58 RID: 7000
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractType
	{
		// Token: 0x060095E1 RID: 38369 RVA: 0x0015A67C File Offset: 0x0015887C
		private IInteractType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractType_SetValue());
			}
			return result;
		}

		// Token: 0x060095E2 RID: 38370 RVA: 0x0015A6B4 File Offset: 0x001588B4
		public static IInteractType Create([Nullable(2)] IInteractType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060095E3 RID: 38371 RVA: 0x0015A6C7 File Offset: 0x001588C7
		public static IInteractType CreateFromSetValue([Nullable(2)] IInteractType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060095E4 RID: 38372 RVA: 0x0015A6DA File Offset: 0x001588DA
		public IInteractType_SetValue ToSetValue()
		{
			return new IInteractType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F43 RID: 12099
		// (get) Token: 0x060095E5 RID: 38373 RVA: 0x0015A6ED File Offset: 0x001588ED
		// (set) Token: 0x060095E6 RID: 38374 RVA: 0x0015A718 File Offset: 0x00158918
		public virtual EInteractOption Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractOption.Flow;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005BB2 RID: 23474
		[Nullable(2)]
		protected IInteractType FbInstance;

		// Token: 0x04005BB3 RID: 23475
		[Nullable(2)]
		protected IInteractType_SetValue PocoInterface;
	}
}
