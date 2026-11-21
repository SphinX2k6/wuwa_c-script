using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007295 RID: 29333
	public class IMoveOperationTypeT
	{
		// Token: 0x1700D703 RID: 55043
		// (get) Token: 0x060331DE RID: 209374 RVA: 0x006E5C6A File Offset: 0x006E3E6A
		// (set) Token: 0x060331DF RID: 209375 RVA: 0x006E5C72 File Offset: 0x006E3E72
		public EMoveOperationType Type { get; set; }

		// Token: 0x060331E0 RID: 209376 RVA: 0x006E5C7B File Offset: 0x006E3E7B
		public IMoveOperationTypeT()
		{
			this.Type = EMoveOperationType.Enable;
		}
	}
}
