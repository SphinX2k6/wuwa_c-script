using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074A2 RID: 29858
	public class IPlayMapMusicT
	{
		// Token: 0x1700DB65 RID: 56165
		// (get) Token: 0x06034490 RID: 214160 RVA: 0x0070AA6E File Offset: 0x00708C6E
		// (set) Token: 0x06034491 RID: 214161 RVA: 0x0070AA76 File Offset: 0x00708C76
		public EAkEventMap Type { get; set; }

		// Token: 0x06034492 RID: 214162 RVA: 0x0070AA7F File Offset: 0x00708C7F
		public IPlayMapMusicT()
		{
			this.Type = EAkEventMap.PlayMapMusic;
		}
	}
}
