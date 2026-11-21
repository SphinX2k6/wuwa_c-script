using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A1A RID: 31258
	public class ISuperCatapultT
	{
		// Token: 0x1700E508 RID: 58632
		// (get) Token: 0x0603712C RID: 225580 RVA: 0x0075C14B File Offset: 0x0075A34B
		// (set) Token: 0x0603712D RID: 225581 RVA: 0x0075C153 File Offset: 0x0075A353
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700E509 RID: 58633
		// (get) Token: 0x0603712E RID: 225582 RVA: 0x0075C15C File Offset: 0x0075A35C
		// (set) Token: 0x0603712F RID: 225583 RVA: 0x0075C164 File Offset: 0x0075A364
		public ICatapultParamT Param { get; set; }

		// Token: 0x06037130 RID: 225584 RVA: 0x0075C16D File Offset: 0x0075A36D
		public ISuperCatapultT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.Param = null;
		}
	}
}
