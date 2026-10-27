using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D4E RID: 27982
	public class IPlotAudioConfigT
	{
		// Token: 0x1700D0B8 RID: 53432
		// (get) Token: 0x06031697 RID: 202391 RVA: 0x006B35D9 File Offset: 0x006B17D9
		// (set) Token: 0x06031698 RID: 202392 RVA: 0x006B35E1 File Offset: 0x006B17E1
		public IPlotVoiceFadeOutOnInterruptT VoiceFadeOutOnInterrupt { get; set; }

		// Token: 0x06031699 RID: 202393 RVA: 0x006B35EA File Offset: 0x006B17EA
		public IPlotAudioConfigT()
		{
			this.VoiceFadeOutOnInterrupt = null;
		}
	}
}
