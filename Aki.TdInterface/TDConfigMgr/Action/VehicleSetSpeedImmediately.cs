using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024E4 RID: 9444
	public class VehicleSetSpeedImmediately : ActionParams
	{
		// Token: 0x0600CD58 RID: 52568 RVA: 0x001D39E8 File Offset: 0x001D1BE8
		private VehicleSetSpeedImmediately_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("VehicleSetSpeedImmediately 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			VehicleSetSpeedImmediately_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new VehicleSetSpeedImmediately_SetValue());
			}
			return result;
		}

		// Token: 0x0600CD59 RID: 52569 RVA: 0x001D3A20 File Offset: 0x001D1C20
		public static VehicleSetSpeedImmediately Create([Nullable(2)] VehicleSetSpeedImmediately instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VehicleSetSpeedImmediately
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CD5A RID: 52570 RVA: 0x001D3A33 File Offset: 0x001D1C33
		public static VehicleSetSpeedImmediately CreateFromSetValue([Nullable(2)] VehicleSetSpeedImmediately_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new VehicleSetSpeedImmediately
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CD5B RID: 52571 RVA: 0x001D3A46 File Offset: 0x001D1C46
		public VehicleSetSpeedImmediately_SetValue ToSetValue()
		{
			return new VehicleSetSpeedImmediately_SetValue
			{
				SetSpeedConfig = this.SetSpeedConfig
			};
		}

		// Token: 0x17003D7B RID: 15739
		// (get) Token: 0x0600CD5C RID: 52572 RVA: 0x001D3A59 File Offset: 0x001D1C59
		// (set) Token: 0x0600CD5D RID: 52573 RVA: 0x001D3A80 File Offset: 0x001D1C80
		public virtual ISetVehicleSpeedImmediatelyType SetSpeedConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SetSpeedConfig;
				}
				VehicleSetSpeedImmediately_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SetSpeedConfig;
			}
			set
			{
				this.GetOrCreatePoco().SetSpeedConfig = value;
			}
		}

		// Token: 0x0400799C RID: 31132
		[Nullable(2)]
		protected new VehicleSetSpeedImmediately FbInstance;

		// Token: 0x0400799D RID: 31133
		[Nullable(2)]
		protected VehicleSetSpeedImmediately_SetValue PocoInterface;
	}
}
