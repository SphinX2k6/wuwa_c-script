using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001097 RID: 4247
	public class IFastReturnPosBase
	{
		// Token: 0x06005DA0 RID: 23968 RVA: 0x000E3260 File Offset: 0x000E1460
		private IFastReturnPosBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFastReturnPosBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFastReturnPosBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFastReturnPosBase_SetValue());
			}
			return result;
		}

		// Token: 0x06005DA1 RID: 23969 RVA: 0x000E3298 File Offset: 0x000E1498
		public static IFastReturnPosBase Create([Nullable(2)] IFastReturnPosBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFastReturnPosBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005DA2 RID: 23970 RVA: 0x000E32AB File Offset: 0x000E14AB
		public static IFastReturnPosBase CreateFromSetValue([Nullable(2)] IFastReturnPosBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFastReturnPosBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005DA3 RID: 23971 RVA: 0x000E32BE File Offset: 0x000E14BE
		public IFastReturnPosBase_SetValue ToSetValue()
		{
			return new IFastReturnPosBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001EEA RID: 7914
		// (get) Token: 0x06005DA4 RID: 23972 RVA: 0x000E32D1 File Offset: 0x000E14D1
		// (set) Token: 0x06005DA5 RID: 23973 RVA: 0x000E32FC File Offset: 0x000E14FC
		public virtual EFastReturnPosType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFastReturnPosType.EntityPos;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003840 RID: 14400
		[Nullable(2)]
		protected IFastReturnPosBase FbInstance;

		// Token: 0x04003841 RID: 14401
		[Nullable(2)]
		protected IFastReturnPosBase_SetValue PocoInterface;
	}
}
