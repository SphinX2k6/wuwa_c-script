using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035B7 RID: 13751
public class __TsDecoratorCheckMoveStuck_SubClassMissingExportProxy : __TsDecoratorCheckMoveStuck_InheritProxy
{
	// Token: 0x0601E0B6 RID: 123062 RVA: 0x0087ED7C File Offset: 0x0087CF7C
	[NullableContext(1)]
	protected __TsDecoratorCheckMoveStuck_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckMoveStuck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E0B7 RID: 123063 RVA: 0x0087EDAF File Offset: 0x0087CFAF
	protected __TsDecoratorCheckMoveStuck_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
