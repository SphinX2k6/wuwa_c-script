using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006120 RID: 24864
	public class IAddBuffToFollowShooterT
	{
		// Token: 0x1700B73F RID: 46911
		// (get) Token: 0x0602A7E9 RID: 174057 RVA: 0x005DA3AD File Offset: 0x005D85AD
		// (set) Token: 0x0602A7EA RID: 174058 RVA: 0x005DA3B5 File Offset: 0x005D85B5
		public List<long> BuffIds { get; set; }

		// Token: 0x1700B740 RID: 46912
		// (get) Token: 0x0602A7EB RID: 174059 RVA: 0x005DA3BE File Offset: 0x005D85BE
		// (set) Token: 0x0602A7EC RID: 174060 RVA: 0x005DA3C6 File Offset: 0x005D85C6
		public int FollowShooterId { get; set; }

		// Token: 0x1700B741 RID: 46913
		// (get) Token: 0x0602A7ED RID: 174061 RVA: 0x005DA3CF File Offset: 0x005D85CF
		// (set) Token: 0x0602A7EE RID: 174062 RVA: 0x005DA3D7 File Offset: 0x005D85D7
		public byte NullMask { get; set; }

		// Token: 0x0602A7EF RID: 174063 RVA: 0x005DA3E0 File Offset: 0x005D85E0
		public IAddBuffToFollowShooterT()
		{
			this.BuffIds = null;
			this.FollowShooterId = 0;
			this.NullMask = 0;
		}
	}
}
