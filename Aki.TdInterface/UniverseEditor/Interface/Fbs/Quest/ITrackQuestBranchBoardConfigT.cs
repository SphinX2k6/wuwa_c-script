using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004209 RID: 16905
	public class ITrackQuestBranchBoardConfigT
	{
		// Token: 0x17007812 RID: 30738
		// (get) Token: 0x06018F90 RID: 102288 RVA: 0x003981EE File Offset: 0x003963EE
		// (set) Token: 0x06018F91 RID: 102289 RVA: 0x003981F6 File Offset: 0x003963F6
		public int Id { get; set; }

		// Token: 0x17007813 RID: 30739
		// (get) Token: 0x06018F92 RID: 102290 RVA: 0x003981FF File Offset: 0x003963FF
		// (set) Token: 0x06018F93 RID: 102291 RVA: 0x00398207 File Offset: 0x00396407
		public bool EnableAnimation { get; set; }

		// Token: 0x17007814 RID: 30740
		// (get) Token: 0x06018F94 RID: 102292 RVA: 0x00398210 File Offset: 0x00396410
		// (set) Token: 0x06018F95 RID: 102293 RVA: 0x00398218 File Offset: 0x00396418
		public byte NullMask { get; set; }

		// Token: 0x06018F96 RID: 102294 RVA: 0x00398221 File Offset: 0x00396421
		public ITrackQuestBranchBoardConfigT()
		{
			this.Id = 0;
			this.EnableAnimation = false;
			this.NullMask = 0;
		}
	}
}
