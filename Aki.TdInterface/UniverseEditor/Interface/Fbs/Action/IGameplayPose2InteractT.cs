using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F1E RID: 28446
	public class IGameplayPose2InteractT
	{
		// Token: 0x1700D08F RID: 53391
		// (get) Token: 0x060313A7 RID: 201639 RVA: 0x006ABA5E File Offset: 0x006A9C5E
		// (set) Token: 0x060313A8 RID: 201640 RVA: 0x006ABA66 File Offset: 0x006A9C66
		public ELeisureInteract Type { get; set; }

		// Token: 0x060313A9 RID: 201641 RVA: 0x006ABA6F File Offset: 0x006A9C6F
		public IGameplayPose2InteractT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
