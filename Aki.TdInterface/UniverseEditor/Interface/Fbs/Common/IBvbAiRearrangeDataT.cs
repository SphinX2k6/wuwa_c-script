using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006372 RID: 25458
	public class IBvbAiRearrangeDataT
	{
		// Token: 0x1700BC4C RID: 48204
		// (get) Token: 0x0602B397 RID: 177047 RVA: 0x005E4F35 File Offset: 0x005E3135
		// (set) Token: 0x0602B398 RID: 177048 RVA: 0x005E4F3D File Offset: 0x005E313D
		public EBvbEventName Type { get; set; }

		// Token: 0x1700BC4D RID: 48205
		// (get) Token: 0x0602B399 RID: 177049 RVA: 0x005E4F46 File Offset: 0x005E3146
		// (set) Token: 0x0602B39A RID: 177050 RVA: 0x005E4F4E File Offset: 0x005E314E
		public TVarRefUnion BoardCard { get; set; }

		// Token: 0x1700BC4E RID: 48206
		// (get) Token: 0x0602B39B RID: 177051 RVA: 0x005E4F57 File Offset: 0x005E3157
		// (set) Token: 0x0602B39C RID: 177052 RVA: 0x005E4F5F File Offset: 0x005E315F
		public TVarRefUnion BoardPos { get; set; }

		// Token: 0x0602B39D RID: 177053 RVA: 0x005E4F68 File Offset: 0x005E3168
		public IBvbAiRearrangeDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
			this.BoardCard = null;
			this.BoardPos = null;
		}
	}
}
