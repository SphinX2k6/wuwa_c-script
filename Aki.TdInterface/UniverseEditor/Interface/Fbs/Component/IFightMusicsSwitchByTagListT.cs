using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057AC RID: 22444
	public class IFightMusicsSwitchByTagListT
	{
		// Token: 0x1700A24C RID: 41548
		// (get) Token: 0x060243C1 RID: 148417 RVA: 0x004FB2CF File Offset: 0x004F94CF
		// (set) Token: 0x060243C2 RID: 148418 RVA: 0x004FB2D7 File Offset: 0x004F94D7
		public EFightMusicsSwitchType Type { get; set; }

		// Token: 0x1700A24D RID: 41549
		// (get) Token: 0x060243C3 RID: 148419 RVA: 0x004FB2E0 File Offset: 0x004F94E0
		// (set) Token: 0x060243C4 RID: 148420 RVA: 0x004FB2E8 File Offset: 0x004F94E8
		public List<IFightMusicSwitchByTagT> Element { get; set; }

		// Token: 0x060243C5 RID: 148421 RVA: 0x004FB2F1 File Offset: 0x004F94F1
		public IFightMusicsSwitchByTagListT()
		{
			this.Type = EFightMusicsSwitchType.SwitchByTag;
			this.Element = null;
		}
	}
}
