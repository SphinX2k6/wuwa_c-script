using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046A3 RID: 18083
	public class ISkipToLevelPlayNodeT
	{
		// Token: 0x1700806E RID: 32878
		// (get) Token: 0x0601B787 RID: 112519 RVA: 0x003E6954 File Offset: 0x003E4B54
		// (set) Token: 0x0601B788 RID: 112520 RVA: 0x003E695C File Offset: 0x003E4B5C
		public EGmCommand Type { get; set; }

		// Token: 0x1700806F RID: 32879
		// (get) Token: 0x0601B789 RID: 112521 RVA: 0x003E6965 File Offset: 0x003E4B65
		// (set) Token: 0x0601B78A RID: 112522 RVA: 0x003E696D File Offset: 0x003E4B6D
		public int LevelPlayId { get; set; }

		// Token: 0x17008070 RID: 32880
		// (get) Token: 0x0601B78B RID: 112523 RVA: 0x003E6976 File Offset: 0x003E4B76
		// (set) Token: 0x0601B78C RID: 112524 RVA: 0x003E697E File Offset: 0x003E4B7E
		public int ChildQuestId { get; set; }

		// Token: 0x17008071 RID: 32881
		// (get) Token: 0x0601B78D RID: 112525 RVA: 0x003E6987 File Offset: 0x003E4B87
		// (set) Token: 0x0601B78E RID: 112526 RVA: 0x003E698F File Offset: 0x003E4B8F
		public bool IsTeleport { get; set; }

		// Token: 0x0601B78F RID: 112527 RVA: 0x003E6998 File Offset: 0x003E4B98
		public ISkipToLevelPlayNodeT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.LevelPlayId = 0;
			this.ChildQuestId = 0;
			this.IsTeleport = false;
		}
	}
}
