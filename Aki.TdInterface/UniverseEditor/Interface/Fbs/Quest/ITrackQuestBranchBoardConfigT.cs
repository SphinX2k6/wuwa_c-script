using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004665 RID: 18021
	public class ITrackQuestBranchBoardConfigT
	{
		// Token: 0x17007E43 RID: 32323
		// (get) Token: 0x0601A6FC RID: 108284 RVA: 0x003C38C6 File Offset: 0x003C1AC6
		// (set) Token: 0x0601A6FD RID: 108285 RVA: 0x003C38CE File Offset: 0x003C1ACE
		public int Id { get; set; }

		// Token: 0x17007E44 RID: 32324
		// (get) Token: 0x0601A6FE RID: 108286 RVA: 0x003C38D7 File Offset: 0x003C1AD7
		// (set) Token: 0x0601A6FF RID: 108287 RVA: 0x003C38DF File Offset: 0x003C1ADF
		public bool EnableAnimation { get; set; }

		// Token: 0x17007E45 RID: 32325
		// (get) Token: 0x0601A700 RID: 108288 RVA: 0x003C38E8 File Offset: 0x003C1AE8
		// (set) Token: 0x0601A701 RID: 108289 RVA: 0x003C38F0 File Offset: 0x003C1AF0
		public byte NullMask { get; set; }

		// Token: 0x0601A702 RID: 108290 RVA: 0x003C38F9 File Offset: 0x003C1AF9
		public ITrackQuestBranchBoardConfigT()
		{
			this.Id = 0;
			this.EnableAnimation = false;
			this.NullMask = 0;
		}
	}
}
