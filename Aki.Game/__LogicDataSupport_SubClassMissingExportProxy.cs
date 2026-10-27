using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003919 RID: 14617
public class __LogicDataSupport_SubClassMissingExportProxy : __LogicDataSupport_InheritProxy
{
	// Token: 0x0601EBAA RID: 125866 RVA: 0x008988D4 File Offset: 0x00896AD4
	[NullableContext(1)]
	protected __LogicDataSupport_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSupport.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBAB RID: 125867 RVA: 0x00898907 File Offset: 0x00896B07
	protected __LogicDataSupport_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
