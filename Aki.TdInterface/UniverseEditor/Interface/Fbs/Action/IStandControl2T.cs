using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071AC RID: 29100
	public class IStandControl2T
	{
		// Token: 0x1700D81B RID: 55323
		// (get) Token: 0x06033986 RID: 211334 RVA: 0x006F2AEA File Offset: 0x006F0CEA
		// (set) Token: 0x06033987 RID: 211335 RVA: 0x006F2AF2 File Offset: 0x006F0CF2
		public ELeisureInteract Type { get; set; }

		// Token: 0x06033988 RID: 211336 RVA: 0x006F2AFB File Offset: 0x006F0CFB
		public IStandControl2T()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
