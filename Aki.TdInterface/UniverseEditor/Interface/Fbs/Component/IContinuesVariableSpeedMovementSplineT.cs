using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005022 RID: 20514
	public class IContinuesVariableSpeedMovementSplineT
	{
		// Token: 0x170094CE RID: 38094
		// (get) Token: 0x06020D89 RID: 134537 RVA: 0x004911A8 File Offset: 0x0048F3A8
		// (set) Token: 0x06020D8A RID: 134538 RVA: 0x004911B0 File Offset: 0x0048F3B0
		public ESplineType Type { get; set; }

		// Token: 0x170094CF RID: 38095
		// (get) Token: 0x06020D8B RID: 134539 RVA: 0x004911B9 File Offset: 0x0048F3B9
		// (set) Token: 0x06020D8C RID: 134540 RVA: 0x004911C1 File Offset: 0x0048F3C1
		public int TransitionSpeed { get; set; }

		// Token: 0x170094D0 RID: 38096
		// (get) Token: 0x06020D8D RID: 134541 RVA: 0x004911CA File Offset: 0x0048F3CA
		// (set) Token: 0x06020D8E RID: 134542 RVA: 0x004911D2 File Offset: 0x0048F3D2
		public ITimePathConfigT EntireTimePathConfig { get; set; }

		// Token: 0x170094D1 RID: 38097
		// (get) Token: 0x06020D8F RID: 134543 RVA: 0x004911DB File Offset: 0x0048F3DB
		// (set) Token: 0x06020D90 RID: 134544 RVA: 0x004911E3 File Offset: 0x0048F3E3
		public EMoveCircleMode CircleMode { get; set; }

		// Token: 0x170094D2 RID: 38098
		// (get) Token: 0x06020D91 RID: 134545 RVA: 0x004911EC File Offset: 0x0048F3EC
		// (set) Token: 0x06020D92 RID: 134546 RVA: 0x004911F4 File Offset: 0x0048F3F4
		public List<IContinuesVariableSpeedSplinePointT> Points { get; set; }

		// Token: 0x170094D3 RID: 38099
		// (get) Token: 0x06020D93 RID: 134547 RVA: 0x004911FD File Offset: 0x0048F3FD
		// (set) Token: 0x06020D94 RID: 134548 RVA: 0x00491205 File Offset: 0x0048F405
		public byte NullMask { get; set; }

		// Token: 0x06020D95 RID: 134549 RVA: 0x0049120E File Offset: 0x0048F40E
		public IContinuesVariableSpeedMovementSplineT()
		{
			this.Type = ESplineType.Common;
			this.TransitionSpeed = 0;
			this.EntireTimePathConfig = null;
			this.CircleMode = EMoveCircleMode.CloseLoop;
			this.Points = null;
			this.NullMask = 0;
		}
	}
}
