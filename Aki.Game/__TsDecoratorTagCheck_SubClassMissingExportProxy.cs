using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B56 RID: 11094
public class __TsDecoratorTagCheck_SubClassMissingExportProxy : __TsDecoratorTagCheck_InheritProxy
{
	// Token: 0x0601BE47 RID: 114247 RVA: 0x008A7C2C File Offset: 0x008A5E2C
	[NullableContext(1)]
	protected __TsDecoratorTagCheck_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorTagCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BE48 RID: 114248 RVA: 0x008A7C5F File Offset: 0x008A5E5F
	protected __TsDecoratorTagCheck_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
