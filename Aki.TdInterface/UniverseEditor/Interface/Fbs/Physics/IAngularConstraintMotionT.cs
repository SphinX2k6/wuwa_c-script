using System;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x020047A8 RID: 18344
	public class IAngularConstraintMotionT
	{
		// Token: 0x17007FCC RID: 32716
		// (get) Token: 0x0601B01D RID: 110621 RVA: 0x003D384E File Offset: 0x003D1A4E
		// (set) Token: 0x0601B01E RID: 110622 RVA: 0x003D3856 File Offset: 0x003D1A56
		public EAngularConstraintMotion Type { get; set; }

		// Token: 0x0601B01F RID: 110623 RVA: 0x003D385F File Offset: 0x003D1A5F
		public IAngularConstraintMotionT()
		{
			this.Type = EAngularConstraintMotion.ACM_Free;
		}
	}
}
