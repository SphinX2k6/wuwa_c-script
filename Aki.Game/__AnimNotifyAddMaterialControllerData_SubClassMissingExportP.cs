using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003969 RID: 14697
public class __AnimNotifyAddMaterialControllerData_SubClassMissingExportProxy : __AnimNotifyAddMaterialControllerData_InheritProxy
{
	// Token: 0x0601ED1D RID: 126237 RVA: 0x0089CD08 File Offset: 0x0089AF08
	[NullableContext(1)]
	protected __AnimNotifyAddMaterialControllerData_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddMaterialControllerData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601ED1E RID: 126238 RVA: 0x0089CD3B File Offset: 0x0089AF3B
	protected __AnimNotifyAddMaterialControllerData_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
