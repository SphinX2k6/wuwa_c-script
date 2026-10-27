using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003904 RID: 14596
public class __LogicDataManipulatableTagsChange_InheritProxy : LogicDataManipulatableTagsChange
{
	// Token: 0x0601EB80 RID: 125824 RVA: 0x008983E8 File Offset: 0x008965E8
	[NullableContext(1)]
	public __LogicDataManipulatableTagsChange_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataManipulatableTagsChange.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB81 RID: 125825 RVA: 0x0089841B File Offset: 0x0089661B
	protected __LogicDataManipulatableTagsChange_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
