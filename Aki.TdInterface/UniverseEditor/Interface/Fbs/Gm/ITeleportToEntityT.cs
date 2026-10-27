using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046BE RID: 18110
	public class ITeleportToEntityT
	{
		// Token: 0x170080AD RID: 32941
		// (get) Token: 0x0601B875 RID: 112757 RVA: 0x003E8150 File Offset: 0x003E6350
		// (set) Token: 0x0601B876 RID: 112758 RVA: 0x003E8158 File Offset: 0x003E6358
		public EGmCommand Type { get; set; }

		// Token: 0x170080AE RID: 32942
		// (get) Token: 0x0601B877 RID: 112759 RVA: 0x003E8161 File Offset: 0x003E6361
		// (set) Token: 0x0601B878 RID: 112760 RVA: 0x003E8169 File Offset: 0x003E6369
		public int EntityId { get; set; }

		// Token: 0x170080AF RID: 32943
		// (get) Token: 0x0601B879 RID: 112761 RVA: 0x003E8172 File Offset: 0x003E6372
		// (set) Token: 0x0601B87A RID: 112762 RVA: 0x003E817A File Offset: 0x003E637A
		public float Rotation { get; set; }

		// Token: 0x170080B0 RID: 32944
		// (get) Token: 0x0601B87B RID: 112763 RVA: 0x003E8183 File Offset: 0x003E6383
		// (set) Token: 0x0601B87C RID: 112764 RVA: 0x003E818B File Offset: 0x003E638B
		public byte NullMask { get; set; }

		// Token: 0x0601B87D RID: 112765 RVA: 0x003E8194 File Offset: 0x003E6394
		public ITeleportToEntityT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.EntityId = 0;
			this.Rotation = 0f;
			this.NullMask = 0;
		}
	}
}
