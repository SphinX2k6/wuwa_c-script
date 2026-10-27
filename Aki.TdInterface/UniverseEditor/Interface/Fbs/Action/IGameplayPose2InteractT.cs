using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200687D RID: 26749
	public class IGameplayPose2InteractT
	{
		// Token: 0x1700C6A9 RID: 50857
		// (get) Token: 0x0602EA6D RID: 191085 RVA: 0x0065C9DE File Offset: 0x0065ABDE
		// (set) Token: 0x0602EA6E RID: 191086 RVA: 0x0065C9E6 File Offset: 0x0065ABE6
		public ELeisureInteract Type { get; set; }

		// Token: 0x0602EA6F RID: 191087 RVA: 0x0065C9EF File Offset: 0x0065ABEF
		public IGameplayPose2InteractT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
