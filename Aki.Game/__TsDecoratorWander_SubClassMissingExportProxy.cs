using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035E7 RID: 13799
public class __TsDecoratorWander_SubClassMissingExportProxy : __TsDecoratorWander_InheritProxy
{
	// Token: 0x0601E12E RID: 123182 RVA: 0x0087FD9C File Offset: 0x0087DF9C
	[NullableContext(1)]
	protected __TsDecoratorWander_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorWander.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E12F RID: 123183 RVA: 0x0087FDCF File Offset: 0x0087DFCF
	protected __TsDecoratorWander_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
