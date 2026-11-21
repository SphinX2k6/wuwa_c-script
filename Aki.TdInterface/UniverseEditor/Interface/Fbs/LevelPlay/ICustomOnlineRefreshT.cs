using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048B5 RID: 18613
	public class ICustomOnlineRefreshT
	{
		// Token: 0x17008175 RID: 33141
		// (get) Token: 0x0601B825 RID: 112677 RVA: 0x003E42C1 File Offset: 0x003E24C1
		// (set) Token: 0x0601B826 RID: 112678 RVA: 0x003E42C9 File Offset: 0x003E24C9
		public ELevelPlayRefreshType Type { get; set; }

		// Token: 0x17008176 RID: 33142
		// (get) Token: 0x0601B827 RID: 112679 RVA: 0x003E42D2 File Offset: 0x003E24D2
		// (set) Token: 0x0601B828 RID: 112680 RVA: 0x003E42DA File Offset: 0x003E24DA
		public ISingleOnlineRefreshT SingleOnlineRefresh { get; set; }

		// Token: 0x17008177 RID: 33143
		// (get) Token: 0x0601B829 RID: 112681 RVA: 0x003E42E3 File Offset: 0x003E24E3
		// (set) Token: 0x0601B82A RID: 112682 RVA: 0x003E42EB File Offset: 0x003E24EB
		public IMultiplayerRefreshT MultiplayerRefresh { get; set; }

		// Token: 0x0601B82B RID: 112683 RVA: 0x003E42F4 File Offset: 0x003E24F4
		public ICustomOnlineRefreshT()
		{
			this.Type = ELevelPlayRefreshType.None;
			this.SingleOnlineRefresh = null;
			this.MultiplayerRefresh = null;
		}
	}
}
