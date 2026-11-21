using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E43 RID: 3651
	public class IAudioVehicleFeature : IVehicleFeature
	{
		// Token: 0x060052A6 RID: 21158 RVA: 0x000CC478 File Offset: 0x000CA678
		public static IAudioVehicleFeature Create(IAudioVehicleFeature? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAudioVehicleFeature
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A1B RID: 6683
		// (get) Token: 0x060052A7 RID: 21159 RVA: 0x000CC497 File Offset: 0x000CA697
		public override EVehicleFeatureFlag Type
		{
			get
			{
				return (EVehicleFeatureFlag)this.Instance.Type;
			}
		}

		// Token: 0x17001A1C RID: 6684
		// (get) Token: 0x060052A8 RID: 21160 RVA: 0x000CC4A4 File Offset: 0x000CA6A4
		public virtual IVehicleAudioConfig AudioConfigs
		{
			get
			{
				if (this._AudioConfigsInited)
				{
					return this._AudioConfigsCache;
				}
				this._AudioConfigsInited = true;
				this._AudioConfigsCache = IVehicleAudioConfig.Create(this.Instance.AudioConfigs);
				return this._AudioConfigsCache;
			}
		}

		// Token: 0x04002F32 RID: 12082
		private IAudioVehicleFeature Instance;

		// Token: 0x04002F33 RID: 12083
		[Nullable(2)]
		private IVehicleAudioConfig _AudioConfigsCache;

		// Token: 0x04002F34 RID: 12084
		private bool _AudioConfigsInited;
	}
}
