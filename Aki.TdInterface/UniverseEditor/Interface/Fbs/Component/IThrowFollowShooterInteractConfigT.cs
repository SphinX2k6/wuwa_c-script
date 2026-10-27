using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A65 RID: 23141
	public class IThrowFollowShooterInteractConfigT
	{
		// Token: 0x1700AE23 RID: 44579
		// (get) Token: 0x06027615 RID: 161301 RVA: 0x0056B624 File Offset: 0x00569824
		// (set) Token: 0x06027616 RID: 161302 RVA: 0x0056B62C File Offset: 0x0056982C
		public float Radius { get; set; }

		// Token: 0x1700AE24 RID: 44580
		// (get) Token: 0x06027617 RID: 161303 RVA: 0x0056B635 File Offset: 0x00569835
		// (set) Token: 0x06027618 RID: 161304 RVA: 0x0056B63D File Offset: 0x0056983D
		public List<int> MatchIds { get; set; }

		// Token: 0x1700AE25 RID: 44581
		// (get) Token: 0x06027619 RID: 161305 RVA: 0x0056B646 File Offset: 0x00569846
		// (set) Token: 0x0602761A RID: 161306 RVA: 0x0056B64E File Offset: 0x0056984E
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700AE26 RID: 44582
		// (get) Token: 0x0602761B RID: 161307 RVA: 0x0056B657 File Offset: 0x00569857
		// (set) Token: 0x0602761C RID: 161308 RVA: 0x0056B65F File Offset: 0x0056985F
		public List<IConditionActionT> ArrivedConditionActions { get; set; }

		// Token: 0x1700AE27 RID: 44583
		// (get) Token: 0x0602761D RID: 161309 RVA: 0x0056B668 File Offset: 0x00569868
		// (set) Token: 0x0602761E RID: 161310 RVA: 0x0056B670 File Offset: 0x00569870
		public List<IConditionActionT> LeavedConditionActions { get; set; }

		// Token: 0x1700AE28 RID: 44584
		// (get) Token: 0x0602761F RID: 161311 RVA: 0x0056B679 File Offset: 0x00569879
		// (set) Token: 0x06027620 RID: 161312 RVA: 0x0056B681 File Offset: 0x00569881
		public byte NullMask { get; set; }

		// Token: 0x06027621 RID: 161313 RVA: 0x0056B68A File Offset: 0x0056988A
		public IThrowFollowShooterInteractConfigT()
		{
			this.Radius = 0f;
			this.MatchIds = null;
			this.Offset = null;
			this.ArrivedConditionActions = null;
			this.LeavedConditionActions = null;
			this.NullMask = 0;
		}
	}
}
