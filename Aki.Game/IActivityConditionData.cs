using System;
using System.Runtime.CompilerServices;

// Token: 0x0200056C RID: 1388
[NullableContext(1)]
public interface IActivityConditionData
{
	// Token: 0x17000979 RID: 2425
	// (get) Token: 0x060042EC RID: 17132
	// (set) Token: 0x060042ED RID: 17133
	int ConditionId { get; set; }

	// Token: 0x1700097A RID: 2426
	// (get) Token: 0x060042EE RID: 17134
	// (set) Token: 0x060042EF RID: 17135
	string ConditionTextId { get; set; }

	// Token: 0x1700097B RID: 2427
	// (get) Token: 0x060042F0 RID: 17136
	// (set) Token: 0x060042F1 RID: 17137
	bool IsFinished { get; set; }

	// Token: 0x1700097C RID: 2428
	// (get) Token: 0x060042F2 RID: 17138
	// (set) Token: 0x060042F3 RID: 17139
	int AccessId { get; set; }

	// Token: 0x1700097D RID: 2429
	// (get) Token: 0x060042F4 RID: 17140
	// (set) Token: 0x060042F5 RID: 17141
	int AccessType { get; set; }

	// Token: 0x1700097E RID: 2430
	// (get) Token: 0x060042F6 RID: 17142
	// (set) Token: 0x060042F7 RID: 17143
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

	// Token: 0x1700097F RID: 2431
	// (get) Token: 0x060042F8 RID: 17144
	// (set) Token: 0x060042F9 RID: 17145
	[Nullable(2)]
	Action OnJump { [NullableContext(2)] get; [NullableContext(2)] set; }
}
