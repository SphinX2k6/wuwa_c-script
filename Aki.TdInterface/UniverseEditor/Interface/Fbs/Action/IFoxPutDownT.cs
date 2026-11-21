using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EF7 RID: 28407
	public class IFoxPutDownT
	{
		// Token: 0x1700D053 RID: 53331
		// (get) Token: 0x0603127B RID: 201339 RVA: 0x006A9ADA File Offset: 0x006A7CDA
		// (set) Token: 0x0603127C RID: 201340 RVA: 0x006A9AE2 File Offset: 0x006A7CE2
		public ELeisureInteract Type { get; set; }

		// Token: 0x0603127D RID: 201341 RVA: 0x006A9AEB File Offset: 0x006A7CEB
		public IFoxPutDownT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
