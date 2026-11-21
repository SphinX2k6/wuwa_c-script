using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057AF RID: 22447
	public class IFightMusicsSwitchTypeT
	{
		// Token: 0x1700A250 RID: 41552
		// (get) Token: 0x060243D5 RID: 148437 RVA: 0x004FB48E File Offset: 0x004F968E
		// (set) Token: 0x060243D6 RID: 148438 RVA: 0x004FB496 File Offset: 0x004F9696
		public EFightMusicsSwitchType Type { get; set; }

		// Token: 0x060243D7 RID: 148439 RVA: 0x004FB49F File Offset: 0x004F969F
		public IFightMusicsSwitchTypeT()
		{
			this.Type = EFightMusicsSwitchType.SwitchByTag;
		}
	}
}
