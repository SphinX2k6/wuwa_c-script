using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F1B RID: 12059
public class __EffectModelPostProcess_InheritProxy : EffectModelPostProcess
{
	// Token: 0x0601CA52 RID: 117330 RVA: 0x008C0274 File Offset: 0x008BE474
	[NullableContext(1)]
	public __EffectModelPostProcess_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelPostProcess.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA53 RID: 117331 RVA: 0x008C02A7 File Offset: 0x008BE4A7
	protected __EffectModelPostProcess_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
