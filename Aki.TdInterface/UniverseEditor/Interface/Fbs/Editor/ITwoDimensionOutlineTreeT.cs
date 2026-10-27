using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048BA RID: 18618
	public class ITwoDimensionOutlineTreeT
	{
		// Token: 0x17008708 RID: 34568
		// (get) Token: 0x0601D140 RID: 119104 RVA: 0x0041B12F File Offset: 0x0041932F
		// (set) Token: 0x0601D141 RID: 119105 RVA: 0x0041B137 File Offset: 0x00419337
		public ITwoDimensionOutlineFolderNodeT Root { get; set; }

		// Token: 0x17008709 RID: 34569
		// (get) Token: 0x0601D142 RID: 119106 RVA: 0x0041B140 File Offset: 0x00419340
		// (set) Token: 0x0601D143 RID: 119107 RVA: 0x0041B148 File Offset: 0x00419348
		public int NextFolderIndex { get; set; }

		// Token: 0x0601D144 RID: 119108 RVA: 0x0041B151 File Offset: 0x00419351
		public ITwoDimensionOutlineTreeT()
		{
			this.Root = null;
			this.NextFolderIndex = 0;
		}
	}
}
