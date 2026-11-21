using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A9F RID: 27295
	public class IClosePathLineMoveT
	{
		// Token: 0x1700C87B RID: 51323
		// (get) Token: 0x0602ED87 RID: 191879 RVA: 0x0066222A File Offset: 0x0066042A
		// (set) Token: 0x0602ED88 RID: 191880 RVA: 0x00662232 File Offset: 0x00660432
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700C87C RID: 51324
		// (get) Token: 0x0602ED89 RID: 191881 RVA: 0x0066223B File Offset: 0x0066043B
		// (set) Token: 0x0602ED8A RID: 191882 RVA: 0x00662243 File Offset: 0x00660443
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700C87D RID: 51325
		// (get) Token: 0x0602ED8B RID: 191883 RVA: 0x0066224C File Offset: 0x0066044C
		// (set) Token: 0x0602ED8C RID: 191884 RVA: 0x00662254 File Offset: 0x00660454
		public byte NullMask { get; set; }

		// Token: 0x0602ED8D RID: 191885 RVA: 0x0066225D File Offset: 0x0066045D
		public IClosePathLineMoveT()
		{
			this.Type = ESplineMovePattern.PathLine;
			this.GravitySwitchAngularVelocity = 0f;
			this.NullMask = 0;
		}
	}
}
