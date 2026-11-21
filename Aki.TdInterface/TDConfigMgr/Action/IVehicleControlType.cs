using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200227A RID: 8826
	public class IVehicleControlType
	{
		// Token: 0x0600C048 RID: 49224 RVA: 0x001BB3F0 File Offset: 0x001B95F0
		private IVehicleControlType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVehicleControlType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVehicleControlType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVehicleControlType_SetValue());
			}
			return result;
		}

		// Token: 0x0600C049 RID: 49225 RVA: 0x001BB428 File Offset: 0x001B9628
		public static IVehicleControlType Create([Nullable(2)] IVehicleControlType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleControlType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C04A RID: 49226 RVA: 0x001BB43B File Offset: 0x001B963B
		public static IVehicleControlType CreateFromSetValue([Nullable(2)] IVehicleControlType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVehicleControlType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C04B RID: 49227 RVA: 0x001BB44E File Offset: 0x001B964E
		public IVehicleControlType_SetValue ToSetValue()
		{
			return new IVehicleControlType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003A7D RID: 14973
		// (get) Token: 0x0600C04C RID: 49228 RVA: 0x001BB461 File Offset: 0x001B9661
		// (set) Token: 0x0600C04D RID: 49229 RVA: 0x001BB48C File Offset: 0x001B968C
		public virtual EVehicleControlType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVehicleControlType.EnterPathMoving;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04007314 RID: 29460
		[Nullable(2)]
		protected IVehicleControlType FbInstance;

		// Token: 0x04007315 RID: 29461
		[Nullable(2)]
		protected IVehicleControlType_SetValue PocoInterface;
	}
}
