using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200754B RID: 30027
	public class IVisionSettlementHardTipT
	{
		// Token: 0x1700E3D2 RID: 58322
		// (get) Token: 0x06036A20 RID: 223776 RVA: 0x0076BE24 File Offset: 0x0076A024
		// (set) Token: 0x06036A21 RID: 223777 RVA: 0x0076BE2C File Offset: 0x0076A02C
		public ECommonTipType Type { get; set; }

		// Token: 0x1700E3D3 RID: 58323
		// (get) Token: 0x06036A22 RID: 223778 RVA: 0x0076BE35 File Offset: 0x0076A035
		// (set) Token: 0x06036A23 RID: 223779 RVA: 0x0076BE3D File Offset: 0x0076A03D
		public string TidMainText { get; set; }

		// Token: 0x1700E3D4 RID: 58324
		// (get) Token: 0x06036A24 RID: 223780 RVA: 0x0076BE46 File Offset: 0x0076A046
		// (set) Token: 0x06036A25 RID: 223781 RVA: 0x0076BE4E File Offset: 0x0076A04E
		public string TidSubText { get; set; }

		// Token: 0x06036A26 RID: 223782 RVA: 0x0076BE57 File Offset: 0x0076A057
		public IVisionSettlementHardTipT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
			this.TidSubText = null;
		}
	}
}
