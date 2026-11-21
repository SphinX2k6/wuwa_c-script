using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F47 RID: 12103
public class __WorldFunctionLibrary_InheritProxy : WorldFunctionLibrary
{
	// Token: 0x0601CAF9 RID: 117497 RVA: 0x008C11D4 File Offset: 0x008BF3D4
	[NullableContext(1)]
	public __WorldFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WorldFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CAFA RID: 117498 RVA: 0x008C1207 File Offset: 0x008BF407
	protected __WorldFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
