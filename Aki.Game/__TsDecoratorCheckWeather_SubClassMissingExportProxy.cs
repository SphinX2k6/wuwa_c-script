using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035BD RID: 13757
public class __TsDecoratorCheckWeather_SubClassMissingExportProxy : __TsDecoratorCheckWeather_InheritProxy
{
	// Token: 0x0601E0C5 RID: 123077 RVA: 0x0087EF80 File Offset: 0x0087D180
	[NullableContext(1)]
	protected __TsDecoratorCheckWeather_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckWeather.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E0C6 RID: 123078 RVA: 0x0087EFB3 File Offset: 0x0087D1B3
	protected __TsDecoratorCheckWeather_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
