using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200227C RID: 8828
	public class IVehicleCruisingParams
	{
		// Token: 0x0600C050 RID: 49232 RVA: 0x001BB4AC File Offset: 0x001B96AC
		private IVehicleCruisingParams_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVehicleCruisingParams 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVehicleCruisingParams_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVehicleCruisingParams_SetValue());
			}
			return result;
		}

		// Token: 0x0600C051 RID: 49233 RVA: 0x001BB4E4 File Offset: 0x001B96E4
		public static IVehicleCruisingParams Create([Nullable(2)] IVehicleCruisingParams instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleCruisingParams
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C052 RID: 49234 RVA: 0x001BB4F7 File Offset: 0x001B96F7
		public static IVehicleCruisingParams CreateFromSetValue([Nullable(2)] IVehicleCruisingParams_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVehicleCruisingParams
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C053 RID: 49235 RVA: 0x001BB50A File Offset: 0x001B970A
		public IVehicleCruisingParams_SetValue ToSetValue()
		{
			return new IVehicleCruisingParams_SetValue
			{
				ForwardSpeed = this.ForwardSpeed,
				ForwardAcceleration = this.ForwardAcceleration,
				DisableSprint = this.DisableSprint
			};
		}

		// Token: 0x17003A7E RID: 14974
		// (get) Token: 0x0600C054 RID: 49236 RVA: 0x001BB535 File Offset: 0x001B9735
		// (set) Token: 0x0600C055 RID: 49237 RVA: 0x001BB564 File Offset: 0x001B9764
		public virtual float ForwardSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ForwardSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.ForwardSpeed;
			}
			set
			{
				this.GetOrCreatePoco().ForwardSpeed = value;
			}
		}

		// Token: 0x17003A7F RID: 14975
		// (get) Token: 0x0600C056 RID: 49238 RVA: 0x001BB572 File Offset: 0x001B9772
		// (set) Token: 0x0600C057 RID: 49239 RVA: 0x001BB5A1 File Offset: 0x001B97A1
		public virtual float ForwardAcceleration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ForwardAcceleration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.ForwardAcceleration;
			}
			set
			{
				this.GetOrCreatePoco().ForwardAcceleration = value;
			}
		}

		// Token: 0x17003A80 RID: 14976
		// (get) Token: 0x0600C058 RID: 49240 RVA: 0x001BB5B0 File Offset: 0x001B97B0
		// (set) Token: 0x0600C059 RID: 49241 RVA: 0x001BB5EA File Offset: 0x001B97EA
		public virtual bool? DisableSprint
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableSprint;
				}
				IVehicleCruisingParams_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableSprint;
			}
			set
			{
				this.GetOrCreatePoco().DisableSprint = value;
			}
		}

		// Token: 0x04007317 RID: 29463
		[Nullable(2)]
		protected IVehicleCruisingParams FbInstance;

		// Token: 0x04007318 RID: 29464
		[Nullable(2)]
		protected IVehicleCruisingParams_SetValue PocoInterface;
	}
}
