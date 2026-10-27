using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200469D RID: 18077
	public class IShowTipsViewT
	{
		// Token: 0x1700805E RID: 32862
		// (get) Token: 0x0601B74F RID: 112463 RVA: 0x003E6370 File Offset: 0x003E4570
		// (set) Token: 0x0601B750 RID: 112464 RVA: 0x003E6378 File Offset: 0x003E4578
		public EGmCommand Type { get; set; }

		// Token: 0x1700805F RID: 32863
		// (get) Token: 0x0601B751 RID: 112465 RVA: 0x003E6381 File Offset: 0x003E4581
		// (set) Token: 0x0601B752 RID: 112466 RVA: 0x003E6389 File Offset: 0x003E4589
		public bool IsShield { get; set; }

		// Token: 0x0601B753 RID: 112467 RVA: 0x003E6392 File Offset: 0x003E4592
		public IShowTipsViewT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.IsShield = false;
		}
	}
}
