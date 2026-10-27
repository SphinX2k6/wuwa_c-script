using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060CC RID: 24780
	public class IActorInitialMontageT
	{
		// Token: 0x1700B696 RID: 46742
		// (get) Token: 0x0602A500 RID: 173312 RVA: 0x005D4D3D File Offset: 0x005D2F3D
		// (set) Token: 0x0602A501 RID: 173313 RVA: 0x005D4D45 File Offset: 0x005D2F45
		public IMontageIdT MontageId { get; set; }

		// Token: 0x0602A502 RID: 173314 RVA: 0x005D4D4E File Offset: 0x005D2F4E
		public IActorInitialMontageT()
		{
			this.MontageId = null;
		}
	}
}
