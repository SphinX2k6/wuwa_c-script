using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002BCC RID: 11212
public class __TsTaskBlackBoardSetString_SubClassMissingExportProxy : __TsTaskBlackBoardSetString_InheritProxy
{
	// Token: 0x0601BF8E RID: 114574 RVA: 0x008AA7C4 File Offset: 0x008A89C4
	[NullableContext(1)]
	protected __TsTaskBlackBoardSetString_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskBlackBoardSetString.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BF8F RID: 114575 RVA: 0x008AA7F7 File Offset: 0x008A89F7
	protected __TsTaskBlackBoardSetString_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
