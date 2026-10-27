using System;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x02004340 RID: 17216
	public class IAcmLimitedT
	{
		// Token: 0x17007990 RID: 31120
		// (get) Token: 0x06019869 RID: 104553 RVA: 0x003A7B10 File Offset: 0x003A5D10
		// (set) Token: 0x0601986A RID: 104554 RVA: 0x003A7B18 File Offset: 0x003A5D18
		public EAngularConstraintMotion Type { get; set; }

		// Token: 0x17007991 RID: 31121
		// (get) Token: 0x0601986B RID: 104555 RVA: 0x003A7B21 File Offset: 0x003A5D21
		// (set) Token: 0x0601986C RID: 104556 RVA: 0x003A7B29 File Offset: 0x003A5D29
		public int LimitValue { get; set; }

		// Token: 0x0601986D RID: 104557 RVA: 0x003A7B32 File Offset: 0x003A5D32
		public IAcmLimitedT()
		{
			this.Type = EAngularConstraintMotion.ACM_Free;
			this.LimitValue = 0;
		}
	}
}
