using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038FC RID: 14588
public class __LogicDataEffectSave_InheritProxy : LogicDataEffectSave
{
	// Token: 0x0601EB70 RID: 125808 RVA: 0x00898208 File Offset: 0x00896408
	[NullableContext(1)]
	public __LogicDataEffectSave_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataEffectSave.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB71 RID: 125809 RVA: 0x0089823B File Offset: 0x0089643B
	protected __LogicDataEffectSave_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
