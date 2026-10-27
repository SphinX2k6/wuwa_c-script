using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200469A RID: 18074
	public class IShieldGuideT
	{
		// Token: 0x17008059 RID: 32857
		// (get) Token: 0x0601B739 RID: 112441 RVA: 0x003E6170 File Offset: 0x003E4370
		// (set) Token: 0x0601B73A RID: 112442 RVA: 0x003E6178 File Offset: 0x003E4378
		public EGmCommand Type { get; set; }

		// Token: 0x1700805A RID: 32858
		// (get) Token: 0x0601B73B RID: 112443 RVA: 0x003E6181 File Offset: 0x003E4381
		// (set) Token: 0x0601B73C RID: 112444 RVA: 0x003E6189 File Offset: 0x003E4389
		public bool IsShield { get; set; }

		// Token: 0x0601B73D RID: 112445 RVA: 0x003E6192 File Offset: 0x003E4392
		public IShieldGuideT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.IsShield = false;
		}
	}
}
