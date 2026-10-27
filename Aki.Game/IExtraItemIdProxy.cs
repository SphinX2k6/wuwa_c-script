using System;
using System.Runtime.CompilerServices;

// Token: 0x020028FF RID: 10495
[NullableContext(2)]
public interface IExtraItemIdProxy
{
	// Token: 0x06015A9A RID: 88730
	int GetExtraItemId();

	// Token: 0x06015A9B RID: 88731
	int? GetExtraItemIdReplaceOverride();

	// Token: 0x06015A9C RID: 88732
	void SetExtraItemId(int itemId, Action<bool> callback = null);

	// Token: 0x06015A9D RID: 88733
	void ApplyServerSnapshot(int itemId);
}
