using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200636F RID: 25455
	public class IBvbAiGetBestSwapDataT
	{
		// Token: 0x1700BC45 RID: 48197
		// (get) Token: 0x0602B36F RID: 177007 RVA: 0x005E4789 File Offset: 0x005E2989
		// (set) Token: 0x0602B370 RID: 177008 RVA: 0x005E4791 File Offset: 0x005E2991
		public EBvbEventName Type { get; set; }

		// Token: 0x1700BC46 RID: 48198
		// (get) Token: 0x0602B371 RID: 177009 RVA: 0x005E479A File Offset: 0x005E299A
		// (set) Token: 0x0602B372 RID: 177010 RVA: 0x005E47A2 File Offset: 0x005E29A2
		public TVarRefUnion BoardCard1Stored { get; set; }

		// Token: 0x1700BC47 RID: 48199
		// (get) Token: 0x0602B373 RID: 177011 RVA: 0x005E47AB File Offset: 0x005E29AB
		// (set) Token: 0x0602B374 RID: 177012 RVA: 0x005E47B3 File Offset: 0x005E29B3
		public TVarRefUnion BoardCard2Stored { get; set; }

		// Token: 0x0602B375 RID: 177013 RVA: 0x005E47BC File Offset: 0x005E29BC
		public IBvbAiGetBestSwapDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
			this.BoardCard1Stored = null;
			this.BoardCard2Stored = null;
		}
	}
}
