using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C9C RID: 31900
	public class IUiOperationTypeT
	{
		// Token: 0x1700EED9 RID: 61145
		// (get) Token: 0x060398C3 RID: 235715 RVA: 0x007C4526 File Offset: 0x007C2726
		// (set) Token: 0x060398C4 RID: 235716 RVA: 0x007C452E File Offset: 0x007C272E
		public EUiOperationType Type { get; set; }

		// Token: 0x060398C5 RID: 235717 RVA: 0x007C4537 File Offset: 0x007C2737
		public IUiOperationTypeT()
		{
			this.Type = EUiOperationType.Enable;
		}
	}
}
