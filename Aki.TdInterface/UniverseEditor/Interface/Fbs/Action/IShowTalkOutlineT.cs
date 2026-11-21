using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078CD RID: 30925
	public class IShowTalkOutlineT
	{
		// Token: 0x1700E2F2 RID: 58098
		// (get) Token: 0x06036727 RID: 223015 RVA: 0x0074A6AC File Offset: 0x007488AC
		// (set) Token: 0x06036728 RID: 223016 RVA: 0x0074A6B4 File Offset: 0x007488B4
		public int TextId { get; set; }

		// Token: 0x1700E2F3 RID: 58099
		// (get) Token: 0x06036729 RID: 223017 RVA: 0x0074A6BD File Offset: 0x007488BD
		// (set) Token: 0x0603672A RID: 223018 RVA: 0x0074A6C5 File Offset: 0x007488C5
		public string TidOutline { get; set; }

		// Token: 0x1700E2F4 RID: 58100
		// (get) Token: 0x0603672B RID: 223019 RVA: 0x0074A6CE File Offset: 0x007488CE
		// (set) Token: 0x0603672C RID: 223020 RVA: 0x0074A6D6 File Offset: 0x007488D6
		public string PlotLineKey { get; set; }

		// Token: 0x0603672D RID: 223021 RVA: 0x0074A6DF File Offset: 0x007488DF
		public IShowTalkOutlineT()
		{
			this.TextId = 0;
			this.TidOutline = null;
			this.PlotLineKey = null;
		}
	}
}
