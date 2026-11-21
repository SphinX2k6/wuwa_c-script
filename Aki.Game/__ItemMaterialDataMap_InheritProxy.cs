using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F37 RID: 12087
public class __ItemMaterialDataMap_InheritProxy : ItemMaterialDataMap
{
	// Token: 0x0601CA91 RID: 117393 RVA: 0x008C097C File Offset: 0x008BEB7C
	[NullableContext(1)]
	public __ItemMaterialDataMap_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ItemMaterialDataMap.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA92 RID: 117394 RVA: 0x008C09AF File Offset: 0x008BEBAF
	protected __ItemMaterialDataMap_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
