using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004664 RID: 18020
	public class IGmGotoRogueRoomInGmT
	{
		// Token: 0x17007FEA RID: 32746
		// (get) Token: 0x0601B57D RID: 111997 RVA: 0x003E3661 File Offset: 0x003E1861
		// (set) Token: 0x0601B57E RID: 111998 RVA: 0x003E3669 File Offset: 0x003E1869
		public EGmCommand Type { get; set; }

		// Token: 0x17007FEB RID: 32747
		// (get) Token: 0x0601B57F RID: 111999 RVA: 0x003E3672 File Offset: 0x003E1872
		// (set) Token: 0x0601B580 RID: 112000 RVA: 0x003E367A File Offset: 0x003E187A
		public int RoomId { get; set; }

		// Token: 0x17007FEC RID: 32748
		// (get) Token: 0x0601B581 RID: 112001 RVA: 0x003E3683 File Offset: 0x003E1883
		// (set) Token: 0x0601B582 RID: 112002 RVA: 0x003E368B File Offset: 0x003E188B
		public string RoomType { get; set; }

		// Token: 0x0601B583 RID: 112003 RVA: 0x003E3694 File Offset: 0x003E1894
		public IGmGotoRogueRoomInGmT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.RoomId = 0;
			this.RoomType = null;
		}
	}
}
