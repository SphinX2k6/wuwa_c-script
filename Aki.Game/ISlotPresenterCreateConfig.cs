using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001C11 RID: 7185
[NullableContext(1)]
[Nullable(0)]
public class ISlotPresenterCreateConfig
{
	// Token: 0x04006270 RID: 25200
	[Nullable(new byte[]
	{
		1,
		2
	})]
	public Func<int, UUIItem> GetItem;

	// Token: 0x04006271 RID: 25201
	public IReadOnlyList<int> SlotKeys = new List<int>();

	// Token: 0x04006272 RID: 25202
	public int DragRoleItemKey;

	// Token: 0x04006273 RID: 25203
	public Action<int> OnAddRole;

	// Token: 0x04006274 RID: 25204
	public Action<int, int, int, int> ExchangeCallback;

	// Token: 0x04006275 RID: 25205
	public IFormationProvider Provider;
}
