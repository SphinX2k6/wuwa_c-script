using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004ABE RID: 19134
	public class ICheckLevelPlayChildQuestFinishedT
	{
		// Token: 0x17008AB2 RID: 35506
		// (get) Token: 0x0601E09C RID: 123036 RVA: 0x0043726E File Offset: 0x0043546E
		// (set) Token: 0x0601E09D RID: 123037 RVA: 0x00437276 File Offset: 0x00435476
		public ECondition Type { get; set; }

		// Token: 0x17008AB3 RID: 35507
		// (get) Token: 0x0601E09E RID: 123038 RVA: 0x0043727F File Offset: 0x0043547F
		// (set) Token: 0x0601E09F RID: 123039 RVA: 0x00437287 File Offset: 0x00435487
		public int ChildQuestId { get; set; }

		// Token: 0x17008AB4 RID: 35508
		// (get) Token: 0x0601E0A0 RID: 123040 RVA: 0x00437290 File Offset: 0x00435490
		// (set) Token: 0x0601E0A1 RID: 123041 RVA: 0x00437298 File Offset: 0x00435498
		public ECompare Compare { get; set; }

		// Token: 0x0601E0A2 RID: 123042 RVA: 0x004372A1 File Offset: 0x004354A1
		public ICheckLevelPlayChildQuestFinishedT()
		{
			this.Type = ECondition.CompareVar;
			this.ChildQuestId = 0;
			this.Compare = ECompare.Eq;
		}
	}
}
