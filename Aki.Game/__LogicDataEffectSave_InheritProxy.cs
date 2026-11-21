using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E75 RID: 11893
public class __LogicDataEffectSave_InheritProxy : LogicDataEffectSave
{
	// Token: 0x0601C828 RID: 116776 RVA: 0x008BC6AC File Offset: 0x008BA8AC
	[NullableContext(1)]
	public __LogicDataEffectSave_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataEffectSave.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C829 RID: 116777 RVA: 0x008BC6DF File Offset: 0x008BA8DF
	protected __LogicDataEffectSave_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
