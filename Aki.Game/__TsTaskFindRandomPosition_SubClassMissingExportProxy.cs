using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200367B RID: 13947
public class __TsTaskFindRandomPosition_SubClassMissingExportProxy : __TsTaskFindRandomPosition_InheritProxy
{
	// Token: 0x0601E2D4 RID: 123604 RVA: 0x008839AC File Offset: 0x00881BAC
	[NullableContext(1)]
	protected __TsTaskFindRandomPosition_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskFindRandomPosition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E2D5 RID: 123605 RVA: 0x008839DF File Offset: 0x00881BDF
	protected __TsTaskFindRandomPosition_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
