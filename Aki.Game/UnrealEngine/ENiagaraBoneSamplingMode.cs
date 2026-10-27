using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004462 RID: 17506
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraBoneSamplingMode.ENiagaraBoneSamplingMode")]
	public enum ENiagaraBoneSamplingMode : byte
	{
		// Token: 0x040181D5 RID: 98773
		Random__Filtered_Bones_,
		// Token: 0x040181D6 RID: 98774
		Random__Unfiltered_Bones_,
		// Token: 0x040181D7 RID: 98775
		Random__All_Bones_,
		// Token: 0x040181D8 RID: 98776
		Direct__Filtered_Bones_,
		// Token: 0x040181D9 RID: 98777
		Direct__Unfiltered_Bones_,
		// Token: 0x040181DA RID: 98778
		Direct__All_Bones_,
		// Token: 0x040181DB RID: 98779
		ENiagaraBoneSamplingMode_MAX
	}
}
