using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B09 RID: 23305
	public class IVehicleAudioConfigT
	{
		// Token: 0x1700AFD5 RID: 45013
		// (get) Token: 0x06027CC0 RID: 163008 RVA: 0x00579311 File Offset: 0x00577511
		// (set) Token: 0x06027CC1 RID: 163009 RVA: 0x00579319 File Offset: 0x00577519
		public float MinVehicleSpeed { get; set; }

		// Token: 0x1700AFD6 RID: 45014
		// (get) Token: 0x06027CC2 RID: 163010 RVA: 0x00579322 File Offset: 0x00577522
		// (set) Token: 0x06027CC3 RID: 163011 RVA: 0x0057932A File Offset: 0x0057752A
		public float MaxVehicleSpeed { get; set; }

		// Token: 0x1700AFD7 RID: 45015
		// (get) Token: 0x06027CC4 RID: 163012 RVA: 0x00579333 File Offset: 0x00577533
		// (set) Token: 0x06027CC5 RID: 163013 RVA: 0x0057933B File Offset: 0x0057753B
		public string AudioEvent { get; set; }

		// Token: 0x06027CC6 RID: 163014 RVA: 0x00579344 File Offset: 0x00577544
		public IVehicleAudioConfigT()
		{
			this.MinVehicleSpeed = 0f;
			this.MaxVehicleSpeed = 0f;
			this.AudioEvent = null;
		}
	}
}
