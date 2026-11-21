using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007514 RID: 29972
	public class IPreloadMp4sT
	{
		// Token: 0x1700DC91 RID: 56465
		// (get) Token: 0x06034903 RID: 215299 RVA: 0x0071324F File Offset: 0x0071144F
		// (set) Token: 0x06034904 RID: 215300 RVA: 0x00713257 File Offset: 0x00711457
		public EPreloadObjectType Type { get; set; }

		// Token: 0x1700DC92 RID: 56466
		// (get) Token: 0x06034905 RID: 215301 RVA: 0x00713260 File Offset: 0x00711460
		// (set) Token: 0x06034906 RID: 215302 RVA: 0x00713268 File Offset: 0x00711468
		public List<string> Mp4s { get; set; }

		// Token: 0x06034907 RID: 215303 RVA: 0x00713271 File Offset: 0x00711471
		public IPreloadMp4sT()
		{
			this.Type = EPreloadObjectType.PreloadTrialCharacterForSkill;
			this.Mp4s = null;
		}
	}
}
