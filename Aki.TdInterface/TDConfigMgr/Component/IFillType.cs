using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000382 RID: 898
	[NullableContext(1)]
	[Nullable(0)]
	public class IFillType
	{
		// Token: 0x060011D1 RID: 4561 RVA: 0x0003B998 File Offset: 0x00039B98
		private IFillType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFillType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFillType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFillType_SetValue());
			}
			return result;
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x0003B9D0 File Offset: 0x00039BD0
		public static IFillType Create([Nullable(2)] IFillType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFillType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x0003B9E3 File Offset: 0x00039BE3
		public static IFillType CreateFromSetValue([Nullable(2)] IFillType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFillType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x0003B9F6 File Offset: 0x00039BF6
		public IFillType_SetValue ToSetValue()
		{
			return new IFillType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x0003BA09 File Offset: 0x00039C09
		// (set) Token: 0x060011D6 RID: 4566 RVA: 0x0003BA34 File Offset: 0x00039C34
		public virtual EFillType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFillType.Fixed;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000E82 RID: 3714
		[Nullable(2)]
		protected IFillType FbInstance;

		// Token: 0x04000E83 RID: 3715
		[Nullable(2)]
		protected IFillType_SetValue PocoInterface;
	}
}
