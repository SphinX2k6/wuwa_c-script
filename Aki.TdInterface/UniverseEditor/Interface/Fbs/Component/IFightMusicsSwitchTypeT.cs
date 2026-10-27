using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005247 RID: 21063
	public class IFightMusicsSwitchTypeT
	{
		// Token: 0x17009A54 RID: 39508
		// (get) Token: 0x0602243F RID: 140351 RVA: 0x004C09CA File Offset: 0x004BEBCA
		// (set) Token: 0x06022440 RID: 140352 RVA: 0x004C09D2 File Offset: 0x004BEBD2
		public EFightMusicsSwitchType Type { get; set; }

		// Token: 0x06022441 RID: 140353 RVA: 0x004C09DB File Offset: 0x004BEBDB
		public IFightMusicsSwitchTypeT()
		{
			this.Type = EFightMusicsSwitchType.SwitchByTag;
		}
	}
}
