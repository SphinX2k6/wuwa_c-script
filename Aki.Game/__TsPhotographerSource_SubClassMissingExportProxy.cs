using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038C1 RID: 14529
public class __TsPhotographerSource_SubClassMissingExportProxy : __TsPhotographerSource_InheritProxy
{
	// Token: 0x0601EAC6 RID: 125638 RVA: 0x00896F30 File Offset: 0x00895130
	[NullableContext(1)]
	protected __TsPhotographerSource_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsPhotographerSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EAC7 RID: 125639 RVA: 0x00896F63 File Offset: 0x00895163
	protected __TsPhotographerSource_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
