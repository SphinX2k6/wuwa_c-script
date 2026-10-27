using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200394B RID: 14667
public class __TsSimpleInteractPoint_SubClassMissingExportProxy : __TsSimpleInteractPoint_InheritProxy
{
	// Token: 0x0601EC4B RID: 126027 RVA: 0x0089A1AC File Offset: 0x008983AC
	[NullableContext(1)]
	protected __TsSimpleInteractPoint_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC4C RID: 126028 RVA: 0x0089A1DF File Offset: 0x008983DF
	protected __TsSimpleInteractPoint_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
