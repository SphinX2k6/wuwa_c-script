using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x0200434B RID: 17227
	[NullableContext(1)]
	[Nullable(0)]
	public class GuqinKeyConfig
	{
		// Token: 0x1700571A RID: 22298
		// (get) Token: 0x0602B836 RID: 178230 RVA: 0x00C3A61C File Offset: 0x00C3881C
		// (set) Token: 0x0602B837 RID: 178231 RVA: 0x00C3A624 File Offset: 0x00C38824
		public string FundamentalToneAudioEvent { get; set; } = "";

		// Token: 0x1700571B RID: 22299
		// (get) Token: 0x0602B838 RID: 178232 RVA: 0x00C3A62D File Offset: 0x00C3882D
		// (set) Token: 0x0602B839 RID: 178233 RVA: 0x00C3A635 File Offset: 0x00C38835
		public string OverToneAudioEvent { get; set; } = "";

		// Token: 0x1700571C RID: 22300
		// (get) Token: 0x0602B83A RID: 178234 RVA: 0x00C3A63E File Offset: 0x00C3883E
		// (set) Token: 0x0602B83B RID: 178235 RVA: 0x00C3A646 File Offset: 0x00C38846
		public string KeyIconPath { get; set; } = "";
	}
}
