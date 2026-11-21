using System;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CD6 RID: 15574
	public class DropRewardItemData : IDropRewardItemData
	{
		// Token: 0x170051C0 RID: 20928
		// (get) Token: 0x06027E11 RID: 163345 RVA: 0x00B2759B File Offset: 0x00B2579B
		// (set) Token: 0x06027E12 RID: 163346 RVA: 0x00B275A3 File Offset: 0x00B257A3
		public int ItemId { get; set; }

		// Token: 0x170051C1 RID: 20929
		// (get) Token: 0x06027E13 RID: 163347 RVA: 0x00B275AC File Offset: 0x00B257AC
		// (set) Token: 0x06027E14 RID: 163348 RVA: 0x00B275B4 File Offset: 0x00B257B4
		public int Count { get; set; }

		// Token: 0x170051C2 RID: 20930
		// (get) Token: 0x06027E15 RID: 163349 RVA: 0x00B275BD File Offset: 0x00B257BD
		// (set) Token: 0x06027E16 RID: 163350 RVA: 0x00B275C5 File Offset: 0x00B257C5
		public bool HaveFinish { get; set; }
	}
}
