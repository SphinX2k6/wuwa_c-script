using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035D9 RID: 13785
public class __TsDecoratorPlayerIdle_SubClassMissingExportProxy : __TsDecoratorPlayerIdle_InheritProxy
{
	// Token: 0x0601E10B RID: 123147 RVA: 0x0087F8E8 File Offset: 0x0087DAE8
	[NullableContext(1)]
	protected __TsDecoratorPlayerIdle_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorPlayerIdle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E10C RID: 123148 RVA: 0x0087F91B File Offset: 0x0087DB1B
	protected __TsDecoratorPlayerIdle_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
