using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074F3 RID: 29939
	public class IPostAkEventMusicSubtitleT
	{
		// Token: 0x1700DC60 RID: 56416
		// (get) Token: 0x06034808 RID: 215048 RVA: 0x007117CA File Offset: 0x0070F9CA
		// (set) Token: 0x06034809 RID: 215049 RVA: 0x007117D2 File Offset: 0x0070F9D2
		public EPostAkEvent Type { get; set; }

		// Token: 0x1700DC61 RID: 56417
		// (get) Token: 0x0603480A RID: 215050 RVA: 0x007117DB File Offset: 0x0070F9DB
		// (set) Token: 0x0603480B RID: 215051 RVA: 0x007117E3 File Offset: 0x0070F9E3
		public string MusicSubtitleGroupTag { get; set; }

		// Token: 0x1700DC62 RID: 56418
		// (get) Token: 0x0603480C RID: 215052 RVA: 0x007117EC File Offset: 0x0070F9EC
		// (set) Token: 0x0603480D RID: 215053 RVA: 0x007117F4 File Offset: 0x0070F9F4
		public string AkEvent { get; set; }

		// Token: 0x1700DC63 RID: 56419
		// (get) Token: 0x0603480E RID: 215054 RVA: 0x007117FD File Offset: 0x0070F9FD
		// (set) Token: 0x0603480F RID: 215055 RVA: 0x00711805 File Offset: 0x0070FA05
		public bool IsLoop { get; set; }

		// Token: 0x1700DC64 RID: 56420
		// (get) Token: 0x06034810 RID: 215056 RVA: 0x0071180E File Offset: 0x0070FA0E
		// (set) Token: 0x06034811 RID: 215057 RVA: 0x00711816 File Offset: 0x0070FA16
		public bool IsEndAkEvent { get; set; }

		// Token: 0x1700DC65 RID: 56421
		// (get) Token: 0x06034812 RID: 215058 RVA: 0x0071181F File Offset: 0x0070FA1F
		// (set) Token: 0x06034813 RID: 215059 RVA: 0x00711827 File Offset: 0x0070FA27
		public byte NullMask { get; set; }

		// Token: 0x06034814 RID: 215060 RVA: 0x00711830 File Offset: 0x0070FA30
		public IPostAkEventMusicSubtitleT()
		{
			this.Type = EPostAkEvent.Global;
			this.MusicSubtitleGroupTag = null;
			this.AkEvent = null;
			this.IsLoop = false;
			this.IsEndAkEvent = false;
			this.NullMask = 0;
		}
	}
}
