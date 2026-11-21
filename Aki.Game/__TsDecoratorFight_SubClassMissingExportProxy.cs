using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B3A RID: 11066
public class __TsDecoratorFight_SubClassMissingExportProxy : __TsDecoratorFight_InheritProxy
{
	// Token: 0x0601BE01 RID: 114177 RVA: 0x008A72C4 File Offset: 0x008A54C4
	[NullableContext(1)]
	protected __TsDecoratorFight_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorFight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BE02 RID: 114178 RVA: 0x008A72F7 File Offset: 0x008A54F7
	protected __TsDecoratorFight_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
