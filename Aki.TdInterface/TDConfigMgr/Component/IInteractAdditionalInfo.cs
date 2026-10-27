using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000472 RID: 1138
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractAdditionalInfo
	{
		// Token: 0x060016F1 RID: 5873 RVA: 0x00046198 File Offset: 0x00044398
		private IInteractAdditionalInfo_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractAdditionalInfo 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractAdditionalInfo_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractAdditionalInfo_SetValue());
			}
			return result;
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x000461D0 File Offset: 0x000443D0
		public static IInteractAdditionalInfo Create([Nullable(2)] IInteractAdditionalInfo instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractAdditionalInfo
			{
				FbInstance = instance
			};
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x000461E3 File Offset: 0x000443E3
		public static IInteractAdditionalInfo CreateFromSetValue([Nullable(2)] IInteractAdditionalInfo_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractAdditionalInfo
			{
				PocoInterface = value
			};
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x000461F6 File Offset: 0x000443F6
		public IInteractAdditionalInfo_SetValue ToSetValue()
		{
			return new IInteractAdditionalInfo_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x060016F5 RID: 5877 RVA: 0x00046209 File Offset: 0x00044409
		// (set) Token: 0x060016F6 RID: 5878 RVA: 0x00046234 File Offset: 0x00044434
		public virtual EInteractAdditionalInfoType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractAdditionalInfoType.FishingPoint;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001156 RID: 4438
		[Nullable(2)]
		protected IInteractAdditionalInfo FbInstance;

		// Token: 0x04001157 RID: 4439
		[Nullable(2)]
		protected IInteractAdditionalInfo_SetValue PocoInterface;
	}
}
