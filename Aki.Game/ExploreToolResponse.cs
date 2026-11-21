using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020016C4 RID: 5828
public class ExploreToolResponse : IExploreToolResponse
{
	// Token: 0x17001596 RID: 5526
	// (get) Token: 0x0600E2A8 RID: 58024 RVA: 0x004288B5 File Offset: 0x00426AB5
	// (set) Token: 0x0600E2A9 RID: 58025 RVA: 0x004288BD File Offset: 0x00426ABD
	public ERouletteExploreId PhantomSkillId { get; set; }

	// Token: 0x17001597 RID: 5527
	// (get) Token: 0x0600E2AA RID: 58026 RVA: 0x004288C6 File Offset: 0x00426AC6
	// (set) Token: 0x0600E2AB RID: 58027 RVA: 0x004288CE File Offset: 0x00426ACE
	[Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})]
	public OneOf<AddTemporaryTeleportResponse, AddTreasureBoxSlotResponse, CheckUseSoundBoxSkillResponse, UseSoundBoxSkillResponse> Content { [return: Nullable(new byte[]
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

	// Token: 0x0600E2AC RID: 58028 RVA: 0x004288D8 File Offset: 0x00426AD8
	public ErrorCode GetErrorCode()
	{
		return this.Content.Match<ErrorCode>((AddTemporaryTeleportResponse t1) => t1.Code, (AddTreasureBoxSlotResponse t2) => t2.Code, (CheckUseSoundBoxSkillResponse t3) => t3.Code, (UseSoundBoxSkillResponse t4) => t4.Code);
	}
}
