using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200366B RID: 13931
public class __TsTaskDoTurn_SubClassMissingExportProxy : __TsTaskDoTurn_InheritProxy
{
	// Token: 0x0601E2AC RID: 123564 RVA: 0x0088346C File Offset: 0x0088166C
	[NullableContext(1)]
	protected __TsTaskDoTurn_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskDoTurn.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E2AD RID: 123565 RVA: 0x0088349F File Offset: 0x0088169F
	protected __TsTaskDoTurn_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
