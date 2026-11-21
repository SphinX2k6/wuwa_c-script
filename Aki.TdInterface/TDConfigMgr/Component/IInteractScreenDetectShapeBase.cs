using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004E4 RID: 1252
	public class IInteractScreenDetectShapeBase
	{
		// Token: 0x060018FE RID: 6398 RVA: 0x0004AC20 File Offset: 0x00048E20
		private IInteractScreenDetectShapeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractScreenDetectShapeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractScreenDetectShapeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractScreenDetectShapeBase_SetValue());
			}
			return result;
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x0004AC58 File Offset: 0x00048E58
		public static IInteractScreenDetectShapeBase Create([Nullable(2)] IInteractScreenDetectShapeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractScreenDetectShapeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x0004AC6B File Offset: 0x00048E6B
		public static IInteractScreenDetectShapeBase CreateFromSetValue([Nullable(2)] IInteractScreenDetectShapeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractScreenDetectShapeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x0004AC7E File Offset: 0x00048E7E
		public IInteractScreenDetectShapeBase_SetValue ToSetValue()
		{
			return new IInteractScreenDetectShapeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x0004AC91 File Offset: 0x00048E91
		// (set) Token: 0x06001903 RID: 6403 RVA: 0x0004ACBC File Offset: 0x00048EBC
		public virtual EInteractScreenDetectShape Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractScreenDetectShape.Circle;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040012AD RID: 4781
		[Nullable(2)]
		protected IInteractScreenDetectShapeBase FbInstance;

		// Token: 0x040012AE RID: 4782
		[Nullable(2)]
		protected IInteractScreenDetectShapeBase_SetValue PocoInterface;
	}
}
