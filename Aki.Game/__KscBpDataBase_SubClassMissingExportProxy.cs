using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E1A RID: 11802
public class __KscBpDataBase_SubClassMissingExportProxy : __KscBpDataBase_InheritProxy
{
	// Token: 0x0601C720 RID: 116512 RVA: 0x008BABC0 File Offset: 0x008B8DC0
	[NullableContext(1)]
	protected __KscBpDataBase_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(KscBpDataBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C721 RID: 116513 RVA: 0x008BABF3 File Offset: 0x008B8DF3
	protected __KscBpDataBase_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
