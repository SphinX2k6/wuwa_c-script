using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007655 RID: 30293
	public class IRideMotorcycleInteractT
	{
		// Token: 0x1700DE75 RID: 56949
		// (get) Token: 0x06035273 RID: 217715 RVA: 0x00722DA0 File Offset: 0x00720FA0
		// (set) Token: 0x06035274 RID: 217716 RVA: 0x00722DA8 File Offset: 0x00720FA8
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700DE76 RID: 56950
		// (get) Token: 0x06035275 RID: 217717 RVA: 0x00722DB1 File Offset: 0x00720FB1
		// (set) Token: 0x06035276 RID: 217718 RVA: 0x00722DB9 File Offset: 0x00720FB9
		public int MotorcycleEntityId { get; set; }

		// Token: 0x06035277 RID: 217719 RVA: 0x00722DC2 File Offset: 0x00720FC2
		public IRideMotorcycleInteractT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.MotorcycleEntityId = 0;
		}
	}
}
