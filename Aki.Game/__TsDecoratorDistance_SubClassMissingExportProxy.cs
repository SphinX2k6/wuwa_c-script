using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035C3 RID: 13763
public class __TsDecoratorDistance_SubClassMissingExportProxy : __TsDecoratorDistance_InheritProxy
{
	// Token: 0x0601E0D4 RID: 123092 RVA: 0x0087F184 File Offset: 0x0087D384
	[NullableContext(1)]
	protected __TsDecoratorDistance_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorDistance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E0D5 RID: 123093 RVA: 0x0087F1B7 File Offset: 0x0087D3B7
	protected __TsDecoratorDistance_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
