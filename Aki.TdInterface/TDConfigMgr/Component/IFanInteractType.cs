using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000378 RID: 888
	[NullableContext(1)]
	[Nullable(0)]
	public class IFanInteractType
	{
		// Token: 0x060011A3 RID: 4515 RVA: 0x0003B474 File Offset: 0x00039674
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

		// Token: 0x060011A4 RID: 4516 RVA: 0x0003B4AC File Offset: 0x000396AC
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

		// Token: 0x060011A5 RID: 4517 RVA: 0x0003B4BF File Offset: 0x000396BF
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

		// Token: 0x060011A6 RID: 4518 RVA: 0x0003B4D2 File Offset: 0x000396D2
		public IFanInteractType_SetValue ToSetValue()
		{
			return new IFanInteractType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x0003B4E5 File Offset: 0x000396E5
		// (set) Token: 0x060011A8 RID: 4520 RVA: 0x0003B510 File Offset: 0x00039710
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

		// Token: 0x04000E6C RID: 3692
		[Nullable(2)]
		protected IFanInteractType FbInstance;

		// Token: 0x04000E6D RID: 3693
		[Nullable(2)]
		protected IFanInteractType_SetValue PocoInterface;
	}
}
