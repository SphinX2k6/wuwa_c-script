using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B4E RID: 11086
public class __TsDecoratorPlayerIdle_SubClassMissingExportProxy : __TsDecoratorPlayerIdle_InheritProxy
{
	// Token: 0x0601BE33 RID: 114227 RVA: 0x008A797C File Offset: 0x008A5B7C
	[NullableContext(1)]
	protected __TsDecoratorPlayerIdle_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorPlayerIdle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BE34 RID: 114228 RVA: 0x008A79AF File Offset: 0x008A5BAF
	protected __TsDecoratorPlayerIdle_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
