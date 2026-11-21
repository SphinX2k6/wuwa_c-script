using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E51 RID: 11857
public class __TsUiHomeHelper_InheritProxy : TsUiHomeHelper
{
	// Token: 0x0601C7C2 RID: 116674 RVA: 0x008BBCC0 File Offset: 0x008B9EC0
	[NullableContext(1)]
	public __TsUiHomeHelper_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiHomeHelper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C7C3 RID: 116675 RVA: 0x008BBCF3 File Offset: 0x008B9EF3
	protected __TsUiHomeHelper_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
