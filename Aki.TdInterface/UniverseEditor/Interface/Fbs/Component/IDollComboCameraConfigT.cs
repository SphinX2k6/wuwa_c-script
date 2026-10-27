using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005094 RID: 20628
	public class IDollComboCameraConfigT
	{
		// Token: 0x170095D1 RID: 38353
		// (get) Token: 0x060211CB RID: 135627 RVA: 0x00499D87 File Offset: 0x00497F87
		// (set) Token: 0x060211CC RID: 135628 RVA: 0x00499D8F File Offset: 0x00497F8F
		public int ComboId { get; set; }

		// Token: 0x170095D2 RID: 38354
		// (get) Token: 0x060211CD RID: 135629 RVA: 0x00499D98 File Offset: 0x00497F98
		// (set) Token: 0x060211CE RID: 135630 RVA: 0x00499DA0 File Offset: 0x00497FA0
		public IPosAndRotT PosAndRot { get; set; }

		// Token: 0x060211CF RID: 135631 RVA: 0x00499DA9 File Offset: 0x00497FA9
		public IDollComboCameraConfigT()
		{
			this.ComboId = 0;
			this.PosAndRot = null;
		}
	}
}
