using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200672E RID: 26414
	public class IActorInitialMontageT
	{
		// Token: 0x1700C001 RID: 49153
		// (get) Token: 0x0602CBE1 RID: 183265 RVA: 0x0061ECE5 File Offset: 0x0061CEE5
		// (set) Token: 0x0602CBE2 RID: 183266 RVA: 0x0061ECED File Offset: 0x0061CEED
		public IMontageIdT MontageId { get; set; }

		// Token: 0x0602CBE3 RID: 183267 RVA: 0x0061ECF6 File Offset: 0x0061CEF6
		public IActorInitialMontageT()
		{
			this.MontageId = null;
		}
	}
}
