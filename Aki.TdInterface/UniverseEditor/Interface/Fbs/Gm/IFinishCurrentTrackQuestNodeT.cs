using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AB7 RID: 19127
	public class IFinishCurrentTrackQuestNodeT
	{
		// Token: 0x170085FD RID: 34301
		// (get) Token: 0x0601CC32 RID: 117810 RVA: 0x0040D8DE File Offset: 0x0040BADE
		// (set) Token: 0x0601CC33 RID: 117811 RVA: 0x0040D8E6 File Offset: 0x0040BAE6
		public EGmCommand Type { get; set; }

		// Token: 0x170085FE RID: 34302
		// (get) Token: 0x0601CC34 RID: 117812 RVA: 0x0040D8EF File Offset: 0x0040BAEF
		// (set) Token: 0x0601CC35 RID: 117813 RVA: 0x0040D8F7 File Offset: 0x0040BAF7
		public int NodeId { get; set; }

		// Token: 0x170085FF RID: 34303
		// (get) Token: 0x0601CC36 RID: 117814 RVA: 0x0040D900 File Offset: 0x0040BB00
		// (set) Token: 0x0601CC37 RID: 117815 RVA: 0x0040D908 File Offset: 0x0040BB08
		public int NodeIndex { get; set; }

		// Token: 0x17008600 RID: 34304
		// (get) Token: 0x0601CC38 RID: 117816 RVA: 0x0040D911 File Offset: 0x0040BB11
		// (set) Token: 0x0601CC39 RID: 117817 RVA: 0x0040D919 File Offset: 0x0040BB19
		public bool IsComplete { get; set; }

		// Token: 0x17008601 RID: 34305
		// (get) Token: 0x0601CC3A RID: 117818 RVA: 0x0040D922 File Offset: 0x0040BB22
		// (set) Token: 0x0601CC3B RID: 117819 RVA: 0x0040D92A File Offset: 0x0040BB2A
		public byte NullMask { get; set; }

		// Token: 0x0601CC3C RID: 117820 RVA: 0x0040D933 File Offset: 0x0040BB33
		public IFinishCurrentTrackQuestNodeT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.NodeId = 0;
			this.NodeIndex = 0;
			this.IsComplete = false;
			this.NullMask = 0;
		}
	}
}
