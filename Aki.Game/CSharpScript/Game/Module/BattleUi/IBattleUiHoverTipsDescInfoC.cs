using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C60 RID: 19552
	[NullableContext(1)]
	public interface IBattleUiHoverTipsDescInfoC
	{
		// Token: 0x170061B1 RID: 25009
		// (get) Token: 0x06030C9B RID: 199835
		// (set) Token: 0x06030C9C RID: 199836
		[Nullable(2)]
		string TitleKey { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170061B2 RID: 25010
		// (get) Token: 0x06030C9D RID: 199837
		// (set) Token: 0x06030C9E RID: 199838
		string DescKey { get; set; }
	}
}
