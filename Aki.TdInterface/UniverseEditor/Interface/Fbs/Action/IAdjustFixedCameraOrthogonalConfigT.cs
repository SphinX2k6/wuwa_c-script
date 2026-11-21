using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067B5 RID: 26549
	public class IAdjustFixedCameraOrthogonalConfigT
	{
		// Token: 0x1700C23C RID: 49724
		// (get) Token: 0x0602D33B RID: 185147 RVA: 0x0062F68B File Offset: 0x0062D88B
		// (set) Token: 0x0602D33C RID: 185148 RVA: 0x0062F693 File Offset: 0x0062D893
		public IVectorInfoT BasePoint { get; set; }

		// Token: 0x1700C23D RID: 49725
		// (get) Token: 0x0602D33D RID: 185149 RVA: 0x0062F69C File Offset: 0x0062D89C
		// (set) Token: 0x0602D33E RID: 185150 RVA: 0x0062F6A4 File Offset: 0x0062D8A4
		public float FadeInTime { get; set; }

		// Token: 0x1700C23E RID: 49726
		// (get) Token: 0x0602D33F RID: 185151 RVA: 0x0062F6AD File Offset: 0x0062D8AD
		// (set) Token: 0x0602D340 RID: 185152 RVA: 0x0062F6B5 File Offset: 0x0062D8B5
		public float FadeOutTime { get; set; }

		// Token: 0x1700C23F RID: 49727
		// (get) Token: 0x0602D341 RID: 185153 RVA: 0x0062F6BE File Offset: 0x0062D8BE
		// (set) Token: 0x0602D342 RID: 185154 RVA: 0x0062F6C6 File Offset: 0x0062D8C6
		public byte NullMask { get; set; }

		// Token: 0x0602D343 RID: 185155 RVA: 0x0062F6CF File Offset: 0x0062D8CF
		public IAdjustFixedCameraOrthogonalConfigT()
		{
			this.BasePoint = null;
			this.FadeInTime = 0f;
			this.FadeOutTime = 0f;
			this.NullMask = 0;
		}
	}
}
