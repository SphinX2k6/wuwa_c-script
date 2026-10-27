using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035D3 RID: 13779
public class __TsDecoratorItemIsValid_SubClassMissingExportProxy : __TsDecoratorItemIsValid_InheritProxy
{
	// Token: 0x0601E0FC RID: 123132 RVA: 0x0087F6E4 File Offset: 0x0087D8E4
	[NullableContext(1)]
	protected __TsDecoratorItemIsValid_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorItemIsValid.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E0FD RID: 123133 RVA: 0x0087F717 File Offset: 0x0087D917
	protected __TsDecoratorItemIsValid_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
