using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B60 RID: 11104
public class __TsServiceAnimalPerception_SubClassMissingExportProxy : __TsServiceAnimalPerception_InheritProxy
{
	// Token: 0x0601BE61 RID: 114273 RVA: 0x008A7FB8 File Offset: 0x008A61B8
	[NullableContext(1)]
	protected __TsServiceAnimalPerception_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsServiceAnimalPerception.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BE62 RID: 114274 RVA: 0x008A7FEB File Offset: 0x008A61EB
	protected __TsServiceAnimalPerception_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
