using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074DC RID: 29916
	public class IUnlockPhotoMemoryCollectSystemItemT
	{
		// Token: 0x1700E301 RID: 58113
		// (get) Token: 0x06036631 RID: 222769 RVA: 0x00763A58 File Offset: 0x00761C58
		// (set) Token: 0x06036632 RID: 222770 RVA: 0x00763A60 File Offset: 0x00761C60
		public EUnlockSystemItemType Type { get; set; }

		// Token: 0x1700E302 RID: 58114
		// (get) Token: 0x06036633 RID: 222771 RVA: 0x00763A69 File Offset: 0x00761C69
		// (set) Token: 0x06036634 RID: 222772 RVA: 0x00763A71 File Offset: 0x00761C71
		public int Id { get; set; }

		// Token: 0x06036635 RID: 222773 RVA: 0x00763A7A File Offset: 0x00761C7A
		public IUnlockPhotoMemoryCollectSystemItemT()
		{
			this.Type = EUnlockSystemItemType.CookSystem;
			this.Id = 0;
		}
	}
}
