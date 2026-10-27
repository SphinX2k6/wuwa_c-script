using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002271 RID: 8817
	[NullableContext(1)]
	[Nullable(0)]
	public class VehicleExitPlayer : ActionParams
	{
		// Token: 0x0600C170 RID: 49520 RVA: 0x001BBE98 File Offset: 0x001BA098
		private VehicleExitPlayer_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("VehicleExitPlayer 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			VehicleExitPlayer_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new VehicleExitPlayer_SetValue());
			}
			return result;
		}

		// Token: 0x0600C171 RID: 49521 RVA: 0x001BBED0 File Offset: 0x001BA0D0
		public static VehicleExitPlayer Create([Nullable(2)] VehicleExitPlayer instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VehicleExitPlayer
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C172 RID: 49522 RVA: 0x001BBEE3 File Offset: 0x001BA0E3
		public static VehicleExitPlayer CreateFromSetValue([Nullable(2)] VehicleExitPlayer_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new VehicleExitPlayer
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C173 RID: 49523 RVA: 0x001BBEF6 File Offset: 0x001BA0F6
		public VehicleExitPlayer_SetValue ToSetValue()
		{
			return new VehicleExitPlayer_SetValue
			{
				DestroyVehicle = this.DestroyVehicle,
				ExitType = this.ExitType
			};
		}

		// Token: 0x17003A7C RID: 14972
		// (get) Token: 0x0600C174 RID: 49524 RVA: 0x001BBF18 File Offset: 0x001BA118
		// (set) Token: 0x0600C175 RID: 49525 RVA: 0x001BBF52 File Offset: 0x001BA152
		public virtual bool? DestroyVehicle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DestroyVehicle;
				}
				VehicleExitPlayer_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DestroyVehicle;
			}
			set
			{
				this.GetOrCreatePoco().DestroyVehicle = value;
			}
		}

		// Token: 0x17003A7D RID: 14973
		// (get) Token: 0x0600C176 RID: 49526 RVA: 0x001BBF60 File Offset: 0x001BA160
		// (set) Token: 0x0600C177 RID: 49527 RVA: 0x001BBF87 File Offset: 0x001BA187
		public virtual IExitVehicleType ExitType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExitType;
				}
				VehicleExitPlayer_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ExitType;
			}
			set
			{
				this.GetOrCreatePoco().ExitType = value;
			}
		}

		// Token: 0x0400733F RID: 29503
		[Nullable(2)]
		protected new VehicleExitPlayer FbInstance;

		// Token: 0x04007340 RID: 29504
		[Nullable(2)]
		protected VehicleExitPlayer_SetValue PocoInterface;
	}
}
