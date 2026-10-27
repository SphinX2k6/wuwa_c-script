using System;
using System.Runtime.CompilerServices;

// Token: 0x02001C00 RID: 7168
[NullableContext(2)]
[Nullable(0)]
public class IFormationEditViewData
{
	// Token: 0x040061E0 RID: 25056
	public int? InitialFormationId;

	// Token: 0x040061E1 RID: 25057
	public Func<int, bool> SwitchFormationCallback;

	// Token: 0x040061E2 RID: 25058
	public Action<int> RenameFormationCallback;

	// Token: 0x040061E3 RID: 25059
	public Action CloseCallback;

	// Token: 0x040061E4 RID: 25060
	public Action ConfirmCallback;

	// Token: 0x040061E5 RID: 25061
	public Action<int> QuickSelectConfirmCallback;
}
