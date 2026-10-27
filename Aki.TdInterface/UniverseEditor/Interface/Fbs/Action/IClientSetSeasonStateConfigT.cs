using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063F2 RID: 25586
	public class IClientSetSeasonStateConfigT
	{
		// Token: 0x1700BE90 RID: 48784
		// (get) Token: 0x0602C443 RID: 181315 RVA: 0x0061365A File Offset: 0x0061185A
		// (set) Token: 0x0602C444 RID: 181316 RVA: 0x00613662 File Offset: 0x00611862
		public EClientSetSeasonStateType Type { get; set; }

		// Token: 0x0602C445 RID: 181317 RVA: 0x0061366B File Offset: 0x0061186B
		public IClientSetSeasonStateConfigT()
		{
			this.Type = EClientSetSeasonStateType.SwitchSeason;
		}
	}
}
