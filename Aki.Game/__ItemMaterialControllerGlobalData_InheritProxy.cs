using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F35 RID: 12085
public class __ItemMaterialControllerGlobalData_InheritProxy : ItemMaterialControllerGlobalData
{
	// Token: 0x0601CA8D RID: 117389 RVA: 0x008C0904 File Offset: 0x008BEB04
	[NullableContext(1)]
	public __ItemMaterialControllerGlobalData_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ItemMaterialControllerGlobalData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA8E RID: 117390 RVA: 0x008C0937 File Offset: 0x008BEB37
	protected __ItemMaterialControllerGlobalData_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
