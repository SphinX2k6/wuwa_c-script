using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200571C RID: 22300
	public class IEntityStateAudioConfigT
	{
		// Token: 0x1700A0DC RID: 41180
		// (get) Token: 0x06023D5A RID: 146778 RVA: 0x004ECF11 File Offset: 0x004EB111
		// (set) Token: 0x06023D5B RID: 146779 RVA: 0x004ECF19 File Offset: 0x004EB119
		public string State { get; set; }

		// Token: 0x1700A0DD RID: 41181
		// (get) Token: 0x06023D5C RID: 146780 RVA: 0x004ECF22 File Offset: 0x004EB122
		// (set) Token: 0x06023D5D RID: 146781 RVA: 0x004ECF2A File Offset: 0x004EB12A
		public string AkEvent { get; set; }

		// Token: 0x1700A0DE RID: 41182
		// (get) Token: 0x06023D5E RID: 146782 RVA: 0x004ECF33 File Offset: 0x004EB133
		// (set) Token: 0x06023D5F RID: 146783 RVA: 0x004ECF3B File Offset: 0x004EB13B
		public string LeaveAkEvent { get; set; }

		// Token: 0x1700A0DF RID: 41183
		// (get) Token: 0x06023D60 RID: 146784 RVA: 0x004ECF44 File Offset: 0x004EB144
		// (set) Token: 0x06023D61 RID: 146785 RVA: 0x004ECF4C File Offset: 0x004EB14C
		public IAudioFadeT AudioFade { get; set; }

		// Token: 0x1700A0E0 RID: 41184
		// (get) Token: 0x06023D62 RID: 146786 RVA: 0x004ECF55 File Offset: 0x004EB155
		// (set) Token: 0x06023D63 RID: 146787 RVA: 0x004ECF5D File Offset: 0x004EB15D
		public bool IsBanVehicleRadio { get; set; }

		// Token: 0x1700A0E1 RID: 41185
		// (get) Token: 0x06023D64 RID: 146788 RVA: 0x004ECF66 File Offset: 0x004EB166
		// (set) Token: 0x06023D65 RID: 146789 RVA: 0x004ECF6E File Offset: 0x004EB16E
		public byte NullMask { get; set; }

		// Token: 0x06023D66 RID: 146790 RVA: 0x004ECF77 File Offset: 0x004EB177
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
