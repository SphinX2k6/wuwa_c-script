using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FBD RID: 16317
	public class IProgressBarLeftTypeT
	{
		// Token: 0x170071F5 RID: 29173
		// (get) Token: 0x06017556 RID: 95574 RVA: 0x0035CFC2 File Offset: 0x0035B1C2
		// (set) Token: 0x06017557 RID: 95575 RVA: 0x0035CFCA File Offset: 0x0035B1CA
		public EProgressBarLeftType Type { get; set; }

		// Token: 0x06017558 RID: 95576 RVA: 0x0035CFD3 File Offset: 0x0035B1D3
		public IProgressBarLeftTypeT()
		{
			this.Type = EProgressBarLeftType.UseCount;
		}
	}
}
