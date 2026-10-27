using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DEA RID: 28138
	public class IQiuyuanQinggongExploration4T
	{
		// Token: 0x1700D1B9 RID: 53689
		// (get) Token: 0x06031B33 RID: 203571 RVA: 0x006BAF92 File Offset: 0x006B9192
		// (set) Token: 0x06031B34 RID: 203572 RVA: 0x006BAF9A File Offset: 0x006B919A
		public ELeisureInteract Type { get; set; }

		// Token: 0x06031B35 RID: 203573 RVA: 0x006BAFA3 File Offset: 0x006B91A3
		public IQiuyuanQinggongExploration4T()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
