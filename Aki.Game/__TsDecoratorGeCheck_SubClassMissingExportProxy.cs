using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035C7 RID: 13767
public class __TsDecoratorGeCheck_SubClassMissingExportProxy : __TsDecoratorGeCheck_InheritProxy
{
	// Token: 0x0601E0DE RID: 123102 RVA: 0x0087F2DC File Offset: 0x0087D4DC
	[NullableContext(1)]
	protected __TsDecoratorGeCheck_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorGeCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E0DF RID: 123103 RVA: 0x0087F30F File Offset: 0x0087D50F
	protected __TsDecoratorGeCheck_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
