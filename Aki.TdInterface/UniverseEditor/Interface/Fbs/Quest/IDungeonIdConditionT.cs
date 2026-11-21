using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004224 RID: 16932
	public class IDungeonIdConditionT
	{
		// Token: 0x17007359 RID: 29529
		// (get) Token: 0x06017878 RID: 96376 RVA: 0x0035BD76 File Offset: 0x00359F76
		// (set) Token: 0x06017879 RID: 96377 RVA: 0x0035BD7E File Offset: 0x00359F7E
		public EDungeonConditionType Type { get; set; }

		// Token: 0x1700735A RID: 29530
		// (get) Token: 0x0601787A RID: 96378 RVA: 0x0035BD87 File Offset: 0x00359F87
		// (set) Token: 0x0601787B RID: 96379 RVA: 0x0035BD8F File Offset: 0x00359F8F
		public int Count { get; set; }

		// Token: 0x1700735B RID: 29531
		// (get) Token: 0x0601787C RID: 96380 RVA: 0x0035BD98 File Offset: 0x00359F98
		// (set) Token: 0x0601787D RID: 96381 RVA: 0x0035BDA0 File Offset: 0x00359FA0
		public bool IsExitDungeon { get; set; }

		// Token: 0x1700735C RID: 29532
		// (get) Token: 0x0601787E RID: 96382 RVA: 0x0035BDA9 File Offset: 0x00359FA9
		// (set) Token: 0x0601787F RID: 96383 RVA: 0x0035BDB1 File Offset: 0x00359FB1
		public int DungeonId { get; set; }

		// Token: 0x1700735D RID: 29533
		// (get) Token: 0x06017880 RID: 96384 RVA: 0x0035BDBA File Offset: 0x00359FBA
		// (set) Token: 0x06017881 RID: 96385 RVA: 0x0035BDC2 File Offset: 0x00359FC2
		public byte NullMask { get; set; }

		// Token: 0x06017882 RID: 96386 RVA: 0x0035BDCB File Offset: 0x00359FCB
		public IDungeonIdConditionT()
		{
			this.Type = EDungeonConditionType.DungeonSubType;
			this.Count = 0;
			this.IsExitDungeon = false;
			this.DungeonId = 0;
			this.NullMask = 0;
		}
	}
}
