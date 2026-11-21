using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006369 RID: 25449
	public class IBvbAiGetBestRearrangeDataT
	{
		// Token: 0x1700BC37 RID: 48183
		// (get) Token: 0x0602B31F RID: 176927 RVA: 0x005E3831 File Offset: 0x005E1A31
		// (set) Token: 0x0602B320 RID: 176928 RVA: 0x005E3839 File Offset: 0x005E1A39
		public EBvbEventName Type { get; set; }

		// Token: 0x1700BC38 RID: 48184
		// (get) Token: 0x0602B321 RID: 176929 RVA: 0x005E3842 File Offset: 0x005E1A42
		// (set) Token: 0x0602B322 RID: 176930 RVA: 0x005E384A File Offset: 0x005E1A4A
		public TVarRefUnion BoardCardStored { get; set; }

		// Token: 0x1700BC39 RID: 48185
		// (get) Token: 0x0602B323 RID: 176931 RVA: 0x005E3853 File Offset: 0x005E1A53
		// (set) Token: 0x0602B324 RID: 176932 RVA: 0x005E385B File Offset: 0x005E1A5B
		public TVarRefUnion BoardPosStored { get; set; }

		// Token: 0x0602B325 RID: 176933 RVA: 0x005E3864 File Offset: 0x005E1A64
		public IBvbAiGetBestRearrangeDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
			this.BoardCardStored = null;
			this.BoardPosStored = null;
		}
	}
}
