using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005524 RID: 21796
	public class ICombineDaNpcModelT
	{
		// Token: 0x17009BC4 RID: 39876
		// (get) Token: 0x06022743 RID: 141123 RVA: 0x004BF280 File Offset: 0x004BD480
		// (set) Token: 0x06022744 RID: 141124 RVA: 0x004BF288 File Offset: 0x004BD488
		public ENpcModelType Type { get; set; }

		// Token: 0x17009BC5 RID: 39877
		// (get) Token: 0x06022745 RID: 141125 RVA: 0x004BF291 File Offset: 0x004BD491
		// (set) Token: 0x06022746 RID: 141126 RVA: 0x004BF299 File Offset: 0x004BD499
		public string Da { get; set; }

		// Token: 0x17009BC6 RID: 39878
		// (get) Token: 0x06022747 RID: 141127 RVA: 0x004BF2A2 File Offset: 0x004BD4A2
		// (set) Token: 0x06022748 RID: 141128 RVA: 0x004BF2AA File Offset: 0x004BD4AA
		public List<string> InitialHiddenAttachTypes { get; set; }

		// Token: 0x17009BC7 RID: 39879
		// (get) Token: 0x06022749 RID: 141129 RVA: 0x004BF2B3 File Offset: 0x004BD4B3
		// (set) Token: 0x0602274A RID: 141130 RVA: 0x004BF2BB File Offset: 0x004BD4BB
		public byte NullMask { get; set; }

		// Token: 0x0602274B RID: 141131 RVA: 0x004BF2C4 File Offset: 0x004BD4C4
		public ICombineDaNpcModelT()
		{
			this.Type = ENpcModelType.Mesh;
			this.Da = null;
			this.InitialHiddenAttachTypes = null;
			this.NullMask = 0;
		}
	}
}
