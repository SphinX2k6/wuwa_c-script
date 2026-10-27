using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038D9 RID: 14553
public class __TsUiHomeHelper_SubClassMissingExportProxy : __TsUiHomeHelper_InheritProxy
{
	// Token: 0x0601EB0C RID: 125708 RVA: 0x00897858 File Offset: 0x00895A58
	[NullableContext(1)]
	protected __TsUiHomeHelper_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiHomeHelper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB0D RID: 125709 RVA: 0x0089788B File Offset: 0x00895A8B
	protected __TsUiHomeHelper_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
