using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E6E RID: 11886
public class __LogicDataCameraModify_SubClassMissingExportProxy : __LogicDataCameraModify_InheritProxy
{
	// Token: 0x0601C81A RID: 116762 RVA: 0x008BC508 File Offset: 0x008BA708
	[NullableContext(1)]
	protected __LogicDataCameraModify_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataCameraModify.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C81B RID: 116763 RVA: 0x008BC53B File Offset: 0x008BA73B
	protected __LogicDataCameraModify_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
