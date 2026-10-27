using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DBD RID: 19901
	[NullableContext(2)]
	[Nullable(0)]
	public class RoguelikeAchieveViewInfo : IRoguelikeAchieveViewInfo
	{
		// Token: 0x17007EA7 RID: 32423
		// (get) Token: 0x06033604 RID: 210436 RVA: 0x00BFF132 File Offset: 0x00BFD332
		// (set) Token: 0x06033605 RID: 210437 RVA: 0x00BFF13A File Offset: 0x00BFD33A
		public ERoguelikeAchieveViewMode Mode { get; set; }

		// Token: 0x17007EA8 RID: 32424
		// (get) Token: 0x06033606 RID: 210438 RVA: 0x00BFF143 File Offset: 0x00BFD343
		// (set) Token: 0x06033607 RID: 210439 RVA: 0x00BFF14B File Offset: 0x00BFD34B
		public RogueArchiveInfoData TempRecordInfo { get; set; }
	}
}
