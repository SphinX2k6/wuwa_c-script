using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000860 RID: 2144
	public class IVehicleMontagePlayConfig
	{
		// Token: 0x06002E25 RID: 11813 RVA: 0x000778B4 File Offset: 0x00075AB4
		private IVehicleMontagePlayConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVehicleMontagePlayConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVehicleMontagePlayConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVehicleMontagePlayConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x000778EC File Offset: 0x00075AEC
		public static IVehicleMontagePlayConfig Create([Nullable(2)] IVehicleMontagePlayConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleMontagePlayConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x000778FF File Offset: 0x00075AFF
		public static IVehicleMontagePlayConfig CreateFromSetValue([Nullable(2)] IVehicleMontagePlayConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVehicleMontagePlayConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x00077914 File Offset: 0x00075B14
		public IVehicleMontagePlayConfig_SetValue ToSetValue()
		{
			return new IVehicleMontagePlayConfig_SetValue
			{
				MinMontageSpeedFactor = this.MinMontageSpeedFactor,
				MaxMontageSpeedFactor = this.MaxMontageSpeedFactor,
				MinVehicleSpeed = this.MinVehicleSpeed,
				MaxVehicleSpeed = this.MaxVehicleSpeed,
				TargetState = this.TargetState
			};
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x06002E29 RID: 11817 RVA: 0x00077962 File Offset: 0x00075B62
		// (set) Token: 0x06002E2A RID: 11818 RVA: 0x00077991 File Offset: 0x00075B91
		public virtual float MinMontageSpeedFactor
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MinMontageSpeedFactor;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MinMontageSpeedFactor;
			}
			set
			{
				this.GetOrCreatePoco().MinMontageSpeedFactor = value;
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x06002E2B RID: 11819 RVA: 0x0007799F File Offset: 0x00075B9F
		// (set) Token: 0x06002E2C RID: 11820 RVA: 0x000779CE File Offset: 0x00075BCE
		public virtual float MaxMontageSpeedFactor
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxMontageSpeedFactor;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MaxMontageSpeedFactor;
			}
			set
			{
				this.GetOrCreatePoco().MaxMontageSpeedFactor = value;
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06002E2D RID: 11821 RVA: 0x000779DC File Offset: 0x00075BDC
		// (set) Token: 0x06002E2E RID: 11822 RVA: 0x00077A0B File Offset: 0x00075C0B
		public virtual float MinVehicleSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MinVehicleSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MinVehicleSpeed;
			}
			set
			{
				this.GetOrCreatePoco().MinVehicleSpeed = value;
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06002E2F RID: 11823 RVA: 0x00077A19 File Offset: 0x00075C19
		// (set) Token: 0x06002E30 RID: 11824 RVA: 0x00077A48 File Offset: 0x00075C48
		public virtual float MaxVehicleSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxVehicleSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MaxVehicleSpeed;
			}
			set
			{
				this.GetOrCreatePoco().MaxVehicleSpeed = value;
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06002E31 RID: 11825 RVA: 0x00077A56 File Offset: 0x00075C56
		// (set) Token: 0x06002E32 RID: 11826 RVA: 0x00077A81 File Offset: 0x00075C81
		public virtual string TargetState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TargetState;
			}
			set
			{
				this.GetOrCreatePoco().TargetState = value;
			}
		}

		// Token: 0x04001EA2 RID: 7842
		[Nullable(2)]
		protected IVehicleMontagePlayConfig FbInstance;

		// Token: 0x04001EA3 RID: 7843
		[Nullable(2)]
		protected IVehicleMontagePlayConfig_SetValue PocoInterface;
	}
}
