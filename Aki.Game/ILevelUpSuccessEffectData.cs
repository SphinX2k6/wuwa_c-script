using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001E03 RID: 7683
[NullableContext(2)]
public interface ILevelUpSuccessEffectData
{
	// Token: 0x17001CF1 RID: 7409
	// (get) Token: 0x06012FB2 RID: 77746
	// (set) Token: 0x06012FB3 RID: 77747
	string Title { get; set; }

	// Token: 0x17001CF2 RID: 7410
	// (get) Token: 0x06012FB4 RID: 77748
	// (set) Token: 0x06012FB5 RID: 77749
	string AudioId { get; set; }

	// Token: 0x17001CF3 RID: 7411
	// (get) Token: 0x06012FB6 RID: 77750
	// (set) Token: 0x06012FB7 RID: 77751
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

	// Token: 0x17001CF4 RID: 7412
	// (get) Token: 0x06012FB8 RID: 77752
	// (set) Token: 0x06012FB9 RID: 77753
	string ClickText { get; set; }

	// Token: 0x17001CF5 RID: 7413
	// (get) Token: 0x06012FBA RID: 77754
	// (set) Token: 0x06012FBB RID: 77755
	Action ClickFunction { get; set; }
}
