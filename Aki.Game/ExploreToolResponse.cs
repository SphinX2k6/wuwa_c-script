using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020021E0 RID: 8672
public class ExploreToolResponse : IExploreToolResponse
{
	// Token: 0x1700155F RID: 5471
	// (get) Token: 0x06010E17 RID: 69143 RVA: 0x0041BFD5 File Offset: 0x0041A1D5
	// (set) Token: 0x06010E18 RID: 69144 RVA: 0x0041BFDD File Offset: 0x0041A1DD
	public ERouletteExploreId PhantomSkillId { get; set; }

	// Token: 0x17001560 RID: 5472
	// (get) Token: 0x06010E19 RID: 69145 RVA: 0x0041BFE6 File Offset: 0x0041A1E6
	// (set) Token: 0x06010E1A RID: 69146 RVA: 0x0041BFEE File Offset: 0x0041A1EE
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

	// Token: 0x06010E1B RID: 69147 RVA: 0x0041BFF8 File Offset: 0x0041A1F8
	public ErrorCode GetErrorCode()
	{
		return this.Content.Match<ErrorCode>((AddTemporaryTeleportResponse t1) => t1.Code, (AddTreasureBoxSlotResponse t2) => t2.Code, (CheckUseSoundBoxSkillResponse t3) => t3.Code, (UseSoundBoxSkillResponse t4) => t4.Code);
	}
}
