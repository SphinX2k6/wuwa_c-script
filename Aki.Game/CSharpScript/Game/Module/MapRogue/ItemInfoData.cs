using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02005630 RID: 22064
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemInfoData : IItemInfoData
	{
		// Token: 0x17008731 RID: 34609
		// (get) Token: 0x060381DE RID: 229854 RVA: 0x00D4B0C7 File Offset: 0x00D492C7
		// (set) Token: 0x060381DF RID: 229855 RVA: 0x00D4B0CF File Offset: 0x00D492CF
		public string TitleId { get; set; } = string.Empty;

		// Token: 0x17008732 RID: 34610
		// (get) Token: 0x060381E0 RID: 229856 RVA: 0x00D4B0D8 File Offset: 0x00D492D8
		// (set) Token: 0x060381E1 RID: 229857 RVA: 0x00D4B0E0 File Offset: 0x00D492E0
		public string Value { get; set; } = string.Empty;

		// Token: 0x17008733 RID: 34611
		// (get) Token: 0x060381E2 RID: 229858 RVA: 0x00D4B0E9 File Offset: 0x00D492E9
		// (set) Token: 0x060381E3 RID: 229859 RVA: 0x00D4B0F1 File Offset: 0x00D492F1
		public bool ValueChangeColor { get; set; }
	}
}
