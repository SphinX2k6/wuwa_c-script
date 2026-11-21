using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020016C3 RID: 5827
public interface IExploreToolResponse
{
	// Token: 0x17001594 RID: 5524
	// (get) Token: 0x0600E2A4 RID: 58020
	// (set) Token: 0x0600E2A5 RID: 58021
	ERouletteExploreId PhantomSkillId { get; set; }

	// Token: 0x17001595 RID: 5525
	// (get) Token: 0x0600E2A6 RID: 58022
	// (set) Token: 0x0600E2A7 RID: 58023
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
