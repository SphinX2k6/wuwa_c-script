using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D19 RID: 19737
	public class ITwoDimensionOutlineFolderNodeT
	{
		// Token: 0x17008D42 RID: 36162
		// (get) Token: 0x0601E8F9 RID: 125177 RVA: 0x004473BC File Offset: 0x004455BC
		// (set) Token: 0x0601E8FA RID: 125178 RVA: 0x004473C4 File Offset: 0x004455C4
		public ETwoDimensionOutlineNodeType Type { get; set; }

		// Token: 0x17008D43 RID: 36163
		// (get) Token: 0x0601E8FB RID: 125179 RVA: 0x004473CD File Offset: 0x004455CD
		// (set) Token: 0x0601E8FC RID: 125180 RVA: 0x004473D5 File Offset: 0x004455D5
		public string Id { get; set; }

		// Token: 0x17008D44 RID: 36164
		// (get) Token: 0x0601E8FD RID: 125181 RVA: 0x004473DE File Offset: 0x004455DE
		// (set) Token: 0x0601E8FE RID: 125182 RVA: 0x004473E6 File Offset: 0x004455E6
		public string Name { get; set; }

		// Token: 0x17008D45 RID: 36165
		// (get) Token: 0x0601E8FF RID: 125183 RVA: 0x004473EF File Offset: 0x004455EF
		// (set) Token: 0x0601E900 RID: 125184 RVA: 0x004473F7 File Offset: 0x004455F7
		public List<TTwoDimensionOutlineNodeUnion> Children { get; set; }

		// Token: 0x17008D46 RID: 36166
		// (get) Token: 0x0601E901 RID: 125185 RVA: 0x00447400 File Offset: 0x00445600
		// (set) Token: 0x0601E902 RID: 125186 RVA: 0x00447408 File Offset: 0x00445608
		public bool _Folded { get; set; }

		// Token: 0x17008D47 RID: 36167
		// (get) Token: 0x0601E903 RID: 125187 RVA: 0x00447411 File Offset: 0x00445611
		// (set) Token: 0x0601E904 RID: 125188 RVA: 0x00447419 File Offset: 0x00445619
		public byte NullMask { get; set; }

		// Token: 0x0601E905 RID: 125189 RVA: 0x00447422 File Offset: 0x00445622
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
