using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ADA RID: 27354
	public class IMoneHackingDoorInteractT
	{
		// Token: 0x1700CAF2 RID: 51954
		// (get) Token: 0x0602FF2C RID: 196396 RVA: 0x00685472 File Offset: 0x00683672
		// (set) Token: 0x0602FF2D RID: 196397 RVA: 0x0068547A File Offset: 0x0068367A
		public ELeisureInteract Type { get; set; }

		// Token: 0x0602FF2E RID: 196398 RVA: 0x00685483 File Offset: 0x00683683
		public IMoneHackingDoorInteractT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
