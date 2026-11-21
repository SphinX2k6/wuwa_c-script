using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200079B RID: 1947
	public class ISpeedEffectConfig
	{
		// Token: 0x06002990 RID: 10640 RVA: 0x0006DD4C File Offset: 0x0006BF4C
		private ISpeedEffectConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpeedEffectConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpeedEffectConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpeedEffectConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x0006DD84 File Offset: 0x0006BF84
		public static ISpeedEffectConfig Create([Nullable(2)] ISpeedEffectConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpeedEffectConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x0006DD97 File Offset: 0x0006BF97
		public static ISpeedEffectConfig CreateFromSetValue([Nullable(2)] ISpeedEffectConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpeedEffectConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x0006DDAA File Offset: 0x0006BFAA
		public ISpeedEffectConfig_SetValue ToSetValue()
		{
			return new ISpeedEffectConfig_SetValue
			{
				MinVehicleSpeed = this.MinVehicleSpeed,
				MaxVehicleSpeed = this.MaxVehicleSpeed,
				GameplayCueIds = this.GameplayCueIds
			};
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06002994 RID: 10644 RVA: 0x0006DDD5 File Offset: 0x0006BFD5
		// (set) Token: 0x06002995 RID: 10645 RVA: 0x0006DE04 File Offset: 0x0006C004
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

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06002996 RID: 10646 RVA: 0x0006DE12 File Offset: 0x0006C012
		// (set) Token: 0x06002997 RID: 10647 RVA: 0x0006DE41 File Offset: 0x0006C041
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

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06002998 RID: 10648 RVA: 0x0006DE4F File Offset: 0x0006C04F
		// (set) Token: 0x06002999 RID: 10649 RVA: 0x0006DE76 File Offset: 0x0006C076
		public virtual List<long> GameplayCueIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GameplayCueIds;
				}
				ISpeedEffectConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GameplayCueIds;
			}
			set
			{
				this.GetOrCreatePoco().GameplayCueIds = value;
			}
		}

		// Token: 0x04001C13 RID: 7187
		[Nullable(2)]
		protected ISpeedEffectConfig FbInstance;

		// Token: 0x04001C14 RID: 7188
		[Nullable(2)]
		protected ISpeedEffectConfig_SetValue PocoInterface;
	}
}
