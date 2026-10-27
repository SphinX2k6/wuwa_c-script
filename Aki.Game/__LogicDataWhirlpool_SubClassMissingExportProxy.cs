using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200391B RID: 14619
public class __LogicDataWhirlpool_SubClassMissingExportProxy : __LogicDataWhirlpool_InheritProxy
{
	// Token: 0x0601EBAE RID: 125870 RVA: 0x0089894C File Offset: 0x00896B4C
	[NullableContext(1)]
	protected __LogicDataWhirlpool_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataWhirlpool.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBAF RID: 125871 RVA: 0x0089897F File Offset: 0x00896B7F
	protected __LogicDataWhirlpool_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
