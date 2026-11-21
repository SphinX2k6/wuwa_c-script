using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F21 RID: 28449
	public class IGameplayPose3InteractT
	{
		// Token: 0x1700D092 RID: 53394
		// (get) Token: 0x060313B9 RID: 201657 RVA: 0x006ABBD6 File Offset: 0x006A9DD6
		// (set) Token: 0x060313BA RID: 201658 RVA: 0x006ABBDE File Offset: 0x006A9DDE
		public ELeisureInteract Type { get; set; }

		// Token: 0x060313BB RID: 201659 RVA: 0x006ABBE7 File Offset: 0x006A9DE7
		public IGameplayPose3InteractT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
