using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C61 RID: 19553
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiHoverTipsDescInfoC : IBattleUiHoverTipsDescInfoC
	{
		// Token: 0x170061B3 RID: 25011
		// (get) Token: 0x06030C9F RID: 199839 RVA: 0x00D9ACFD File Offset: 0x00D98EFD
		// (set) Token: 0x06030CA0 RID: 199840 RVA: 0x00D9AD05 File Offset: 0x00D98F05
		[Nullable(2)]
		public string TitleKey { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170061B4 RID: 25012
		// (get) Token: 0x06030CA1 RID: 199841 RVA: 0x00D9AD0E File Offset: 0x00D98F0E
		// (set) Token: 0x06030CA2 RID: 199842 RVA: 0x00D9AD16 File Offset: 0x00D98F16
		public string DescKey { get; set; }
	}
}
