using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CD3 RID: 23763
	public class IPasserbyNpcStandPosT
	{
		// Token: 0x1700AE9D RID: 44701
		// (get) Token: 0x06027727 RID: 161575 RVA: 0x0056625B File Offset: 0x0056445B
		// (set) Token: 0x06027728 RID: 161576 RVA: 0x00566263 File Offset: 0x00564463
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700AE9E RID: 44702
		// (get) Token: 0x06027729 RID: 161577 RVA: 0x0056626C File Offset: 0x0056446C
		// (set) Token: 0x0602772A RID: 161578 RVA: 0x00566274 File Offset: 0x00564474
		public int Yaw { get; set; }

		// Token: 0x0602772B RID: 161579 RVA: 0x0056627D File Offset: 0x0056447D
		public IPasserbyNpcStandPosT()
		{
			this.Offset = null;
			this.Yaw = 0;
		}
	}
}
