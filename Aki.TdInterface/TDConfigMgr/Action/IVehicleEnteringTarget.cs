using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002039 RID: 8249
	[NullableContext(1)]
	[Nullable(0)]
	public class IVehicleEnteringTarget
	{
		// Token: 0x0600B54C RID: 46412 RVA: 0x001A5104 File Offset: 0x001A3304
		private IVehicleEnteringTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVehicleEnteringTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVehicleEnteringTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVehicleEnteringTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600B54D RID: 46413 RVA: 0x001A513C File Offset: 0x001A333C
		public static IVehicleEnteringTarget Create([Nullable(2)] IVehicleEnteringTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleEnteringTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B54E RID: 46414 RVA: 0x001A514F File Offset: 0x001A334F
		public static IVehicleEnteringTarget CreateFromSetValue([Nullable(2)] IVehicleEnteringTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVehicleEnteringTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B54F RID: 46415 RVA: 0x001A5162 File Offset: 0x001A3362
		public IVehicleEnteringTarget_SetValue ToSetValue()
		{
			return new IVehicleEnteringTarget_SetValue
			{
				Type = this.Type,
				TargetVehicle = this.TargetVehicle
			};
		}

		// Token: 0x170037A9 RID: 14249
		// (get) Token: 0x0600B550 RID: 46416 RVA: 0x001A5181 File Offset: 0x001A3381
		// (set) Token: 0x0600B551 RID: 46417 RVA: 0x001A51AC File Offset: 0x001A33AC
		public virtual EVehicleEnteringTarget Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVehicleEnteringTarget.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170037AA RID: 14250
		// (get) Token: 0x0600B552 RID: 46418 RVA: 0x001A51BC File Offset: 0x001A33BC
		// (set) Token: 0x0600B553 RID: 46419 RVA: 0x001A51F6 File Offset: 0x001A33F6
		public virtual int? TargetVehicle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetVehicle;
				}
				IVehicleEnteringTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TargetVehicle;
			}
			set
			{
				this.GetOrCreatePoco().TargetVehicle = value;
			}
		}

		// Token: 0x04006D1C RID: 27932
		[Nullable(2)]
		protected IVehicleEnteringTarget FbInstance;

		// Token: 0x04006D1D RID: 27933
		[Nullable(2)]
		protected IVehicleEnteringTarget_SetValue PocoInterface;
	}
}
