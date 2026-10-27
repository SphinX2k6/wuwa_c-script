using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035DD RID: 13789
public class __TsDecoratorSelectSkill_SubClassMissingExportProxy : __TsDecoratorSelectSkill_InheritProxy
{
	// Token: 0x0601E115 RID: 123157 RVA: 0x0087FA40 File Offset: 0x0087DC40
	[NullableContext(1)]
	protected __TsDecoratorSelectSkill_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorSelectSkill.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E116 RID: 123158 RVA: 0x0087FA73 File Offset: 0x0087DC73
	protected __TsDecoratorSelectSkill_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
