using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038A1 RID: 14497
public class __KscBpDataBase_SubClassMissingExportProxy : __KscBpDataBase_InheritProxy
{
	// Token: 0x0601EA45 RID: 125509 RVA: 0x00895648 File Offset: 0x00893848
	[NullableContext(1)]
	protected __KscBpDataBase_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(KscBpDataBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA46 RID: 125510 RVA: 0x0089567B File Offset: 0x0089387B
	protected __KscBpDataBase_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
