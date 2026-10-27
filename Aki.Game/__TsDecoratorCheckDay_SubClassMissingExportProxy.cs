using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035AB RID: 13739
public class __TsDecoratorCheckDay_SubClassMissingExportProxy : __TsDecoratorCheckDay_InheritProxy
{
	// Token: 0x0601E096 RID: 123030 RVA: 0x0087E908 File Offset: 0x0087CB08
	[NullableContext(1)]
	protected __TsDecoratorCheckDay_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckDay.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E097 RID: 123031 RVA: 0x0087E93B File Offset: 0x0087CB3B
	protected __TsDecoratorCheckDay_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
