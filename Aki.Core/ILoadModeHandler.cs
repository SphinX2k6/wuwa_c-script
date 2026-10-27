using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000BA RID: 186
[NullableContext(1)]
public interface ILoadModeHandler
{
	// Token: 0x060005D4 RID: 1492
	void EnterMode(UObject worldContext);

	// Token: 0x060005D5 RID: 1493
	void ExitMode(UObject worldContext);
}
