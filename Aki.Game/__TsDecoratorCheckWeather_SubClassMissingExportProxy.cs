using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B32 RID: 11058
public class __TsDecoratorCheckWeather_SubClassMissingExportProxy : __TsDecoratorCheckWeather_InheritProxy
{
	// Token: 0x0601BDED RID: 114157 RVA: 0x008A7014 File Offset: 0x008A5214
	[NullableContext(1)]
	protected __TsDecoratorCheckWeather_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckWeather.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BDEE RID: 114158 RVA: 0x008A7047 File Offset: 0x008A5247
	protected __TsDecoratorCheckWeather_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
