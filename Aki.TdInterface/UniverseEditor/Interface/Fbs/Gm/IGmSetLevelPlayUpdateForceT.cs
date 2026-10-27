using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200466D RID: 18029
	public class IGmSetLevelPlayUpdateForceT
	{
		// Token: 0x17008003 RID: 32771
		// (get) Token: 0x0601B5D3 RID: 112083 RVA: 0x003E3F22 File Offset: 0x003E2122
		// (set) Token: 0x0601B5D4 RID: 112084 RVA: 0x003E3F2A File Offset: 0x003E212A
		public EGmCommand Type { get; set; }

		// Token: 0x17008004 RID: 32772
		// (get) Token: 0x0601B5D5 RID: 112085 RVA: 0x003E3F33 File Offset: 0x003E2133
		// (set) Token: 0x0601B5D6 RID: 112086 RVA: 0x003E3F3B File Offset: 0x003E213B
		public int LevelPlayId { get; set; }

		// Token: 0x17008005 RID: 32773
		// (get) Token: 0x0601B5D7 RID: 112087 RVA: 0x003E3F44 File Offset: 0x003E2144
		// (set) Token: 0x0601B5D8 RID: 112088 RVA: 0x003E3F4C File Offset: 0x003E214C
		public bool IsTeleport { get; set; }

		// Token: 0x0601B5D9 RID: 112089 RVA: 0x003E3F55 File Offset: 0x003E2155
		public IGmSetLevelPlayUpdateForceT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.LevelPlayId = 0;
			this.IsTeleport = false;
		}
	}
}
