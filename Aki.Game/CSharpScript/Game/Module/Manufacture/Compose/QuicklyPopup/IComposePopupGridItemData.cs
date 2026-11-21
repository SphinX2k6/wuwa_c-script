using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Manufacture.Compose.QuicklyPopup
{
	// Token: 0x02004654 RID: 18004
	[NullableContext(1)]
	[Nullable(0)]
	public class IComposePopupGridItemData
	{
		// Token: 0x17005B34 RID: 23348
		// (get) Token: 0x0602D46E RID: 185454 RVA: 0x00CAD010 File Offset: 0x00CAB210
		// (set) Token: 0x0602D46F RID: 185455 RVA: 0x00CAD018 File Offset: 0x00CAB218
		public ISelectedData Item { get; set; }

		// Token: 0x17005B35 RID: 23349
		// (get) Token: 0x0602D470 RID: 185456 RVA: 0x00CAD021 File Offset: 0x00CAB221
		// (set) Token: 0x0602D471 RID: 185457 RVA: 0x00CAD029 File Offset: 0x00CAB229
		public EGridState State { get; set; }

		// Token: 0x17005B36 RID: 23350
		// (get) Token: 0x0602D472 RID: 185458 RVA: 0x00CAD032 File Offset: 0x00CAB232
		// (set) Token: 0x0602D473 RID: 185459 RVA: 0x00CAD03A File Offset: 0x00CAB23A
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

		// Token: 0x17005B37 RID: 23351
		// (get) Token: 0x0602D474 RID: 185460 RVA: 0x00CAD043 File Offset: 0x00CAB243
		// (set) Token: 0x0602D475 RID: 185461 RVA: 0x00CAD04B File Offset: 0x00CAB24B
		public int? UsedCount { get; set; }
	}
}
