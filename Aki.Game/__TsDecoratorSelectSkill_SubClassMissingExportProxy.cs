using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B52 RID: 11090
public class __TsDecoratorSelectSkill_SubClassMissingExportProxy : __TsDecoratorSelectSkill_InheritProxy
{
	// Token: 0x0601BE3D RID: 114237 RVA: 0x008A7AD4 File Offset: 0x008A5CD4
	[NullableContext(1)]
	protected __TsDecoratorSelectSkill_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorSelectSkill.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BE3E RID: 114238 RVA: 0x008A7B07 File Offset: 0x008A5D07
	protected __TsDecoratorSelectSkill_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
