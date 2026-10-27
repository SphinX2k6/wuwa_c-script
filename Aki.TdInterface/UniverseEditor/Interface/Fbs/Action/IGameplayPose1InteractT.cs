using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200687A RID: 26746
	public class IGameplayPose1InteractT
	{
		// Token: 0x1700C6A6 RID: 50854
		// (get) Token: 0x0602EA5B RID: 191067 RVA: 0x0065C866 File Offset: 0x0065AA66
		// (set) Token: 0x0602EA5C RID: 191068 RVA: 0x0065C86E File Offset: 0x0065AA6E
		public ELeisureInteract Type { get; set; }

		// Token: 0x0602EA5D RID: 191069 RVA: 0x0065C877 File Offset: 0x0065AA77
		public IGameplayPose1InteractT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
