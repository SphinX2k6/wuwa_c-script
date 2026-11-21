using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007401 RID: 29697
	public class IPetalFlyConfigT
	{
		// Token: 0x1700DA26 RID: 55846
		// (get) Token: 0x06033F52 RID: 212818 RVA: 0x00701232 File Offset: 0x006FF432
		// (set) Token: 0x06033F53 RID: 212819 RVA: 0x0070123A File Offset: 0x006FF43A
		public ESportStateType Type { get; set; }

		// Token: 0x06033F54 RID: 212820 RVA: 0x00701243 File Offset: 0x006FF443
		public IPetalFlyConfigT()
		{
			this.Type = ESportStateType.Slide;
		}
	}
}
