using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041B8 RID: 16824
	public class ITetrisBoardT
	{
		// Token: 0x1700774E RID: 30542
		// (get) Token: 0x06018C64 RID: 101476 RVA: 0x0039103D File Offset: 0x0038F23D
		// (set) Token: 0x06018C65 RID: 101477 RVA: 0x00391045 File Offset: 0x0038F245
		public List<ITetrisSingleGridT> Grids { get; set; }

		// Token: 0x1700774F RID: 30543
		// (get) Token: 0x06018C66 RID: 101478 RVA: 0x0039104E File Offset: 0x0038F24E
		// (set) Token: 0x06018C67 RID: 101479 RVA: 0x00391056 File Offset: 0x0038F256
		public IRequiredVector2T BoardSize { get; set; }

		// Token: 0x06018C68 RID: 101480 RVA: 0x0039105F File Offset: 0x0038F25F
		public ITetrisBoardT()
		{
			this.Grids = null;
			this.BoardSize = null;
		}
	}
}
