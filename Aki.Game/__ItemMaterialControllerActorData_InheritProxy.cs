using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039B8 RID: 14776
public class __ItemMaterialControllerActorData_InheritProxy : ItemMaterialControllerActorData
{
	// Token: 0x0601EE62 RID: 126562 RVA: 0x008A0C88 File Offset: 0x0089EE88
	[NullableContext(1)]
	public __ItemMaterialControllerActorData_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ItemMaterialControllerActorData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE63 RID: 126563 RVA: 0x008A0CBB File Offset: 0x0089EEBB
	protected __ItemMaterialControllerActorData_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
