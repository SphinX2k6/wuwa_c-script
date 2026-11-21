using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EC7 RID: 11975
public class __SceneItemLibrary_InheritProxy : SceneItemLibrary
{
	// Token: 0x0601C8F1 RID: 116977 RVA: 0x008BDBF4 File Offset: 0x008BBDF4
	[NullableContext(1)]
	public __SceneItemLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SceneItemLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8F2 RID: 116978 RVA: 0x008BDC27 File Offset: 0x008BBE27
	protected __SceneItemLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
