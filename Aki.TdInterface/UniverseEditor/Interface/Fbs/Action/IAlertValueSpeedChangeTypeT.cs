using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200618F RID: 24975
	public class IAlertValueSpeedChangeTypeT
	{
		// Token: 0x1700BA32 RID: 47666
		// (get) Token: 0x0602B052 RID: 176210 RVA: 0x005EF2AA File Offset: 0x005ED4AA
		// (set) Token: 0x0602B053 RID: 176211 RVA: 0x005EF2B2 File Offset: 0x005ED4B2
		public EValueChangeType Type { get; set; }

		// Token: 0x0602B054 RID: 176212 RVA: 0x005EF2BB File Offset: 0x005ED4BB
		public IAlertValueSpeedChangeTypeT()
		{
			this.Type = EValueChangeType.AddOrSub;
		}
	}
}
