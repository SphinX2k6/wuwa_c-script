using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006FA RID: 1786
	[NullableContext(1)]
	[Nullable(0)]
	public class ISpeedEffectConfig
	{
		// Token: 0x06002670 RID: 9840 RVA: 0x00066CDC File Offset: 0x00064EDC
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

		// Token: 0x06002671 RID: 9841 RVA: 0x00066D14 File Offset: 0x00064F14
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

		// Token: 0x06002672 RID: 9842 RVA: 0x00066D27 File Offset: 0x00064F27
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

		// Token: 0x06002673 RID: 9843 RVA: 0x00066D3A File Offset: 0x00064F3A
		public ISpeedEffectConfig_SetValue ToSetValue()
		{
			return new ISpeedEffectConfig_SetValue
			{
				MinVehicleSpeed = this.MinVehicleSpeed,
				MaxVehicleSpeed = this.MaxVehicleSpeed,
				GameplayCueIds = this.GameplayCueIds
			};
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06002674 RID: 9844 RVA: 0x00066D65 File Offset: 0x00064F65
		// (set) Token: 0x06002675 RID: 9845 RVA: 0x00066D94 File Offset: 0x00064F94
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

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06002676 RID: 9846 RVA: 0x00066DA2 File Offset: 0x00064FA2
		// (set) Token: 0x06002677 RID: 9847 RVA: 0x00066DD1 File Offset: 0x00064FD1
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

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06002678 RID: 9848 RVA: 0x00066DDF File Offset: 0x00064FDF
		// (set) Token: 0x06002679 RID: 9849 RVA: 0x00066E06 File Offset: 0x00065006
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

		// Token: 0x04001A14 RID: 6676
		[Nullable(2)]
		protected ISpeedEffectConfig FbInstance;

		// Token: 0x04001A15 RID: 6677
		[Nullable(2)]
		protected ISpeedEffectConfig_SetValue PocoInterface;
	}
}
