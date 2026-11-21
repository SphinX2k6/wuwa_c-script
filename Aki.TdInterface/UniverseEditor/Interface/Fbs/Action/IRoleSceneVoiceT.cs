using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200767C RID: 30332
	public class IRoleSceneVoiceT
	{
		// Token: 0x1700DEA6 RID: 56998
		// (get) Token: 0x0603536D RID: 217965 RVA: 0x00724520 File Offset: 0x00722720
		// (set) Token: 0x0603536E RID: 217966 RVA: 0x00724528 File Offset: 0x00722728
		public EAudioType Type { get; set; }

		// Token: 0x1700DEA7 RID: 56999
		// (get) Token: 0x0603536F RID: 217967 RVA: 0x00724531 File Offset: 0x00722731
		// (set) Token: 0x06035370 RID: 217968 RVA: 0x00724539 File Offset: 0x00722739
		public int VoiceGroupData { get; set; }

		// Token: 0x06035371 RID: 217969 RVA: 0x00724542 File Offset: 0x00722742
		public IRoleSceneVoiceT()
		{
			this.Type = EAudioType.RoleSceneVoice;
			this.VoiceGroupData = 0;
		}
	}
}
