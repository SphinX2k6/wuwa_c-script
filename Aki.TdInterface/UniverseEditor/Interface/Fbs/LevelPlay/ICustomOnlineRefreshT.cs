using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200444D RID: 17485
	public class ICustomOnlineRefreshT
	{
		// Token: 0x17007B36 RID: 31542
		// (get) Token: 0x0601A054 RID: 106580 RVA: 0x003B80B5 File Offset: 0x003B62B5
		// (set) Token: 0x0601A055 RID: 106581 RVA: 0x003B80BD File Offset: 0x003B62BD
		public ELevelPlayRefreshType Type { get; set; }

		// Token: 0x17007B37 RID: 31543
		// (get) Token: 0x0601A056 RID: 106582 RVA: 0x003B80C6 File Offset: 0x003B62C6
		// (set) Token: 0x0601A057 RID: 106583 RVA: 0x003B80CE File Offset: 0x003B62CE
		public ISingleOnlineRefreshT SingleOnlineRefresh { get; set; }

		// Token: 0x17007B38 RID: 31544
		// (get) Token: 0x0601A058 RID: 106584 RVA: 0x003B80D7 File Offset: 0x003B62D7
		// (set) Token: 0x0601A059 RID: 106585 RVA: 0x003B80DF File Offset: 0x003B62DF
		public IMultiplayerRefreshT MultiplayerRefresh { get; set; }

		// Token: 0x0601A05A RID: 106586 RVA: 0x003B80E8 File Offset: 0x003B62E8
		public ICustomOnlineRefreshT()
		{
			this.Type = ELevelPlayRefreshType.None;
			this.SingleOnlineRefresh = null;
			this.MultiplayerRefresh = null;
		}
	}
}
