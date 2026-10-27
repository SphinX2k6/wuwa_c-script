using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039AB RID: 14763
public class __EffectScalabilitySetting_SubClassMissingExportProxy : __EffectScalabilitySetting_InheritProxy
{
	// Token: 0x0601EE3B RID: 126523 RVA: 0x008A064C File Offset: 0x0089E84C
	[NullableContext(1)]
	protected __EffectScalabilitySetting_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectScalabilitySetting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE3C RID: 126524 RVA: 0x008A067F File Offset: 0x0089E87F
	protected __EffectScalabilitySetting_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
