using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B76 RID: 11126
public class __TsTaskKeepFollowing_SubClassMissingExportProxy : __TsTaskKeepFollowing_InheritProxy
{
	// Token: 0x0601BE9C RID: 114332 RVA: 0x008A87C4 File Offset: 0x008A69C4
	[NullableContext(1)]
	protected __TsTaskKeepFollowing_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskKeepFollowing.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BE9D RID: 114333 RVA: 0x008A87F7 File Offset: 0x008A69F7
	protected __TsTaskKeepFollowing_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
