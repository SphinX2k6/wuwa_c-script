using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B02 RID: 11010
public class __TsDecoratorTimePeriodCheck_SubClassMissingExportProxy : __TsDecoratorTimePeriodCheck_InheritProxy
{
	// Token: 0x0601BD73 RID: 114035 RVA: 0x008A5F88 File Offset: 0x008A4188
	[NullableContext(1)]
	protected __TsDecoratorTimePeriodCheck_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorTimePeriodCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BD74 RID: 114036 RVA: 0x008A5FBB File Offset: 0x008A41BB
	protected __TsDecoratorTimePeriodCheck_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
