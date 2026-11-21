using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200697D RID: 27005
	public class IChangeNpcAbpStateT
	{
		// Token: 0x1700C6D5 RID: 50901
		// (get) Token: 0x0602E510 RID: 189712 RVA: 0x00652E67 File Offset: 0x00651067
		// (set) Token: 0x0602E511 RID: 189713 RVA: 0x00652E6F File Offset: 0x0065106F
		public int EntityId { get; set; }

		// Token: 0x1700C6D6 RID: 50902
		// (get) Token: 0x0602E512 RID: 189714 RVA: 0x00652E78 File Offset: 0x00651078
		// (set) Token: 0x0602E513 RID: 189715 RVA: 0x00652E80 File Offset: 0x00651080
		public string AbpState { get; set; }

		// Token: 0x0602E514 RID: 189716 RVA: 0x00652E89 File Offset: 0x00651089
		public IChangeNpcAbpStateT()
		{
			this.EntityId = 0;
			this.AbpState = null;
		}
	}
}
