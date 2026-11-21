using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200540D RID: 21517
	public class IAudioVehicleFeatureT
	{
		// Token: 0x1700985F RID: 39007
		// (get) Token: 0x06021A73 RID: 137843 RVA: 0x004A3843 File Offset: 0x004A1A43
		// (set) Token: 0x06021A74 RID: 137844 RVA: 0x004A384B File Offset: 0x004A1A4B
		public EVehicleFeatureFlag Type { get; set; }

		// Token: 0x17009860 RID: 39008
		// (get) Token: 0x06021A75 RID: 137845 RVA: 0x004A3854 File Offset: 0x004A1A54
		// (set) Token: 0x06021A76 RID: 137846 RVA: 0x004A385C File Offset: 0x004A1A5C
		public IVehicleAudioConfigT AudioConfigs { get; set; }

		// Token: 0x06021A77 RID: 137847 RVA: 0x004A3865 File Offset: 0x004A1A65
		public IAudioVehicleFeatureT()
		{
			this.Type = EVehicleFeatureFlag.None;
			this.AudioConfigs = null;
		}
	}
}
