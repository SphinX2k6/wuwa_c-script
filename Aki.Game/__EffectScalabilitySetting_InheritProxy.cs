using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039AA RID: 14762
public class __EffectScalabilitySetting_InheritProxy : EffectScalabilitySetting
{
	// Token: 0x0601EE39 RID: 126521 RVA: 0x008A0610 File Offset: 0x0089E810
	[NullableContext(1)]
	public __EffectScalabilitySetting_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectScalabilitySetting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE3A RID: 126522 RVA: 0x008A0643 File Offset: 0x0089E843
	protected __EffectScalabilitySetting_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
