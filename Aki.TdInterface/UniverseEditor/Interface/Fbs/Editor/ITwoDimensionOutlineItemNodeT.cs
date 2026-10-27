using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048B7 RID: 18615
	public class ITwoDimensionOutlineItemNodeT
	{
		// Token: 0x17008703 RID: 34563
		// (get) Token: 0x0601D12A RID: 119082 RVA: 0x0041AEC0 File Offset: 0x004190C0
		// (set) Token: 0x0601D12B RID: 119083 RVA: 0x0041AEC8 File Offset: 0x004190C8
		public ETwoDimensionOutlineNodeType Type { get; set; }

		// Token: 0x17008704 RID: 34564
		// (get) Token: 0x0601D12C RID: 119084 RVA: 0x0041AED1 File Offset: 0x004190D1
		// (set) Token: 0x0601D12D RID: 119085 RVA: 0x0041AED9 File Offset: 0x004190D9
		public int Id { get; set; }

		// Token: 0x0601D12E RID: 119086 RVA: 0x0041AEE2 File Offset: 0x004190E2
		public ITwoDimensionOutlineItemNodeT()
		{
			this.Type = ETwoDimensionOutlineNodeType.Folder;
			this.Id = 0;
		}
	}
}
