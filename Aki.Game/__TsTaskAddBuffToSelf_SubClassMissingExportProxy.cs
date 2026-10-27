using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003641 RID: 13889
public class __TsTaskAddBuffToSelf_SubClassMissingExportProxy : __TsTaskAddBuffToSelf_InheritProxy
{
	// Token: 0x0601E222 RID: 123426 RVA: 0x00881F08 File Offset: 0x00880108
	[NullableContext(1)]
	protected __TsTaskAddBuffToSelf_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAddBuffToSelf.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E223 RID: 123427 RVA: 0x00881F3B File Offset: 0x0088013B
	protected __TsTaskAddBuffToSelf_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
