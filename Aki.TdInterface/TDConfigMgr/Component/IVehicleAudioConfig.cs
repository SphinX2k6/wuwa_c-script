using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007B1 RID: 1969
	[NullableContext(1)]
	[Nullable(0)]
	public class IVehicleAudioConfig
	{
		// Token: 0x06002AAD RID: 10925 RVA: 0x0006FCEC File Offset: 0x0006DEEC
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

		// Token: 0x06002AAE RID: 10926 RVA: 0x0006FD24 File Offset: 0x0006DF24
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

		// Token: 0x06002AAF RID: 10927 RVA: 0x0006FD37 File Offset: 0x0006DF37
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

		// Token: 0x06002AB0 RID: 10928 RVA: 0x0006FD4A File Offset: 0x0006DF4A
		public IVehicleAudioConfig_SetValue ToSetValue()
		{
			return new IVehicleAudioConfig_SetValue
			{
				MinVehicleSpeed = this.MinVehicleSpeed,
				MaxVehicleSpeed = this.MaxVehicleSpeed,
				AudioEvent = this.AudioEvent
			};
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06002AB1 RID: 10929 RVA: 0x0006FD75 File Offset: 0x0006DF75
		// (set) Token: 0x06002AB2 RID: 10930 RVA: 0x0006FDA4 File Offset: 0x0006DFA4
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

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06002AB3 RID: 10931 RVA: 0x0006FDB2 File Offset: 0x0006DFB2
		// (set) Token: 0x06002AB4 RID: 10932 RVA: 0x0006FDE1 File Offset: 0x0006DFE1
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

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06002AB5 RID: 10933 RVA: 0x0006FDEF File Offset: 0x0006DFEF
		// (set) Token: 0x06002AB6 RID: 10934 RVA: 0x0006FE1A File Offset: 0x0006E01A
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

		// Token: 0x04001C74 RID: 7284
		[Nullable(2)]
		protected IVehicleAudioConfig FbInstance;

		// Token: 0x04001C75 RID: 7285
		[Nullable(2)]
		protected IVehicleAudioConfig_SetValue PocoInterface;
	}
}
