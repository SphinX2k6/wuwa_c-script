using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071F4 RID: 29172
	public class IStopUiScreenEffectT
	{
		// Token: 0x1700D8A1 RID: 55457
		// (get) Token: 0x06033BF0 RID: 211952 RVA: 0x006F73C5 File Offset: 0x006F55C5
		// (set) Token: 0x06033BF1 RID: 211953 RVA: 0x006F73CD File Offset: 0x006F55CD
		public string EffectDaPath { get; set; }

		// Token: 0x06033BF2 RID: 211954 RVA: 0x006F73D6 File Offset: 0x006F55D6
		public IStopUiScreenEffectT()
		{
			this.EffectDaPath = null;
		}
	}
}
