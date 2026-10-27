using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003950 RID: 14672
public class __TsExploreCameraTriggerVolume_InheritProxy : TsExploreCameraTriggerVolume
{
	// Token: 0x0601EC65 RID: 126053 RVA: 0x0089A7C8 File Offset: 0x008989C8
	[NullableContext(1)]
	public __TsExploreCameraTriggerVolume_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsExploreCameraTriggerVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC66 RID: 126054 RVA: 0x0089A7FB File Offset: 0x008989FB
	protected __TsExploreCameraTriggerVolume_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
