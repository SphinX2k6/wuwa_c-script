using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C7F RID: 23679
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiHoverTipsC : IBattleUiHoverTipsC
	{
		// Token: 0x17008DDD RID: 36317
		// (get) Token: 0x0603BD48 RID: 245064 RVA: 0x00E4A757 File Offset: 0x00E48957
		// (set) Token: 0x0603BD49 RID: 245065 RVA: 0x00E4A75F File Offset: 0x00E4895F
		public string TitleKey { get; set; }

		// Token: 0x17008DDE RID: 36318
		// (get) Token: 0x0603BD4A RID: 245066 RVA: 0x00E4A768 File Offset: 0x00E48968
		// (set) Token: 0x0603BD4B RID: 245067 RVA: 0x00E4A770 File Offset: 0x00E48970
		public List<IBattleUiHoverTipsDescInfoC> DescInfoList { get; set; }
	}
}
