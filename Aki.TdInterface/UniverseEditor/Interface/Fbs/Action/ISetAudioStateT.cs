using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FB5 RID: 28597
	public class ISetAudioStateT
	{
		// Token: 0x1700D459 RID: 54361
		// (get) Token: 0x060328B3 RID: 207027 RVA: 0x006D2265 File Offset: 0x006D0465
		// (set) Token: 0x060328B4 RID: 207028 RVA: 0x006D226D File Offset: 0x006D046D
		public IAudioStateT AudioConfig { get; set; }

		// Token: 0x060328B5 RID: 207029 RVA: 0x006D2276 File Offset: 0x006D0476
		public ISetAudioStateT()
		{
			this.AudioConfig = null;
		}
	}
}
