using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069D3 RID: 27091
	public class ICheckFlowLookAtEntityT
	{
		// Token: 0x1700C75C RID: 51036
		// (get) Token: 0x0602E7B1 RID: 190385 RVA: 0x006578D0 File Offset: 0x00655AD0
		// (set) Token: 0x0602E7B2 RID: 190386 RVA: 0x006578D8 File Offset: 0x00655AD8
		public ECheckFlowLookAtTargetType Type { get; set; }

		// Token: 0x1700C75D RID: 51037
		// (get) Token: 0x0602E7B3 RID: 190387 RVA: 0x006578E1 File Offset: 0x00655AE1
		// (set) Token: 0x0602E7B4 RID: 190388 RVA: 0x006578E9 File Offset: 0x00655AE9
		public int EntityId { get; set; }

		// Token: 0x0602E7B5 RID: 190389 RVA: 0x006578F2 File Offset: 0x00655AF2
		public ICheckFlowLookAtEntityT()
		{
			this.Type = ECheckFlowLookAtTargetType.Entity;
			this.EntityId = 0;
		}
	}
}
