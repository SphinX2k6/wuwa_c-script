using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Manufacture.Compose.QuicklyPopup
{
	// Token: 0x0200567E RID: 22142
	[NullableContext(1)]
	[Nullable(0)]
	public class IComposePopupGridItemData
	{
		// Token: 0x1700876D RID: 34669
		// (get) Token: 0x06038571 RID: 230769 RVA: 0x00D5EEC0 File Offset: 0x00D5D0C0
		// (set) Token: 0x06038572 RID: 230770 RVA: 0x00D5EEC8 File Offset: 0x00D5D0C8
		public ISelectedData Item { get; set; }

		// Token: 0x1700876E RID: 34670
		// (get) Token: 0x06038573 RID: 230771 RVA: 0x00D5EED1 File Offset: 0x00D5D0D1
		// (set) Token: 0x06038574 RID: 230772 RVA: 0x00D5EED9 File Offset: 0x00D5D0D9
		public EGridState State { get; set; }

		// Token: 0x1700876F RID: 34671
		// (get) Token: 0x06038575 RID: 230773 RVA: 0x00D5EEE2 File Offset: 0x00D5D0E2
		// (set) Token: 0x06038576 RID: 230774 RVA: 0x00D5EEEA File Offset: 0x00D5D0EA
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ISelectedData> ComposeList { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17008770 RID: 34672
		// (get) Token: 0x06038577 RID: 230775 RVA: 0x00D5EEF3 File Offset: 0x00D5D0F3
		// (set) Token: 0x06038578 RID: 230776 RVA: 0x00D5EEFB File Offset: 0x00D5D0FB
		public int? UsedCount { get; set; }
	}
}
