using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A7D RID: 31357
	public class ITalkCommonEffectT
	{
		// Token: 0x1700E5AE RID: 58798
		// (get) Token: 0x06037453 RID: 226387 RVA: 0x0076171D File Offset: 0x0075F91D
		// (set) Token: 0x06037454 RID: 226388 RVA: 0x00761725 File Offset: 0x0075F925
		public ETalkEffectType Type { get; set; }

		// Token: 0x1700E5AF RID: 58799
		// (get) Token: 0x06037455 RID: 226389 RVA: 0x0076172E File Offset: 0x0075F92E
		// (set) Token: 0x06037456 RID: 226390 RVA: 0x00761736 File Offset: 0x0075F936
		public string Path { get; set; }

		// Token: 0x1700E5B0 RID: 58800
		// (get) Token: 0x06037457 RID: 226391 RVA: 0x0076173F File Offset: 0x0075F93F
		// (set) Token: 0x06037458 RID: 226392 RVA: 0x00761747 File Offset: 0x0075F947
		public IAbsolutePos2T Pos2 { get; set; }

		// Token: 0x1700E5B1 RID: 58801
		// (get) Token: 0x06037459 RID: 226393 RVA: 0x00761750 File Offset: 0x0075F950
		// (set) Token: 0x0603745A RID: 226394 RVA: 0x00761758 File Offset: 0x0075F958
		public bool StartFromLoop { get; set; }

		// Token: 0x1700E5B2 RID: 58802
		// (get) Token: 0x0603745B RID: 226395 RVA: 0x00761761 File Offset: 0x0075F961
		// (set) Token: 0x0603745C RID: 226396 RVA: 0x00761769 File Offset: 0x0075F969
		public byte NullMask { get; set; }

		// Token: 0x0603745D RID: 226397 RVA: 0x00761772 File Offset: 0x0075F972
		public ITalkCommonEffectT()
		{
			this.Type = ETalkEffectType.Effect;
			this.Path = null;
			this.Pos2 = null;
			this.StartFromLoop = false;
			this.NullMask = 0;
		}
	}
}
