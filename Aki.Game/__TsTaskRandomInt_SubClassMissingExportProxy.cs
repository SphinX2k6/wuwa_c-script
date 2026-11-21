using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C1E RID: 11294
public class __TsTaskRandomInt_SubClassMissingExportProxy : __TsTaskRandomInt_InheritProxy
{
	// Token: 0x0601C06E RID: 114798 RVA: 0x008AC5E4 File Offset: 0x008AA7E4
	[NullableContext(1)]
	protected __TsTaskRandomInt_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskRandomInt.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C06F RID: 114799 RVA: 0x008AC617 File Offset: 0x008AA817
	protected __TsTaskRandomInt_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
