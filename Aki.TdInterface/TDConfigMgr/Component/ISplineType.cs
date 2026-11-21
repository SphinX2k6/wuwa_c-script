using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200079F RID: 1951
	public class ISplineType
	{
		// Token: 0x060029AC RID: 10668 RVA: 0x0006E0F0 File Offset: 0x0006C2F0
		private ISplineType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISplineType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISplineType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISplineType_SetValue());
			}
			return result;
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x0006E128 File Offset: 0x0006C328
		public static ISplineType Create([Nullable(2)] ISplineType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISplineType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x0006E13B File Offset: 0x0006C33B
		public static ISplineType CreateFromSetValue([Nullable(2)] ISplineType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISplineType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x0006E14E File Offset: 0x0006C34E
		public ISplineType_SetValue ToSetValue()
		{
			return new ISplineType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x060029B0 RID: 10672 RVA: 0x0006E161 File Offset: 0x0006C361
		// (set) Token: 0x060029B1 RID: 10673 RVA: 0x0006E18C File Offset: 0x0006C38C
		public virtual ESplineType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineType.Common;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001C21 RID: 7201
		[Nullable(2)]
		protected ISplineType FbInstance;

		// Token: 0x04001C22 RID: 7202
		[Nullable(2)]
		protected ISplineType_SetValue PocoInterface;
	}
}
