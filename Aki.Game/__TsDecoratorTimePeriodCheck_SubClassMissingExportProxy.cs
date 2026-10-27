using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200358D RID: 13709
public class __TsDecoratorTimePeriodCheck_SubClassMissingExportProxy : __TsDecoratorTimePeriodCheck_InheritProxy
{
	// Token: 0x0601E04B RID: 122955 RVA: 0x0087DEF4 File Offset: 0x0087C0F4
	[NullableContext(1)]
	protected __TsDecoratorTimePeriodCheck_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorTimePeriodCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E04C RID: 122956 RVA: 0x0087DF27 File Offset: 0x0087C127
	protected __TsDecoratorTimePeriodCheck_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
