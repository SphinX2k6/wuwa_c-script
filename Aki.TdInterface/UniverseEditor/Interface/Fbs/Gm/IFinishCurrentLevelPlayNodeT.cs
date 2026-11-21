using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AB4 RID: 19124
	public class IFinishCurrentLevelPlayNodeT
	{
		// Token: 0x170085F1 RID: 34289
		// (get) Token: 0x0601CC0E RID: 117774 RVA: 0x0040D510 File Offset: 0x0040B710
		// (set) Token: 0x0601CC0F RID: 117775 RVA: 0x0040D518 File Offset: 0x0040B718
		public EGmCommand Type { get; set; }

		// Token: 0x170085F2 RID: 34290
		// (get) Token: 0x0601CC10 RID: 117776 RVA: 0x0040D521 File Offset: 0x0040B721
		// (set) Token: 0x0601CC11 RID: 117777 RVA: 0x0040D529 File Offset: 0x0040B729
		public int LevelPlayId { get; set; }

		// Token: 0x170085F3 RID: 34291
		// (get) Token: 0x0601CC12 RID: 117778 RVA: 0x0040D532 File Offset: 0x0040B732
		// (set) Token: 0x0601CC13 RID: 117779 RVA: 0x0040D53A File Offset: 0x0040B73A
		public int NodeId { get; set; }

		// Token: 0x170085F4 RID: 34292
		// (get) Token: 0x0601CC14 RID: 117780 RVA: 0x0040D543 File Offset: 0x0040B743
		// (set) Token: 0x0601CC15 RID: 117781 RVA: 0x0040D54B File Offset: 0x0040B74B
		public int NodeIndex { get; set; }

		// Token: 0x170085F5 RID: 34293
		// (get) Token: 0x0601CC16 RID: 117782 RVA: 0x0040D554 File Offset: 0x0040B754
		// (set) Token: 0x0601CC17 RID: 117783 RVA: 0x0040D55C File Offset: 0x0040B75C
		public bool IsComplete { get; set; }

		// Token: 0x170085F6 RID: 34294
		// (get) Token: 0x0601CC18 RID: 117784 RVA: 0x0040D565 File Offset: 0x0040B765
		// (set) Token: 0x0601CC19 RID: 117785 RVA: 0x0040D56D File Offset: 0x0040B76D
		public byte NullMask { get; set; }

		// Token: 0x0601CC1A RID: 117786 RVA: 0x0040D576 File Offset: 0x0040B776
		public IFinishCurrentLevelPlayNodeT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.LevelPlayId = 0;
			this.NodeId = 0;
			this.NodeIndex = 0;
			this.IsComplete = false;
			this.NullMask = 0;
		}
	}
}
