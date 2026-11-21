using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005913 RID: 22803
	public class IHitLogicActionByHitTypeT
	{
		// Token: 0x1700A569 RID: 42345
		// (get) Token: 0x06025128 RID: 151848 RVA: 0x00516B5B File Offset: 0x00514D5B
		// (set) Token: 0x06025129 RID: 151849 RVA: 0x00516B63 File Offset: 0x00514D63
		public EHitLogicType Type { get; set; }

		// Token: 0x1700A56A RID: 42346
		// (get) Token: 0x0602512A RID: 151850 RVA: 0x00516B6C File Offset: 0x00514D6C
		// (set) Token: 0x0602512B RID: 151851 RVA: 0x00516B74 File Offset: 0x00514D74
		public List<IActionByHitTypeConfigT> Configs { get; set; }

		// Token: 0x0602512C RID: 151852 RVA: 0x00516B7D File Offset: 0x00514D7D
		public IHitLogicActionByHitTypeT()
		{
			this.Type = EHitLogicType.ChangeNextState;
			this.Configs = null;
		}
	}
}
