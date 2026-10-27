using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002033 RID: 8243
	[NullableContext(1)]
	[Nullable(0)]
	public class IVehicleCruisingParams
	{
		// Token: 0x0600B52A RID: 46378 RVA: 0x001A4D40 File Offset: 0x001A2F40
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

		// Token: 0x0600B52B RID: 46379 RVA: 0x001A4D78 File Offset: 0x001A2F78
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

		// Token: 0x0600B52C RID: 46380 RVA: 0x001A4D8B File Offset: 0x001A2F8B
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

		// Token: 0x0600B52D RID: 46381 RVA: 0x001A4D9E File Offset: 0x001A2F9E
		public IVehicleCruisingParams_SetValue ToSetValue()
		{
			return new IVehicleCruisingParams_SetValue
			{
				ForwardSpeed = this.ForwardSpeed,
				ForwardAcceleration = this.ForwardAcceleration,
				DisableSprint = this.DisableSprint
			};
		}

		// Token: 0x170037A1 RID: 14241
		// (get) Token: 0x0600B52E RID: 46382 RVA: 0x001A4DC9 File Offset: 0x001A2FC9
		// (set) Token: 0x0600B52F RID: 46383 RVA: 0x001A4DF8 File Offset: 0x001A2FF8
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

		// Token: 0x170037A2 RID: 14242
		// (get) Token: 0x0600B530 RID: 46384 RVA: 0x001A4E06 File Offset: 0x001A3006
		// (set) Token: 0x0600B531 RID: 46385 RVA: 0x001A4E35 File Offset: 0x001A3035
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

		// Token: 0x170037A3 RID: 14243
		// (get) Token: 0x0600B532 RID: 46386 RVA: 0x001A4E44 File Offset: 0x001A3044
		// (set) Token: 0x0600B533 RID: 46387 RVA: 0x001A4E7E File Offset: 0x001A307E
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

		// Token: 0x04006D0E RID: 27918
		[Nullable(2)]
		protected IVehicleCruisingParams FbInstance;

		// Token: 0x04006D0F RID: 27919
		[Nullable(2)]
		protected IVehicleCruisingParams_SetValue PocoInterface;
	}
}
