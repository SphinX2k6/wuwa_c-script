using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CE4 RID: 27876
	public class IEnableLevelPlayT
	{
		// Token: 0x1700CC73 RID: 52339
		// (get) Token: 0x060300E0 RID: 196832 RVA: 0x00689B9D File Offset: 0x00687D9D
		// (set) Token: 0x060300E1 RID: 196833 RVA: 0x00689BA5 File Offset: 0x00687DA5
		public List<IEnableLevelPlayConfigT> Configs { get; set; }

		// Token: 0x1700CC74 RID: 52340
		// (get) Token: 0x060300E2 RID: 196834 RVA: 0x00689BAE File Offset: 0x00687DAE
		// (set) Token: 0x060300E3 RID: 196835 RVA: 0x00689BB6 File Offset: 0x00687DB6
		public EPlayerType TargetPlayer { get; set; }

		// Token: 0x1700CC75 RID: 52341
		// (get) Token: 0x060300E4 RID: 196836 RVA: 0x00689BBF File Offset: 0x00687DBF
		// (set) Token: 0x060300E5 RID: 196837 RVA: 0x00689BC7 File Offset: 0x00687DC7
		public byte NullMask { get; set; }

		// Token: 0x060300E6 RID: 196838 RVA: 0x00689BD0 File Offset: 0x00687DD0
		public IEnableLevelPlayT()
		{
			this.Configs = null;
			this.TargetPlayer = EPlayerType.P1;
			this.NullMask = 0;
		}
	}
}
