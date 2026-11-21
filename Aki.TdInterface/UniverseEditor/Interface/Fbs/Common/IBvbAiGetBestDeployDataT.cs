using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006366 RID: 25446
	public class IBvbAiGetBestDeployDataT
	{
		// Token: 0x1700BC30 RID: 48176
		// (get) Token: 0x0602B2F7 RID: 176887 RVA: 0x005E3085 File Offset: 0x005E1285
		// (set) Token: 0x0602B2F8 RID: 176888 RVA: 0x005E308D File Offset: 0x005E128D
		public EBvbEventName Type { get; set; }

		// Token: 0x1700BC31 RID: 48177
		// (get) Token: 0x0602B2F9 RID: 176889 RVA: 0x005E3096 File Offset: 0x005E1296
		// (set) Token: 0x0602B2FA RID: 176890 RVA: 0x005E309E File Offset: 0x005E129E
		public TVarRefUnion HandCard { get; set; }

		// Token: 0x1700BC32 RID: 48178
		// (get) Token: 0x0602B2FB RID: 176891 RVA: 0x005E30A7 File Offset: 0x005E12A7
		// (set) Token: 0x0602B2FC RID: 176892 RVA: 0x005E30AF File Offset: 0x005E12AF
		public TVarRefUnion BoardPosStored { get; set; }

		// Token: 0x0602B2FD RID: 176893 RVA: 0x005E30B8 File Offset: 0x005E12B8
		public IBvbAiGetBestDeployDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
			this.HandCard = null;
			this.BoardPosStored = null;
		}
	}
}
