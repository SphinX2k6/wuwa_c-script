using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200723B RID: 29243
	public class IMontageRegisteredT
	{
		// Token: 0x1700D636 RID: 54838
		// (get) Token: 0x06032E9C RID: 208540 RVA: 0x006DFBB7 File Offset: 0x006DDDB7
		// (set) Token: 0x06032E9D RID: 208541 RVA: 0x006DFBBF File Offset: 0x006DDDBF
		public EMontageConfigType Type { get; set; }

		// Token: 0x1700D637 RID: 54839
		// (get) Token: 0x06032E9E RID: 208542 RVA: 0x006DFBC8 File Offset: 0x006DDDC8
		// (set) Token: 0x06032E9F RID: 208543 RVA: 0x006DFBD0 File Offset: 0x006DDDD0
		public IMontageIdT MontageId { get; set; }

		// Token: 0x06032EA0 RID: 208544 RVA: 0x006DFBD9 File Offset: 0x006DDDD9
		public IMontageRegisteredT()
		{
			this.Type = EMontageConfigType.Asset;
			this.MontageId = null;
		}
	}
}
