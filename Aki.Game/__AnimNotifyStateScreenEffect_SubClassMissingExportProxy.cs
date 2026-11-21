using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EFC RID: 12028
public class __AnimNotifyStateScreenEffect_SubClassMissingExportProxy : __AnimNotifyStateScreenEffect_InheritProxy
{
	// Token: 0x0601CA10 RID: 117264 RVA: 0x008BFA7C File Offset: 0x008BDC7C
	[NullableContext(1)]
	protected __AnimNotifyStateScreenEffect_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateScreenEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA11 RID: 117265 RVA: 0x008BFAAF File Offset: 0x008BDCAF
	protected __AnimNotifyStateScreenEffect_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
