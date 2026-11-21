using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E7D RID: 11901
public class __LogicDataManipulatableTagsChange_InheritProxy : LogicDataManipulatableTagsChange
{
	// Token: 0x0601C838 RID: 116792 RVA: 0x008BC88C File Offset: 0x008BAA8C
	[NullableContext(1)]
	public __LogicDataManipulatableTagsChange_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataManipulatableTagsChange.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C839 RID: 116793 RVA: 0x008BC8BF File Offset: 0x008BAABF
	protected __LogicDataManipulatableTagsChange_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
