using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039CC RID: 14796
public class __WorldFunctionLibrary_InheritProxy : WorldFunctionLibrary
{
	// Token: 0x0601EF17 RID: 126743 RVA: 0x008A35FC File Offset: 0x008A17FC
	[NullableContext(1)]
	public __WorldFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WorldFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EF18 RID: 126744 RVA: 0x008A362F File Offset: 0x008A182F
	protected __WorldFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
