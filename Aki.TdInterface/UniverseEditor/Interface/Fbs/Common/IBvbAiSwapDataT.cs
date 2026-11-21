using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006378 RID: 25464
	public class IBvbAiSwapDataT
	{
		// Token: 0x1700BC58 RID: 48216
		// (get) Token: 0x0602B3DC RID: 177116 RVA: 0x005E5B6D File Offset: 0x005E3D6D
		// (set) Token: 0x0602B3DD RID: 177117 RVA: 0x005E5B75 File Offset: 0x005E3D75
		public EBvbEventName Type { get; set; }

		// Token: 0x1700BC59 RID: 48217
		// (get) Token: 0x0602B3DE RID: 177118 RVA: 0x005E5B7E File Offset: 0x005E3D7E
		// (set) Token: 0x0602B3DF RID: 177119 RVA: 0x005E5B86 File Offset: 0x005E3D86
		public TVarRefUnion BoardCard1 { get; set; }

		// Token: 0x1700BC5A RID: 48218
		// (get) Token: 0x0602B3E0 RID: 177120 RVA: 0x005E5B8F File Offset: 0x005E3D8F
		// (set) Token: 0x0602B3E1 RID: 177121 RVA: 0x005E5B97 File Offset: 0x005E3D97
		public TVarRefUnion BoardCard2 { get; set; }

		// Token: 0x0602B3E2 RID: 177122 RVA: 0x005E5BA0 File Offset: 0x005E3DA0
		public IBvbAiSwapDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
			this.BoardCard1 = null;
			this.BoardCard2 = null;
		}
	}
}
