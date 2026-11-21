using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000854 RID: 2132
	public class IVehicleAudioConfig
	{
		// Token: 0x06002DDD RID: 11741 RVA: 0x00077050 File Offset: 0x00075250
		private IVehicleAudioConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVehicleAudioConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVehicleAudioConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVehicleAudioConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002DDE RID: 11742 RVA: 0x00077088 File Offset: 0x00075288
		public static IVehicleAudioConfig Create([Nullable(2)] IVehicleAudioConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleAudioConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002DDF RID: 11743 RVA: 0x0007709B File Offset: 0x0007529B
		public static IVehicleAudioConfig CreateFromSetValue([Nullable(2)] IVehicleAudioConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVehicleAudioConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002DE0 RID: 11744 RVA: 0x000770AE File Offset: 0x000752AE
		public IVehicleAudioConfig_SetValue ToSetValue()
		{
			return new IVehicleAudioConfig_SetValue
			{
				MinVehicleSpeed = this.MinVehicleSpeed,
				MaxVehicleSpeed = this.MaxVehicleSpeed,
				AudioEvent = this.AudioEvent
			};
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06002DE1 RID: 11745 RVA: 0x000770D9 File Offset: 0x000752D9
		// (set) Token: 0x06002DE2 RID: 11746 RVA: 0x00077108 File Offset: 0x00075308
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

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06002DE3 RID: 11747 RVA: 0x00077116 File Offset: 0x00075316
		// (set) Token: 0x06002DE4 RID: 11748 RVA: 0x00077145 File Offset: 0x00075345
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

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06002DE5 RID: 11749 RVA: 0x00077153 File Offset: 0x00075353
		// (set) Token: 0x06002DE6 RID: 11750 RVA: 0x0007717E File Offset: 0x0007537E
		public virtual string AudioEvent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AudioEvent;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.AudioEvent;
			}
			set
			{
				this.GetOrCreatePoco().AudioEvent = value;
			}
		}

		// Token: 0x04001E80 RID: 7808
		[Nullable(2)]
		protected IVehicleAudioConfig FbInstance;

		// Token: 0x04001E81 RID: 7809
		[Nullable(2)]
		protected IVehicleAudioConfig_SetValue PocoInterface;
	}
}
