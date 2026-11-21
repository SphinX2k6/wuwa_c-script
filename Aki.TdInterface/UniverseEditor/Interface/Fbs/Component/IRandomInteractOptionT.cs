using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DF2 RID: 24050
	public class IRandomInteractOptionT
	{
		// Token: 0x1700B140 RID: 45376
		// (get) Token: 0x0602824A RID: 164426 RVA: 0x0057D7C7 File Offset: 0x0057B9C7
		// (set) Token: 0x0602824B RID: 164427 RVA: 0x0057D7CF File Offset: 0x0057B9CF
		public int Weight { get; set; }

		// Token: 0x1700B141 RID: 45377
		// (get) Token: 0x0602824C RID: 164428 RVA: 0x0057D7D8 File Offset: 0x0057B9D8
		// (set) Token: 0x0602824D RID: 164429 RVA: 0x0057D7E0 File Offset: 0x0057B9E0
		public IInteractOptionT Option { get; set; }

		// Token: 0x0602824E RID: 164430 RVA: 0x0057D7E9 File Offset: 0x0057B9E9
		public IRandomInteractOptionT()
		{
			this.Weight = 0;
			this.Option = null;
		}
	}
}
