using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D85 RID: 15749
	[NullableContext(2)]
	public interface IRoguelikeAchieveViewInfo
	{
		// Token: 0x17005255 RID: 21077
		// (get) Token: 0x0602846D RID: 164973
		// (set) Token: 0x0602846E RID: 164974
		ERoguelikeAchieveViewMode Mode { get; set; }

		// Token: 0x17005256 RID: 21078
		// (get) Token: 0x0602846F RID: 164975
		// (set) Token: 0x06028470 RID: 164976
		RogueArchiveInfoData TempRecordInfo { get; set; }
	}
}
