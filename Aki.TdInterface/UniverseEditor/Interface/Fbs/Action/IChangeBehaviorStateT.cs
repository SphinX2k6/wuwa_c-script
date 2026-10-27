using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062D0 RID: 25296
	public class IChangeBehaviorStateT
	{
		// Token: 0x1700BCD6 RID: 48342
		// (get) Token: 0x0602BB9D RID: 179101 RVA: 0x0060452C File Offset: 0x0060272C
		// (set) Token: 0x0602BB9E RID: 179102 RVA: 0x00604534 File Offset: 0x00602734
		public int StateId { get; set; }

		// Token: 0x1700BCD7 RID: 48343
		// (get) Token: 0x0602BB9F RID: 179103 RVA: 0x0060453D File Offset: 0x0060273D
		// (set) Token: 0x0602BBA0 RID: 179104 RVA: 0x00604545 File Offset: 0x00602745
		public bool IsInstant { get; set; }

		// Token: 0x0602BBA1 RID: 179105 RVA: 0x0060454E File Offset: 0x0060274E
		public IChangeBehaviorStateT()
		{
			this.StateId = 0;
			this.IsInstant = false;
		}
	}
}
