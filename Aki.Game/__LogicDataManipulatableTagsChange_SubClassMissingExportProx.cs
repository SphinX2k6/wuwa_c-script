using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E7E RID: 11902
public class __LogicDataManipulatableTagsChange_SubClassMissingExportProxy : __LogicDataManipulatableTagsChange_InheritProxy
{
	// Token: 0x0601C83A RID: 116794 RVA: 0x008BC8C8 File Offset: 0x008BAAC8
	[NullableContext(1)]
	protected __LogicDataManipulatableTagsChange_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataManipulatableTagsChange.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C83B RID: 116795 RVA: 0x008BC8FB File Offset: 0x008BAAFB
	protected __LogicDataManipulatableTagsChange_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
