using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F8D RID: 20365
	public class ICheckLevelPlayChildQuestFinishedT
	{
		// Token: 0x1700919F RID: 37279
		// (get) Token: 0x0601FB85 RID: 129925 RVA: 0x00468A8E File Offset: 0x00466C8E
		// (set) Token: 0x0601FB86 RID: 129926 RVA: 0x00468A96 File Offset: 0x00466C96
		public ECondition Type { get; set; }

		// Token: 0x170091A0 RID: 37280
		// (get) Token: 0x0601FB87 RID: 129927 RVA: 0x00468A9F File Offset: 0x00466C9F
		// (set) Token: 0x0601FB88 RID: 129928 RVA: 0x00468AA7 File Offset: 0x00466CA7
		public int ChildQuestId { get; set; }

		// Token: 0x170091A1 RID: 37281
		// (get) Token: 0x0601FB89 RID: 129929 RVA: 0x00468AB0 File Offset: 0x00466CB0
		// (set) Token: 0x0601FB8A RID: 129930 RVA: 0x00468AB8 File Offset: 0x00466CB8
		public ECompare Compare { get; set; }

		// Token: 0x0601FB8B RID: 129931 RVA: 0x00468AC1 File Offset: 0x00466CC1
		public ICheckLevelPlayChildQuestFinishedT()
		{
			this.Type = ECondition.CompareVar;
			this.ChildQuestId = 0;
			this.Compare = ECompare.Eq;
		}
	}
}
