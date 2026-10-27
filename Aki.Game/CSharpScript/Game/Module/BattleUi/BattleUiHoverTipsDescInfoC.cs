using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C81 RID: 23681
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiHoverTipsDescInfoC : IBattleUiHoverTipsDescInfoC
	{
		// Token: 0x17008DE1 RID: 36321
		// (get) Token: 0x0603BD51 RID: 245073 RVA: 0x00E4A781 File Offset: 0x00E48981
		// (set) Token: 0x0603BD52 RID: 245074 RVA: 0x00E4A789 File Offset: 0x00E48989
		[Nullable(2)]
		public string TitleKey { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008DE2 RID: 36322
		// (get) Token: 0x0603BD53 RID: 245075 RVA: 0x00E4A792 File Offset: 0x00E48992
		// (set) Token: 0x0603BD54 RID: 245076 RVA: 0x00E4A79A File Offset: 0x00E4899A
		public string DescKey { get; set; }
	}
}
