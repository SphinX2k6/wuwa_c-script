using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038F5 RID: 14581
public class __LogicDataCameraModify_SubClassMissingExportProxy : __LogicDataCameraModify_InheritProxy
{
	// Token: 0x0601EB62 RID: 125794 RVA: 0x00898064 File Offset: 0x00896264
	[NullableContext(1)]
	protected __LogicDataCameraModify_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataCameraModify.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB63 RID: 125795 RVA: 0x00898097 File Offset: 0x00896297
	protected __LogicDataCameraModify_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
