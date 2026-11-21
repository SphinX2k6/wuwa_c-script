using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004EA RID: 1258
	public class IInteractStyleBase
	{
		// Token: 0x0600191A RID: 6426 RVA: 0x0004AEE8 File Offset: 0x000490E8
		private IInteractStyleBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractStyleBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractStyleBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractStyleBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x0004AF20 File Offset: 0x00049120
		public static IInteractStyleBase Create([Nullable(2)] IInteractStyleBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractStyleBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x0004AF33 File Offset: 0x00049133
		public static IInteractStyleBase CreateFromSetValue([Nullable(2)] IInteractStyleBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractStyleBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x0004AF46 File Offset: 0x00049146
		public IInteractStyleBase_SetValue ToSetValue()
		{
			return new IInteractStyleBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x0004AF59 File Offset: 0x00049159
		// (set) Token: 0x0600191F RID: 6431 RVA: 0x0004AF84 File Offset: 0x00049184
		public virtual EInteractStyleType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractStyleType.Panorama;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040012B8 RID: 4792
		[Nullable(2)]
		protected IInteractStyleBase FbInstance;

		// Token: 0x040012B9 RID: 4793
		[Nullable(2)]
		protected IInteractStyleBase_SetValue PocoInterface;
	}
}
