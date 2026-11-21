using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CD2 RID: 31954
	public class IUnlockPhotoMemoryCollectSystemItemT
	{
		// Token: 0x1700EF2B RID: 61227
		// (get) Token: 0x06039A46 RID: 236102 RVA: 0x007C6CA8 File Offset: 0x007C4EA8
		// (set) Token: 0x06039A47 RID: 236103 RVA: 0x007C6CB0 File Offset: 0x007C4EB0
		public EUnlockSystemItemType Type { get; set; }

		// Token: 0x1700EF2C RID: 61228
		// (get) Token: 0x06039A48 RID: 236104 RVA: 0x007C6CB9 File Offset: 0x007C4EB9
		// (set) Token: 0x06039A49 RID: 236105 RVA: 0x007C6CC1 File Offset: 0x007C4EC1
		public int Id { get; set; }

		// Token: 0x06039A4A RID: 236106 RVA: 0x007C6CCA File Offset: 0x007C4ECA
		public IUnlockPhotoMemoryCollectSystemItemT()
		{
			this.Type = EUnlockSystemItemType.CookSystem;
			this.Id = 0;
		}
	}
}
