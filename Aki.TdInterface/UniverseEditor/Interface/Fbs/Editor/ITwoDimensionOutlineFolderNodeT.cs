using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048B4 RID: 18612
	public class ITwoDimensionOutlineFolderNodeT
	{
		// Token: 0x170086FA RID: 34554
		// (get) Token: 0x0601D10C RID: 119052 RVA: 0x0041AC20 File Offset: 0x00418E20
		// (set) Token: 0x0601D10D RID: 119053 RVA: 0x0041AC28 File Offset: 0x00418E28
		public ETwoDimensionOutlineNodeType Type { get; set; }

		// Token: 0x170086FB RID: 34555
		// (get) Token: 0x0601D10E RID: 119054 RVA: 0x0041AC31 File Offset: 0x00418E31
		// (set) Token: 0x0601D10F RID: 119055 RVA: 0x0041AC39 File Offset: 0x00418E39
		public string Id { get; set; }

		// Token: 0x170086FC RID: 34556
		// (get) Token: 0x0601D110 RID: 119056 RVA: 0x0041AC42 File Offset: 0x00418E42
		// (set) Token: 0x0601D111 RID: 119057 RVA: 0x0041AC4A File Offset: 0x00418E4A
		public string Name { get; set; }

		// Token: 0x170086FD RID: 34557
		// (get) Token: 0x0601D112 RID: 119058 RVA: 0x0041AC53 File Offset: 0x00418E53
		// (set) Token: 0x0601D113 RID: 119059 RVA: 0x0041AC5B File Offset: 0x00418E5B
		public List<TTwoDimensionOutlineNodeUnion> Children { get; set; }

		// Token: 0x170086FE RID: 34558
		// (get) Token: 0x0601D114 RID: 119060 RVA: 0x0041AC64 File Offset: 0x00418E64
		// (set) Token: 0x0601D115 RID: 119061 RVA: 0x0041AC6C File Offset: 0x00418E6C
		public bool _Folded { get; set; }

		// Token: 0x170086FF RID: 34559
		// (get) Token: 0x0601D116 RID: 119062 RVA: 0x0041AC75 File Offset: 0x00418E75
		// (set) Token: 0x0601D117 RID: 119063 RVA: 0x0041AC7D File Offset: 0x00418E7D
		public byte NullMask { get; set; }

		// Token: 0x0601D118 RID: 119064 RVA: 0x0041AC86 File Offset: 0x00418E86
		public ITwoDimensionOutlineFolderNodeT()
		{
			this.Type = ETwoDimensionOutlineNodeType.Folder;
			this.Id = null;
			this.Name = null;
			this.Children = null;
			this._Folded = false;
			this.NullMask = 0;
		}
	}
}
