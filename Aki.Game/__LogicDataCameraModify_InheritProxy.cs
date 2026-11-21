using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E6D RID: 11885
public class __LogicDataCameraModify_InheritProxy : LogicDataCameraModify
{
	// Token: 0x0601C818 RID: 116760 RVA: 0x008BC4CC File Offset: 0x008BA6CC
	[NullableContext(1)]
	public __LogicDataCameraModify_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataCameraModify.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C819 RID: 116761 RVA: 0x008BC4FF File Offset: 0x008BA6FF
	protected __LogicDataCameraModify_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
