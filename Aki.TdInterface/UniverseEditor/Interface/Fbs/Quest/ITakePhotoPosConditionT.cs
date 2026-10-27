using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041AC RID: 16812
	public class ITakePhotoPosConditionT
	{
		// Token: 0x1700773D RID: 30525
		// (get) Token: 0x06018C0C RID: 101388 RVA: 0x00390637 File Offset: 0x0038E837
		// (set) Token: 0x06018C0D RID: 101389 RVA: 0x0039063F File Offset: 0x0038E83F
		public int RangeEntity { get; set; }

		// Token: 0x1700773E RID: 30526
		// (get) Token: 0x06018C0E RID: 101390 RVA: 0x00390648 File Offset: 0x0038E848
		// (set) Token: 0x06018C0F RID: 101391 RVA: 0x00390650 File Offset: 0x0038E850
		public string TidDescription { get; set; }

		// Token: 0x06018C10 RID: 101392 RVA: 0x00390659 File Offset: 0x0038E859
		public ITakePhotoPosConditionT()
		{
			this.RangeEntity = 0;
			this.TidDescription = null;
		}
	}
}
