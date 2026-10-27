using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064A8 RID: 25768
	public class ICommonTipPrepareCountdownT
	{
		// Token: 0x1700BFC2 RID: 49090
		// (get) Token: 0x0602CAA4 RID: 182948 RVA: 0x00621962 File Offset: 0x0061FB62
		// (set) Token: 0x0602CAA5 RID: 182949 RVA: 0x0062196A File Offset: 0x0061FB6A
		public ECommonTipType Type { get; set; }

		// Token: 0x0602CAA6 RID: 182950 RVA: 0x00621973 File Offset: 0x0061FB73
		public ICommonTipPrepareCountdownT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
		}
	}
}
