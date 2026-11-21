using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067EE RID: 26606
	public class IAkEventMapTypeT
	{
		// Token: 0x1700C3A4 RID: 50084
		// (get) Token: 0x0602D73D RID: 186173 RVA: 0x006394DE File Offset: 0x006376DE
		// (set) Token: 0x0602D73E RID: 186174 RVA: 0x006394E6 File Offset: 0x006376E6
		public EAkEventMap Type { get; set; }

		// Token: 0x0602D73F RID: 186175 RVA: 0x006394EF File Offset: 0x006376EF
		public IAkEventMapTypeT()
		{
			this.Type = EAkEventMap.PlayMapMusic;
		}
	}
}
