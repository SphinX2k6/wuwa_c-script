using System;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B75 RID: 19317
	public class IRunningTreeT
	{
		// Token: 0x1700887D RID: 34941
		// (get) Token: 0x0601D648 RID: 120392 RVA: 0x00420A21 File Offset: 0x0041EC21
		// (set) Token: 0x0601D649 RID: 120393 RVA: 0x00420A29 File Offset: 0x0041EC29
		public int Id { get; set; }

		// Token: 0x1700887E RID: 34942
		// (get) Token: 0x0601D64A RID: 120394 RVA: 0x00420A32 File Offset: 0x0041EC32
		// (set) Token: 0x0601D64B RID: 120395 RVA: 0x00420A3A File Offset: 0x0041EC3A
		public bool IsOccupy { get; set; }

		// Token: 0x1700887F RID: 34943
		// (get) Token: 0x0601D64C RID: 120396 RVA: 0x00420A43 File Offset: 0x0041EC43
		// (set) Token: 0x0601D64D RID: 120397 RVA: 0x00420A4B File Offset: 0x0041EC4B
		public bool IsHide { get; set; }

		// Token: 0x17008880 RID: 34944
		// (get) Token: 0x0601D64E RID: 120398 RVA: 0x00420A54 File Offset: 0x0041EC54
		// (set) Token: 0x0601D64F RID: 120399 RVA: 0x00420A5C File Offset: 0x0041EC5C
		public bool IsSuspend { get; set; }

		// Token: 0x17008881 RID: 34945
		// (get) Token: 0x0601D650 RID: 120400 RVA: 0x00420A65 File Offset: 0x0041EC65
		// (set) Token: 0x0601D651 RID: 120401 RVA: 0x00420A6D File Offset: 0x0041EC6D
		public EQuestStatus QuestStatus { get; set; }

		// Token: 0x17008882 RID: 34946
		// (get) Token: 0x0601D652 RID: 120402 RVA: 0x00420A76 File Offset: 0x0041EC76
		// (set) Token: 0x0601D653 RID: 120403 RVA: 0x00420A7E File Offset: 0x0041EC7E
		public IRunningTreeConfigT Tree { get; set; }

		// Token: 0x17008883 RID: 34947
		// (get) Token: 0x0601D654 RID: 120404 RVA: 0x00420A87 File Offset: 0x0041EC87
		// (set) Token: 0x0601D655 RID: 120405 RVA: 0x00420A8F File Offset: 0x0041EC8F
		public byte NullMask { get; set; }

		// Token: 0x0601D656 RID: 120406 RVA: 0x00420A98 File Offset: 0x0041EC98
		public IRunningTreeT()
		{
			this.Id = 0;
			this.IsOccupy = false;
			this.IsHide = false;
			this.IsSuspend = false;
			this.QuestStatus = EQuestStatus.None;
			this.Tree = null;
			this.NullMask = 0;
		}
	}
}
