using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003981 RID: 14721
public class __AnimNotifyStateScreenEffect_SubClassMissingExportProxy : __AnimNotifyStateScreenEffect_InheritProxy
{
	// Token: 0x0601EDE3 RID: 126435 RVA: 0x0089FBC0 File Offset: 0x0089DDC0
	[NullableContext(1)]
	protected __AnimNotifyStateScreenEffect_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateScreenEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EDE4 RID: 126436 RVA: 0x0089FBF3 File Offset: 0x0089DDF3
	protected __AnimNotifyStateScreenEffect_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
