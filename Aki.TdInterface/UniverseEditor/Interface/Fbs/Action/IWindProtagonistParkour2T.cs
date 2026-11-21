using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E19 RID: 32281
	public class IWindProtagonistParkour2T
	{
		// Token: 0x1700F1C7 RID: 61895
		// (get) Token: 0x0603A567 RID: 238951 RVA: 0x007DBBFA File Offset: 0x007D9DFA
		// (set) Token: 0x0603A568 RID: 238952 RVA: 0x007DBC02 File Offset: 0x007D9E02
		public ELeisureInteract Type { get; set; }

		// Token: 0x0603A569 RID: 238953 RVA: 0x007DBC0B File Offset: 0x007D9E0B
		public IWindProtagonistParkour2T()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
