using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B02 RID: 19202
	public class IShieldGuideT
	{
		// Token: 0x1700869A RID: 34458
		// (get) Token: 0x0601CF0E RID: 118542 RVA: 0x0041240C File Offset: 0x0041060C
		// (set) Token: 0x0601CF0F RID: 118543 RVA: 0x00412414 File Offset: 0x00410614
		public EGmCommand Type { get; set; }

		// Token: 0x1700869B RID: 34459
		// (get) Token: 0x0601CF10 RID: 118544 RVA: 0x0041241D File Offset: 0x0041061D
		// (set) Token: 0x0601CF11 RID: 118545 RVA: 0x00412425 File Offset: 0x00410625
		public bool IsShield { get; set; }

		// Token: 0x0601CF12 RID: 118546 RVA: 0x0041242E File Offset: 0x0041062E
		public IShieldGuideT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.IsShield = false;
		}
	}
}
