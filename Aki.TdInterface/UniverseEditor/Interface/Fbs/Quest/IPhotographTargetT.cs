using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F90 RID: 16272
	public class IPhotographTargetT
	{
		// Token: 0x17007197 RID: 29079
		// (get) Token: 0x060173DA RID: 95194 RVA: 0x0035A37A File Offset: 0x0035857A
		// (set) Token: 0x060173DB RID: 95195 RVA: 0x0035A382 File Offset: 0x00358582
		public EPhotographTargetType Type { get; set; }

		// Token: 0x060173DC RID: 95196 RVA: 0x0035A38B File Offset: 0x0035858B
		public IPhotographTargetT()
		{
			this.Type = EPhotographTargetType.Player;
		}
	}
}
