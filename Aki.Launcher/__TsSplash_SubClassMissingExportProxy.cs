using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02000018 RID: 24
public class __TsSplash_SubClassMissingExportProxy : __TsSplash_InheritProxy
{
	// Token: 0x060000C0 RID: 192 RVA: 0x000075A0 File Offset: 0x000057A0
	[NullableContext(1)]
	protected __TsSplash_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSplash.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x000075D3 File Offset: 0x000057D3
	protected __TsSplash_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
