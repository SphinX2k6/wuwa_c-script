using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F1B RID: 28443
	public class IGameplayPose1InteractT
	{
		// Token: 0x1700D08C RID: 53388
		// (get) Token: 0x06031395 RID: 201621 RVA: 0x006AB8E6 File Offset: 0x006A9AE6
		// (set) Token: 0x06031396 RID: 201622 RVA: 0x006AB8EE File Offset: 0x006A9AEE
		public ELeisureInteract Type { get; set; }

		// Token: 0x06031397 RID: 201623 RVA: 0x006AB8F7 File Offset: 0x006A9AF7
		public IGameplayPose1InteractT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
