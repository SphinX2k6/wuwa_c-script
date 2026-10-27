using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001B15 RID: 6933
[NullableContext(1)]
[Nullable(0)]
public abstract class FloroRanchEntityDataBaseComponent : FloroRanchEntityComponentBase
{
	// Token: 0x0600CDB5 RID: 52661
	public abstract void RefreshEntityData(FloroRanchPlayUnit entityData);

	// Token: 0x0600CDB6 RID: 52662
	public abstract string Info();

	// Token: 0x0600CDB7 RID: 52663
	public abstract string DebugInfo();
}
