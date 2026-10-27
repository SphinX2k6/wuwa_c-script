using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DE4 RID: 28132
	public class IQiuyuanQinggongExploration2T
	{
		// Token: 0x1700D1B3 RID: 53683
		// (get) Token: 0x06031B0F RID: 203535 RVA: 0x006BACA2 File Offset: 0x006B8EA2
		// (set) Token: 0x06031B10 RID: 203536 RVA: 0x006BACAA File Offset: 0x006B8EAA
		public ELeisureInteract Type { get; set; }

		// Token: 0x06031B11 RID: 203537 RVA: 0x006BACB3 File Offset: 0x006B8EB3
		public IQiuyuanQinggongExploration2T()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
