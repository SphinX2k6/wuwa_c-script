using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074C9 RID: 29897
	public class IPlotAudioConfigT
	{
		// Token: 0x1700DC00 RID: 56320
		// (get) Token: 0x06034693 RID: 214675 RVA: 0x0070ECC1 File Offset: 0x0070CEC1
		// (set) Token: 0x06034694 RID: 214676 RVA: 0x0070ECC9 File Offset: 0x0070CEC9
		public IPlotVoiceFadeOutOnInterruptT VoiceFadeOutOnInterrupt { get; set; }

		// Token: 0x06034695 RID: 214677 RVA: 0x0070ECD2 File Offset: 0x0070CED2
		public IPlotAudioConfigT()
		{
			this.VoiceFadeOutOnInterrupt = null;
		}
	}
}
