using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035CD RID: 13773
public class __TsDecoratorInGazeAwareness_SubClassMissingExportProxy : __TsDecoratorInGazeAwareness_InheritProxy
{
	// Token: 0x0601E0ED RID: 123117 RVA: 0x0087F4E0 File Offset: 0x0087D6E0
	[NullableContext(1)]
	protected __TsDecoratorInGazeAwareness_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorInGazeAwareness.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E0EE RID: 123118 RVA: 0x0087F513 File Offset: 0x0087D713
	protected __TsDecoratorInGazeAwareness_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
