using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200394C RID: 14668
public class __SceneItemLibrary_InheritProxy : SceneItemLibrary
{
	// Token: 0x0601EC4D RID: 126029 RVA: 0x0089A1E8 File Offset: 0x008983E8
	[NullableContext(1)]
	public __SceneItemLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SceneItemLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC4E RID: 126030 RVA: 0x0089A21B File Offset: 0x0089841B
	protected __SceneItemLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
