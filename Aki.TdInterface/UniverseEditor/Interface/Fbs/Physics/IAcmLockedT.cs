using System;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x020047A5 RID: 18341
	public class IAcmLockedT
	{
		// Token: 0x17007FC9 RID: 32713
		// (get) Token: 0x0601B00B RID: 110603 RVA: 0x003D36D6 File Offset: 0x003D18D6
		// (set) Token: 0x0601B00C RID: 110604 RVA: 0x003D36DE File Offset: 0x003D18DE
		public EAngularConstraintMotion Type { get; set; }

		// Token: 0x0601B00D RID: 110605 RVA: 0x003D36E7 File Offset: 0x003D18E7
		public IAcmLockedT()
		{
			this.Type = EAngularConstraintMotion.ACM_Free;
		}
	}
}
