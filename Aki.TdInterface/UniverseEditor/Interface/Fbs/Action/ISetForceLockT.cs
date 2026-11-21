using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077BC RID: 30652
	public class ISetForceLockT
	{
		// Token: 0x1700E0BC RID: 57532
		// (get) Token: 0x06035D84 RID: 220548 RVA: 0x00736F44 File Offset: 0x00735144
		// (set) Token: 0x06035D85 RID: 220549 RVA: 0x00736F4C File Offset: 0x0073514C
		public int EntityId { get; set; }

		// Token: 0x1700E0BD RID: 57533
		// (get) Token: 0x06035D86 RID: 220550 RVA: 0x00736F55 File Offset: 0x00735155
		// (set) Token: 0x06035D87 RID: 220551 RVA: 0x00736F5D File Offset: 0x0073515D
		public bool IsLocked { get; set; }

		// Token: 0x06035D88 RID: 220552 RVA: 0x00736F66 File Offset: 0x00735166
		public ISetForceLockT()
		{
			this.EntityId = 0;
			this.IsLocked = false;
		}
	}
}
