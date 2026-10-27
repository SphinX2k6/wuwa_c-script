using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D38 RID: 15672
	public class IBossRushBuffInfoViewT
	{
		// Token: 0x17006B7D RID: 27517
		// (get) Token: 0x06015A55 RID: 88661 RVA: 0x0031FBDE File Offset: 0x0031DDDE
		// (set) Token: 0x06015A56 RID: 88662 RVA: 0x0031FBE6 File Offset: 0x0031DDE6
		public EInformationViewType Type { get; set; }

		// Token: 0x06015A57 RID: 88663 RVA: 0x0031FBEF File Offset: 0x0031DDEF
		public IBossRushBuffInfoViewT()
		{
			this.Type = EInformationViewType.LevelPlay;
		}
	}
}
