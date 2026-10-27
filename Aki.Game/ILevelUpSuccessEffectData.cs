using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002888 RID: 10376
[NullableContext(2)]
public interface ILevelUpSuccessEffectData
{
	// Token: 0x17001C99 RID: 7321
	// (get) Token: 0x060155B4 RID: 87476
	// (set) Token: 0x060155B5 RID: 87477
	string Title { get; set; }

	// Token: 0x17001C9A RID: 7322
	// (get) Token: 0x060155B6 RID: 87478
	// (set) Token: 0x060155B7 RID: 87479
	string AudioId { get; set; }

	// Token: 0x17001C9B RID: 7323
	// (get) Token: 0x060155B8 RID: 87480
	// (set) Token: 0x060155B9 RID: 87481
	[Nullable(new byte[]
	{
		2,
		1
	})]
	List<SingleText> TextList { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17001C9C RID: 7324
	// (get) Token: 0x060155BA RID: 87482
	// (set) Token: 0x060155BB RID: 87483
	string ClickText { get; set; }

	// Token: 0x17001C9D RID: 7325
	// (get) Token: 0x060155BC RID: 87484
	// (set) Token: 0x060155BD RID: 87485
	Action ClickFunction { get; set; }
}
