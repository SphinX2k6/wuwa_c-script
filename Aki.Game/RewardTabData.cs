using System;
using System.Runtime.CompilerServices;

// Token: 0x02000810 RID: 2064
[NullableContext(2)]
[Nullable(0)]
public class RewardTabData
{
	// Token: 0x04003E2A RID: 15914
	public string NameTextId;

	// Token: 0x04003E2B RID: 15915
	public int Index = -1;

	// Token: 0x04003E2C RID: 15916
	public Action<int> ClickedCallback;

	// Token: 0x04003E2D RID: 15917
	public Func<int, bool> RefreshRedDot;
}
