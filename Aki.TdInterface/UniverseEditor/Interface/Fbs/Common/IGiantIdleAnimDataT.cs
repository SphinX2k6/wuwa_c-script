using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063FC RID: 25596
	public class IGiantIdleAnimDataT
	{
		// Token: 0x1700BD16 RID: 48406
		// (get) Token: 0x0602B7C8 RID: 178120 RVA: 0x005EC73C File Offset: 0x005EA93C
		// (set) Token: 0x0602B7C9 RID: 178121 RVA: 0x005EC744 File Offset: 0x005EA944
		public EGiantAnimationType Type { get; set; }

		// Token: 0x1700BD17 RID: 48407
		// (get) Token: 0x0602B7CA RID: 178122 RVA: 0x005EC74D File Offset: 0x005EA94D
		// (set) Token: 0x0602B7CB RID: 178123 RVA: 0x005EC755 File Offset: 0x005EA955
		public EGiantIdleType IdleType { get; set; }

		// Token: 0x0602B7CC RID: 178124 RVA: 0x005EC75E File Offset: 0x005EA95E
		public IGiantIdleAnimDataT()
		{
			this.Type = EGiantAnimationType.Idle;
			this.IdleType = EGiantIdleType.Common;
		}
	}
}
