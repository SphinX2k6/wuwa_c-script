using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061BB RID: 25019
	public class IWuWaGoEntityBaseT
	{
		// Token: 0x1700BA93 RID: 47763
		// (get) Token: 0x0602A88B RID: 174219 RVA: 0x005CD0BE File Offset: 0x005CB2BE
		// (set) Token: 0x0602A88C RID: 174220 RVA: 0x005CD0C6 File Offset: 0x005CB2C6
		public EWuWaGoEntityType Type { get; set; }

		// Token: 0x0602A88D RID: 174221 RVA: 0x005CD0CF File Offset: 0x005CB2CF
		public IWuWaGoEntityBaseT()
		{
			this.Type = EWuWaGoEntityType.LevelCenter;
		}
	}
}
