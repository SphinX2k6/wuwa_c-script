using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060CE RID: 24782
	public class ITrafficAudioControlT
	{
		// Token: 0x1700B837 RID: 47159
		// (get) Token: 0x06029F04 RID: 171780 RVA: 0x005B92C7 File Offset: 0x005B74C7
		// (set) Token: 0x06029F05 RID: 171781 RVA: 0x005B92CF File Offset: 0x005B74CF
		public EAudioControlType Type { get; set; }

		// Token: 0x1700B838 RID: 47160
		// (get) Token: 0x06029F06 RID: 171782 RVA: 0x005B92D8 File Offset: 0x005B74D8
		// (set) Token: 0x06029F07 RID: 171783 RVA: 0x005B92E0 File Offset: 0x005B74E0
		public string EngineAudio { get; set; }

		// Token: 0x1700B839 RID: 47161
		// (get) Token: 0x06029F08 RID: 171784 RVA: 0x005B92E9 File Offset: 0x005B74E9
		// (set) Token: 0x06029F09 RID: 171785 RVA: 0x005B92F1 File Offset: 0x005B74F1
		public string BrakingAudio { get; set; }

		// Token: 0x1700B83A RID: 47162
		// (get) Token: 0x06029F0A RID: 171786 RVA: 0x005B92FA File Offset: 0x005B74FA
		// (set) Token: 0x06029F0B RID: 171787 RVA: 0x005B9302 File Offset: 0x005B7502
		public string BrakingShortAudio { get; set; }

		// Token: 0x1700B83B RID: 47163
		// (get) Token: 0x06029F0C RID: 171788 RVA: 0x005B930B File Offset: 0x005B750B
		// (set) Token: 0x06029F0D RID: 171789 RVA: 0x005B9313 File Offset: 0x005B7513
		public string HornAudio { get; set; }

		// Token: 0x06029F0E RID: 171790 RVA: 0x005B931C File Offset: 0x005B751C
		public ITrafficAudioControlT()
		{
			this.Type = EAudioControlType.Gramophone;
			this.EngineAudio = null;
			this.BrakingAudio = null;
			this.BrakingShortAudio = null;
			this.HornAudio = null;
		}
	}
}
