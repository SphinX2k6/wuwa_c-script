using System;
using System.Runtime.CompilerServices;

// Token: 0x020010B8 RID: 4280
[NullableContext(1)]
public interface IActivityConditionData
{
	// Token: 0x17000959 RID: 2393
	// (get) Token: 0x06006F56 RID: 28502
	// (set) Token: 0x06006F57 RID: 28503
	int ConditionId { get; set; }

	// Token: 0x1700095A RID: 2394
	// (get) Token: 0x06006F58 RID: 28504
	// (set) Token: 0x06006F59 RID: 28505
	string ConditionTextId { get; set; }

	// Token: 0x1700095B RID: 2395
	// (get) Token: 0x06006F5A RID: 28506
	// (set) Token: 0x06006F5B RID: 28507
	bool IsFinished { get; set; }

	// Token: 0x1700095C RID: 2396
	// (get) Token: 0x06006F5C RID: 28508
	// (set) Token: 0x06006F5D RID: 28509
	int AccessId { get; set; }

	// Token: 0x1700095D RID: 2397
	// (get) Token: 0x06006F5E RID: 28510
	// (set) Token: 0x06006F5F RID: 28511
	int AccessType { get; set; }

	// Token: 0x1700095E RID: 2398
	// (get) Token: 0x06006F60 RID: 28512
	// (set) Token: 0x06006F61 RID: 28513
	[Nullable(new byte[]
	{
		2,
		1
	})]
	object[] TextParam { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x1700095F RID: 2399
	// (get) Token: 0x06006F62 RID: 28514
	// (set) Token: 0x06006F63 RID: 28515
	[Nullable(2)]
	Action OnJump { [NullableContext(2)] get; [NullableContext(2)] set; }
}
