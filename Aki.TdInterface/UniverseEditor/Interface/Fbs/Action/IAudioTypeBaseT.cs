using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006824 RID: 26660
	public class IAudioTypeBaseT
	{
		// Token: 0x1700C406 RID: 50182
		// (get) Token: 0x0602D8F5 RID: 186613 RVA: 0x0063C282 File Offset: 0x0063A482
		// (set) Token: 0x0602D8F6 RID: 186614 RVA: 0x0063C28A File Offset: 0x0063A48A
		public EAudioType Type { get; set; }

		// Token: 0x0602D8F7 RID: 186615 RVA: 0x0063C293 File Offset: 0x0063A493
		public IAudioTypeBaseT()
		{
			this.Type = EAudioType.RoleSceneVoice;
		}
	}
}
