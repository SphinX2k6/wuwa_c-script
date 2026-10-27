using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007305 RID: 29445
	public class ITalkItemStylePhoneSendErrorT
	{
		// Token: 0x1700DDC6 RID: 56774
		// (get) Token: 0x0603500C RID: 217100 RVA: 0x0072E986 File Offset: 0x0072CB86
		// (set) Token: 0x0603500D RID: 217101 RVA: 0x0072E98E File Offset: 0x0072CB8E
		public ETalkItemStyle Type { get; set; }

		// Token: 0x0603500E RID: 217102 RVA: 0x0072E997 File Offset: 0x0072CB97
		public ITalkItemStylePhoneSendErrorT()
		{
			this.Type = ETalkItemStyle.InnerVoice;
		}
	}
}
