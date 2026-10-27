using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item
{
	// Token: 0x020066DC RID: 26332
	public class DropCatchLevelItemData : IDropCatchLevelItemData
	{
		// Token: 0x17009648 RID: 38472
		// (get) Token: 0x06041D28 RID: 269608 RVA: 0x00FF6B50 File Offset: 0x00FF4D50
		// (set) Token: 0x06041D29 RID: 269609 RVA: 0x00FF6B58 File Offset: 0x00FF4D58
		public int CfgId { get; set; }

		// Token: 0x17009649 RID: 38473
		// (get) Token: 0x06041D2A RID: 269610 RVA: 0x00FF6B61 File Offset: 0x00FF4D61
		// (set) Token: 0x06041D2B RID: 269611 RVA: 0x00FF6B69 File Offset: 0x00FF4D69
		public EDropCatchLevelState? State { get; set; }

		// Token: 0x1700964A RID: 38474
		// (get) Token: 0x06041D2C RID: 269612 RVA: 0x00FF6B72 File Offset: 0x00FF4D72
		// (set) Token: 0x06041D2D RID: 269613 RVA: 0x00FF6B7A File Offset: 0x00FF4D7A
		public bool HasRedPoint { get; set; }
	}
}
