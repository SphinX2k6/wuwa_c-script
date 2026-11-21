using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006375 RID: 25461
	public class IBvbAiRecycleDataT
	{
		// Token: 0x1700BC52 RID: 48210
		// (get) Token: 0x0602B3B6 RID: 177078 RVA: 0x005E5417 File Offset: 0x005E3617
		// (set) Token: 0x0602B3B7 RID: 177079 RVA: 0x005E541F File Offset: 0x005E361F
		public EBvbEventName Type { get; set; }

		// Token: 0x1700BC53 RID: 48211
		// (get) Token: 0x0602B3B8 RID: 177080 RVA: 0x005E5428 File Offset: 0x005E3628
		// (set) Token: 0x0602B3B9 RID: 177081 RVA: 0x005E5430 File Offset: 0x005E3630
		public TVarRefUnion BoardCard { get; set; }

		// Token: 0x0602B3BA RID: 177082 RVA: 0x005E5439 File Offset: 0x005E3639
		public IBvbAiRecycleDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
			this.BoardCard = null;
		}
	}
}
