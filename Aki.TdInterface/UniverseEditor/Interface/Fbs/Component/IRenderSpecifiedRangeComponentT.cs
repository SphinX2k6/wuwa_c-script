using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E57 RID: 24151
	public class IRenderSpecifiedRangeComponentT
	{
		// Token: 0x1700B21D RID: 45597
		// (get) Token: 0x0602860B RID: 165387 RVA: 0x0058594B File Offset: 0x00583B4B
		// (set) Token: 0x0602860C RID: 165388 RVA: 0x00585953 File Offset: 0x00583B53
		public bool Disabled { get; set; }

		// Token: 0x1700B21E RID: 45598
		// (get) Token: 0x0602860D RID: 165389 RVA: 0x0058595C File Offset: 0x00583B5C
		// (set) Token: 0x0602860E RID: 165390 RVA: 0x00585964 File Offset: 0x00583B64
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700B21F RID: 45599
		// (get) Token: 0x0602860F RID: 165391 RVA: 0x0058596D File Offset: 0x00583B6D
		// (set) Token: 0x06028610 RID: 165392 RVA: 0x00585975 File Offset: 0x00583B75
		public TRenderSpecifiedRangeConfigUnion RenderConfig { get; set; }

		// Token: 0x1700B220 RID: 45600
		// (get) Token: 0x06028611 RID: 165393 RVA: 0x0058597E File Offset: 0x00583B7E
		// (set) Token: 0x06028612 RID: 165394 RVA: 0x00585986 File Offset: 0x00583B86
		public byte NullMask { get; set; }

		// Token: 0x06028613 RID: 165395 RVA: 0x0058598F File Offset: 0x00583B8F
		public IRenderSpecifiedRangeComponentT()
		{
			this.Disabled = false;
			this.Condition = null;
			this.RenderConfig = null;
			this.NullMask = 0;
		}
	}
}
