using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077CE RID: 30670
	public class ISetInteractionLockStateT
	{
		// Token: 0x1700E0D6 RID: 57558
		// (get) Token: 0x06035E11 RID: 220689 RVA: 0x00738142 File Offset: 0x00736342
		// (set) Token: 0x06035E12 RID: 220690 RVA: 0x0073814A File Offset: 0x0073634A
		public bool IsLock { get; set; }

		// Token: 0x06035E13 RID: 220691 RVA: 0x00738153 File Offset: 0x00736353
		public ISetInteractionLockStateT()
		{
			this.IsLock = false;
		}
	}
}
