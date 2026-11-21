using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006441 RID: 25665
	public class IGravityDirectionWorldAxisT
	{
		// Token: 0x1700BD7A RID: 48506
		// (get) Token: 0x0602B9B6 RID: 178614 RVA: 0x005EFB0C File Offset: 0x005EDD0C
		// (set) Token: 0x0602B9B7 RID: 178615 RVA: 0x005EFB14 File Offset: 0x005EDD14
		public EGravityDirectionType Type { get; set; }

		// Token: 0x1700BD7B RID: 48507
		// (get) Token: 0x0602B9B8 RID: 178616 RVA: 0x005EFB1D File Offset: 0x005EDD1D
		// (set) Token: 0x0602B9B9 RID: 178617 RVA: 0x005EFB25 File Offset: 0x005EDD25
		public EWorldAxisType WorldAxis { get; set; }

		// Token: 0x0602B9BA RID: 178618 RVA: 0x005EFB2E File Offset: 0x005EDD2E
		public IGravityDirectionWorldAxisT()
		{
			this.Type = EGravityDirectionType.SelfRotation;
			this.WorldAxis = EWorldAxisType.PositiveX;
		}
	}
}
