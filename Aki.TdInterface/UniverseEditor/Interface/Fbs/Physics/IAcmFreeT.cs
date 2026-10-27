using System;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x0200433D RID: 17213
	public class IAcmFreeT
	{
		// Token: 0x1700798C RID: 31116
		// (get) Token: 0x06019855 RID: 104533 RVA: 0x003A7936 File Offset: 0x003A5B36
		// (set) Token: 0x06019856 RID: 104534 RVA: 0x003A793E File Offset: 0x003A5B3E
		public EAngularConstraintMotion Type { get; set; }

		// Token: 0x06019857 RID: 104535 RVA: 0x003A7947 File Offset: 0x003A5B47
		public IAcmFreeT()
		{
			this.Type = EAngularConstraintMotion.ACM_Free;
		}
	}
}
