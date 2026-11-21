using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CB7 RID: 31927
	public class IUnlockAchievementSystemItemT
	{
		// Token: 0x1700EF07 RID: 61191
		// (get) Token: 0x06039988 RID: 235912 RVA: 0x007C5958 File Offset: 0x007C3B58
		// (set) Token: 0x06039989 RID: 235913 RVA: 0x007C5960 File Offset: 0x007C3B60
		public EUnlockSystemItemType Type { get; set; }

		// Token: 0x1700EF08 RID: 61192
		// (get) Token: 0x0603998A RID: 235914 RVA: 0x007C5969 File Offset: 0x007C3B69
		// (set) Token: 0x0603998B RID: 235915 RVA: 0x007C5971 File Offset: 0x007C3B71
		public int Id { get; set; }

		// Token: 0x0603998C RID: 235916 RVA: 0x007C597A File Offset: 0x007C3B7A
		public IUnlockAchievementSystemItemT()
		{
			this.Type = EUnlockSystemItemType.CookSystem;
			this.Id = 0;
		}
	}
}
