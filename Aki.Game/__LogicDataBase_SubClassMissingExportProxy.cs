using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038F1 RID: 14577
public class __LogicDataBase_SubClassMissingExportProxy : __LogicDataBase_InheritProxy
{
	// Token: 0x0601EB5A RID: 125786 RVA: 0x00897F74 File Offset: 0x00896174
	[NullableContext(1)]
	protected __LogicDataBase_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB5B RID: 125787 RVA: 0x00897FA7 File Offset: 0x008961A7
	protected __LogicDataBase_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
