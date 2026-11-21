using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002E2 RID: 738
	public class ICustomPrimitiveMapping
	{
		// Token: 0x06000DA1 RID: 3489 RVA: 0x00033294 File Offset: 0x00031494
		private ICustomPrimitiveMapping_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICustomPrimitiveMapping 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICustomPrimitiveMapping_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICustomPrimitiveMapping_SetValue());
			}
			return result;
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x000332CC File Offset: 0x000314CC
		public static ICustomPrimitiveMapping Create([Nullable(2)] ICustomPrimitiveMapping instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomPrimitiveMapping
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x000332DF File Offset: 0x000314DF
		public static ICustomPrimitiveMapping CreateFromSetValue([Nullable(2)] ICustomPrimitiveMapping_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICustomPrimitiveMapping
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x000332F2 File Offset: 0x000314F2
		public ICustomPrimitiveMapping_SetValue ToSetValue()
		{
			return new ICustomPrimitiveMapping_SetValue
			{
				KeyPrefix = this.KeyPrefix,
				Index = this.Index
			};
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x00033311 File Offset: 0x00031511
		// (set) Token: 0x06000DA6 RID: 3494 RVA: 0x0003333C File Offset: 0x0003153C
		public virtual string KeyPrefix
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeyPrefix;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.KeyPrefix;
			}
			set
			{
				this.GetOrCreatePoco().KeyPrefix = value;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x0003334A File Offset: 0x0003154A
		// (set) Token: 0x06000DA8 RID: 3496 RVA: 0x00033375 File Offset: 0x00031575
		public virtual int Index
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Index;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Index;
			}
			set
			{
				this.GetOrCreatePoco().Index = value;
			}
		}

		// Token: 0x04000C98 RID: 3224
		[Nullable(2)]
		protected ICustomPrimitiveMapping FbInstance;

		// Token: 0x04000C99 RID: 3225
		[Nullable(2)]
		protected ICustomPrimitiveMapping_SetValue PocoInterface;
	}
}
