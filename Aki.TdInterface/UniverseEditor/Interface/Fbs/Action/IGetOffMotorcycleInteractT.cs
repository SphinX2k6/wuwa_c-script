using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F27 RID: 28455
	public class IGetOffMotorcycleInteractT
	{
		// Token: 0x1700D09E RID: 53406
		// (get) Token: 0x060313EF RID: 201711 RVA: 0x006AC296 File Offset: 0x006AA496
		// (set) Token: 0x060313F0 RID: 201712 RVA: 0x006AC29E File Offset: 0x006AA49E
		public ELeisureInteract Type { get; set; }

		// Token: 0x060313F1 RID: 201713 RVA: 0x006AC2A7 File Offset: 0x006AA4A7
		public IGetOffMotorcycleInteractT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
