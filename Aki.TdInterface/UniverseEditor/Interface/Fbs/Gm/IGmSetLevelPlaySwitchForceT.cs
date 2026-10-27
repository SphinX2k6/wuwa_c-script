using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200466A RID: 18026
	public class IGmSetLevelPlaySwitchForceT
	{
		// Token: 0x17007FFC RID: 32764
		// (get) Token: 0x0601B5B9 RID: 112057 RVA: 0x003E3C8E File Offset: 0x003E1E8E
		// (set) Token: 0x0601B5BA RID: 112058 RVA: 0x003E3C96 File Offset: 0x003E1E96
		public EGmCommand Type { get; set; }

		// Token: 0x17007FFD RID: 32765
		// (get) Token: 0x0601B5BB RID: 112059 RVA: 0x003E3C9F File Offset: 0x003E1E9F
		// (set) Token: 0x0601B5BC RID: 112060 RVA: 0x003E3CA7 File Offset: 0x003E1EA7
		public int LevelPlayId { get; set; }

		// Token: 0x17007FFE RID: 32766
		// (get) Token: 0x0601B5BD RID: 112061 RVA: 0x003E3CB0 File Offset: 0x003E1EB0
		// (set) Token: 0x0601B5BE RID: 112062 RVA: 0x003E3CB8 File Offset: 0x003E1EB8
		public bool IsOpen { get; set; }

		// Token: 0x0601B5BF RID: 112063 RVA: 0x003E3CC1 File Offset: 0x003E1EC1
		public IGmSetLevelPlaySwitchForceT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.LevelPlayId = 0;
			this.IsOpen = false;
		}
	}
}
