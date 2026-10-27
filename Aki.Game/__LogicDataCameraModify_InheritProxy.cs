using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038F4 RID: 14580
public class __LogicDataCameraModify_InheritProxy : LogicDataCameraModify
{
	// Token: 0x0601EB60 RID: 125792 RVA: 0x00898028 File Offset: 0x00896228
	[NullableContext(1)]
	public __LogicDataCameraModify_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataCameraModify.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB61 RID: 125793 RVA: 0x0089805B File Offset: 0x0089625B
	protected __LogicDataCameraModify_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
