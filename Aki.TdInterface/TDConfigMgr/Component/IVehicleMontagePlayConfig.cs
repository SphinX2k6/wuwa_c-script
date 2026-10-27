using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007BD RID: 1981
	[NullableContext(1)]
	[Nullable(0)]
	public class IVehicleMontagePlayConfig
	{
		// Token: 0x06002AF5 RID: 10997 RVA: 0x00070550 File Offset: 0x0006E750
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

		// Token: 0x06002AF6 RID: 10998 RVA: 0x00070588 File Offset: 0x0006E788
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

		// Token: 0x06002AF7 RID: 10999 RVA: 0x0007059B File Offset: 0x0006E79B
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

		// Token: 0x06002AF8 RID: 11000 RVA: 0x000705B0 File Offset: 0x0006E7B0
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

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06002AF9 RID: 11001 RVA: 0x000705FE File Offset: 0x0006E7FE
		// (set) Token: 0x06002AFA RID: 11002 RVA: 0x0007062D File Offset: 0x0006E82D
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

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06002AFB RID: 11003 RVA: 0x0007063B File Offset: 0x0006E83B
		// (set) Token: 0x06002AFC RID: 11004 RVA: 0x0007066A File Offset: 0x0006E86A
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

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x06002AFD RID: 11005 RVA: 0x00070678 File Offset: 0x0006E878
		// (set) Token: 0x06002AFE RID: 11006 RVA: 0x000706A7 File Offset: 0x0006E8A7
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

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06002AFF RID: 11007 RVA: 0x000706B5 File Offset: 0x0006E8B5
		// (set) Token: 0x06002B00 RID: 11008 RVA: 0x000706E4 File Offset: 0x0006E8E4
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

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06002B01 RID: 11009 RVA: 0x000706F2 File Offset: 0x0006E8F2
		// (set) Token: 0x06002B02 RID: 11010 RVA: 0x0007071D File Offset: 0x0006E91D
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

		// Token: 0x04001C96 RID: 7318
		[Nullable(2)]
		protected IVehicleMontagePlayConfig FbInstance;

		// Token: 0x04001C97 RID: 7319
		[Nullable(2)]
		protected IVehicleMontagePlayConfig_SetValue PocoInterface;
	}
}
