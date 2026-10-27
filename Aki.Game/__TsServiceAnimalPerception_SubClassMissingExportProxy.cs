using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035EB RID: 13803
public class __TsServiceAnimalPerception_SubClassMissingExportProxy : __TsServiceAnimalPerception_InheritProxy
{
	// Token: 0x0601E139 RID: 123193 RVA: 0x0087FF24 File Offset: 0x0087E124
	[NullableContext(1)]
	protected __TsServiceAnimalPerception_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsServiceAnimalPerception.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E13A RID: 123194 RVA: 0x0087FF57 File Offset: 0x0087E157
	protected __TsServiceAnimalPerception_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
