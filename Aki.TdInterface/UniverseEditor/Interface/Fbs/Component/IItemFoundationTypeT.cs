using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A1E RID: 23070
	public class IItemFoundationTypeT
	{
		// Token: 0x1700A7B5 RID: 42933
		// (get) Token: 0x06025B0C RID: 154380 RVA: 0x0052AB92 File Offset: 0x00528D92
		// (set) Token: 0x06025B0D RID: 154381 RVA: 0x0052AB9A File Offset: 0x00528D9A
		public EItemFoundation Type { get; set; }

		// Token: 0x06025B0E RID: 154382 RVA: 0x0052ABA3 File Offset: 0x00528DA3
		public IItemFoundationTypeT()
		{
			this.Type = EItemFoundation.CategoryMatching;
		}
	}
}
