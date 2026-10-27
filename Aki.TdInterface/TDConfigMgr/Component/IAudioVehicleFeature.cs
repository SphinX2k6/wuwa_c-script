using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001DD RID: 477
	[NullableContext(1)]
	[Nullable(0)]
	public class IAudioVehicleFeature : IVehicleFeature
	{
		// Token: 0x060007AC RID: 1964 RVA: 0x0002550C File Offset: 0x0002370C
		private IAudioVehicleFeature_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAudioVehicleFeature 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAudioVehicleFeature_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAudioVehicleFeature_SetValue());
			}
			return result;
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00025544 File Offset: 0x00023744
		public static IAudioVehicleFeature Create([Nullable(2)] IAudioVehicleFeature instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAudioVehicleFeature
			{
				FbInstance = instance
			};
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00025557 File Offset: 0x00023757
		public static IAudioVehicleFeature CreateFromSetValue([Nullable(2)] IAudioVehicleFeature_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAudioVehicleFeature
			{
				PocoInterface = value
			};
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0002556A File Offset: 0x0002376A
		public new IAudioVehicleFeature_SetValue ToSetValue()
		{
			return new IAudioVehicleFeature_SetValue
			{
				Type = this.Type,
				AudioConfigs = this.AudioConfigs
			};
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x00025589 File Offset: 0x00023789
		// (set) Token: 0x060007B1 RID: 1969 RVA: 0x000255B4 File Offset: 0x000237B4
		public override EVehicleFeatureFlag Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return (EVehicleFeatureFlag)0;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x000255C4 File Offset: 0x000237C4
		// (set) Token: 0x060007B3 RID: 1971 RVA: 0x00025625 File Offset: 0x00023825
		public virtual IVehicleAudioConfig AudioConfigs
		{
			get
			{
				if (this._AudioConfigsInited)
				{
					return this._AudioConfigsCache;
				}
				this._AudioConfigsInited = true;
				if (this.FbInstance != null)
				{
					this._AudioConfigsCache = IVehicleAudioConfig.Create(this.FbInstance.AudioConfigs);
				}
				else
				{
					IAudioVehicleFeature_SetValue pocoInterface = this.PocoInterface;
					this._AudioConfigsCache = ((pocoInterface != null) ? pocoInterface.AudioConfigs : null);
				}
				return this._AudioConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().AudioConfigs = value;
				this._AudioConfigsInited = false;
			}
		}

		// Token: 0x040008BA RID: 2234
		[Nullable(2)]
		protected new IAudioVehicleFeature FbInstance;

		// Token: 0x040008BB RID: 2235
		[Nullable(2)]
		protected new IAudioVehicleFeature_SetValue PocoInterface;

		// Token: 0x040008BC RID: 2236
		private IVehicleAudioConfig _AudioConfigsCache;

		// Token: 0x040008BD RID: 2237
		private bool _AudioConfigsInited;
	}
}
