using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005489 RID: 21641
	public class IIntervalSplineSpawnAudioConfigBaseT
	{
		// Token: 0x17009F5D RID: 40797
		// (get) Token: 0x060239DB RID: 145883 RVA: 0x004ECB82 File Offset: 0x004EAD82
		// (set) Token: 0x060239DC RID: 145884 RVA: 0x004ECB8A File Offset: 0x004EAD8A
		public EIntervalSplineSpawnAudioConfigType Type { get; set; }

		// Token: 0x060239DD RID: 145885 RVA: 0x004ECB93 File Offset: 0x004EAD93
		public IIntervalSplineSpawnAudioConfigBaseT()
		{
			this.Type = EIntervalSplineSpawnAudioConfigType.AllActorAddAudio;
		}
	}
}
