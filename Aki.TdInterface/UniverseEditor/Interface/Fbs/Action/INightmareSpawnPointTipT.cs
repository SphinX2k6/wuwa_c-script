using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BAA RID: 27562
	public class INightmareSpawnPointTipT
	{
		// Token: 0x1700CCDA RID: 52442
		// (get) Token: 0x0603069B RID: 198299 RVA: 0x00693398 File Offset: 0x00691598
		// (set) Token: 0x0603069C RID: 198300 RVA: 0x006933A0 File Offset: 0x006915A0
		public ECommonTipType Type { get; set; }

		// Token: 0x1700CCDB RID: 52443
		// (get) Token: 0x0603069D RID: 198301 RVA: 0x006933A9 File Offset: 0x006915A9
		// (set) Token: 0x0603069E RID: 198302 RVA: 0x006933B1 File Offset: 0x006915B1
		public string TidMainText { get; set; }

		// Token: 0x1700CCDC RID: 52444
		// (get) Token: 0x0603069F RID: 198303 RVA: 0x006933BA File Offset: 0x006915BA
		// (set) Token: 0x060306A0 RID: 198304 RVA: 0x006933C2 File Offset: 0x006915C2
		public string TidSubText { get; set; }

		// Token: 0x060306A1 RID: 198305 RVA: 0x006933CB File Offset: 0x006915CB
		public INightmareSpawnPointTipT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
			this.TidSubText = null;
		}
	}
}
