using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067E7 RID: 26599
	public class IFloatingSubtitleLanguageDiffT
	{
		// Token: 0x1700C569 RID: 50537
		// (get) Token: 0x0602E4EB RID: 189675 RVA: 0x00652732 File Offset: 0x00650932
		// (set) Token: 0x0602E4EC RID: 189676 RVA: 0x0065273A File Offset: 0x0065093A
		public EPreprocessOperation Type { get; set; }

		// Token: 0x0602E4ED RID: 189677 RVA: 0x00652743 File Offset: 0x00650943
		public IFloatingSubtitleLanguageDiffT()
		{
			this.Type = EPreprocessOperation.FloatingSubtitleLanguageDiff;
		}
	}
}
