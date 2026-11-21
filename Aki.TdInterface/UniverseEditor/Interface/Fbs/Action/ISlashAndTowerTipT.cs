using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007906 RID: 30982
	public class ISlashAndTowerTipT
	{
		// Token: 0x1700E347 RID: 58183
		// (get) Token: 0x060368D6 RID: 223446 RVA: 0x0074D517 File Offset: 0x0074B717
		// (set) Token: 0x060368D7 RID: 223447 RVA: 0x0074D51F File Offset: 0x0074B71F
		public ECommonTipType Type { get; set; }

		// Token: 0x1700E348 RID: 58184
		// (get) Token: 0x060368D8 RID: 223448 RVA: 0x0074D528 File Offset: 0x0074B728
		// (set) Token: 0x060368D9 RID: 223449 RVA: 0x0074D530 File Offset: 0x0074B730
		public string WarningText { get; set; }

		// Token: 0x060368DA RID: 223450 RVA: 0x0074D539 File Offset: 0x0074B739
		public ISlashAndTowerTipT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.WarningText = null;
		}
	}
}
