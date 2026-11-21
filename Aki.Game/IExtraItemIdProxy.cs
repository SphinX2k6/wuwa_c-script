using System;
using System.Runtime.CompilerServices;

// Token: 0x02001E7A RID: 7802
[NullableContext(2)]
public interface IExtraItemIdProxy
{
	// Token: 0x0601349E RID: 79006
	int GetExtraItemId();

	// Token: 0x0601349F RID: 79007
	int? GetExtraItemIdReplaceOverride();

	// Token: 0x060134A0 RID: 79008
	void SetExtraItemId(int itemId, Action<bool> callback = null);

	// Token: 0x060134A1 RID: 79009
	void ApplyServerSnapshot(int itemId);
}
