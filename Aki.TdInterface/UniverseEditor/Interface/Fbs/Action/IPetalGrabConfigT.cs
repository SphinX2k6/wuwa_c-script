using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007404 RID: 29700
	public class IPetalGrabConfigT
	{
		// Token: 0x1700DA2A RID: 55850
		// (get) Token: 0x06033F66 RID: 212838 RVA: 0x0070140C File Offset: 0x006FF60C
		// (set) Token: 0x06033F67 RID: 212839 RVA: 0x00701414 File Offset: 0x006FF614
		public ESportStateType Type { get; set; }

		// Token: 0x1700DA2B RID: 55851
		// (get) Token: 0x06033F68 RID: 212840 RVA: 0x0070141D File Offset: 0x006FF61D
		// (set) Token: 0x06033F69 RID: 212841 RVA: 0x00701425 File Offset: 0x006FF625
		public int FirstGrabEntityId { get; set; }

		// Token: 0x06033F6A RID: 212842 RVA: 0x0070142E File Offset: 0x006FF62E
		public IPetalGrabConfigT()
		{
			this.Type = ESportStateType.Slide;
			this.FirstGrabEntityId = 0;
		}
	}
}
