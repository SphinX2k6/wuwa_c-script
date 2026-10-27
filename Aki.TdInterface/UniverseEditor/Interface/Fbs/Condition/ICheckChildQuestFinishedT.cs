using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200499B RID: 18843
	public class ICheckChildQuestFinishedT
	{
		// Token: 0x17008828 RID: 34856
		// (get) Token: 0x0601D648 RID: 120392 RVA: 0x004248D2 File Offset: 0x00422AD2
		// (set) Token: 0x0601D649 RID: 120393 RVA: 0x004248DA File Offset: 0x00422ADA
		public ECondition Type { get; set; }

		// Token: 0x17008829 RID: 34857
		// (get) Token: 0x0601D64A RID: 120394 RVA: 0x004248E3 File Offset: 0x00422AE3
		// (set) Token: 0x0601D64B RID: 120395 RVA: 0x004248EB File Offset: 0x00422AEB
		public int QuestId { get; set; }

		// Token: 0x1700882A RID: 34858
		// (get) Token: 0x0601D64C RID: 120396 RVA: 0x004248F4 File Offset: 0x00422AF4
		// (set) Token: 0x0601D64D RID: 120397 RVA: 0x004248FC File Offset: 0x00422AFC
		public int ChildQuestId { get; set; }

		// Token: 0x1700882B RID: 34859
		// (get) Token: 0x0601D64E RID: 120398 RVA: 0x00424905 File Offset: 0x00422B05
		// (set) Token: 0x0601D64F RID: 120399 RVA: 0x0042490D File Offset: 0x00422B0D
		public ECompare Compare { get; set; }

		// Token: 0x1700882C RID: 34860
		// (get) Token: 0x0601D650 RID: 120400 RVA: 0x00424916 File Offset: 0x00422B16
		// (set) Token: 0x0601D651 RID: 120401 RVA: 0x0042491E File Offset: 0x00422B1E
		public byte NullMask { get; set; }

		// Token: 0x0601D652 RID: 120402 RVA: 0x00424927 File Offset: 0x00422B27
		public ICheckChildQuestFinishedT()
		{
			this.Type = ECondition.CompareVar;
			this.QuestId = 0;
			this.ChildQuestId = 0;
			this.Compare = ECompare.Eq;
			this.NullMask = 0;
		}
	}
}
