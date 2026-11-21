using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004ACC RID: 19148
	public class IGmGotoRogueRoomInGmT
	{
		// Token: 0x1700862B RID: 34347
		// (get) Token: 0x0601CD52 RID: 118098 RVA: 0x0040F8FD File Offset: 0x0040DAFD
		// (set) Token: 0x0601CD53 RID: 118099 RVA: 0x0040F905 File Offset: 0x0040DB05
		public EGmCommand Type { get; set; }

		// Token: 0x1700862C RID: 34348
		// (get) Token: 0x0601CD54 RID: 118100 RVA: 0x0040F90E File Offset: 0x0040DB0E
		// (set) Token: 0x0601CD55 RID: 118101 RVA: 0x0040F916 File Offset: 0x0040DB16
		public int RoomId { get; set; }

		// Token: 0x1700862D RID: 34349
		// (get) Token: 0x0601CD56 RID: 118102 RVA: 0x0040F91F File Offset: 0x0040DB1F
		// (set) Token: 0x0601CD57 RID: 118103 RVA: 0x0040F927 File Offset: 0x0040DB27
		public string RoomType { get; set; }

		// Token: 0x0601CD58 RID: 118104 RVA: 0x0040F930 File Offset: 0x0040DB30
		public IGmGotoRogueRoomInGmT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.RoomId = 0;
			this.RoomType = null;
		}
	}
}
