using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E0A RID: 24074
	public class IMotorAirCurrentConfigT
	{
		// Token: 0x1700B422 RID: 46114
		// (get) Token: 0x06029366 RID: 168806 RVA: 0x005A7500 File Offset: 0x005A5700
		// (set) Token: 0x06029367 RID: 168807 RVA: 0x005A7508 File Offset: 0x005A5708
		public IVectorInfoT Direction { get; set; }

		// Token: 0x1700B423 RID: 46115
		// (get) Token: 0x06029368 RID: 168808 RVA: 0x005A7511 File Offset: 0x005A5711
		// (set) Token: 0x06029369 RID: 168809 RVA: 0x005A7519 File Offset: 0x005A5719
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700B424 RID: 46116
		// (get) Token: 0x0602936A RID: 168810 RVA: 0x005A7522 File Offset: 0x005A5722
		// (set) Token: 0x0602936B RID: 168811 RVA: 0x005A752A File Offset: 0x005A572A
		public float WindFieldDepth { get; set; }

		// Token: 0x1700B425 RID: 46117
		// (get) Token: 0x0602936C RID: 168812 RVA: 0x005A7533 File Offset: 0x005A5733
		// (set) Token: 0x0602936D RID: 168813 RVA: 0x005A753B File Offset: 0x005A573B
		public float MaxAdditionalSpeed { get; set; }

		// Token: 0x1700B426 RID: 46118
		// (get) Token: 0x0602936E RID: 168814 RVA: 0x005A7544 File Offset: 0x005A5744
		// (set) Token: 0x0602936F RID: 168815 RVA: 0x005A754C File Offset: 0x005A574C
		public string SpeedCurve { get; set; }

		// Token: 0x1700B427 RID: 46119
		// (get) Token: 0x06029370 RID: 168816 RVA: 0x005A7555 File Offset: 0x005A5755
		// (set) Token: 0x06029371 RID: 168817 RVA: 0x005A755D File Offset: 0x005A575D
		public float SpeedTolerance { get; set; }

		// Token: 0x06029372 RID: 168818 RVA: 0x005A7566 File Offset: 0x005A5766
		public IMotorAirCurrentConfigT()
		{
			this.Direction = null;
			this.Offset = null;
			this.WindFieldDepth = 0f;
			this.MaxAdditionalSpeed = 0f;
			this.SpeedCurve = null;
			this.SpeedTolerance = 0f;
		}
	}
}
