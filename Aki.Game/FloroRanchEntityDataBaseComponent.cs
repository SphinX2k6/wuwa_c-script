using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000FD4 RID: 4052
[NullableContext(1)]
[Nullable(0)]
public abstract class FloroRanchEntityDataBaseComponent : FloroRanchEntityComponentBase
{
	// Token: 0x0600A1C6 RID: 41414
	public abstract void RefreshEntityData(FloroRanchPlayUnit entityData);

	// Token: 0x0600A1C7 RID: 41415
	public abstract string Info();

	// Token: 0x0600A1C8 RID: 41416
	public abstract string DebugInfo();
}
