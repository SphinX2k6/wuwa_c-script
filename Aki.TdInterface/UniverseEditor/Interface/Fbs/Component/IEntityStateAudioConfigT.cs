using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051B7 RID: 20919
	public class IEntityStateAudioConfigT
	{
		// Token: 0x170098ED RID: 39149
		// (get) Token: 0x06021E02 RID: 138754 RVA: 0x004B2EA9 File Offset: 0x004B10A9
		// (set) Token: 0x06021E03 RID: 138755 RVA: 0x004B2EB1 File Offset: 0x004B10B1
		public string State { get; set; }

		// Token: 0x170098EE RID: 39150
		// (get) Token: 0x06021E04 RID: 138756 RVA: 0x004B2EBA File Offset: 0x004B10BA
		// (set) Token: 0x06021E05 RID: 138757 RVA: 0x004B2EC2 File Offset: 0x004B10C2
		public string AkEvent { get; set; }

		// Token: 0x170098EF RID: 39151
		// (get) Token: 0x06021E06 RID: 138758 RVA: 0x004B2ECB File Offset: 0x004B10CB
		// (set) Token: 0x06021E07 RID: 138759 RVA: 0x004B2ED3 File Offset: 0x004B10D3
		public string LeaveAkEvent { get; set; }

		// Token: 0x170098F0 RID: 39152
		// (get) Token: 0x06021E08 RID: 138760 RVA: 0x004B2EDC File Offset: 0x004B10DC
		// (set) Token: 0x06021E09 RID: 138761 RVA: 0x004B2EE4 File Offset: 0x004B10E4
		public IAudioFadeT AudioFade { get; set; }

		// Token: 0x170098F1 RID: 39153
		// (get) Token: 0x06021E0A RID: 138762 RVA: 0x004B2EED File Offset: 0x004B10ED
		// (set) Token: 0x06021E0B RID: 138763 RVA: 0x004B2EF5 File Offset: 0x004B10F5
		public bool IsBanVehicleRadio { get; set; }

		// Token: 0x170098F2 RID: 39154
		// (get) Token: 0x06021E0C RID: 138764 RVA: 0x004B2EFE File Offset: 0x004B10FE
		// (set) Token: 0x06021E0D RID: 138765 RVA: 0x004B2F06 File Offset: 0x004B1106
		public byte NullMask { get; set; }

		// Token: 0x06021E0E RID: 138766 RVA: 0x004B2F0F File Offset: 0x004B110F
		public IEntityStateAudioConfigT()
		{
			this.State = null;
			this.AkEvent = null;
			this.LeaveAkEvent = null;
			this.AudioFade = null;
			this.IsBanVehicleRadio = false;
			this.NullMask = 0;
		}
	}
}
