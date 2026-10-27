using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007302 RID: 29442
	public class ITalkItemStyleInnerVoiceT
	{
		// Token: 0x1700DDC3 RID: 56771
		// (get) Token: 0x06034FFA RID: 217082 RVA: 0x0072E80E File Offset: 0x0072CA0E
		// (set) Token: 0x06034FFB RID: 217083 RVA: 0x0072E816 File Offset: 0x0072CA16
		public ETalkItemStyle Type { get; set; }

		// Token: 0x06034FFC RID: 217084 RVA: 0x0072E81F File Offset: 0x0072CA1F
		public ITalkItemStyleInnerVoiceT()
		{
			this.Type = ETalkItemStyle.InnerVoice;
		}
	}
}
