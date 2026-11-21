using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200414F RID: 16719
	public class IBossRushBuffInfoViewT
	{
		// Token: 0x17007137 RID: 28983
		// (get) Token: 0x06016F8D RID: 94093 RVA: 0x00346E56 File Offset: 0x00345056
		// (set) Token: 0x06016F8E RID: 94094 RVA: 0x00346E5E File Offset: 0x0034505E
		public EInformationViewType Type { get; set; }

		// Token: 0x06016F8F RID: 94095 RVA: 0x00346E67 File Offset: 0x00345067
		public IBossRushBuffInfoViewT()
		{
			this.Type = EInformationViewType.LevelPlay;
		}
	}
}
