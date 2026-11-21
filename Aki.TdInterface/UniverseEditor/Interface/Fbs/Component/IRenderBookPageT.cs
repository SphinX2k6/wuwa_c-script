using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E49 RID: 24137
	public class IRenderBookPageT
	{
		// Token: 0x1700B1F0 RID: 45552
		// (get) Token: 0x0602855F RID: 165215 RVA: 0x00583C87 File Offset: 0x00581E87
		// (set) Token: 0x06028560 RID: 165216 RVA: 0x00583C8F File Offset: 0x00581E8F
		public ERenderSpecifiedRangeType Type { get; set; }

		// Token: 0x1700B1F1 RID: 45553
		// (get) Token: 0x06028561 RID: 165217 RVA: 0x00583C98 File Offset: 0x00581E98
		// (set) Token: 0x06028562 RID: 165218 RVA: 0x00583CA0 File Offset: 0x00581EA0
		public int Radius { get; set; }

		// Token: 0x1700B1F2 RID: 45554
		// (get) Token: 0x06028563 RID: 165219 RVA: 0x00583CA9 File Offset: 0x00581EA9
		// (set) Token: 0x06028564 RID: 165220 RVA: 0x00583CB1 File Offset: 0x00581EB1
		public TTargetEntityUnion CenterTarget { get; set; }

		// Token: 0x1700B1F3 RID: 45555
		// (get) Token: 0x06028565 RID: 165221 RVA: 0x00583CBA File Offset: 0x00581EBA
		// (set) Token: 0x06028566 RID: 165222 RVA: 0x00583CC2 File Offset: 0x00581EC2
		public string AkEvent { get; set; }

		// Token: 0x06028567 RID: 165223 RVA: 0x00583CCB File Offset: 0x00581ECB
		public IRenderBookPageT()
		{
			this.Type = ERenderSpecifiedRangeType.FlowerBridge;
			this.Radius = 0;
			this.CenterTarget = null;
			this.AkEvent = null;
		}
	}
}
