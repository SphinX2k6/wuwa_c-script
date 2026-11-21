using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047BD RID: 18365
	public class IPerformerAiBtTreeT
	{
		// Token: 0x17007FE4 RID: 32740
		// (get) Token: 0x0601B0AA RID: 110762 RVA: 0x003D4B2E File Offset: 0x003D2D2E
		// (set) Token: 0x0601B0AB RID: 110763 RVA: 0x003D4B36 File Offset: 0x003D2D36
		public IPerformerAiStartT Root { get; set; }

		// Token: 0x17007FE5 RID: 32741
		// (get) Token: 0x0601B0AC RID: 110764 RVA: 0x003D4B3F File Offset: 0x003D2D3F
		// (set) Token: 0x0601B0AD RID: 110765 RVA: 0x003D4B47 File Offset: 0x003D2D47
		public List<int> _StSelectedNodeIds { get; set; }

		// Token: 0x17007FE6 RID: 32742
		// (get) Token: 0x0601B0AE RID: 110766 RVA: 0x003D4B50 File Offset: 0x003D2D50
		// (set) Token: 0x0601B0AF RID: 110767 RVA: 0x003D4B58 File Offset: 0x003D2D58
		public byte NullMask { get; set; }

		// Token: 0x0601B0B0 RID: 110768 RVA: 0x003D4B61 File Offset: 0x003D2D61
		public IPerformerAiBtTreeT()
		{
			this.Root = null;
			this._StSelectedNodeIds = null;
			this.NullMask = 0;
		}
	}
}
