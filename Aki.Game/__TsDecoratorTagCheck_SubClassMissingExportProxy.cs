using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035E1 RID: 13793
public class __TsDecoratorTagCheck_SubClassMissingExportProxy : __TsDecoratorTagCheck_InheritProxy
{
	// Token: 0x0601E11F RID: 123167 RVA: 0x0087FB98 File Offset: 0x0087DD98
	[NullableContext(1)]
	protected __TsDecoratorTagCheck_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorTagCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E120 RID: 123168 RVA: 0x0087FBCB File Offset: 0x0087DDCB
	protected __TsDecoratorTagCheck_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
