using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DBC RID: 19900
	[NullableContext(2)]
	public interface IRoguelikeAchieveViewInfo
	{
		// Token: 0x17007EA5 RID: 32421
		// (get) Token: 0x06033600 RID: 210432
		// (set) Token: 0x06033601 RID: 210433
		ERoguelikeAchieveViewMode Mode { get; set; }

		// Token: 0x17007EA6 RID: 32422
		// (get) Token: 0x06033602 RID: 210434
		// (set) Token: 0x06033603 RID: 210435
		RogueArchiveInfoData TempRecordInfo { get; set; }
	}
}
