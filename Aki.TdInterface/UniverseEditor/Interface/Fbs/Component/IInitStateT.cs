using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200541A RID: 21530
	public class IInitStateT
	{
		// Token: 0x17009E63 RID: 40547
		// (get) Token: 0x060235CB RID: 144843 RVA: 0x004E4D66 File Offset: 0x004E2F66
		// (set) Token: 0x060235CC RID: 144844 RVA: 0x004E4D6E File Offset: 0x004E2F6E
		public EInitStateType Type { get; set; }

		// Token: 0x060235CD RID: 144845 RVA: 0x004E4D77 File Offset: 0x004E2F77
		public IInitStateT()
		{
			this.Type = EInitStateType.Birth;
		}
	}
}
