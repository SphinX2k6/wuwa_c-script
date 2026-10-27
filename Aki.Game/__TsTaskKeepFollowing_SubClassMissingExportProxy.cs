using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003601 RID: 13825
public class __TsTaskKeepFollowing_SubClassMissingExportProxy : __TsTaskKeepFollowing_InheritProxy
{
	// Token: 0x0601E174 RID: 123252 RVA: 0x00880730 File Offset: 0x0087E930
	[NullableContext(1)]
	protected __TsTaskKeepFollowing_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskKeepFollowing.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E175 RID: 123253 RVA: 0x00880763 File Offset: 0x0087E963
	protected __TsTaskKeepFollowing_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
