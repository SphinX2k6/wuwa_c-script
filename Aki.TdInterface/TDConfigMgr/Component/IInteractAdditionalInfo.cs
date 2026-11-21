using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004CB RID: 1227
	public class IInteractAdditionalInfo
	{
		// Token: 0x0600188B RID: 6283 RVA: 0x00049EE0 File Offset: 0x000480E0
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

		// Token: 0x0600188C RID: 6284 RVA: 0x00049F18 File Offset: 0x00048118
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

		// Token: 0x0600188D RID: 6285 RVA: 0x00049F2B File Offset: 0x0004812B
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

		// Token: 0x0600188E RID: 6286 RVA: 0x00049F3E File Offset: 0x0004813E
		public IInteractAdditionalInfo_SetValue ToSetValue()
		{
			return new IInteractAdditionalInfo_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x0600188F RID: 6287 RVA: 0x00049F51 File Offset: 0x00048151
		// (set) Token: 0x06001890 RID: 6288 RVA: 0x00049F7C File Offset: 0x0004817C
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

		// Token: 0x04001278 RID: 4728
		[Nullable(2)]
		protected IInteractAdditionalInfo FbInstance;

		// Token: 0x04001279 RID: 4729
		[Nullable(2)]
		protected IInteractAdditionalInfo_SetValue PocoInterface;
	}
}
