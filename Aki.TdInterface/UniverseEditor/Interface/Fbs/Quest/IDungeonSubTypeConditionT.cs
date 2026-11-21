using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004227 RID: 16935
	public class IDungeonSubTypeConditionT
	{
		// Token: 0x17007364 RID: 29540
		// (get) Token: 0x0601789A RID: 96410 RVA: 0x0035C122 File Offset: 0x0035A322
		// (set) Token: 0x0601789B RID: 96411 RVA: 0x0035C12A File Offset: 0x0035A32A
		public EDungeonConditionType Type { get; set; }

		// Token: 0x17007365 RID: 29541
		// (get) Token: 0x0601789C RID: 96412 RVA: 0x0035C133 File Offset: 0x0035A333
		// (set) Token: 0x0601789D RID: 96413 RVA: 0x0035C13B File Offset: 0x0035A33B
		public int Count { get; set; }

		// Token: 0x17007366 RID: 29542
		// (get) Token: 0x0601789E RID: 96414 RVA: 0x0035C144 File Offset: 0x0035A344
		// (set) Token: 0x0601789F RID: 96415 RVA: 0x0035C14C File Offset: 0x0035A34C
		public bool IsExitDungeon { get; set; }

		// Token: 0x17007367 RID: 29543
		// (get) Token: 0x060178A0 RID: 96416 RVA: 0x0035C155 File Offset: 0x0035A355
		// (set) Token: 0x060178A1 RID: 96417 RVA: 0x0035C15D File Offset: 0x0035A35D
		public EDungeonSubType DungeonSubType { get; set; }

		// Token: 0x17007368 RID: 29544
		// (get) Token: 0x060178A2 RID: 96418 RVA: 0x0035C166 File Offset: 0x0035A366
		// (set) Token: 0x060178A3 RID: 96419 RVA: 0x0035C16E File Offset: 0x0035A36E
		public byte NullMask { get; set; }

		// Token: 0x060178A4 RID: 96420 RVA: 0x0035C177 File Offset: 0x0035A377
		public IDungeonSubTypeConditionT()
		{
			this.Type = EDungeonConditionType.DungeonSubType;
			this.Count = 0;
			this.IsExitDungeon = false;
			this.DungeonSubType = EDungeonSubType.Test;
			this.NullMask = 0;
		}
	}
}
