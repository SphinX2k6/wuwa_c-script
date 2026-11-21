using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F33 RID: 12083
public class __ItemMaterialControllerActorData_InheritProxy : ItemMaterialControllerActorData
{
	// Token: 0x0601CA89 RID: 117385 RVA: 0x008C088C File Offset: 0x008BEA8C
	[NullableContext(1)]
	public __ItemMaterialControllerActorData_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ItemMaterialControllerActorData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA8A RID: 117386 RVA: 0x008C08BF File Offset: 0x008BEABF
	protected __ItemMaterialControllerActorData_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
