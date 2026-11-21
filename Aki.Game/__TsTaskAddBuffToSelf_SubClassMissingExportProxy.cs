using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002BB6 RID: 11190
public class __TsTaskAddBuffToSelf_SubClassMissingExportProxy : __TsTaskAddBuffToSelf_InheritProxy
{
	// Token: 0x0601BF4A RID: 114506 RVA: 0x008A9F9C File Offset: 0x008A819C
	[NullableContext(1)]
	protected __TsTaskAddBuffToSelf_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAddBuffToSelf.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BF4B RID: 114507 RVA: 0x008A9FCF File Offset: 0x008A81CF
	protected __TsTaskAddBuffToSelf_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
