using System;
using System.Runtime.CompilerServices;

// Token: 0x0200135C RID: 4956
[NullableContext(2)]
[Nullable(0)]
public class RewardTabData
{
	// Token: 0x04003D92 RID: 15762
	public string NameTextId;

	// Token: 0x04003D93 RID: 15763
	public int Index = -1;

	// Token: 0x04003D94 RID: 15764
	public Action<int> ClickedCallback;

	// Token: 0x04003D95 RID: 15765
	public Func<int, bool> RefreshRedDot;
}
