using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B0E RID: 11022
public class __TsDecoratorBlackboard_SubClassMissingExportProxy : __TsDecoratorBlackboard_InheritProxy
{
	// Token: 0x0601BD91 RID: 114065 RVA: 0x008A6390 File Offset: 0x008A4590
	[NullableContext(1)]
	protected __TsDecoratorBlackboard_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboard.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BD92 RID: 114066 RVA: 0x008A63C3 File Offset: 0x008A45C3
	protected __TsDecoratorBlackboard_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
