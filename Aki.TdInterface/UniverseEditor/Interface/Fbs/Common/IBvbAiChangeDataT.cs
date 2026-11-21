using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006357 RID: 25431
	public class IBvbAiChangeDataT
	{
		// Token: 0x1700BC0E RID: 48142
		// (get) Token: 0x0602B242 RID: 176706 RVA: 0x005E10A3 File Offset: 0x005DF2A3
		// (set) Token: 0x0602B243 RID: 176707 RVA: 0x005E10AB File Offset: 0x005DF2AB
		public EBvbEventName Type { get; set; }

		// Token: 0x1700BC0F RID: 48143
		// (get) Token: 0x0602B244 RID: 176708 RVA: 0x005E10B4 File Offset: 0x005DF2B4
		// (set) Token: 0x0602B245 RID: 176709 RVA: 0x005E10BC File Offset: 0x005DF2BC
		public TVarRefUnion HandCard { get; set; }

		// Token: 0x0602B246 RID: 176710 RVA: 0x005E10C5 File Offset: 0x005DF2C5
		public IBvbAiChangeDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
			this.HandCard = null;
		}
	}
}
