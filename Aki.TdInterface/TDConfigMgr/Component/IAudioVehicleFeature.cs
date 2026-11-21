using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000204 RID: 516
	public class IAudioVehicleFeature : IVehicleFeature
	{
		// Token: 0x0600081A RID: 2074 RVA: 0x00026BEC File Offset: 0x00024DEC
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

		// Token: 0x0600081B RID: 2075 RVA: 0x00026C24 File Offset: 0x00024E24
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

		// Token: 0x0600081C RID: 2076 RVA: 0x00026C37 File Offset: 0x00024E37
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

		// Token: 0x0600081D RID: 2077 RVA: 0x00026C4A File Offset: 0x00024E4A
		public new IAudioVehicleFeature_SetValue ToSetValue()
		{
			return new IAudioVehicleFeature_SetValue
			{
				Type = this.Type,
				AudioConfigs = this.AudioConfigs
			};
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x00026C69 File Offset: 0x00024E69
		// (set) Token: 0x0600081F RID: 2079 RVA: 0x00026C94 File Offset: 0x00024E94
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

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x00026CA4 File Offset: 0x00024EA4
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x00026D05 File Offset: 0x00024F05
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

		// Token: 0x04000941 RID: 2369
		[Nullable(2)]
		protected new IAudioVehicleFeature FbInstance;

		// Token: 0x04000942 RID: 2370
		[Nullable(2)]
		protected new IAudioVehicleFeature_SetValue PocoInterface;

		// Token: 0x04000943 RID: 2371
		private IVehicleAudioConfig _AudioConfigsCache;

		// Token: 0x04000944 RID: 2372
		private bool _AudioConfigsInited;
	}
}
