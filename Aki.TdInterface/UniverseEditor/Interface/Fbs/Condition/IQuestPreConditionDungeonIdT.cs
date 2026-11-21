using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051A0 RID: 20896
	public class IQuestPreConditionDungeonIdT
	{
		// Token: 0x170095A3 RID: 38307
		// (get) Token: 0x06020E2B RID: 134699 RVA: 0x0048CC08 File Offset: 0x0048AE08
		// (set) Token: 0x06020E2C RID: 134700 RVA: 0x0048CC10 File Offset: 0x0048AE10
		public EQuestPreConditionDungeonType Type { get; set; }

		// Token: 0x170095A4 RID: 38308
		// (get) Token: 0x06020E2D RID: 134701 RVA: 0x0048CC19 File Offset: 0x0048AE19
		// (set) Token: 0x06020E2E RID: 134702 RVA: 0x0048CC21 File Offset: 0x0048AE21
		public int DungeonId { get; set; }

		// Token: 0x06020E2F RID: 134703 RVA: 0x0048CC2A File Offset: 0x0048AE2A
		public IQuestPreConditionDungeonIdT()
		{
			this.Type = EQuestPreConditionDungeonType.DungeonId;
			this.DungeonId = 0;
		}
	}
}
