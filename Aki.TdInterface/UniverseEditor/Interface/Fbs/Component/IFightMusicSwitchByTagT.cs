using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057B5 RID: 22453
	public class IFightMusicSwitchByTagT
	{
		// Token: 0x1700A256 RID: 41558
		// (get) Token: 0x060243F9 RID: 148473 RVA: 0x004FB7D2 File Offset: 0x004F99D2
		// (set) Token: 0x060243FA RID: 148474 RVA: 0x004FB7DA File Offset: 0x004F99DA
		public string FightMusic { get; set; }

		// Token: 0x1700A257 RID: 41559
		// (get) Token: 0x060243FB RID: 148475 RVA: 0x004FB7E3 File Offset: 0x004F99E3
		// (set) Token: 0x060243FC RID: 148476 RVA: 0x004FB7EB File Offset: 0x004F99EB
		public string ActivateTag { get; set; }

		// Token: 0x060243FD RID: 148477 RVA: 0x004FB7F4 File Offset: 0x004F99F4
		public IFightMusicSwitchByTagT()
		{
			this.FightMusic = null;
			this.ActivateTag = null;
		}
	}
}
