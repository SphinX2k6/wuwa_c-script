using System;
using System.Runtime.CompilerServices;

// Token: 0x020010BF RID: 4287
[NullableContext(2)]
[Nullable(0)]
public class IFormationEditViewData
{
	// Token: 0x040062B2 RID: 25266
	public int? InitialFormationId;

	// Token: 0x040062B3 RID: 25267
	public Func<int, bool> SwitchFormationCallback;

	// Token: 0x040062B4 RID: 25268
	public Action<int> RenameFormationCallback;

	// Token: 0x040062B5 RID: 25269
	public Action CloseCallback;

	// Token: 0x040062B6 RID: 25270
	public Action ConfirmCallback;

	// Token: 0x040062B7 RID: 25271
	public Action<int> QuickSelectConfirmCallback;
}
