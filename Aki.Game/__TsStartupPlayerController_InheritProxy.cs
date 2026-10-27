using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003894 RID: 14484
public class __TsStartupPlayerController_InheritProxy : TsStartupPlayerController
{
	// Token: 0x0601EA24 RID: 125476 RVA: 0x00895198 File Offset: 0x00893398
	[NullableContext(1)]
	public __TsStartupPlayerController_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsStartupPlayerController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA25 RID: 125477 RVA: 0x008951CB File Offset: 0x008933CB
	protected __TsStartupPlayerController_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
