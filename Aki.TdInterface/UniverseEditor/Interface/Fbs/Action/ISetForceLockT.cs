using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FF3 RID: 28659
	public class ISetForceLockT
	{
		// Token: 0x1700D4E8 RID: 54504
		// (get) Token: 0x06032B1E RID: 207646 RVA: 0x006D7300 File Offset: 0x006D5500
		// (set) Token: 0x06032B1F RID: 207647 RVA: 0x006D7308 File Offset: 0x006D5508
		public int EntityId { get; set; }

		// Token: 0x1700D4E9 RID: 54505
		// (get) Token: 0x06032B20 RID: 207648 RVA: 0x006D7311 File Offset: 0x006D5511
		// (set) Token: 0x06032B21 RID: 207649 RVA: 0x006D7319 File Offset: 0x006D5519
		public bool IsLocked { get; set; }

		// Token: 0x06032B22 RID: 207650 RVA: 0x006D7322 File Offset: 0x006D5522
		public ISetForceLockT()
		{
			this.EntityId = 0;
			this.IsLocked = false;
		}
	}
}
