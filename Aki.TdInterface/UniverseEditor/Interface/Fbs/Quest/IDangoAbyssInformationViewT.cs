using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DC8 RID: 15816
	public class IDangoAbyssInformationViewT
	{
		// Token: 0x17006D2D RID: 27949
		// (get) Token: 0x06016129 RID: 90409 RVA: 0x00330FB2 File Offset: 0x0032F1B2
		// (set) Token: 0x0601612A RID: 90410 RVA: 0x00330FBA File Offset: 0x0032F1BA
		public EInformationViewType Type { get; set; }

		// Token: 0x0601612B RID: 90411 RVA: 0x00330FC3 File Offset: 0x0032F1C3
		public IDangoAbyssInformationViewT()
		{
			this.Type = EInformationViewType.LevelPlay;
		}
	}
}
