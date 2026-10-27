using System;

namespace CSharpScript.Game.LevelFlow
{
	// Token: 0x02006F69 RID: 28521
	public class LevelFlowTransitionToSplineParam
	{
		// Token: 0x17009B63 RID: 39779
		// (get) Token: 0x0604560E RID: 284174 RVA: 0x0112CD48 File Offset: 0x0112AF48
		// (set) Token: 0x0604560F RID: 284175 RVA: 0x0112CD50 File Offset: 0x0112AF50
		public int EntityId { get; set; }

		// Token: 0x17009B64 RID: 39780
		// (get) Token: 0x06045610 RID: 284176 RVA: 0x0112CD59 File Offset: 0x0112AF59
		// (set) Token: 0x06045611 RID: 284177 RVA: 0x0112CD61 File Offset: 0x0112AF61
		public int SplineId { get; set; }

		// Token: 0x17009B65 RID: 39781
		// (get) Token: 0x06045612 RID: 284178 RVA: 0x0112CD6A File Offset: 0x0112AF6A
		// (set) Token: 0x06045613 RID: 284179 RVA: 0x0112CD72 File Offset: 0x0112AF72
		public bool SnapToWall { get; set; }

		// Token: 0x17009B66 RID: 39782
		// (get) Token: 0x06045614 RID: 284180 RVA: 0x0112CD7B File Offset: 0x0112AF7B
		// (set) Token: 0x06045615 RID: 284181 RVA: 0x0112CD83 File Offset: 0x0112AF83
		public bool NeedSync { get; set; }

		// Token: 0x17009B67 RID: 39783
		// (get) Token: 0x06045616 RID: 284182 RVA: 0x0112CD8C File Offset: 0x0112AF8C
		// (set) Token: 0x06045617 RID: 284183 RVA: 0x0112CD94 File Offset: 0x0112AF94
		public bool SimulateRotation { get; set; }

		// Token: 0x17009B68 RID: 39784
		// (get) Token: 0x06045618 RID: 284184 RVA: 0x0112CD9D File Offset: 0x0112AF9D
		// (set) Token: 0x06045619 RID: 284185 RVA: 0x0112CDA5 File Offset: 0x0112AFA5
		public bool KeepForward { get; set; }

		// Token: 0x17009B69 RID: 39785
		// (get) Token: 0x0604561A RID: 284186 RVA: 0x0112CDAE File Offset: 0x0112AFAE
		// (set) Token: 0x0604561B RID: 284187 RVA: 0x0112CDB6 File Offset: 0x0112AFB6
		public float Speed { get; set; }
	}
}
