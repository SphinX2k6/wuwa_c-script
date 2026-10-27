using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007245 RID: 29253
	public class ISuperCatapultT
	{
		// Token: 0x1700D90F RID: 55567
		// (get) Token: 0x06033E2A RID: 212522 RVA: 0x006FADEB File Offset: 0x006F8FEB
		// (set) Token: 0x06033E2B RID: 212523 RVA: 0x006FADF3 File Offset: 0x006F8FF3
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700D910 RID: 55568
		// (get) Token: 0x06033E2C RID: 212524 RVA: 0x006FADFC File Offset: 0x006F8FFC
		// (set) Token: 0x06033E2D RID: 212525 RVA: 0x006FAE04 File Offset: 0x006F9004
		public ICatapultParamT Param { get; set; }

		// Token: 0x06033E2E RID: 212526 RVA: 0x006FAE0D File Offset: 0x006F900D
		public ISuperCatapultT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.Param = null;
		}
	}
}
