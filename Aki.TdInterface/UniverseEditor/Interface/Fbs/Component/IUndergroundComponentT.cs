using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AFD RID: 23293
	public class IUndergroundComponentT
	{
		// Token: 0x1700AFBA RID: 44986
		// (get) Token: 0x06027C52 RID: 162898 RVA: 0x005786DE File Offset: 0x005768DE
		// (set) Token: 0x06027C53 RID: 162899 RVA: 0x005786E6 File Offset: 0x005768E6
		public bool Disabled { get; set; }

		// Token: 0x1700AFBB RID: 44987
		// (get) Token: 0x06027C54 RID: 162900 RVA: 0x005786EF File Offset: 0x005768EF
		// (set) Token: 0x06027C55 RID: 162901 RVA: 0x005786F7 File Offset: 0x005768F7
		public int TestState { get; set; }

		// Token: 0x1700AFBC RID: 44988
		// (get) Token: 0x06027C56 RID: 162902 RVA: 0x00578700 File Offset: 0x00576900
		// (set) Token: 0x06027C57 RID: 162903 RVA: 0x00578708 File Offset: 0x00576908
		public bool IsRestartPlayer { get; set; }

		// Token: 0x1700AFBD RID: 44989
		// (get) Token: 0x06027C58 RID: 162904 RVA: 0x00578711 File Offset: 0x00576911
		// (set) Token: 0x06027C59 RID: 162905 RVA: 0x00578719 File Offset: 0x00576919
		public List<string> DestroyTag { get; set; }

		// Token: 0x1700AFBE RID: 44990
		// (get) Token: 0x06027C5A RID: 162906 RVA: 0x00578722 File Offset: 0x00576922
		// (set) Token: 0x06027C5B RID: 162907 RVA: 0x0057872A File Offset: 0x0057692A
		public List<IUndergroundStateInfoT> StateInfo { get; set; }

		// Token: 0x1700AFBF RID: 44991
		// (get) Token: 0x06027C5C RID: 162908 RVA: 0x00578733 File Offset: 0x00576933
		// (set) Token: 0x06027C5D RID: 162909 RVA: 0x0057873B File Offset: 0x0057693B
		public byte NullMask { get; set; }

		// Token: 0x06027C5E RID: 162910 RVA: 0x00578744 File Offset: 0x00576944
		public IUndergroundComponentT()
		{
			this.Disabled = false;
			this.TestState = 0;
			this.IsRestartPlayer = false;
			this.DestroyTag = null;
			this.StateInfo = null;
			this.NullMask = 0;
		}
	}
}
