using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000462 RID: 1122
	[NullableContext(1)]
	[Nullable(0)]
	public class IInhaledPerResultType
	{
		// Token: 0x060016A7 RID: 5799 RVA: 0x000459DC File Offset: 0x00043BDC
		private IInhaledPerResultType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInhaledPerResultType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInhaledPerResultType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInhaledPerResultType_SetValue());
			}
			return result;
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x00045A14 File Offset: 0x00043C14
		public static IInhaledPerResultType Create([Nullable(2)] IInhaledPerResultType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInhaledPerResultType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x00045A27 File Offset: 0x00043C27
		public static IInhaledPerResultType CreateFromSetValue([Nullable(2)] IInhaledPerResultType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInhaledPerResultType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00045A3A File Offset: 0x00043C3A
		public IInhaledPerResultType_SetValue ToSetValue()
		{
			return new IInhaledPerResultType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x060016AB RID: 5803 RVA: 0x00045A4D File Offset: 0x00043C4D
		// (set) Token: 0x060016AC RID: 5804 RVA: 0x00045A78 File Offset: 0x00043C78
		public virtual EInhaledPerResultType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInhaledPerResultType.DestroySelf;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001137 RID: 4407
		[Nullable(2)]
		protected IInhaledPerResultType FbInstance;

		// Token: 0x04001138 RID: 4408
		[Nullable(2)]
		protected IInhaledPerResultType_SetValue PocoInterface;
	}
}
