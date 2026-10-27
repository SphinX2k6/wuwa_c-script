using System;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02007017 RID: 28695
	public class TouchUiEditDataImpl : ITouchUiEditData
	{
		// Token: 0x17009BAD RID: 39853
		// (get) Token: 0x06045D61 RID: 286049 RVA: 0x0115DDFD File Offset: 0x0115BFFD
		// (set) Token: 0x06045D62 RID: 286050 RVA: 0x0115DE05 File Offset: 0x0115C005
		public int StorageId { get; set; }

		// Token: 0x17009BAE RID: 39854
		// (get) Token: 0x06045D63 RID: 286051 RVA: 0x0115DE0E File Offset: 0x0115C00E
		// (set) Token: 0x06045D64 RID: 286052 RVA: 0x0115DE16 File Offset: 0x0115C016
		public float OffsetX { get; set; }

		// Token: 0x17009BAF RID: 39855
		// (get) Token: 0x06045D65 RID: 286053 RVA: 0x0115DE1F File Offset: 0x0115C01F
		// (set) Token: 0x06045D66 RID: 286054 RVA: 0x0115DE27 File Offset: 0x0115C027
		public float OffsetY { get; set; }

		// Token: 0x17009BB0 RID: 39856
		// (get) Token: 0x06045D67 RID: 286055 RVA: 0x0115DE30 File Offset: 0x0115C030
		// (set) Token: 0x06045D68 RID: 286056 RVA: 0x0115DE38 File Offset: 0x0115C038
		public float Scale { get; set; }

		// Token: 0x17009BB1 RID: 39857
		// (get) Token: 0x06045D69 RID: 286057 RVA: 0x0115DE41 File Offset: 0x0115C041
		// (set) Token: 0x06045D6A RID: 286058 RVA: 0x0115DE49 File Offset: 0x0115C049
		public float Alpha { get; set; }

		// Token: 0x17009BB2 RID: 39858
		// (get) Token: 0x06045D6B RID: 286059 RVA: 0x0115DE52 File Offset: 0x0115C052
		// (set) Token: 0x06045D6C RID: 286060 RVA: 0x0115DE5A File Offset: 0x0115C05A
		public int HierarchyIndex { get; set; }

		// Token: 0x17009BB3 RID: 39859
		// (get) Token: 0x06045D6D RID: 286061 RVA: 0x0115DE63 File Offset: 0x0115C063
		// (set) Token: 0x06045D6E RID: 286062 RVA: 0x0115DE6B File Offset: 0x0115C06B
		public bool Editable { get; set; }

		// Token: 0x17009BB4 RID: 39860
		// (get) Token: 0x06045D6F RID: 286063 RVA: 0x0115DE74 File Offset: 0x0115C074
		// (set) Token: 0x06045D70 RID: 286064 RVA: 0x0115DE7C File Offset: 0x0115C07C
		public bool DefaultSelect { get; set; }

		// Token: 0x17009BB5 RID: 39861
		// (get) Token: 0x06045D71 RID: 286065 RVA: 0x0115DE85 File Offset: 0x0115C085
		// (set) Token: 0x06045D72 RID: 286066 RVA: 0x0115DE8D File Offset: 0x0115C08D
		public bool ShouldCheckOverlap { get; set; }
	}
}
