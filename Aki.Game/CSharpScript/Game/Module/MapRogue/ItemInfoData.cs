using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004606 RID: 17926
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemInfoData : IItemInfoData
	{
		// Token: 0x17005AF8 RID: 23288
		// (get) Token: 0x0602D0DC RID: 184540 RVA: 0x00C98E0F File Offset: 0x00C9700F
		// (set) Token: 0x0602D0DD RID: 184541 RVA: 0x00C98E17 File Offset: 0x00C97017
		public string TitleId { get; set; } = string.Empty;

		// Token: 0x17005AF9 RID: 23289
		// (get) Token: 0x0602D0DE RID: 184542 RVA: 0x00C98E20 File Offset: 0x00C97020
		// (set) Token: 0x0602D0DF RID: 184543 RVA: 0x00C98E28 File Offset: 0x00C97028
		public string Value { get; set; } = string.Empty;

		// Token: 0x17005AFA RID: 23290
		// (get) Token: 0x0602D0E0 RID: 184544 RVA: 0x00C98E31 File Offset: 0x00C97031
		// (set) Token: 0x0602D0E1 RID: 184545 RVA: 0x00C98E39 File Offset: 0x00C97039
		public bool ValueChangeColor { get; set; }
	}
}
