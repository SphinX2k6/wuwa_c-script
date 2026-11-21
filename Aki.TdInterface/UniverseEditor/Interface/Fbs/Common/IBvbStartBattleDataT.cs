using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200639F RID: 25503
	public class IBvbStartBattleDataT
	{
		// Token: 0x1700BC7F RID: 48255
		// (get) Token: 0x0602B4EE RID: 177390 RVA: 0x005E74A2 File Offset: 0x005E56A2
		// (set) Token: 0x0602B4EF RID: 177391 RVA: 0x005E74AA File Offset: 0x005E56AA
		public EBvbEventName Type { get; set; }

		// Token: 0x0602B4F0 RID: 177392 RVA: 0x005E74B3 File Offset: 0x005E56B3
		public IBvbStartBattleDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
		}
	}
}
