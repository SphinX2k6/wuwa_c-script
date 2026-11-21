using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000BC RID: 188
[NullableContext(1)]
public interface ILoadModeHandler
{
	// Token: 0x06000615 RID: 1557
	void EnterMode(UObject worldContext);

	// Token: 0x06000616 RID: 1558
	void ExitMode(UObject worldContext);
}
