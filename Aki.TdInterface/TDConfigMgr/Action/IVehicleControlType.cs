using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002031 RID: 8241
	[NullableContext(1)]
	[Nullable(0)]
	public class IVehicleControlType
	{
		// Token: 0x0600B522 RID: 46370 RVA: 0x001A4C84 File Offset: 0x001A2E84
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

		// Token: 0x0600B523 RID: 46371 RVA: 0x001A4CBC File Offset: 0x001A2EBC
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

		// Token: 0x0600B524 RID: 46372 RVA: 0x001A4CCF File Offset: 0x001A2ECF
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

		// Token: 0x0600B525 RID: 46373 RVA: 0x001A4CE2 File Offset: 0x001A2EE2
		public IVehicleControlType_SetValue ToSetValue()
		{
			return new IVehicleControlType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170037A0 RID: 14240
		// (get) Token: 0x0600B526 RID: 46374 RVA: 0x001A4CF5 File Offset: 0x001A2EF5
		// (set) Token: 0x0600B527 RID: 46375 RVA: 0x001A4D20 File Offset: 0x001A2F20
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

		// Token: 0x04006D0B RID: 27915
		[Nullable(2)]
		protected IVehicleControlType FbInstance;

		// Token: 0x04006D0C RID: 27916
		[Nullable(2)]
		protected IVehicleControlType_SetValue PocoInterface;
	}
}
