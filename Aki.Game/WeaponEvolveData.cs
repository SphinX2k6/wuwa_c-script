using System;

// Token: 0x020020E7 RID: 8423
public class WeaponEvolveData : IWeaponEvolveData
{
	// Token: 0x17001F0F RID: 7951
	// (get) Token: 0x06014AA5 RID: 84645 RVA: 0x006055AD File Offset: 0x006037AD
	// (set) Token: 0x06014AA6 RID: 84646 RVA: 0x006055B5 File Offset: 0x006037B5
	public int EvolveId { get; set; }

	// Token: 0x17001F10 RID: 7952
	// (get) Token: 0x06014AA7 RID: 84647 RVA: 0x006055BE File Offset: 0x006037BE
	// (set) Token: 0x06014AA8 RID: 84648 RVA: 0x006055C6 File Offset: 0x006037C6
	public bool IsUnlock { get; set; }

	// Token: 0x17001F11 RID: 7953
	// (get) Token: 0x06014AA9 RID: 84649 RVA: 0x006055CF File Offset: 0x006037CF
	// (set) Token: 0x06014AAA RID: 84650 RVA: 0x006055D7 File Offset: 0x006037D7
	public bool ShowLine { get; set; }
}
