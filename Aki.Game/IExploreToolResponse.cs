using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020021DF RID: 8671
public interface IExploreToolResponse
{
	// Token: 0x1700155D RID: 5469
	// (get) Token: 0x06010E13 RID: 69139
	// (set) Token: 0x06010E14 RID: 69140
	ERouletteExploreId PhantomSkillId { get; set; }

	// Token: 0x1700155E RID: 5470
	// (get) Token: 0x06010E15 RID: 69141
	// (set) Token: 0x06010E16 RID: 69142
	[Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})]
	OneOf<AddTemporaryTeleportResponse, AddTreasureBoxSlotResponse, CheckUseSoundBoxSkillResponse, UseSoundBoxSkillResponse> Content { [return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})] set; }
}
