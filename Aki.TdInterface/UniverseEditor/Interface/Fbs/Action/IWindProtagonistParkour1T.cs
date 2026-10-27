using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007608 RID: 30216
	public class IWindProtagonistParkour1T
	{
		// Token: 0x1700E586 RID: 58758
		// (get) Token: 0x060370B0 RID: 225456 RVA: 0x00777986 File Offset: 0x00775B86
		// (set) Token: 0x060370B1 RID: 225457 RVA: 0x0077798E File Offset: 0x00775B8E
		public ELeisureInteract Type { get; set; }

		// Token: 0x060370B2 RID: 225458 RVA: 0x00777997 File Offset: 0x00775B97
		public IWindProtagonistParkour1T()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
