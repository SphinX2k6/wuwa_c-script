using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200636C RID: 25452
	public class IBvbAiGetBestReplaceDataT
	{
		// Token: 0x1700BC3E RID: 48190
		// (get) Token: 0x0602B347 RID: 176967 RVA: 0x005E3FDD File Offset: 0x005E21DD
		// (set) Token: 0x0602B348 RID: 176968 RVA: 0x005E3FE5 File Offset: 0x005E21E5
		public EBvbEventName Type { get; set; }

		// Token: 0x1700BC3F RID: 48191
		// (get) Token: 0x0602B349 RID: 176969 RVA: 0x005E3FEE File Offset: 0x005E21EE
		// (set) Token: 0x0602B34A RID: 176970 RVA: 0x005E3FF6 File Offset: 0x005E21F6
		public TVarRefUnion HandCard { get; set; }

		// Token: 0x1700BC40 RID: 48192
		// (get) Token: 0x0602B34B RID: 176971 RVA: 0x005E3FFF File Offset: 0x005E21FF
		// (set) Token: 0x0602B34C RID: 176972 RVA: 0x005E4007 File Offset: 0x005E2207
		public TVarRefUnion BoardCardStored { get; set; }

		// Token: 0x0602B34D RID: 176973 RVA: 0x005E4010 File Offset: 0x005E2210
		public IBvbAiGetBestReplaceDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
			this.HandCard = null;
			this.BoardCardStored = null;
		}
	}
}
