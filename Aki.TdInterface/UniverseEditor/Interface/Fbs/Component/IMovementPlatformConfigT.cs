using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055DC RID: 21980
	public class IMovementPlatformConfigT
	{
		// Token: 0x1700A29D RID: 41629
		// (get) Token: 0x06024745 RID: 149317 RVA: 0x005083C1 File Offset: 0x005065C1
		// (set) Token: 0x06024746 RID: 149318 RVA: 0x005083C9 File Offset: 0x005065C9
		public List<int> PlayerAttachTags { get; set; }

		// Token: 0x1700A29E RID: 41630
		// (get) Token: 0x06024747 RID: 149319 RVA: 0x005083D2 File Offset: 0x005065D2
		// (set) Token: 0x06024748 RID: 149320 RVA: 0x005083DA File Offset: 0x005065DA
		public int SafePointId { get; set; }

		// Token: 0x1700A29F RID: 41631
		// (get) Token: 0x06024749 RID: 149321 RVA: 0x005083E3 File Offset: 0x005065E3
		// (set) Token: 0x0602474A RID: 149322 RVA: 0x005083EB File Offset: 0x005065EB
		public byte NullMask { get; set; }

		// Token: 0x0602474B RID: 149323 RVA: 0x005083F4 File Offset: 0x005065F4
		public IMovementPlatformConfigT()
		{
			this.PlayerAttachTags = null;
			this.SafePointId = 0;
			this.NullMask = 0;
		}
	}
}
