using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C4F RID: 23631
	public class IOperationsAfterEntityGroupFailureT
	{
		// Token: 0x1700AD95 RID: 44437
		// (get) Token: 0x060272E3 RID: 160483 RVA: 0x0055E145 File Offset: 0x0055C345
		// (set) Token: 0x060272E4 RID: 160484 RVA: 0x0055E14D File Offset: 0x0055C34D
		public bool IsResetState { get; set; }

		// Token: 0x1700AD96 RID: 44438
		// (get) Token: 0x060272E5 RID: 160485 RVA: 0x0055E156 File Offset: 0x0055C356
		// (set) Token: 0x060272E6 RID: 160486 RVA: 0x0055E15E File Offset: 0x0055C35E
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700AD97 RID: 44439
		// (get) Token: 0x060272E7 RID: 160487 RVA: 0x0055E167 File Offset: 0x0055C367
		// (set) Token: 0x060272E8 RID: 160488 RVA: 0x0055E16F File Offset: 0x0055C36F
		public byte NullMask { get; set; }

		// Token: 0x060272E9 RID: 160489 RVA: 0x0055E178 File Offset: 0x0055C378
		public IOperationsAfterEntityGroupFailureT()
		{
			this.IsResetState = false;
			this.Actions = null;
			this.NullMask = 0;
		}
	}
}
