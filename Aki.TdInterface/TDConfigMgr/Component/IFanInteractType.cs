using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003C1 RID: 961
	public class IFanInteractType
	{
		// Token: 0x060012E7 RID: 4839 RVA: 0x0003E758 File Offset: 0x0003C958
		private IFanInteractType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFanInteractType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFanInteractType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFanInteractType_SetValue());
			}
			return result;
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x0003E790 File Offset: 0x0003C990
		public static IFanInteractType Create([Nullable(2)] IFanInteractType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFanInteractType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x0003E7A3 File Offset: 0x0003C9A3
		public static IFanInteractType CreateFromSetValue([Nullable(2)] IFanInteractType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFanInteractType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x0003E7B6 File Offset: 0x0003C9B6
		public IFanInteractType_SetValue ToSetValue()
		{
			return new IFanInteractType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x060012EB RID: 4843 RVA: 0x0003E7C9 File Offset: 0x0003C9C9
		// (set) Token: 0x060012EC RID: 4844 RVA: 0x0003E7F4 File Offset: 0x0003C9F4
		public virtual EFanInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFanInteractType.Hit;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000F63 RID: 3939
		[Nullable(2)]
		protected IFanInteractType FbInstance;

		// Token: 0x04000F64 RID: 3940
		[Nullable(2)]
		protected IFanInteractType_SetValue PocoInterface;
	}
}
