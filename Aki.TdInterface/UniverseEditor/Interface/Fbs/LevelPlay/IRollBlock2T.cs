using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200454C RID: 17740
	public class IRollBlock2T
	{
		// Token: 0x17007DD7 RID: 32215
		// (get) Token: 0x0601AB29 RID: 109353 RVA: 0x003CEC64 File Offset: 0x003CCE64
		// (set) Token: 0x0601AB2A RID: 109354 RVA: 0x003CEC6C File Offset: 0x003CCE6C
		public ERollBlockBlockType Type { get; set; }

		// Token: 0x17007DD8 RID: 32216
		// (get) Token: 0x0601AB2B RID: 109355 RVA: 0x003CEC75 File Offset: 0x003CCE75
		// (set) Token: 0x0601AB2C RID: 109356 RVA: 0x003CEC7D File Offset: 0x003CCE7D
		public int BlockId { get; set; }

		// Token: 0x17007DD9 RID: 32217
		// (get) Token: 0x0601AB2D RID: 109357 RVA: 0x003CEC86 File Offset: 0x003CCE86
		// (set) Token: 0x0601AB2E RID: 109358 RVA: 0x003CEC8E File Offset: 0x003CCE8E
		public ERollBlockLayType LayType { get; set; }

		// Token: 0x17007DDA RID: 32218
		// (get) Token: 0x0601AB2F RID: 109359 RVA: 0x003CEC97 File Offset: 0x003CCE97
		// (set) Token: 0x0601AB30 RID: 109360 RVA: 0x003CEC9F File Offset: 0x003CCE9F
		public byte NullMask { get; set; }

		// Token: 0x0601AB31 RID: 109361 RVA: 0x003CECA8 File Offset: 0x003CCEA8
		public IRollBlock2T()
		{
			this.Type = ERollBlockBlockType.Block1;
			this.BlockId = 0;
			this.LayType = ERollBlockLayType.Left;
			this.NullMask = 0;
		}
	}
}
