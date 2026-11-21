using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A32 RID: 31282
	public class ISwitchEffectStateEffectBaseT
	{
		// Token: 0x1700E536 RID: 58678
		// (get) Token: 0x06037204 RID: 225796 RVA: 0x0075D852 File Offset: 0x0075BA52
		// (set) Token: 0x06037205 RID: 225797 RVA: 0x0075D85A File Offset: 0x0075BA5A
		public ESwitchEffectStateEffectType Type { get; set; }

		// Token: 0x06037206 RID: 225798 RVA: 0x0075D863 File Offset: 0x0075BA63
		public ISwitchEffectStateEffectBaseT()
		{
			this.Type = ESwitchEffectStateEffectType.ScreenEffect;
		}
	}
}
