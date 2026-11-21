using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007ADA RID: 31450
	public class ITalkItemStylePhoneSendErrorT
	{
		// Token: 0x1700E9BF RID: 59839
		// (get) Token: 0x06038312 RID: 230162 RVA: 0x0078FDEA File Offset: 0x0078DFEA
		// (set) Token: 0x06038313 RID: 230163 RVA: 0x0078FDF2 File Offset: 0x0078DFF2
		public ETalkItemStyle Type { get; set; }

		// Token: 0x06038314 RID: 230164 RVA: 0x0078FDFB File Offset: 0x0078DFFB
		public ITalkItemStylePhoneSendErrorT()
		{
			this.Type = ETalkItemStyle.InnerVoice;
		}
	}
}
