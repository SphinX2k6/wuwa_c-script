using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039BC RID: 14780
public class __ItemMaterialDataMap_InheritProxy : ItemMaterialDataMap
{
	// Token: 0x0601EE6A RID: 126570 RVA: 0x008A0D78 File Offset: 0x0089EF78
	[NullableContext(1)]
	public __ItemMaterialDataMap_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ItemMaterialDataMap.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE6B RID: 126571 RVA: 0x008A0DAB File Offset: 0x0089EFAB
	protected __ItemMaterialDataMap_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
