using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074C1 RID: 29889
	public class IUnlockAchievementSystemItemT
	{
		// Token: 0x1700E2DD RID: 58077
		// (get) Token: 0x06036573 RID: 222579 RVA: 0x00762708 File Offset: 0x00760908
		// (set) Token: 0x06036574 RID: 222580 RVA: 0x00762710 File Offset: 0x00760910
		public EUnlockSystemItemType Type { get; set; }

		// Token: 0x1700E2DE RID: 58078
		// (get) Token: 0x06036575 RID: 222581 RVA: 0x00762719 File Offset: 0x00760919
		// (set) Token: 0x06036576 RID: 222582 RVA: 0x00762721 File Offset: 0x00760921
		public int Id { get; set; }

		// Token: 0x06036577 RID: 222583 RVA: 0x0076272A File Offset: 0x0076092A
		public IUnlockAchievementSystemItemT()
		{
			this.Type = EUnlockSystemItemType.CookSystem;
			this.Id = 0;
		}
	}
}
