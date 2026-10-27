using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005244 RID: 21060
	public class IFightMusicsSwitchByTagListT
	{
		// Token: 0x17009A50 RID: 39504
		// (get) Token: 0x0602242B RID: 140331 RVA: 0x004C080B File Offset: 0x004BEA0B
		// (set) Token: 0x0602242C RID: 140332 RVA: 0x004C0813 File Offset: 0x004BEA13
		public EFightMusicsSwitchType Type { get; set; }

		// Token: 0x17009A51 RID: 39505
		// (get) Token: 0x0602242D RID: 140333 RVA: 0x004C081C File Offset: 0x004BEA1C
		// (set) Token: 0x0602242E RID: 140334 RVA: 0x004C0824 File Offset: 0x004BEA24
		public List<IFightMusicSwitchByTagT> Element { get; set; }

		// Token: 0x0602242F RID: 140335 RVA: 0x004C082D File Offset: 0x004BEA2D
		public IFightMusicsSwitchByTagListT()
		{
			this.Type = EFightMusicsSwitchType.SwitchByTag;
			this.Element = null;
		}
	}
}
