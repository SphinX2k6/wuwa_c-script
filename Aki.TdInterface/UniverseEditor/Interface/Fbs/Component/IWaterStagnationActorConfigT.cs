using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200616A RID: 24938
	public class IWaterStagnationActorConfigT
	{
		// Token: 0x1700B9DD RID: 47581
		// (get) Token: 0x0602A59F RID: 173471 RVA: 0x005C7432 File Offset: 0x005C5632
		// (set) Token: 0x0602A5A0 RID: 173472 RVA: 0x005C743A File Offset: 0x005C563A
		public int SeqRefEntity { get; set; }

		// Token: 0x0602A5A1 RID: 173473 RVA: 0x005C7443 File Offset: 0x005C5643
		public IWaterStagnationActorConfigT()
		{
			this.SeqRefEntity = 0;
		}
	}
}
