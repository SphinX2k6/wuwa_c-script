using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AD7 RID: 31447
	public class ITalkItemStyleInnerVoiceT
	{
		// Token: 0x1700E9BC RID: 59836
		// (get) Token: 0x06038300 RID: 230144 RVA: 0x0078FC72 File Offset: 0x0078DE72
		// (set) Token: 0x06038301 RID: 230145 RVA: 0x0078FC7A File Offset: 0x0078DE7A
		public ETalkItemStyle Type { get; set; }

		// Token: 0x06038302 RID: 230146 RVA: 0x0078FC83 File Offset: 0x0078DE83
		public ITalkItemStyleInnerVoiceT()
		{
			this.Type = ETalkItemStyle.InnerVoice;
		}
	}
}
