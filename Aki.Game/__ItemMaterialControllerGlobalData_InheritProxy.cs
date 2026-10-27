using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039BA RID: 14778
public class __ItemMaterialControllerGlobalData_InheritProxy : ItemMaterialControllerGlobalData
{
	// Token: 0x0601EE66 RID: 126566 RVA: 0x008A0D00 File Offset: 0x0089EF00
	[NullableContext(1)]
	public __ItemMaterialControllerGlobalData_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ItemMaterialControllerGlobalData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE67 RID: 126567 RVA: 0x008A0D33 File Offset: 0x0089EF33
	protected __ItemMaterialControllerGlobalData_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
