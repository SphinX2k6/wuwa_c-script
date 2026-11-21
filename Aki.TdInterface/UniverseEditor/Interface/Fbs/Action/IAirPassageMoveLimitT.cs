using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067EB RID: 26603
	public class IAirPassageMoveLimitT
	{
		// Token: 0x1700C3A0 RID: 50080
		// (get) Token: 0x0602D729 RID: 186153 RVA: 0x00639338 File Offset: 0x00637538
		// (set) Token: 0x0602D72A RID: 186154 RVA: 0x00639340 File Offset: 0x00637540
		public float DirectionAngleLimit { get; set; }

		// Token: 0x1700C3A1 RID: 50081
		// (get) Token: 0x0602D72B RID: 186155 RVA: 0x00639349 File Offset: 0x00637549
		// (set) Token: 0x0602D72C RID: 186156 RVA: 0x00639351 File Offset: 0x00637551
		public float EdgeLimitCurveFactor { get; set; }

		// Token: 0x0602D72D RID: 186157 RVA: 0x0063935A File Offset: 0x0063755A
		public IAirPassageMoveLimitT()
		{
			this.DirectionAngleLimit = 0f;
			this.EdgeLimitCurveFactor = 0f;
		}
	}
}
