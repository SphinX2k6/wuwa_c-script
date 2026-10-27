using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039A0 RID: 14752
public class __EffectModelPostProcess_InheritProxy : EffectModelPostProcess
{
	// Token: 0x0601EE25 RID: 126501 RVA: 0x008A03B8 File Offset: 0x0089E5B8
	[NullableContext(1)]
	public __EffectModelPostProcess_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelPostProcess.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE26 RID: 126502 RVA: 0x008A03EB File Offset: 0x0089E5EB
	protected __EffectModelPostProcess_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
