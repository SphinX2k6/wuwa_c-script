using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057A9 RID: 22441
	public class IProjectorComponentT
	{
		// Token: 0x1700A780 RID: 42880
		// (get) Token: 0x06025A86 RID: 154246 RVA: 0x00531E33 File Offset: 0x00530033
		// (set) Token: 0x06025A87 RID: 154247 RVA: 0x00531E3B File Offset: 0x0053003B
		public bool Disabled { get; set; }

		// Token: 0x1700A781 RID: 42881
		// (get) Token: 0x06025A88 RID: 154248 RVA: 0x00531E44 File Offset: 0x00530044
		// (set) Token: 0x06025A89 RID: 154249 RVA: 0x00531E4C File Offset: 0x0053004C
		public int ProjectorPatternId { get; set; }

		// Token: 0x1700A782 RID: 42882
		// (get) Token: 0x06025A8A RID: 154250 RVA: 0x00531E55 File Offset: 0x00530055
		// (set) Token: 0x06025A8B RID: 154251 RVA: 0x00531E5D File Offset: 0x0053005D
		public float RotationSpeed { get; set; }

		// Token: 0x1700A783 RID: 42883
		// (get) Token: 0x06025A8C RID: 154252 RVA: 0x00531E66 File Offset: 0x00530066
		// (set) Token: 0x06025A8D RID: 154253 RVA: 0x00531E6E File Offset: 0x0053006E
		public float DragRotationCoefficient { get; set; }

		// Token: 0x1700A784 RID: 42884
		// (get) Token: 0x06025A8E RID: 154254 RVA: 0x00531E77 File Offset: 0x00530077
		// (set) Token: 0x06025A8F RID: 154255 RVA: 0x00531E7F File Offset: 0x0053007F
		public List<IVectorInfoT> RotationTargetAngles { get; set; }

		// Token: 0x1700A785 RID: 42885
		// (get) Token: 0x06025A90 RID: 154256 RVA: 0x00531E88 File Offset: 0x00530088
		// (set) Token: 0x06025A91 RID: 154257 RVA: 0x00531E90 File Offset: 0x00530090
		public float MatchTolerance { get; set; }

		// Token: 0x1700A786 RID: 42886
		// (get) Token: 0x06025A92 RID: 154258 RVA: 0x00531E99 File Offset: 0x00530099
		// (set) Token: 0x06025A93 RID: 154259 RVA: 0x00531EA1 File Offset: 0x005300A1
		public int BackgroundEntityId { get; set; }

		// Token: 0x1700A787 RID: 42887
		// (get) Token: 0x06025A94 RID: 154260 RVA: 0x00531EAA File Offset: 0x005300AA
		// (set) Token: 0x06025A95 RID: 154261 RVA: 0x00531EB2 File Offset: 0x005300B2
		public byte NullMask { get; set; }

		// Token: 0x06025A96 RID: 154262 RVA: 0x00531EBC File Offset: 0x005300BC
		public IProjectorComponentT()
		{
			this.Disabled = false;
			this.ProjectorPatternId = 0;
			this.RotationSpeed = 0f;
			this.DragRotationCoefficient = 0f;
			this.RotationTargetAngles = null;
			this.MatchTolerance = 0f;
			this.BackgroundEntityId = 0;
			this.NullMask = 0;
		}
	}
}
