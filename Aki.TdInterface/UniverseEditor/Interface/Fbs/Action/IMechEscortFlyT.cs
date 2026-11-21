using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071A2 RID: 29090
	public class IMechEscortFlyT
	{
		// Token: 0x1700D50F RID: 54543
		// (get) Token: 0x06032985 RID: 207237 RVA: 0x006D6487 File Offset: 0x006D4687
		// (set) Token: 0x06032986 RID: 207238 RVA: 0x006D648F File Offset: 0x006D468F
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700D510 RID: 54544
		// (get) Token: 0x06032987 RID: 207239 RVA: 0x006D6498 File Offset: 0x006D4698
		// (set) Token: 0x06032988 RID: 207240 RVA: 0x006D64A0 File Offset: 0x006D46A0
		public int TargetEntity { get; set; }

		// Token: 0x1700D511 RID: 54545
		// (get) Token: 0x06032989 RID: 207241 RVA: 0x006D64A9 File Offset: 0x006D46A9
		// (set) Token: 0x0603298A RID: 207242 RVA: 0x006D64B1 File Offset: 0x006D46B1
		public int TargetSpline { get; set; }

		// Token: 0x1700D512 RID: 54546
		// (get) Token: 0x0603298B RID: 207243 RVA: 0x006D64BA File Offset: 0x006D46BA
		// (set) Token: 0x0603298C RID: 207244 RVA: 0x006D64C2 File Offset: 0x006D46C2
		public List<IMechEscortPointT> EscortPoints { get; set; }

		// Token: 0x0603298D RID: 207245 RVA: 0x006D64CB File Offset: 0x006D46CB
		public IMechEscortFlyT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.TargetEntity = 0;
			this.TargetSpline = 0;
			this.EscortPoints = null;
		}
	}
}
