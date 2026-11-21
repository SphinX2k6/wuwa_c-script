using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D86 RID: 15750
	[NullableContext(2)]
	[Nullable(0)]
	public class RoguelikeAchieveViewInfo : IRoguelikeAchieveViewInfo
	{
		// Token: 0x17005257 RID: 21079
		// (get) Token: 0x06028471 RID: 164977 RVA: 0x00B48672 File Offset: 0x00B46872
		// (set) Token: 0x06028472 RID: 164978 RVA: 0x00B4867A File Offset: 0x00B4687A
		public ERoguelikeAchieveViewMode Mode { get; set; }

		// Token: 0x17005258 RID: 21080
		// (get) Token: 0x06028473 RID: 164979 RVA: 0x00B48683 File Offset: 0x00B46883
		// (set) Token: 0x06028474 RID: 164980 RVA: 0x00B4868B File Offset: 0x00B4688B
		public RogueArchiveInfoData TempRecordInfo { get; set; }
	}
}
