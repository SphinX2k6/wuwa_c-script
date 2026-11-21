using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C73 RID: 23667
	public class IPasserbyNpcExitTimingBaseT
	{
		// Token: 0x1700ADE7 RID: 44519
		// (get) Token: 0x0602742F RID: 160815 RVA: 0x00560A7E File Offset: 0x0055EC7E
		// (set) Token: 0x06027430 RID: 160816 RVA: 0x00560A86 File Offset: 0x0055EC86
		public EPasserbyNpcExitTimingType Type { get; set; }

		// Token: 0x06027431 RID: 160817 RVA: 0x00560A8F File Offset: 0x0055EC8F
		public IPasserbyNpcExitTimingBaseT()
		{
			this.Type = EPasserbyNpcExitTimingType.LiftStop;
		}
	}
}
