using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003669 RID: 13929
public class __TsTaskDestroySelf_SubClassMissingExportProxy : __TsTaskDestroySelf_InheritProxy
{
	// Token: 0x0601E2A6 RID: 123558 RVA: 0x00883390 File Offset: 0x00881590
	[NullableContext(1)]
	protected __TsTaskDestroySelf_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskDestroySelf.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E2A7 RID: 123559 RVA: 0x008833C3 File Offset: 0x008815C3
	protected __TsTaskDestroySelf_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
