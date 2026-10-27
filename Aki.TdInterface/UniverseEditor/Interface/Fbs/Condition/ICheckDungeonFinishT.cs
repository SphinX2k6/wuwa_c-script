using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049DA RID: 18906
	public class ICheckDungeonFinishT
	{
		// Token: 0x170088B9 RID: 35001
		// (get) Token: 0x0601D87A RID: 120954 RVA: 0x00428638 File Offset: 0x00426838
		// (set) Token: 0x0601D87B RID: 120955 RVA: 0x00428640 File Offset: 0x00426840
		public ECondition Type { get; set; }

		// Token: 0x170088BA RID: 35002
		// (get) Token: 0x0601D87C RID: 120956 RVA: 0x00428649 File Offset: 0x00426849
		// (set) Token: 0x0601D87D RID: 120957 RVA: 0x00428651 File Offset: 0x00426851
		public int DungeonId { get; set; }

		// Token: 0x170088BB RID: 35003
		// (get) Token: 0x0601D87E RID: 120958 RVA: 0x0042865A File Offset: 0x0042685A
		// (set) Token: 0x0601D87F RID: 120959 RVA: 0x00428662 File Offset: 0x00426862
		public bool IsFinished { get; set; }

		// Token: 0x170088BC RID: 35004
		// (get) Token: 0x0601D880 RID: 120960 RVA: 0x0042866B File Offset: 0x0042686B
		// (set) Token: 0x0601D881 RID: 120961 RVA: 0x00428673 File Offset: 0x00426873
		public byte NullMask { get; set; }

		// Token: 0x0601D882 RID: 120962 RVA: 0x0042867C File Offset: 0x0042687C
		public ICheckDungeonFinishT()
		{
			this.Type = ECondition.CompareVar;
			this.DungeonId = 0;
			this.IsFinished = false;
			this.NullMask = 0;
		}
	}
}
