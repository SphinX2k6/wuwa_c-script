using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B2C RID: 11052
public class __TsDecoratorCheckMoveStuck_SubClassMissingExportProxy : __TsDecoratorCheckMoveStuck_InheritProxy
{
	// Token: 0x0601BDDE RID: 114142 RVA: 0x008A6E10 File Offset: 0x008A5010
	[NullableContext(1)]
	protected __TsDecoratorCheckMoveStuck_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckMoveStuck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BDDF RID: 114143 RVA: 0x008A6E43 File Offset: 0x008A5043
	protected __TsDecoratorCheckMoveStuck_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
