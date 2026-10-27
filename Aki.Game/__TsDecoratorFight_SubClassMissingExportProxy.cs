using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035C5 RID: 13765
public class __TsDecoratorFight_SubClassMissingExportProxy : __TsDecoratorFight_InheritProxy
{
	// Token: 0x0601E0D9 RID: 123097 RVA: 0x0087F230 File Offset: 0x0087D430
	[NullableContext(1)]
	protected __TsDecoratorFight_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorFight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E0DA RID: 123098 RVA: 0x0087F263 File Offset: 0x0087D463
	protected __TsDecoratorFight_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
