using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D27 RID: 27943
	public class IPlayMapMusicT
	{
		// Token: 0x1700D01F RID: 53279
		// (get) Token: 0x06031498 RID: 201880 RVA: 0x006AF42A File Offset: 0x006AD62A
		// (set) Token: 0x06031499 RID: 201881 RVA: 0x006AF432 File Offset: 0x006AD632
		public EAkEventMap Type { get; set; }

		// Token: 0x0603149A RID: 201882 RVA: 0x006AF43B File Offset: 0x006AD63B
		public IPlayMapMusicT()
		{
			this.Type = EAkEventMap.PlayMapMusic;
		}
	}
}
