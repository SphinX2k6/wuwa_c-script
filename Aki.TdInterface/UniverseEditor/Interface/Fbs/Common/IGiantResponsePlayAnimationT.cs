using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063FF RID: 25599
	public class IGiantResponsePlayAnimationT
	{
		// Token: 0x1700BD1B RID: 48411
		// (get) Token: 0x0602B7DE RID: 178142 RVA: 0x005EC93C File Offset: 0x005EAB3C
		// (set) Token: 0x0602B7DF RID: 178143 RVA: 0x005EC944 File Offset: 0x005EAB44
		public EGiantResponseType Type { get; set; }

		// Token: 0x1700BD1C RID: 48412
		// (get) Token: 0x0602B7E0 RID: 178144 RVA: 0x005EC94D File Offset: 0x005EAB4D
		// (set) Token: 0x0602B7E1 RID: 178145 RVA: 0x005EC955 File Offset: 0x005EAB55
		public int GiantAnimationId { get; set; }

		// Token: 0x0602B7E2 RID: 178146 RVA: 0x005EC95E File Offset: 0x005EAB5E
		public IGiantResponsePlayAnimationT()
		{
			this.Type = EGiantResponseType.PlayAnimation;
			this.GiantAnimationId = 0;
		}
	}
}
