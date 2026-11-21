using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EDE RID: 11998
public class __TsRecordGameplayCue_SubClassMissingExportProxy : __TsRecordGameplayCue_InheritProxy
{
	// Token: 0x0601C950 RID: 117072 RVA: 0x008BE590 File Offset: 0x008BC790
	[NullableContext(1)]
	protected __TsRecordGameplayCue_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsRecordGameplayCue.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C951 RID: 117073 RVA: 0x008BE5C3 File Offset: 0x008BC7C3
	protected __TsRecordGameplayCue_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
