using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003905 RID: 14597
public class __LogicDataManipulatableTagsChange_SubClassMissingExportProxy : __LogicDataManipulatableTagsChange_InheritProxy
{
	// Token: 0x0601EB82 RID: 125826 RVA: 0x00898424 File Offset: 0x00896624
	[NullableContext(1)]
	protected __LogicDataManipulatableTagsChange_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataManipulatableTagsChange.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB83 RID: 125827 RVA: 0x00898457 File Offset: 0x00896657
	protected __LogicDataManipulatableTagsChange_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
