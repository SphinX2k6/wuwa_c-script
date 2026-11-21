using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B44 RID: 11076
public class __TsDecoratorInTeamArea_SubClassMissingExportProxy : __TsDecoratorInTeamArea_InheritProxy
{
	// Token: 0x0601BE1A RID: 114202 RVA: 0x008A7620 File Offset: 0x008A5820
	[NullableContext(1)]
	protected __TsDecoratorInTeamArea_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorInTeamArea.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BE1B RID: 114203 RVA: 0x008A7653 File Offset: 0x008A5853
	protected __TsDecoratorInTeamArea_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
