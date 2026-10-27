using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006988 RID: 27016
	public class IInteractFlowT
	{
		// Token: 0x1700C85B RID: 51291
		// (get) Token: 0x0602F2F0 RID: 193264 RVA: 0x0066D58B File Offset: 0x0066B78B
		// (set) Token: 0x0602F2F1 RID: 193265 RVA: 0x0066D593 File Offset: 0x0066B793
		public EInteractOption Type { get; set; }

		// Token: 0x1700C85C RID: 51292
		// (get) Token: 0x0602F2F2 RID: 193266 RVA: 0x0066D59C File Offset: 0x0066B79C
		// (set) Token: 0x0602F2F3 RID: 193267 RVA: 0x0066D5A4 File Offset: 0x0066B7A4
		public IPlayFlowT Flow { get; set; }

		// Token: 0x0602F2F4 RID: 193268 RVA: 0x0066D5AD File Offset: 0x0066B7AD
		public IInteractFlowT()
		{
			this.Type = EInteractOption.Flow;
			this.Flow = null;
		}
	}
}
