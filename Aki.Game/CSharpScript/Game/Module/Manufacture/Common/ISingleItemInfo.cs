using System;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x02004667 RID: 18023
	public class ISingleItemInfo
	{
		// Token: 0x17005B4F RID: 23375
		// (get) Token: 0x0602D533 RID: 185651 RVA: 0x00CB0C3E File Offset: 0x00CAEE3E
		// (set) Token: 0x0602D534 RID: 185652 RVA: 0x00CB0C46 File Offset: 0x00CAEE46
		public int Proto_ItemId { get; set; }

		// Token: 0x17005B50 RID: 23376
		// (get) Token: 0x0602D535 RID: 185653 RVA: 0x00CB0C4F File Offset: 0x00CAEE4F
		// (set) Token: 0x0602D536 RID: 185654 RVA: 0x00CB0C57 File Offset: 0x00CAEE57
		public int Proto_ItemNum { get; set; }

		// Token: 0x17005B51 RID: 23377
		// (get) Token: 0x0602D537 RID: 185655 RVA: 0x00CB0C60 File Offset: 0x00CAEE60
		// (set) Token: 0x0602D538 RID: 185656 RVA: 0x00CB0C68 File Offset: 0x00CAEE68
		public bool Proto_IsUnlock { get; set; }

		// Token: 0x17005B52 RID: 23378
		// (get) Token: 0x0602D539 RID: 185657 RVA: 0x00CB0C71 File Offset: 0x00CAEE71
		// (set) Token: 0x0602D53A RID: 185658 RVA: 0x00CB0C79 File Offset: 0x00CAEE79
		public bool? IsEmpty { get; set; }
	}
}
