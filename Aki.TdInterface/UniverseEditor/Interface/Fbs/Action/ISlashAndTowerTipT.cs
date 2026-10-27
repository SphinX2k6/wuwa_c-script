using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200713A RID: 28986
	public class ISlashAndTowerTipT
	{
		// Token: 0x1700D764 RID: 55140
		// (get) Token: 0x06033634 RID: 210484 RVA: 0x006ECF0B File Offset: 0x006EB10B
		// (set) Token: 0x06033635 RID: 210485 RVA: 0x006ECF13 File Offset: 0x006EB113
		public ECommonTipType Type { get; set; }

		// Token: 0x1700D765 RID: 55141
		// (get) Token: 0x06033636 RID: 210486 RVA: 0x006ECF1C File Offset: 0x006EB11C
		// (set) Token: 0x06033637 RID: 210487 RVA: 0x006ECF24 File Offset: 0x006EB124
		public string WarningText { get; set; }

		// Token: 0x06033638 RID: 210488 RVA: 0x006ECF2D File Offset: 0x006EB12D
		public ISlashAndTowerTipT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.WarningText = null;
		}
	}
}
