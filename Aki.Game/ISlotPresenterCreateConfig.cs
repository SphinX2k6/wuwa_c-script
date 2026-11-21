using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020010D0 RID: 4304
[NullableContext(1)]
[Nullable(0)]
public class ISlotPresenterCreateConfig
{
	// Token: 0x04006342 RID: 25410
	[Nullable(new byte[]
	{
		1,
		2
	})]
	public Func<int, UUIItem> GetItem;

	// Token: 0x04006343 RID: 25411
	public IReadOnlyList<int> SlotKeys = new List<int>();

	// Token: 0x04006344 RID: 25412
	public int DragRoleItemKey;

	// Token: 0x04006345 RID: 25413
	public Action<int> OnAddRole;

	// Token: 0x04006346 RID: 25414
	public Action<int, int, int, int> ExchangeCallback;

	// Token: 0x04006347 RID: 25415
	public IFormationProvider Provider;
}
