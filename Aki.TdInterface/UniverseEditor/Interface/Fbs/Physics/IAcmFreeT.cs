using System;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x0200479F RID: 18335
	public class IAcmFreeT
	{
		// Token: 0x17007FC1 RID: 32705
		// (get) Token: 0x0601AFE3 RID: 110563 RVA: 0x003D335E File Offset: 0x003D155E
		// (set) Token: 0x0601AFE4 RID: 110564 RVA: 0x003D3366 File Offset: 0x003D1566
		public EAngularConstraintMotion Type { get; set; }

		// Token: 0x0601AFE5 RID: 110565 RVA: 0x003D336F File Offset: 0x003D156F
		public IAcmFreeT()
		{
			this.Type = EAngularConstraintMotion.ACM_Free;
		}
	}
}
