using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D49 RID: 3401
	[NullableContext(1)]
	[Nullable(0)]
	public class IAudioVehicleFeature : IVehicleFeature
	{
		// Token: 0x06004D8A RID: 19850 RVA: 0x000C0D34 File Offset: 0x000BEF34
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

		// Token: 0x170018B5 RID: 6325
		// (get) Token: 0x06004D8B RID: 19851 RVA: 0x000C0D53 File Offset: 0x000BEF53
		public override EVehicleFeatureFlag Type
		{
			get
			{
				return (EVehicleFeatureFlag)this.Instance.Type;
			}
		}

		// Token: 0x170018B6 RID: 6326
		// (get) Token: 0x06004D8C RID: 19852 RVA: 0x000C0D60 File Offset: 0x000BEF60
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

		// Token: 0x04002C72 RID: 11378
		private IAudioVehicleFeature Instance;

		// Token: 0x04002C73 RID: 11379
		[Nullable(2)]
		private IVehicleAudioConfig _AudioConfigsCache;

		// Token: 0x04002C74 RID: 11380
		private bool _AudioConfigsInited;
	}
}
