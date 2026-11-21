using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E5A RID: 24154
	public class IRenderSpecifiedRangeTypeT
	{
		// Token: 0x1700B223 RID: 45603
		// (get) Token: 0x06028623 RID: 165411 RVA: 0x00585B86 File Offset: 0x00583D86
		// (set) Token: 0x06028624 RID: 165412 RVA: 0x00585B8E File Offset: 0x00583D8E
		public ERenderSpecifiedRangeType Type { get; set; }

		// Token: 0x06028625 RID: 165413 RVA: 0x00585B97 File Offset: 0x00583D97
		public IRenderSpecifiedRangeTypeT()
		{
			this.Type = ERenderSpecifiedRangeType.FlowerBridge;
		}
	}
}
