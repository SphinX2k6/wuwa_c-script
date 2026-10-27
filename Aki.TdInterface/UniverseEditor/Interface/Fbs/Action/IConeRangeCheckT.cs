using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064C3 RID: 25795
	public class IConeRangeCheckT
	{
		// Token: 0x1700BFF4 RID: 49140
		// (get) Token: 0x0602CBE2 RID: 183266 RVA: 0x006267E7 File Offset: 0x006249E7
		// (set) Token: 0x0602CBE3 RID: 183267 RVA: 0x006267EF File Offset: 0x006249EF
		public ERangeCheckType Type { get; set; }

		// Token: 0x1700BFF5 RID: 49141
		// (get) Token: 0x0602CBE4 RID: 183268 RVA: 0x006267F8 File Offset: 0x006249F8
		// (set) Token: 0x0602CBE5 RID: 183269 RVA: 0x00626800 File Offset: 0x00624A00
		public IVectorInfoT CenterOffset { get; set; }

		// Token: 0x1700BFF6 RID: 49142
		// (get) Token: 0x0602CBE6 RID: 183270 RVA: 0x00626809 File Offset: 0x00624A09
		// (set) Token: 0x0602CBE7 RID: 183271 RVA: 0x00626811 File Offset: 0x00624A11
		public float Radius { get; set; }

		// Token: 0x1700BFF7 RID: 49143
		// (get) Token: 0x0602CBE8 RID: 183272 RVA: 0x0062681A File Offset: 0x00624A1A
		// (set) Token: 0x0602CBE9 RID: 183273 RVA: 0x00626822 File Offset: 0x00624A22
		public float Height { get; set; }

		// Token: 0x0602CBEA RID: 183274 RVA: 0x0062682B File Offset: 0x00624A2B
		public IConeRangeCheckT()
		{
			this.Type = ERangeCheckType.Cone;
			this.CenterOffset = null;
			this.Radius = 0f;
			this.Height = 0f;
		}
	}
}
