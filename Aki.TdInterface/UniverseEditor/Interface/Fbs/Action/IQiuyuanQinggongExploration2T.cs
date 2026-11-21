using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200755F RID: 30047
	public class IQiuyuanQinggongExploration2T
	{
		// Token: 0x1700DCFB RID: 56571
		// (get) Token: 0x06034B0B RID: 215819 RVA: 0x0071638A File Offset: 0x0071458A
		// (set) Token: 0x06034B0C RID: 215820 RVA: 0x00716392 File Offset: 0x00714592
		public ELeisureInteract Type { get; set; }

		// Token: 0x06034B0D RID: 215821 RVA: 0x0071639B File Offset: 0x0071459B
		public IQiuyuanQinggongExploration2T()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
