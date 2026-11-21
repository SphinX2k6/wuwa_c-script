using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D1F RID: 19743
	public class ITwoDimensionOutlineTreeT
	{
		// Token: 0x17008D50 RID: 36176
		// (get) Token: 0x0601E92D RID: 125229 RVA: 0x004478CB File Offset: 0x00445ACB
		// (set) Token: 0x0601E92E RID: 125230 RVA: 0x004478D3 File Offset: 0x00445AD3
		public ITwoDimensionOutlineFolderNodeT Root { get; set; }

		// Token: 0x17008D51 RID: 36177
		// (get) Token: 0x0601E92F RID: 125231 RVA: 0x004478DC File Offset: 0x00445ADC
		// (set) Token: 0x0601E930 RID: 125232 RVA: 0x004478E4 File Offset: 0x00445AE4
		public int NextFolderIndex { get; set; }

		// Token: 0x0601E931 RID: 125233 RVA: 0x004478ED File Offset: 0x00445AED
		public ITwoDimensionOutlineTreeT()
		{
			this.Root = null;
			this.NextFolderIndex = 0;
		}
	}
}
