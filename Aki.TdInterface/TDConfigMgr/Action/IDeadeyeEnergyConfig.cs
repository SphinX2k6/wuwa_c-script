using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AFF RID: 6911
	public class IDeadeyeEnergyConfig
	{
		// Token: 0x060092CD RID: 37581 RVA: 0x00157BF4 File Offset: 0x00155DF4
		private IDeadeyeEnergyConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDeadeyeEnergyConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDeadeyeEnergyConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDeadeyeEnergyConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060092CE RID: 37582 RVA: 0x00157C2C File Offset: 0x00155E2C
		public static IDeadeyeEnergyConfig Create([Nullable(2)] IDeadeyeEnergyConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeadeyeEnergyConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060092CF RID: 37583 RVA: 0x00157C3F File Offset: 0x00155E3F
		public static IDeadeyeEnergyConfig CreateFromSetValue([Nullable(2)] IDeadeyeEnergyConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDeadeyeEnergyConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060092D0 RID: 37584 RVA: 0x00157C52 File Offset: 0x00155E52
		public IDeadeyeEnergyConfig_SetValue ToSetValue()
		{
			return new IDeadeyeEnergyConfig_SetValue
			{
				MaxEnergy = this.MaxEnergy,
				BulletConsumption = this.BulletConsumption,
				TimeConsumption = this.TimeConsumption
			};
		}

		// Token: 0x17002EF4 RID: 12020
		// (get) Token: 0x060092D1 RID: 37585 RVA: 0x00157C7D File Offset: 0x00155E7D
		// (set) Token: 0x060092D2 RID: 37586 RVA: 0x00157CA8 File Offset: 0x00155EA8
		public virtual int MaxEnergy
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxEnergy;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MaxEnergy;
			}
			set
			{
				this.GetOrCreatePoco().MaxEnergy = value;
			}
		}

		// Token: 0x17002EF5 RID: 12021
		// (get) Token: 0x060092D3 RID: 37587 RVA: 0x00157CB6 File Offset: 0x00155EB6
		// (set) Token: 0x060092D4 RID: 37588 RVA: 0x00157CE1 File Offset: 0x00155EE1
		public virtual int BulletConsumption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BulletConsumption;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.BulletConsumption;
			}
			set
			{
				this.GetOrCreatePoco().BulletConsumption = value;
			}
		}

		// Token: 0x17002EF6 RID: 12022
		// (get) Token: 0x060092D5 RID: 37589 RVA: 0x00157CEF File Offset: 0x00155EEF
		// (set) Token: 0x060092D6 RID: 37590 RVA: 0x00157D1A File Offset: 0x00155F1A
		public virtual int TimeConsumption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TimeConsumption;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TimeConsumption;
			}
			set
			{
				this.GetOrCreatePoco().TimeConsumption = value;
			}
		}

		// Token: 0x04005B61 RID: 23393
		[Nullable(2)]
		protected IDeadeyeEnergyConfig FbInstance;

		// Token: 0x04005B62 RID: 23394
		[Nullable(2)]
		protected IDeadeyeEnergyConfig_SetValue PocoInterface;
	}
}
