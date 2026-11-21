using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200777E RID: 30590
	public class ISetAudioStateT
	{
		// Token: 0x1700E02D RID: 57389
		// (get) Token: 0x06035B19 RID: 219929 RVA: 0x00731EA9 File Offset: 0x007300A9
		// (set) Token: 0x06035B1A RID: 219930 RVA: 0x00731EB1 File Offset: 0x007300B1
		public IAudioStateT AudioConfig { get; set; }

		// Token: 0x06035B1B RID: 219931 RVA: 0x00731EBA File Offset: 0x007300BA
		public ISetAudioStateT()
		{
			this.AudioConfig = null;
		}
	}
}
