using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074CA RID: 29898
	public class IUnLockCookSystemItemT
	{
		// Token: 0x1700E2EC RID: 58092
		// (get) Token: 0x060365BB RID: 222651 RVA: 0x00762FA7 File Offset: 0x007611A7
		// (set) Token: 0x060365BC RID: 222652 RVA: 0x00762FAF File Offset: 0x007611AF
		public EUnlockSystemItemType Type { get; set; }

		// Token: 0x1700E2ED RID: 58093
		// (get) Token: 0x060365BD RID: 222653 RVA: 0x00762FB8 File Offset: 0x007611B8
		// (set) Token: 0x060365BE RID: 222654 RVA: 0x00762FC0 File Offset: 0x007611C0
		public IUnlockCookSystemCookBookT UnlockOption { get; set; }

		// Token: 0x060365BF RID: 222655 RVA: 0x00762FC9 File Offset: 0x007611C9
		public IUnLockCookSystemItemT()
		{
			this.Type = EUnlockSystemItemType.CookSystem;
			this.UnlockOption = null;
		}
	}
}
