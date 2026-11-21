using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A4A RID: 31306
	public class ISwitchTrailChainEffectStateT
	{
		// Token: 0x1700E562 RID: 58722
		// (get) Token: 0x060372D5 RID: 226005 RVA: 0x0075F09D File Offset: 0x0075D29D
		// (set) Token: 0x060372D6 RID: 226006 RVA: 0x0075F0A5 File Offset: 0x0075D2A5
		public ESwitchEffectStateEffectType Type { get; set; }

		// Token: 0x1700E563 RID: 58723
		// (get) Token: 0x060372D7 RID: 226007 RVA: 0x0075F0AE File Offset: 0x0075D2AE
		// (set) Token: 0x060372D8 RID: 226008 RVA: 0x0075F0B6 File Offset: 0x0075D2B6
		public int Count { get; set; }

		// Token: 0x1700E564 RID: 58724
		// (get) Token: 0x060372D9 RID: 226009 RVA: 0x0075F0BF File Offset: 0x0075D2BF
		// (set) Token: 0x060372DA RID: 226010 RVA: 0x0075F0C7 File Offset: 0x0075D2C7
		public TPos2Union Pos { get; set; }

		// Token: 0x060372DB RID: 226011 RVA: 0x0075F0D0 File Offset: 0x0075D2D0
		public ISwitchTrailChainEffectStateT()
		{
			this.Type = ESwitchEffectStateEffectType.ScreenEffect;
			this.Count = 0;
			this.Pos = null;
		}
	}
}
