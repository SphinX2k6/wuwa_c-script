using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002ECB RID: 11979
public class __TsExploreCameraTriggerVolume_InheritProxy : TsExploreCameraTriggerVolume
{
	// Token: 0x0601C901 RID: 116993 RVA: 0x008BDDBC File Offset: 0x008BBFBC
	[NullableContext(1)]
	public __TsExploreCameraTriggerVolume_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsExploreCameraTriggerVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C902 RID: 116994 RVA: 0x008BDDEF File Offset: 0x008BBFEF
	protected __TsExploreCameraTriggerVolume_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
