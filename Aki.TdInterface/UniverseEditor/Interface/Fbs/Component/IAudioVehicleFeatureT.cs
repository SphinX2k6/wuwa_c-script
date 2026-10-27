using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EDE RID: 20190
	public class IAudioVehicleFeatureT
	{
		// Token: 0x170090EC RID: 37100
		// (get) Token: 0x0601FD2F RID: 130351 RVA: 0x0046DA73 File Offset: 0x0046BC73
		// (set) Token: 0x0601FD30 RID: 130352 RVA: 0x0046DA7B File Offset: 0x0046BC7B
		public EVehicleFeatureFlag Type { get; set; }

		// Token: 0x170090ED RID: 37101
		// (get) Token: 0x0601FD31 RID: 130353 RVA: 0x0046DA84 File Offset: 0x0046BC84
		// (set) Token: 0x0601FD32 RID: 130354 RVA: 0x0046DA8C File Offset: 0x0046BC8C
		public IVehicleAudioConfigT AudioConfigs { get; set; }

		// Token: 0x0601FD33 RID: 130355 RVA: 0x0046DA95 File Offset: 0x0046BC95
		public IAudioVehicleFeatureT()
		{
			this.Type = EVehicleFeatureFlag.None;
			this.AudioConfigs = null;
		}
	}
}
